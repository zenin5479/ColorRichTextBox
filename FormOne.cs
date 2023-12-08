using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ColorRichTextBox
{
    public partial class FormOne : Form
    {
        public FormOne()
        {
            InitializeComponent();
        }

        // Вывод текста через метод Savelog
        private void ButtonTextOne_Click(object sender, EventArgs e)
        {
            Savelog("Вывод текста через метод Savelog.\n", Color.Red);
        }

        // Вывод текста через метод SavelogColor класса RichTextBoxColor
        private void ButtonTextTwo_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.SavelogColor("Вывод текста через метод SavelogColor класса RichTextBoxColor.\n",
                Color.Fuchsia);
        }

        // Вывод текста через метод SavelogColor2 класса RichTextBoxColor
        private void ButtonThree_Click(object sender, EventArgs e)
        {
            Font font = new Font("Tahoma", 10, FontStyle.Regular);
            RichTextBoxOne.SavelogColor2("Вывод текста через метод SavelogColor2 класса RichTextBoxColor.\n",
                Color.Black, font, false);
        }

        // Вывод текста через метод SavelogColor3 класса RichTextBoxColor
        private void ButtonFour_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.SavelogColor3("Вывод текста через метод SavelogColor3 класса RichTextBoxColor.\n",
                Color.Chocolate);
        }

        // Очистить RichTextBox
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.Clear();
        }

        // Метод записи в RichTextBox
        private void Savelog(string tolog, Color color)
        {
            RichTextBoxOne.SelectionColor = color;
            RichTextBoxOne.AppendText(tolog);
            RichTextBoxOne.ScrollToCaret();
        }
    }

    public static class RichTextBoxColor
    {
        public static void SavelogColor(this RichTextBox box, string text, Color color)
        {
            box.SelectionColor = color;
            box.AppendText(text);
            box.ScrollToCaret();
        }

        public static void SavelogColor2(this RichTextBox rtb, string text, Color color, Font font, bool isNewLine = false)
        {
            rtb.SuspendLayout(); // Временно приостанавливает логику макета для элемента управления.
            rtb.SelectionStart = rtb.TextLength; // Получает или задает начальную позицию текста, выбранного в текстовом поле.
            rtb.SelectionLength = 0; // Получает или задает число символов, выделенных в элементе управления.
            rtb.SelectionColor = color;
            rtb.SelectionFont = font; // Получает или задает цвет текущего текстового выделения или места вставки.
            rtb.AppendText(isNewLine ? $"{text}{Environment.NewLine}" : text); // Добавляет текст в конец текущего текста в текстовом поле.
            rtb.SelectionColor = rtb.ForeColor; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
            rtb.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
            rtb.ResumeLayout(); // Возобновляет обычную логику макета.
        }

        public static void SavelogColor3(this RichTextBox rtb, string text, Color color)
        {
            rtb.SuspendLayout(); // Временно приостанавливает логику макета для элемента управления.
            rtb.SelectionStart = rtb.TextLength; // Получает или задает начальную позицию текста, выбранного в текстовом поле.
            rtb.SelectionLength = 0; // Получает или задает число символов, выделенных в элементе управления.
            rtb.SelectionColor = color;
            Font font = new Font("Tahoma", 10, FontStyle.Regular);
            rtb.SelectionFont = font; // Получает или задает цвет текущего текстового выделения или места вставки.
            rtb.AppendText($"{text}{Environment.NewLine}"); // Добавляет текст в конец текущего текста в текстовом поле.
            rtb.SelectionColor = rtb.ForeColor; // Получает или задает цвет текста, который будет применен к текущему выделению или положению курсора.
            rtb.ScrollToCaret(); // Прокручивает содержимое элемента управления до текущей позиции курсора.
            rtb.ResumeLayout(); // Возобновляет обычную логику макета.
        }
    }
}