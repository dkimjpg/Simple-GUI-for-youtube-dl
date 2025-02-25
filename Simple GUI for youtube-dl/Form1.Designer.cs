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
            richTextBox1 = new RichTextBox();
            argumentsGroup = new GroupBox();
            Link = new Label();
            argumentsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(77, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(325, 55);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // argumentsGroup
            // 
            argumentsGroup.Controls.Add(Link);
            argumentsGroup.Controls.Add(richTextBox1);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(argumentsGroup);
            Name = "Form1";
            Text = "Simple GUI for youtube-dl";
            argumentsGroup.ResumeLayout(false);
            argumentsGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private GroupBox argumentsGroup;
        private Label Link;
    }
}
