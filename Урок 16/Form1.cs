using System.Security.Cryptography.X509Certificates;

namespace Урок_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < 1; Opacity += .05)
            {
                Location = new Point (500,300);
                await Task.Delay(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++, Print(), File.Delete(@$"C:\Users\foxaa\OneDrive\Рабочий стол\Христ\{i}.txt"))
            {

            }
        }

        void Print()
        {
            MessageBox.Show("Hello");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // 1 - 100%
            // .95 - 95%
            for (Opacity=0; Opacity < .95; Opacity += 0.01)
            {
                await Task.Delay(1);
            }
        }
    }
}