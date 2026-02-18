using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorRichTextBox
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      // Вывод текста разных цветов через метод RichTextBoxColor
      private void ButtonTextOne_Click(object sender, EventArgs e)
      {
         RichTextBoxColor("Вывод текста через метод RichTextBoxColor.\n", Color.Red);
      }

      // Вывод текста разных цветов через метод TextColorOne класса RichTextBoxColor
      private void ButtonTextTwo_Click(object sender, EventArgs e)
      {
         ColorRichTextBox.RichTextBoxColor.TextColorOne(RichTextBoxOne, "Вывод текста через метод TextColor класса RichTextBoxColor.\n", Color.Fuchsia);
      }

      // Вывод текста разных цветов через метод TextColorTwo класса RichTextBoxColor
      private void ButtonTextThree_Click(object sender, EventArgs e)
      {
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         ColorRichTextBox.RichTextBoxColor.TextColorTwo(RichTextBoxOne, "Вывод текста через метод TextColor2 класса RichTextBoxColor.\n", Color.Black, font);
      }

      // Вывод текста разных цветов через метод TextColorThree класса RichTextBoxColor
      private void ButtonTextFour_Click(object sender, EventArgs e)
      {
         ColorRichTextBox.RichTextBoxColor.TextColorThree(RichTextBoxOne, "Вывод текста через метод TextColor3 класса RichTextBoxColor.\n", Color.Chocolate);
      }

      // Очистить RichTextBox
      private void ButtonClear_Click(object sender, EventArgs e)
      {
         RichTextBoxOne.Clear();
      }

      // Метод изменения цвета текста RichTextBox
      private void RichTextBoxColor(string tolog, Color color)
      {
         RichTextBoxOne.SelectionColor = color;
         RichTextBoxOne.AppendText(tolog);
         RichTextBoxOne.ScrollToCaret();
      }
   }
}