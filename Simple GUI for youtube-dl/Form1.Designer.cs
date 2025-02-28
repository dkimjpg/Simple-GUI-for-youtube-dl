namespace Simple_GUI_for_youtube_dl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkInputText = new RichTextBox();
            argumentsGroup = new GroupBox();
            qualityBox1 = new ComboBox();
            qualityLabel = new Label();
            formatBox = new ComboBox();
            formatLabel = new Label();
            Link = new Label();
            downloadButton = new Button();
            consoleText = new RichTextBox();
            consoleLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            argumentsGroup.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // linkInputText
            // 
            linkInputText.Location = new Point(77, 33);
            linkInputText.Name = "linkInputText";
            linkInputText.Size = new Size(427, 39);
            linkInputText.TabIndex = 0;
            linkInputText.Text = "";
            // 
            // argumentsGroup
            // 
            argumentsGroup.Controls.Add(qualityBox1);
            argumentsGroup.Controls.Add(qualityLabel);
            argumentsGroup.Controls.Add(formatBox);
            argumentsGroup.Controls.Add(formatLabel);
            argumentsGroup.Controls.Add(Link);
            argumentsGroup.Controls.Add(linkInputText);
            argumentsGroup.Location = new Point(12, 69);
            argumentsGroup.Name = "argumentsGroup";
            argumentsGroup.Size = new Size(526, 240);
            argumentsGroup.TabIndex = 2;
            argumentsGroup.TabStop = false;
            argumentsGroup.Text = "Arguments";
            // 
            // qualityBox1
            // 
            qualityBox1.FormattingEnabled = true;
            qualityBox1.Location = new Point(77, 162);
            qualityBox1.Name = "qualityBox1";
            qualityBox1.Size = new Size(151, 28);
            qualityBox1.TabIndex = 9;
            // 
            // qualityLabel
            // 
            qualityLabel.AutoSize = true;
            qualityLabel.Location = new Point(6, 162);
            qualityLabel.Name = "qualityLabel";
            qualityLabel.Size = new Size(56, 20);
            qualityLabel.TabIndex = 8;
            qualityLabel.Text = "Quality";
            // 
            // formatBox
            // 
            formatBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatBox.FormattingEnabled = true;
            formatBox.Items.AddRange(new object[] { "best", "3gp", "aac", "flv", "m4a", "mkv", "mp3", "mp4", "ogg", "wav", "webm" });
            formatBox.Location = new Point(77, 99);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(151, 28);
            formatBox.TabIndex = 6;
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.Location = new Point(6, 102);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(67, 20);
            formatLabel.TabIndex = 7;
            formatLabel.Text = "File Type";
            // 
            // Link
            // 
            Link.AutoSize = true;
            Link.Location = new Point(20, 42);
            Link.Name = "Link";
            Link.Size = new Size(35, 20);
            Link.TabIndex = 1;
            Link.Text = "Link";
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(835, 102);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(94, 29);
            downloadButton.TabIndex = 3;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // consoleText
            // 
            consoleText.Location = new Point(89, 333);
            consoleText.Name = "consoleText";
            consoleText.Size = new Size(427, 262);
            consoleText.TabIndex = 4;
            consoleText.Text = "";
            // 
            // consoleLabel
            // 
            consoleLabel.AutoSize = true;
            consoleLabel.Location = new Point(12, 372);
            consoleLabel.Name = "consoleLabel";
            consoleLabel.Size = new Size(62, 20);
            consoleLabel.TabIndex = 5;
            consoleLabel.Text = "Console";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(consoleLabel);
            Controls.Add(consoleText);
            Controls.Add(downloadButton);
            Controls.Add(argumentsGroup);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Simple GUI for youtube-dl";
            argumentsGroup.ResumeLayout(false);
            argumentsGroup.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox linkInputText;
        private GroupBox argumentsGroup;
        private Label Link;
        private Button downloadButton;
        private RichTextBox consoleText;
        private Label consoleLabel;
        private ComboBox formatBox;
        private Label formatLabel;
        private ComboBox qualityBox1;
        private Label qualityLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}
