using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorRichTextBox
{
   public static class RichTextBoxColor
   {
      public static void TextColorOne(RichTextBox box, string text, Color color)
      {
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         box.SelectionColor = color;
         // Добавляет текст в конец текущего текста в текстовом поле
         box.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         box.ScrollToCaret();
      }

      public static void TextColorTwo(RichTextBox rtb, string text, Color color, Font font, bool isNewLine = false)
      {
         // Временно приостанавливает логику макета для элемента управления
         rtb.SuspendLayout();
         // Получает или задает начальную позицию текста, выбранного в текстовом поле
         rtb.SelectionStart = rtb.TextLength;
         // Получает или задает число символов, выделенных в элементе управления
         rtb.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         rtb.SelectionColor = color;
         // Получает или задает цвет текущего текстового выделения или места вставки
         rtb.SelectionFont = font;
         // Добавляет текст в конец текущего текста в текстовом поле и переходит на новую строку
         rtb.AppendText(isNewLine ? string.Format("{0}{1}", text, Environment.NewLine) : text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         rtb.ScrollToCaret();
         // Возобновляет обычную логику макета
         rtb.ResumeLayout();
      }

      public static void TextColorThree(RichTextBox rtb, string text, Color color)
      {
         rtb.SuspendLayout(); // Временно приостанавливает логику макета для элемента управления
         rtb.SelectionStart = rtb.TextLength; // Получает или задает начальную позицию текста, выбранного в текстовом поле
         rtb.SelectionLength = 0; // Получает или задает число символов, выделенных в элементе управления
         rtb.SelectionColor = color; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         rtb.SelectionFont = font; // Получает или задает цвет текущего текстового выделения или места вставки
         rtb.AppendText(text); // Добавляет текст в конец текущего текста в текстовом поле
         rtb.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора
         rtb.ResumeLayout(); // Возобновляет обычную логику макета
      }
   }
}