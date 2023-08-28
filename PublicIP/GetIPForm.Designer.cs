namespace PublicIP
{
    partial class GetIPForm
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
            ipTtextBox = new TextBox();
            getButton = new Button();
            SuspendLayout();
            // 
            // ipTtextBox
            // 
            ipTtextBox.Dock = DockStyle.Left;
            ipTtextBox.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ipTtextBox.Location = new Point(5, 5);
            ipTtextBox.Multiline = true;
            ipTtextBox.Name = "ipTtextBox";
            ipTtextBox.Size = new Size(273, 48);
            ipTtextBox.TabIndex = 0;
            // 
            // getButton
            // 
            getButton.Dock = DockStyle.Fill;
            getButton.Location = new Point(278, 5);
            getButton.Name = "getButton";
            getButton.Size = new Size(123, 48);
            getButton.TabIndex = 1;
            getButton.Text = "Get";
            getButton.UseVisualStyleBackColor = true;
            // 
            // GetIPForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 58);
            Controls.Add(getButton);
            Controls.Add(ipTtextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GetIPForm";
            Padding = new Padding(5);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GetIp";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ipTtextBox;
        private Button getButton;
    }
}