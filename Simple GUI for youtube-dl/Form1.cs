using System;
using System.Collections.ObjectModel;
using System.Management.Automation;

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
                    "No Links",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            downloadButton.Enabled = false;

            try
            {
                await Task.Run(() =>
                {
                    foreach (var item in videoListBox.Items)
                    {
                        //use this foreach instead of the linkInputText
                        string link = item.ToString();

                        string command = ".\\youtube-dl ";

                        //need to stop using formatBox.Text since I plan on using the listbox.
                        //change these two strings to use listbox or whatever I end up using later on.
                        string format = formatBox.Text;
                        //string format = link;
                        string quality = qualityBox.Text;
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

                        command += "\"" + link + "\"";

                        BeginInvoke(new Action(() =>
                        {
                            consoleText.AppendText("Downloading...\n");
                            consoleText.AppendText($"link: {link}\n");
                            consoleText.AppendText($"{command}\n");
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

                    if (ps.Streams.Error.Count > 0)
                    {
                        foreach (var error in ps.Streams.Error)
                        {
                            consoleText.AppendText($"ERROR: {error.ToString()}\r\n");
                        }
                    }

                    foreach (PSObject result in results)
                    {
                        consoleText.AppendText($"{result.ToString()}\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                consoleText.AppendText($"Exception: {ex.Message}\r\n");
            }
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
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
