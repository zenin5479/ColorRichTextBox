﻿namespace ColorRichTextBox
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
            ButtonThree = new System.Windows.Forms.Button();
            ButtonFour = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // RichTextBoxOne
            // 
            RichTextBoxOne.Location = new System.Drawing.Point(12, 12);
            RichTextBoxOne.Name = "RichTextBoxOne";
            RichTextBoxOne.Size = new System.Drawing.Size(352, 250);
            RichTextBoxOne.TabIndex = 0;
            RichTextBoxOne.Text = "";
            // 
            // ButtonTextOne
            // 
            ButtonTextOne.Location = new System.Drawing.Point(12, 268);
            ButtonTextOne.Name = "ButtonTextOne";
            ButtonTextOne.Size = new System.Drawing.Size(45, 25);
            ButtonTextOne.TabIndex = 1;
            ButtonTextOne.Text = "Текст 1";
            ButtonTextOne.UseVisualStyleBackColor = true;
            ButtonTextOne.Click += ButtonTextOne_Click;
            // 
            // ButtonTextTwo
            // 
            ButtonTextTwo.Location = new System.Drawing.Point(63, 268);
            ButtonTextTwo.Name = "ButtonTextTwo";
            ButtonTextTwo.Size = new System.Drawing.Size(53, 25);
            ButtonTextTwo.TabIndex = 2;
            ButtonTextTwo.Text = "Текст 2";
            ButtonTextTwo.UseVisualStyleBackColor = true;
            ButtonTextTwo.Click += ButtonTextTwo_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new System.Drawing.Point(296, 269);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new System.Drawing.Size(68, 23);
            ButtonClear.TabIndex = 3;
            ButtonClear.Text = "Очистить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonThree
            // 
            ButtonThree.Location = new System.Drawing.Point(122, 268);
            ButtonThree.Name = "ButtonThree";
            ButtonThree.Size = new System.Drawing.Size(53, 25);
            ButtonThree.TabIndex = 4;
            ButtonThree.Text = "Текст 3";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += ButtonThree_Click;
            // 
            // ButtonFour
            // 
            ButtonFour.Location = new System.Drawing.Point(181, 268);
            ButtonFour.Name = "ButtonFour";
            ButtonFour.Size = new System.Drawing.Size(53, 25);
            ButtonFour.TabIndex = 5;
            ButtonFour.Text = "Текст 4";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += ButtonFour_Click;
            // 
            // FormOne
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(376, 301);
            Controls.Add(ButtonFour);
            Controls.Add(ButtonThree);
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
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonFour;
    }
}