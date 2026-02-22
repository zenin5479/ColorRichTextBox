using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorRichTextBox
{
   public class RichTextBoxColorMethod
   {
      public void TextColorOne(RichTextBox richTextBox, string text, Color color)
      {
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         richTextBox.SelectionColor = color;
         // Добавляет текст в конец текущего текста в текстовом поле
         richTextBox.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         richTextBox.ScrollToCaret();
      }

      public void TextColorTwo(RichTextBox richTextBox, string text, Color color, Font font, bool isNewLine = false)
      {
         // Временно приостанавливает логику макета для элемента управления
         richTextBox.SuspendLayout();
         // Получает или задает начальную позицию текста, выбранного в текстовом поле
         richTextBox.SelectionStart = richTextBox.TextLength;
         // Получает или задает число символов, выделенных в элементе управления
         richTextBox.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         richTextBox.SelectionColor = color;
         // Получает или задает цвет текущего текстового выделения или места вставки
         richTextBox.SelectionFont = font;
         // Добавляет текст в конец текущего текста в текстовом поле и переходит на новую строку
         richTextBox.AppendText(isNewLine ? string.Format("{0}{1}", text, Environment.NewLine) : text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         richTextBox.ScrollToCaret();
         // Возобновляет обычную логику макета
         richTextBox.ResumeLayout();
      }

      public void TextColorThree(RichTextBox richTextBox, string text, Color color)
      {
         // Временно приостанавливает логику макета для элемента управления
         richTextBox.SuspendLayout();
         // Получает или задает начальную позицию текста, выбранного в текстовом поле
         richTextBox.SelectionStart = richTextBox.TextLength;
         // Получает или задает число символов, выделенных в элементе управления
         richTextBox.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         richTextBox.SelectionColor = color;
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         // Получает или задает цвет текущего текстового выделения или места вставки
         richTextBox.SelectionFont = font;
         // Добавляет текст в конец текущего текста в текстовом поле
         richTextBox.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         richTextBox.ScrollToCaret();
         // Возобновляет обычную логику макета
         richTextBox.ResumeLayout();
      }
   }
}