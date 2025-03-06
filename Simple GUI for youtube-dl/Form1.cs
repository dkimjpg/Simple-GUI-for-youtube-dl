using System;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Threading.Tasks;

namespace Simple_GUI_for_youtube_dl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            if (videoListBox.Items.Count == 0)
            {
                MessageBox.Show("No links have been added. Please add YouTube links.",
                    "No Links in the Playlist",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            downloadButton.Enabled = false;

            // Get values from UI controls BEFORE going to the background thread
            string format = formatBox.Text;
            string quality = qualityBox.Text;
            string path = pathInputText.Text;

            // Create a copy of the items since we can't access videoListBox from background thread
            var itemsToDownload = new List<string>();

            foreach (var item in videoListBox.Items)
            {
                itemsToDownload.Add(item.ToString());
            }

            try
            {
                // Process downloads asynchronously
                await Task.Run(() =>
                {
                    foreach (var link in itemsToDownload)
                    {
                        //use this foreach instead of the linkInputText
                        //string link = item.ToString();

                        string command = ".\\youtube-dl ";

                        //need to stop using just formatBox.Text since I plan on using the listbox.
                        //change these two strings to use listbox or whatever I end up using later on.

                        if (format == "")
                        {
                            format = "best";
                        }
                        if (quality == "")
                        {
                            quality = "best";
                        }
                        if (format != "best" || quality != "best")
                        {
                            command += "-f ";
                            if (format != "best")
                            {
                                //Check if format is audio
                                if (format == "aac" || format == "m4a" || format == "ogg" || format == "wav")
                                {
                                    command += "bestaudio[ext=" + format + "]/best ";
                                }
                                else //format is video
                                {
                                    command += "bestvideo[ext=" + format + "]+bestaudio/best ";
                                }
                            }
                            if (quality != "best")
                            {
                                command += quality + " ";
                            }
                        }
                        if (path != "")
                        {
                            command += "-o \"" + path + "\\%(title)s-%(id)s.%(ext)s" + "\" ";
                        }

                        command += "\"" + link + "\"";

                        BeginInvoke(new Action(() =>
                        {
                            consoleText.AppendText("Downloading...\n");
                            consoleText.AppendText($"format: {format}\n");
                            consoleText.AppendText($"quality: {quality}\n");
                            consoleText.AppendText($"link: {link}\n");
                            consoleText.AppendText($"path: {path}\n");
                            consoleText.AppendText($"command: {command}\n");
                        }));


                        ExecutePowerShellCommand(command);                        
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                downloadButton.Enabled = true;
                consoleText.AppendText("\n"); //makes it easier to see console output for the next download operation
            }

        }

        private void ExecutePowerShellCommand(string command)
        {
            try
            {
                using (PowerShell ps = PowerShell.Create())
                {
                    //ps.AddScript("pwd");
                    //ps.Invoke();
                    ps.AddScript(command);
                    Collection<PSObject> results = ps.Invoke();

                    var errors = new List<string>();
                    var outputResults = new List<string>();

                    if (ps.Streams.Error.Count > 0)
                    {
                        foreach (var error in ps.Streams.Error)
                        {
                            errors.Add(error.ToString());
                            //consoleText.AppendText($"ERROR: {error.ToString()}\r\n");
                        }
                    }

                    foreach (PSObject result in results)
                    {
                        outputResults.Add(result.ToString());
                        
                    }
                    this.BeginInvoke(new Action(() =>
                    {
                        foreach (var error in errors)
                        {
                            consoleText.AppendText($"ERROR: {error}\r\n");
                        }

                        foreach (var result in outputResults)
                        {
                            consoleText.AppendText($"{result}\r\n");
                        }
                        //consoleText.AppendText($"{result.ToString()}\r\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    consoleText.AppendText($"Exception: {ex.Message}\r\n");
                }));
            }
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
            //add functionality that prevents adding empty links
            if (linkInputText.Text == "")
            {
                MessageBox.Show("Please put in a link into the Link textbox before pressing Add Link.",
                    "No Links in the Link Textbox",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            videoListBox.Items.Add(linkInputText.Text);
        }

        private void videoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoListBox.SelectedItem != null)
            {
                string selectedItem = videoListBox.SelectedItem.ToString();

                DialogResult askDeletion = MessageBox.Show(
                    $"Do you want to delete '{selectedItem}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (askDeletion == DialogResult.Yes)
                {
                    videoListBox.Items.RemoveAt(videoListBox.SelectedIndex);
                }
            }
        }
    }
}
