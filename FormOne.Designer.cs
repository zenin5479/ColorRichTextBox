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
            ButtonTextTwo = new System.Windows.Forms.Button();
            ButtonClear = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // RichTextBoxOne
            // 
            RichTextBoxOne.Location = new System.Drawing.Point(12, 12);
            RichTextBoxOne.Name = "RichTextBoxOne";
            RichTextBoxOne.Size = new System.Drawing.Size(299, 250);
            RichTextBoxOne.TabIndex = 0;
            RichTextBoxOne.Text = "";
            // 
            // ButtonTextOne
            // 
            ButtonTextOne.Location = new System.Drawing.Point(12, 274);
            ButtonTextOne.Name = "ButtonTextOne";
            ButtonTextOne.Size = new System.Drawing.Size(50, 25);
            ButtonTextOne.TabIndex = 1;
            ButtonTextOne.Text = "Текст 1";
            ButtonTextOne.UseVisualStyleBackColor = true;
            ButtonTextOne.Click += ButtonTextOne_Click;
            // 
            // ButtonTextTwo
            // 
            ButtonTextTwo.Location = new System.Drawing.Point(68, 274);
            ButtonTextTwo.Name = "ButtonTextTwo";
            ButtonTextTwo.Size = new System.Drawing.Size(55, 25);
            ButtonTextTwo.TabIndex = 2;
            ButtonTextTwo.Text = "Текст 2";
            ButtonTextTwo.UseVisualStyleBackColor = true;
            ButtonTextTwo.Click += ButtonTextTwo_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new System.Drawing.Point(236, 275);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new System.Drawing.Size(75, 23);
            ButtonClear.TabIndex = 3;
            ButtonClear.Text = "Очистить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // FormOne
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(323, 307);
            Controls.Add(ButtonClear);
            Controls.Add(ButtonTextTwo);
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
        private System.Windows.Forms.Button ButtonTextTwo;
        private System.Windows.Forms.Button ButtonClear;
    }
}