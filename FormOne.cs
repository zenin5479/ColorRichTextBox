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

      // Вывод текста заданного цвета через метод RichTextBoxColor класса ColorRichTextBox
      private void ButtonTextMethodOne_Click(object sender, EventArgs e)
      {
         RichTextBoxColor("Вывод текста через метод RichTextBoxColor класса ColorRichTextBox\n", Color.Fuchsia);
      }

      // Вывод текста заданного цвета через метод TextColorOne класса RichTextBoxColorMethod
      private void ButtonTextTwo_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod method = new RichTextBoxColorMethod();
         method.TextColorTwo(RichTextBoxOne, "Вывод текста через метод TextColorTwo класса RichTextBoxColor\n", Color.Red);
      }

      // Вывод текста заданного цвета и шрифта через метод TextColorTwo класса RichTextBoxColorMethod
      private void ButtonTextThree_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod method = new RichTextBoxColorMethod();
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         method.TextColorThree(RichTextBoxOne, "Вывод текста через метод TextColorThree класса RichTextBoxColor\n", Color.Black, font);
      }

      // Вывод текста заданного цвета через метод TextColorThree класса RichTextBoxColorMethod
      private void ButtonTextFour_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod method = new RichTextBoxColorMethod();
         method.TextColorFour(RichTextBoxOne, "Вывод текста через метод TextColorFour класса RichTextBoxColor\n", Color.Chocolate);
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

      private void button1_Click(object sender, EventArgs e)
      {

      }
   }
}