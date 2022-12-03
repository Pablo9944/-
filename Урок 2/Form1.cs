using System.IO;

namespace Урок_2
{
    public partial class Form1 : Form
    {
        
        string path = "";
        string pathz = "я";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            label4.Text = Location.ToString();

            if(CheckBox.Checked)
            {
                if(!File.Exists(path)) 
                {
                   DialogResult dialogResult = MessageBox.Show("Файла нет или удалён","Ошибка",MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("ok");
                        
                    }
                    
                  
                }
                else 
                {
                    File.Delete(path);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            path = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = Location        
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // CheckMethod(string.IsNullOrEmpty(pathz) ? "Строка пустая" : "В строке что-то есть");
            CheckMethod(File.Exists(pathz)? "В строке что-то есть" : "Строка пустая"  );

        }
        private void CheckMethod(string message)
        {
           
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}