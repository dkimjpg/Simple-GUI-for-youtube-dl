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
            Link = new Label();
            downloadButton = new Button();
            consoleText = new RichTextBox();
            consoleLabel = new Label();
            argumentsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // linkInputText
            // 
            linkInputText.Location = new Point(77, 26);
            linkInputText.Name = "linkInputText";
            linkInputText.Size = new Size(427, 55);
            linkInputText.TabIndex = 0;
            linkInputText.Text = "";
            // 
            // argumentsGroup
            // 
            argumentsGroup.Controls.Add(Link);
            argumentsGroup.Controls.Add(linkInputText);
            argumentsGroup.Location = new Point(12, 12);
            argumentsGroup.Name = "argumentsGroup";
            argumentsGroup.Size = new Size(526, 240);
            argumentsGroup.TabIndex = 2;
            argumentsGroup.TabStop = false;
            argumentsGroup.Text = "Arguments";
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
            downloadButton.Location = new Point(835, 45);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(consoleLabel);
            Controls.Add(consoleText);
            Controls.Add(downloadButton);
            Controls.Add(argumentsGroup);
            Name = "Form1";
            Text = "Simple GUI for youtube-dl";
            argumentsGroup.ResumeLayout(false);
            argumentsGroup.PerformLayout();
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
    }
}
