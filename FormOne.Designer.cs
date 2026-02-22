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
         ButtonTextThree = new System.Windows.Forms.Button();
         ButtonTextFour = new System.Windows.Forms.Button();
         groupBox1 = new System.Windows.Forms.GroupBox();
         groupBox1.SuspendLayout();
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
         ButtonTextOne.Location = new System.Drawing.Point(6, 22);
         ButtonTextOne.Name = "ButtonTextOne";
         ButtonTextOne.Size = new System.Drawing.Size(45, 25);
         ButtonTextOne.TabIndex = 1;
         ButtonTextOne.Text = "Текст 1";
         ButtonTextOne.UseVisualStyleBackColor = true;
         ButtonTextOne.Click += ButtonTextOne_Click;
         // 
         // ButtonTextTwo
         // 
         ButtonTextTwo.Location = new System.Drawing.Point(57, 22);
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
         // ButtonTextThree
         // 
         ButtonTextThree.Location = new System.Drawing.Point(116, 22);
         ButtonTextThree.Name = "ButtonTextThree";
         ButtonTextThree.Size = new System.Drawing.Size(53, 25);
         ButtonTextThree.TabIndex = 4;
         ButtonTextThree.Text = "Текст 3";
         ButtonTextThree.UseVisualStyleBackColor = true;
         ButtonTextThree.Click += ButtonTextThree_Click;
         // 
         // ButtonTextFour
         // 
         ButtonTextFour.Location = new System.Drawing.Point(6, 53);
         ButtonTextFour.Name = "ButtonTextFour";
         ButtonTextFour.Size = new System.Drawing.Size(53, 25);
         ButtonTextFour.TabIndex = 5;
         ButtonTextFour.Text = "Текст 4";
         ButtonTextFour.UseVisualStyleBackColor = true;
         ButtonTextFour.Click += ButtonTextFour_Click;
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(ButtonTextOne);
         groupBox1.Controls.Add(ButtonTextFour);
         groupBox1.Controls.Add(ButtonTextTwo);
         groupBox1.Controls.Add(ButtonTextThree);
         groupBox1.Location = new System.Drawing.Point(426, 173);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new System.Drawing.Size(200, 100);
         groupBox1.TabIndex = 6;
         groupBox1.TabStop = false;
         groupBox1.Text = "groupBox1";
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(845, 538);
         Controls.Add(groupBox1);
         Controls.Add(ButtonClear);
         Controls.Add(RichTextBoxOne);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Цвет текста в строке";
         groupBox1.ResumeLayout(false);
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.RichTextBox RichTextBoxOne;
      private System.Windows.Forms.Button ButtonTextOne;
      private System.Windows.Forms.Button ButtonTextTwo;
      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.Button ButtonTextThree;
      private System.Windows.Forms.Button ButtonTextFour;
      private System.Windows.Forms.GroupBox groupBox1;
   }
}