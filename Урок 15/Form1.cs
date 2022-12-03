namespace Урок_15
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartProgram();
           
        }
        private async void StartProgram()
        {
            await Task.Run(() =>
            {
                while (true)
                {

                }
            });
          
        }
        private async void StopProgram()
        {
            await Task.Run(() => Close());
           
        }

        private  void  button2_Click(object sender, EventArgs e)
        {

            StopProgram();
        }
        
        private async void PrintText()
        {
            await Task.Run(() =>
            {
             SetMessage(textBox1.Text);
               
            });
            await Task.Delay(1000);
        }
        private  void SetMessage(string message) 
        {
             
           // Thread.Sleep(1000);
            label1.Text = message;
           
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrintText();
           
        }
    }
}