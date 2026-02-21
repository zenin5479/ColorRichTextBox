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

      // Вывод текста заданного цвета через метод RichTextBoxColor
      private void ButtonTextOne_Click(object sender, EventArgs e)
      {
         RichTextBoxColor("Вывод текста через метод RichTextBoxColor.\n", Color.Red);
      }

      // Вывод текста заданного цвета через метод TextColorOne класса RichTextBoxColor
      private void ButtonTextTwo_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod constructor = new RichTextBoxColorMethod();
         constructor.TextColorOne(RichTextBoxOne, "Вывод текста через метод TextColorOne класса RichTextBoxColor.\n", Color.Red);
      }

      // Вывод текста заданного цвета через метод TextColorTwo класса RichTextBoxColor
      private void ButtonTextThree_Click(object sender, EventArgs e)
      {
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         RichTextBoxColorMethod.TextColorTwo(RichTextBoxOne,
            "Вывод текста через метод TextColorTwo класса RichTextBoxColor.\n", Color.Black, font);
      }

      // Вывод текста заданного цвета через метод TextColorThree класса RichTextBoxColor
      private void ButtonTextFour_Click(object sender, EventArgs e)
      {
         ColorRichTextBox.RichTextBoxColorMethod.TextColorThree(RichTextBoxOne,
            "Вывод текста через метод TextColorThree класса RichTextBoxColor.\n", Color.Chocolate);
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