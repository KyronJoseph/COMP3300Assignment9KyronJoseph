namespace COMP3300Assignment9KyronJoseph
{
    partial class AccountForm
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
            selectFileButton = new Button();
            SuspendLayout();
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(72, 258);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(94, 29);
            selectFileButton.TabIndex = 0;
            selectFileButton.Text = "Select File:";
            selectFileButton.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectFileButton);
            Name = "AccountForm";
            Text = "Assignment 9 by Joseph";
            ResumeLayout(false);
        }

        #endregion

        private Button selectFileButton;
    }
}
