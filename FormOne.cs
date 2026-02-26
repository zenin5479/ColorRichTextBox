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

      // Вывод текста заданного цвета через метод TextColorMethodTwo класса RichTextBoxColorMethod
      private void ButtonTextMethodTwo_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod method = new RichTextBoxColorMethod();
         method.TextColorMethodTwo(RichTextBoxOne, "Вывод текста через метод TextColorTwo класса RichTextBoxColor\n", Color.Red);
      }

      // Вывод текста заданного цвета и шрифта через метод TextColorTwo класса RichTextBoxColorMethod
      private void ButtonTextMethodThree_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod method = new RichTextBoxColorMethod();
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         method.TextColorMethodThree(RichTextBoxOne, "Вывод текста через метод TextColorThree класса RichTextBoxColor\n", Color.Black, font);
      }

      // Вывод текста заданного цвета через метод TextColorThree класса RichTextBoxColorMethod
      private void ButtonTextMethodFour_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorMethod method = new RichTextBoxColorMethod();
         method.TextColorMethodFour(RichTextBoxOne, "Вывод текста через метод TextColorFour класса RichTextBoxColor\n", Color.Chocolate);
      }

      // Вывод текста заданного цвета через метод TextColorConstructorOne класса RichTextBoxColorConstructor
      private void ButtonTextConstructorOne_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorConstructor constructor = new RichTextBoxColorConstructor(RichTextBoxOne,
            "Вывод текста через метод TextColorConstructorOne класса RichTextBoxColorConstructor\n", Color.Fuchsia);
         constructor.TextColorConstructorOne();
      }

      // Вывод текста заданного цвета через метод TextColorConstructorTwo класса RichTextBoxColorConstructor
      private void ButtonTextConstructorTwo_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorConstructor constructor = new RichTextBoxColorConstructor(RichTextBoxOne,
            "Вывод текста через метод TextColorConstructorTwo класса RichTextBoxColorConstructor\n");
         constructor.TextColorConstructorTwo();
      }

      // Вывод текста заданного цвета через метод TextColorConstructorThree класса RichTextBoxColorConstructor
      private void ButtonTextConstructorThree_Click(object sender, EventArgs e)
      {
         // Создаём экземпляр класса и передаём ссылку на элемент управления: RichTextBox
         // Локальная переменная создаётся здесь и живёт только в этом методе
         RichTextBoxColorConstructor constructor = new RichTextBoxColorConstructor(RichTextBoxOne);
         constructor.TextColorConstructorThree();
      }

      // Метод изменения цвета текста RichTextBox
      private void RichTextBoxColor(string tolog, Color color)
      {
         RichTextBoxOne.SelectionColor = color;
         RichTextBoxOne.AppendText(tolog);
         RichTextBoxOne.ScrollToCaret();
      }

      // Очистить RichTextBox
      private void ButtonClear_Click(object sender, EventArgs e)
      {
         RichTextBoxOne.Clear();
      }
   }
}