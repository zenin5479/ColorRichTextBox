using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorRichTextBox
{
   public class RichTextBoxColorConstructor
   {
      private readonly RichTextBox _richTextBox;

      // Конструктор, принимающий ссылки на элементы управления
      public RichTextBoxColorConstructor(RichTextBox richTextBox)
      {
         _richTextBox = richTextBox;
      }

      // Метод, добавляет текст заданного цвета в RichTextBox
      public void TextColorConstructorTwo(RichTextBox richTextBox, string text, Color color)
      {
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         richTextBox.SelectionColor = color;
         // Добавляет текст в конец текущего текста в текстовом поле
         richTextBox.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         richTextBox.ScrollToCaret();
      }

      // Метод, добавляет текст заданного цвета и шрифта в RichTextBox
      public void TextColorConstructorThree(RichTextBox richTextBox, string text, Color color, Font font)
      {
         //// Временно приостанавливает логику макета для элемента управления
         //richTextBox.SuspendLayout();
         //// Получает или задает начальную позицию текста, выбранного в текстовом поле
         //richTextBox.SelectionStart = richTextBox.TextLength;
         //// Получает или задает число символов, выделенных в элементе управления
         //richTextBox.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         richTextBox.SelectionColor = color;
         // Получает или задает цвет текущего текстового выделения или места вставки
         richTextBox.SelectionFont = font;
         // Добавляет текст в конец текущего текста в текстовом поле и переходит на новую строку
         richTextBox.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         richTextBox.ScrollToCaret();
         //// Возобновляет обычную логику макета
         //richTextBox.ResumeLayout();
      }

      // Метод, добавляет текст заданного цвета и шрифта в RichTextBox
      public void TextColorConstructorFour(RichTextBox richTextBox, string text, Color color)
      {
         //// Временно приостанавливает логику макета для элемента управления
         //richTextBox.SuspendLayout();
         //// Получает или задает начальную позицию текста, выбранного в текстовом поле
         //richTextBox.SelectionStart = richTextBox.TextLength;
         //// Получает или задает число символов, выделенных в элементе управления
         //richTextBox.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         richTextBox.SelectionColor = color;
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         // Получает или задает цвет текущего текстового выделения или места вставки
         richTextBox.SelectionFont = font;
         // Добавляет текст в конец текущего текста в текстовом поле
         richTextBox.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         richTextBox.ScrollToCaret();
         //// Возобновляет обычную логику макета
         //richTextBox.ResumeLayout();
      }





      // Метод, добавляет текст в RichTextBox
      public void AddToRichTextBox(string text)
      {
         if (_richTextBox != null)
         {
            _richTextBox.AppendText(text);
            _richTextBox.AppendText(Environment.NewLine);
            // Прокрутка RichTextBox вниз
            _richTextBox.ScrollToCaret();
         }
      }
   }
}