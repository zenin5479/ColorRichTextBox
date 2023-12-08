namespace ColorRichTextBox
{
    partial class FormOne
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
            RichTextBoxOne = new System.Windows.Forms.RichTextBox();
            ButtonTextOne = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // RichTextBoxOne
            // 
            RichTextBoxOne.Location = new System.Drawing.Point(12, 12);
            RichTextBoxOne.Name = "RichTextBoxOne";
            RichTextBoxOne.Size = new System.Drawing.Size(300, 250);
            RichTextBoxOne.TabIndex = 0;
            RichTextBoxOne.Text = "";
            // 
            // ButtonTextOne
            // 
            ButtonTextOne.Location = new System.Drawing.Point(26, 274);
            ButtonTextOne.Name = "ButtonTextOne";
            ButtonTextOne.Size = new System.Drawing.Size(50, 25);
            ButtonTextOne.TabIndex = 1;
            ButtonTextOne.Text = "Текст 1";
            ButtonTextOne.UseVisualStyleBackColor = true;
            ButtonTextOne.Click += ButtonTextOne_Click;
            // 
            // FormOne
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(323, 361);
            Controls.Add(ButtonTextOne);
            Controls.Add(RichTextBoxOne);
            Name = "FormOne";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Цвет текста в строке";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBoxOne;
        private System.Windows.Forms.Button ButtonTextOne;
    }
}