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
            string command;
            if (formatBox.Text == "best")
            {
                command = ".\\youtube-dl " + linkInputText.Text;
            }
            else
            {
                command = ".\\youtube-dl " + "-f " + formatBox.Text + " " + linkInputText.Text;
            }
                
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
    }
}
