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
            qualityBox = new ComboBox();
            qualityLabel = new Label();
            formatBox = new ComboBox();
            formatLabel = new Label();
            Link = new Label();
            downloadButton = new Button();
            consoleText = new RichTextBox();
            tabControl1 = new TabControl();
            menuTab = new TabPage();
            addLinkButton = new Button();
            consoleTab = new TabPage();
            argumentsGroup.SuspendLayout();
            tabControl1.SuspendLayout();
            menuTab.SuspendLayout();
            consoleTab.SuspendLayout();
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
            argumentsGroup.Controls.Add(qualityBox);
            argumentsGroup.Controls.Add(qualityLabel);
            argumentsGroup.Controls.Add(formatBox);
            argumentsGroup.Controls.Add(formatLabel);
            argumentsGroup.Controls.Add(Link);
            argumentsGroup.Controls.Add(linkInputText);
            argumentsGroup.Location = new Point(6, 6);
            argumentsGroup.Name = "argumentsGroup";
            argumentsGroup.Size = new Size(526, 147);
            argumentsGroup.TabIndex = 2;
            argumentsGroup.TabStop = false;
            argumentsGroup.Text = "Arguments";
            // 
            // qualityBox
            // 
            qualityBox.FormattingEnabled = true;
            qualityBox.Items.AddRange(new object[] { "best" });
            qualityBox.Location = new Point(353, 99);
            qualityBox.Name = "qualityBox";
            qualityBox.Size = new Size(151, 28);
            qualityBox.TabIndex = 9;
            qualityBox.Text = "best";
            // 
            // qualityLabel
            // 
            qualityLabel.AutoSize = true;
            qualityLabel.Location = new Point(291, 102);
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
            formatBox.Text = "best";
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
            downloadButton.Location = new Point(818, 99);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(94, 29);
            downloadButton.TabIndex = 3;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // consoleText
            // 
            consoleText.Location = new Point(6, 6);
            consoleText.Name = "consoleText";
            consoleText.Size = new Size(938, 584);
            consoleText.TabIndex = 4;
            consoleText.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(menuTab);
            tabControl1.Controls.Add(consoleTab);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(958, 629);
            tabControl1.TabIndex = 7;
            // 
            // menuTab
            // 
            menuTab.Controls.Add(addLinkButton);
            menuTab.Controls.Add(downloadButton);
            menuTab.Controls.Add(argumentsGroup);
            menuTab.Location = new Point(4, 29);
            menuTab.Name = "menuTab";
            menuTab.Padding = new Padding(3);
            menuTab.Size = new Size(950, 596);
            menuTab.TabIndex = 0;
            menuTab.Text = "Menu";
            // 
            // addLinkButton
            // 
            addLinkButton.Location = new Point(818, 39);
            addLinkButton.Name = "addLinkButton";
            addLinkButton.Size = new Size(94, 29);
            addLinkButton.TabIndex = 4;
            addLinkButton.Text = "Add Link";
            addLinkButton.UseVisualStyleBackColor = true;
            // 
            // consoleTab
            // 
            consoleTab.Controls.Add(consoleText);
            consoleTab.Location = new Point(4, 29);
            consoleTab.Name = "consoleTab";
            consoleTab.Padding = new Padding(3);
            consoleTab.Size = new Size(950, 596);
            consoleTab.TabIndex = 1;
            consoleTab.Text = "Console";
            consoleTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Simple GUI for youtube-dl";
            argumentsGroup.ResumeLayout(false);
            argumentsGroup.PerformLayout();
            tabControl1.ResumeLayout(false);
            menuTab.ResumeLayout(false);
            consoleTab.ResumeLayout(false);
            ResumeLayout(false);
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
        private ComboBox qualityBox;
        private Label qualityLabel;
        private TabControl tabControl1;
        private TabPage consoleTab;
        private TabPage menuTab;
        private Button addLinkButton;
    }
}
