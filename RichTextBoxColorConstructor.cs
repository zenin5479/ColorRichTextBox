using System.Windows.Forms;
using System;

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