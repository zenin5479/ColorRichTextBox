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

        // Вывод текста через метод RichTextBoxColor
        private void ButtonTextOne_Click(object sender, EventArgs e)
        {
            RichTextBoxColor("Вывод текста через метод RichTextBoxColor.\n", Color.Red);
        }

        // Вывод текста через метод TextColor класса RichTextBoxColor
        private void ButtonTextTwo_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.TextColor("Вывод текста через метод TextColor класса RichTextBoxColor.\n",
                Color.Fuchsia);
        }

        // Вывод текста через метод TextColor2 класса RichTextBoxColor
        private void ButtonThree_Click(object sender, EventArgs e)
        {
            Font font = new Font("Tahoma", 10, FontStyle.Regular);
            RichTextBoxOne.TextColor2("Вывод текста через метод TextColor2 класса RichTextBoxColor.\n",
                Color.Black, font);
        }

        // Вывод текста через метод TextColor3 класса RichTextBoxColor
        private void ButtonFour_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.TextColor3("Вывод текста через метод TextColor3 класса RichTextBoxColor.\n",
                Color.Chocolate);
        }

        // Очистить RichTextBox
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.Clear();
        }

        // Метод вывода текста в RichTextBox
        private void RichTextBoxColor(string tolog, Color color)
        {
            RichTextBoxOne.SelectionColor = color;
            RichTextBoxOne.AppendText(tolog);
            RichTextBoxOne.ScrollToCaret();
        }
    }

    public static class RichTextBoxColor
    {
        public static void TextColor(this RichTextBox box, string text, Color color)
        {
            box.SelectionColor = color; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
            box.AppendText(text); // Добавляет текст в конец текущего текста в текстовом поле.
            box.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
        }

        public static void TextColor2(this RichTextBox rtb, string text, Color color, Font font, bool isNewLine = false)
        {
            rtb.SuspendLayout(); // Временно приостанавливает логику макета для элемента управления.
            rtb.SelectionStart = rtb.TextLength; // Получает или задает начальную позицию текста, выбранного в текстовом поле.
            rtb.SelectionLength = 0; // Получает или задает число символов, выделенных в элементе управления.
            rtb.SelectionColor = color; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
            rtb.SelectionFont = font; // Получает или задает цвет текущего текстового выделения или места вставки.
            rtb.AppendText(isNewLine ? $"{text}{Environment.NewLine}" : text); // Добавляет текст в конец текущего текста в текстовом поле и переходит на новую строку
            rtb.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
            rtb.ResumeLayout(); // Возобновляет обычную логику макета.
        }

        public static void TextColor3(this RichTextBox rtb, string text, Color color)
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