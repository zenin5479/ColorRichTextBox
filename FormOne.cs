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
            RichTextBoxOne.TextColor("Вывод текста через метод TextColor класса RichTextBoxColor.\n", Color.Fuchsia);
        }

        // Вывод текста через метод TextColor2 класса RichTextBoxColor
        private void ButtonThree_Click(object sender, EventArgs e)
        {
            Font font = new Font("Tahoma", 10, FontStyle.Regular);
            RichTextBoxOne.TextColor2("Вывод текста через метод TextColor2 класса RichTextBoxColor.\n", Color.Black, font);
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
}