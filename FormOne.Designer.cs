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
         GroupBoxMethod = new System.Windows.Forms.GroupBox();
         groupBox1 = new System.Windows.Forms.GroupBox();
         button1 = new System.Windows.Forms.Button();
         button2 = new System.Windows.Forms.Button();
         button3 = new System.Windows.Forms.Button();
         button4 = new System.Windows.Forms.Button();
         GroupBoxMethod.SuspendLayout();
         groupBox1.SuspendLayout();
         SuspendLayout();
         // 
         // RichTextBoxOne
         // 
         RichTextBoxOne.Location = new System.Drawing.Point(12, 76);
         RichTextBoxOne.Name = "RichTextBoxOne";
         RichTextBoxOne.Size = new System.Drawing.Size(410, 250);
         RichTextBoxOne.TabIndex = 0;
         RichTextBoxOne.Text = "";
         // 
         // ButtonTextOne
         // 
         ButtonTextOne.Location = new System.Drawing.Point(6, 22);
         ButtonTextOne.Name = "ButtonTextOne";
         ButtonTextOne.Size = new System.Drawing.Size(70, 25);
         ButtonTextOne.TabIndex = 1;
         ButtonTextOne.Text = "Вариант 1";
         ButtonTextOne.UseVisualStyleBackColor = true;
         ButtonTextOne.Click += ButtonTextOne_Click;
         // 
         // ButtonTextTwo
         // 
         ButtonTextTwo.Location = new System.Drawing.Point(82, 22);
         ButtonTextTwo.Name = "ButtonTextTwo";
         ButtonTextTwo.Size = new System.Drawing.Size(70, 25);
         ButtonTextTwo.TabIndex = 2;
         ButtonTextTwo.Text = "Вариант 2";
         ButtonTextTwo.UseVisualStyleBackColor = true;
         ButtonTextTwo.Click += ButtonTextTwo_Click;
         // 
         // ButtonClear
         // 
         ButtonClear.Location = new System.Drawing.Point(18, 396);
         ButtonClear.Name = "ButtonClear";
         ButtonClear.Size = new System.Drawing.Size(68, 23);
         ButtonClear.TabIndex = 3;
         ButtonClear.Text = "Очистить";
         ButtonClear.UseVisualStyleBackColor = true;
         ButtonClear.Click += ButtonClear_Click;
         // 
         // ButtonTextThree
         // 
         ButtonTextThree.Location = new System.Drawing.Point(158, 22);
         ButtonTextThree.Name = "ButtonTextThree";
         ButtonTextThree.Size = new System.Drawing.Size(70, 25);
         ButtonTextThree.TabIndex = 4;
         ButtonTextThree.Text = "Вариант 3";
         ButtonTextThree.UseVisualStyleBackColor = true;
         ButtonTextThree.Click += ButtonTextThree_Click;
         // 
         // ButtonTextFour
         // 
         ButtonTextFour.Location = new System.Drawing.Point(234, 22);
         ButtonTextFour.Name = "ButtonTextFour";
         ButtonTextFour.Size = new System.Drawing.Size(70, 25);
         ButtonTextFour.TabIndex = 5;
         ButtonTextFour.Text = "Вариант 4";
         ButtonTextFour.UseVisualStyleBackColor = true;
         ButtonTextFour.Click += ButtonTextFour_Click;
         // 
         // GroupBoxMethod
         // 
         GroupBoxMethod.Controls.Add(ButtonTextOne);
         GroupBoxMethod.Controls.Add(ButtonTextFour);
         GroupBoxMethod.Controls.Add(ButtonTextTwo);
         GroupBoxMethod.Controls.Add(ButtonTextThree);
         GroupBoxMethod.Location = new System.Drawing.Point(12, 332);
         GroupBoxMethod.Name = "GroupBoxMethod";
         GroupBoxMethod.Size = new System.Drawing.Size(410, 58);
         GroupBoxMethod.TabIndex = 6;
         GroupBoxMethod.TabStop = false;
         GroupBoxMethod.Text = "Передача ссылок в класс на элементы управления через метод";
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(button1);
         groupBox1.Controls.Add(button2);
         groupBox1.Controls.Add(button3);
         groupBox1.Controls.Add(button4);
         groupBox1.Location = new System.Drawing.Point(12, 12);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new System.Drawing.Size(410, 58);
         groupBox1.TabIndex = 7;
         groupBox1.TabStop = false;
         groupBox1.Text = "Передача ссылок в класс на элементы управления через конструктор";
         // 
         // button1
         // 
         button1.Location = new System.Drawing.Point(6, 22);
         button1.Name = "button1";
         button1.Size = new System.Drawing.Size(70, 25);
         button1.TabIndex = 1;
         button1.Text = "Вариант 1";
         button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         button2.Location = new System.Drawing.Point(234, 22);
         button2.Name = "button2";
         button2.Size = new System.Drawing.Size(70, 25);
         button2.TabIndex = 5;
         button2.Text = "Вариант 4";
         button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         button3.Location = new System.Drawing.Point(82, 22);
         button3.Name = "button3";
         button3.Size = new System.Drawing.Size(70, 25);
         button3.TabIndex = 2;
         button3.Text = "Вариант 2";
         button3.UseVisualStyleBackColor = true;
         // 
         // button4
         // 
         button4.Location = new System.Drawing.Point(158, 22);
         button4.Name = "button4";
         button4.Size = new System.Drawing.Size(70, 25);
         button4.TabIndex = 4;
         button4.Text = "Вариант 3";
         button4.UseVisualStyleBackColor = true;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(845, 538);
         Controls.Add(groupBox1);
         Controls.Add(GroupBoxMethod);
         Controls.Add(ButtonClear);
         Controls.Add(RichTextBoxOne);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Цвет текста в строке";
         GroupBoxMethod.ResumeLayout(false);
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
      private System.Windows.Forms.GroupBox GroupBoxMethod;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
   }
}