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

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string command = ".\\youtube-dl ";
            if (formatBox.Text != "best" || qualityBox.Text != "best")
            {
                command += "-f ";
                if (formatBox.Text != "best")
                {
                    //Check if format is audio
                    if (formatBox.Text == "aac" || formatBox.Text == "m4a" || formatBox.Text == "ogg" || formatBox.Text == "wav")
                    {
                        command += "bestaudio[ext=" + formatBox.Text + "]/best ";
                    }
                    else //format is video
                    {
                        command += "bestvideo[ext="+ formatBox.Text + "]+bestaudio/best ";
                    }
                }
                if (qualityBox.Text != "best")
                {
                    command += qualityBox.Text + " ";
                }
            }

            command += linkInputText.Text;


            consoleText.AppendText("Downloading...\n");
            ExecutePowerShellCommand(command);
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
