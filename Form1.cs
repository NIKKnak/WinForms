namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgressBar();



        }

        async void ProgressBar()
        {
            await Task.Run(async () =>
            {
                while (progressBar1.Value != 100)
                {
                    progressBar1.Value++;
                    await Task.Delay(100);  // задержка милисек
                }
            });



        }

    }
}