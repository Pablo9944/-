namespace Урок_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Text = "Я кнопка";
        }

       

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "321 ";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "123";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyText_MouseEnter(object sender, EventArgs e)
        {
            MyText.Text = "Навёл";
        }
    }
}