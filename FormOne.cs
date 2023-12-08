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


        // Запись логов
        private void Savelog(string tolog, Color color)
        {
            RichTextBoxOne.SelectionColor = color;
            RichTextBoxOne.AppendText(tolog);
            RichTextBoxOne.ScrollToCaret();
        }

        private void ButtonTextOne_Click(object sender, System.EventArgs e)
        {
            Savelog("Текст: " + "Анн Голон, Серж Голон. Анжелика и король.\n", Color.Red);
        }

        private delegate void SavelogDelegate(string tolog, Color color);
    }
}