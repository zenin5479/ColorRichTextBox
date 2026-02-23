using System.Windows.Forms;
using System;

namespace ColorRichTextBox
{
   public class RichTextBoxColorConstructor
   {
      private readonly TextBox _textBox;
      private readonly ListBox _listBox;
      private readonly RichTextBox _richTextBox;

      // Конструктор, принимающий ссылки на элементы управления
      public RichTextBoxColorConstructor(TextBox textBox, ListBox listBox, RichTextBox richTextBox)
      {
         _textBox = textBox;
         _listBox = listBox;
         _richTextBox = richTextBox;
      }

     

      // Метод, добавляет элемент в ListBox
      public void AddToListBox(string item)
      {
         if (_listBox != null)
         {
            _listBox.Items.Add(item);
            // Прокрутка ListBox вниз
            _listBox.TopIndex = _listBox.Items.Count - 1;
         }
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