using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorRichTextBox
{
   public class RichTextBoxColorConstructor
   {
      private readonly RichTextBox _richTextBox;
      private readonly string _text;
      private readonly Color _color;

      // Конструктор, принимающий ссылки на элементы управления
      public RichTextBoxColorConstructor(RichTextBox richTextBox, string text, Color color)
      {
         _richTextBox = richTextBox;
         _text = text;
         _color = color;
      }

      public RichTextBoxColorConstructor(RichTextBox richTextBox, string text)
      {
         _richTextBox = richTextBox;
         _text = text;
      }

      public RichTextBoxColorConstructor(RichTextBox richTextBox)
      {
         _richTextBox = richTextBox;
      }

      // Метод, добавляет текст заданного цвета в RichTextBox
      public void TextColorConstructorOne()
      {
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         _richTextBox.SelectionColor = _color;
         // Добавляет текст в конец текущего текста в текстовом поле
         _richTextBox.AppendText(_text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         _richTextBox.ScrollToCaret();
      }

      // Метод, добавляет текст заданного цвета и шрифта в RichTextBox
      public void TextColorConstructorTwo()
      {
         // Временно приостанавливает логику макета для элемента управления
         _richTextBox.SuspendLayout();
         // Получает или задает начальную позицию текста, выбранного в текстовом поле
         _richTextBox.SelectionStart = _richTextBox.TextLength;
         // Получает или задает число символов, выделенных в элементе управления
         _richTextBox.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         _richTextBox.SelectionColor = Color.Indigo;
         Font font = new Font("Tahoma", 10, FontStyle.Regular);
         // Получает или задает цвет текущего текстового выделения или места вставки
         _richTextBox.SelectionFont = font;
         // Добавляет текст в конец текущего текста в текстовом поле и переходит на новую строку
         _richTextBox.AppendText(_text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         _richTextBox.ScrollToCaret();
         // Возобновляет обычную логику макета
         _richTextBox.ResumeLayout();
      }

      // Метод, добавляет текст заданного цвета и шрифта в RichTextBox
      public void TextColorConstructorThree()
      {
         // Временно приостанавливает логику макета для элемента управления
         _richTextBox.SuspendLayout();
         // Получает или задает начальную позицию текста, выбранного в текстовом поле
         _richTextBox.SelectionStart = _richTextBox.TextLength;
         // Получает или задает число символов, выделенных в элементе управления
         _richTextBox.SelectionLength = 0;
         // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора
         _richTextBox.SelectionColor = Color.Chocolate;
         Font font = new Font("Tahoma", 8, FontStyle.Regular);
         // Получает или задает цвет текущего текстового выделения или места вставки
         _richTextBox.SelectionFont = font;
         string text = "Вывод текста через метод TextColorConstructorOne класса RichTextBoxColorConstructor\n";
         // Добавляет текст в конец текущего текста в текстовом поле
         _richTextBox.AppendText(text);
         // Прокручивает содержимое элемента управления до текущей позиции курсора
         _richTextBox.ScrollToCaret();
         // Возобновляет обычную логику макета
         _richTextBox.ResumeLayout();
      }

      // Метод, добавляет текст в RichTextBox
   }
}