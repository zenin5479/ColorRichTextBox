using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorRichTextBox
{
   public static class RichTextBoxColor
   {
      public static void TextColorOne(RichTextBox box, string text, Color color)
      {
         box.SelectionColor = color; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
         box.AppendText(text); // Добавляет текст в конец текущего текста в текстовом поле.
         box.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
      }

      public static void TextColorTwo(RichTextBox rtb, string text, Color color, Font font, bool isNewLine = false)
      {
         rtb.SuspendLayout(); // Временно приостанавливает логику макета для элемента управления.
         rtb.SelectionStart = rtb.TextLength; // Получает или задает начальную позицию текста, выбранного в текстовом поле.
         rtb.SelectionLength = 0; // Получает или задает число символов, выделенных в элементе управления.
         rtb.SelectionColor = color; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
         rtb.SelectionFont = font; // Получает или задает цвет текущего текстового выделения или места вставки.
         rtb.AppendText(isNewLine ? string.Format("{0}{1}", text, Environment.NewLine) : text); // Добавляет текст в конец текущего текста в текстовом поле и переходит на новую строку
         rtb.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
         rtb.ResumeLayout(); // Возобновляет обычную логику макета.
      }

      public static void TextColorThree(RichTextBox rtb, string text, Color color)
      {
         rtb.SuspendLayout(); // Временно приостанавливает логику макета для элемента управления.
         rtb.SelectionStart = rtb.TextLength; // Получает или задает начальную позицию текста, выбранного в текстовом поле.
         rtb.SelectionLength = 0; // Получает или задает число символов, выделенных в элементе управления.
         rtb.SelectionColor = color; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         rtb.SelectionFont = font; // Получает или задает цвет текущего текстового выделения или места вставки.
         rtb.AppendText(text); // Добавляет текст в конец текущего текста в текстовом поле.
         rtb.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
         rtb.ResumeLayout(); // Возобновляет обычную логику макета.
      }
   }
}