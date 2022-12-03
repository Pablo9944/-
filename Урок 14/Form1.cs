namespace Урок_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
            }
            // Закроет программу
            // Close();

            // Заносит информацию в буфер
            Clipboard.SetText("dgdgdgd");
        }

        
    }
}