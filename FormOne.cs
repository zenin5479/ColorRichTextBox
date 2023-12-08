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

        private void ButtonThree_Click(object sender, EventArgs e)
        {

        }

        // Очистить RichTextBox
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RichTextBoxOne.Clear();
        }

        // Запись логов
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
    }

    public static class RichTextBoxColor2
    {
        private static void Savelog(string tolog, Color color)
        {
            //RichTextBoxOne.SelectionColor = color;
            //RichTextBoxOne.AppendText(tolog);
            //RichTextBoxOne.ScrollToCaret();
        }
    }
}