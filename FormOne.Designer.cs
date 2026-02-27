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
         ButtonTextMethodOne = new System.Windows.Forms.Button();
         ButtonTextMethodTwo = new System.Windows.Forms.Button();
         ButtonClear = new System.Windows.Forms.Button();
         ButtonTextMethodThree = new System.Windows.Forms.Button();
         ButtonTextMethodFour = new System.Windows.Forms.Button();
         GroupBoxMethod = new System.Windows.Forms.GroupBox();
         groupBox1 = new System.Windows.Forms.GroupBox();
         ButtonTextConstructorOne = new System.Windows.Forms.Button();
         ButtonTextConstructorTwo = new System.Windows.Forms.Button();
         ButtonTextConstructorThree = new System.Windows.Forms.Button();
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
         RichTextBoxOne.TextChanged += RichTextBoxOne_TextChanged;
         // 
         // ButtonTextMethodOne
         // 
         ButtonTextMethodOne.Location = new System.Drawing.Point(6, 22);
         ButtonTextMethodOne.Name = "ButtonTextMethodOne";
         ButtonTextMethodOne.Size = new System.Drawing.Size(70, 25);
         ButtonTextMethodOne.TabIndex = 1;
         ButtonTextMethodOne.Text = "Вариант 1";
         ButtonTextMethodOne.UseVisualStyleBackColor = true;
         ButtonTextMethodOne.Click += ButtonTextMethodOne_Click;
         // 
         // ButtonTextMethodTwo
         // 
         ButtonTextMethodTwo.Location = new System.Drawing.Point(82, 22);
         ButtonTextMethodTwo.Name = "ButtonTextMethodTwo";
         ButtonTextMethodTwo.Size = new System.Drawing.Size(70, 25);
         ButtonTextMethodTwo.TabIndex = 2;
         ButtonTextMethodTwo.Text = "Вариант 2";
         ButtonTextMethodTwo.UseVisualStyleBackColor = true;
         ButtonTextMethodTwo.Click += ButtonTextMethodTwo_Click;
         // 
         // ButtonClear
         // 
         ButtonClear.Location = new System.Drawing.Point(12, 396);
         ButtonClear.Name = "ButtonClear";
         ButtonClear.Size = new System.Drawing.Size(68, 23);
         ButtonClear.TabIndex = 3;
         ButtonClear.Text = "Очистить";
         ButtonClear.UseVisualStyleBackColor = true;
         ButtonClear.Click += ButtonClear_Click;
         // 
         // ButtonTextMethodThree
         // 
         ButtonTextMethodThree.Location = new System.Drawing.Point(158, 22);
         ButtonTextMethodThree.Name = "ButtonTextMethodThree";
         ButtonTextMethodThree.Size = new System.Drawing.Size(70, 25);
         ButtonTextMethodThree.TabIndex = 4;
         ButtonTextMethodThree.Text = "Вариант 3";
         ButtonTextMethodThree.UseVisualStyleBackColor = true;
         ButtonTextMethodThree.Click += ButtonTextMethodThree_Click;
         // 
         // ButtonTextMethodFour
         // 
         ButtonTextMethodFour.Location = new System.Drawing.Point(234, 22);
         ButtonTextMethodFour.Name = "ButtonTextMethodFour";
         ButtonTextMethodFour.Size = new System.Drawing.Size(70, 25);
         ButtonTextMethodFour.TabIndex = 5;
         ButtonTextMethodFour.Text = "Вариант 4";
         ButtonTextMethodFour.UseVisualStyleBackColor = true;
         ButtonTextMethodFour.Click += ButtonTextMethodFour_Click;
         // 
         // GroupBoxMethod
         // 
         GroupBoxMethod.Controls.Add(ButtonTextMethodOne);
         GroupBoxMethod.Controls.Add(ButtonTextMethodFour);
         GroupBoxMethod.Controls.Add(ButtonTextMethodTwo);
         GroupBoxMethod.Controls.Add(ButtonTextMethodThree);
         GroupBoxMethod.Location = new System.Drawing.Point(12, 332);
         GroupBoxMethod.Name = "GroupBoxMethod";
         GroupBoxMethod.Size = new System.Drawing.Size(375, 58);
         GroupBoxMethod.TabIndex = 6;
         GroupBoxMethod.TabStop = false;
         GroupBoxMethod.Text = "Передача ссылок в класс на элементы управления через метод";
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(ButtonTextConstructorOne);
         groupBox1.Controls.Add(ButtonTextConstructorTwo);
         groupBox1.Controls.Add(ButtonTextConstructorThree);
         groupBox1.Location = new System.Drawing.Point(12, 12);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new System.Drawing.Size(410, 58);
         groupBox1.TabIndex = 7;
         groupBox1.TabStop = false;
         groupBox1.Text = "Передача ссылок в класс на элементы управления через конструктор";
         // 
         // ButtonTextConstructorOne
         // 
         ButtonTextConstructorOne.Location = new System.Drawing.Point(6, 22);
         ButtonTextConstructorOne.Name = "ButtonTextConstructorOne";
         ButtonTextConstructorOne.Size = new System.Drawing.Size(70, 25);
         ButtonTextConstructorOne.TabIndex = 1;
         ButtonTextConstructorOne.Text = "Вариант 1";
         ButtonTextConstructorOne.UseVisualStyleBackColor = true;
         ButtonTextConstructorOne.Click += ButtonTextConstructorOne_Click;
         // 
         // ButtonTextConstructorTwo
         // 
         ButtonTextConstructorTwo.Location = new System.Drawing.Point(82, 22);
         ButtonTextConstructorTwo.Name = "ButtonTextConstructorTwo";
         ButtonTextConstructorTwo.Size = new System.Drawing.Size(70, 25);
         ButtonTextConstructorTwo.TabIndex = 2;
         ButtonTextConstructorTwo.Text = "Вариант 2";
         ButtonTextConstructorTwo.UseVisualStyleBackColor = true;
         ButtonTextConstructorTwo.Click += ButtonTextConstructorTwo_Click;
         // 
         // ButtonTextConstructorThree
         // 
         ButtonTextConstructorThree.Location = new System.Drawing.Point(158, 22);
         ButtonTextConstructorThree.Name = "ButtonTextConstructorThree";
         ButtonTextConstructorThree.Size = new System.Drawing.Size(70, 25);
         ButtonTextConstructorThree.TabIndex = 4;
         ButtonTextConstructorThree.Text = "Вариант 3";
         ButtonTextConstructorThree.UseVisualStyleBackColor = true;
         ButtonTextConstructorThree.Click += ButtonTextConstructorThree_Click;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(434, 430);
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
      private System.Windows.Forms.Button ButtonTextMethodOne;
      private System.Windows.Forms.Button ButtonTextMethodTwo;
      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.Button ButtonTextMethodThree;
      private System.Windows.Forms.Button ButtonTextMethodFour;
      private System.Windows.Forms.GroupBox GroupBoxMethod;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button ButtonTextConstructorOne;
      private System.Windows.Forms.Button ButtonTextConstructorTwo;
      private System.Windows.Forms.Button ButtonTextConstructorThree;
   }
}