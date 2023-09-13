namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            ProgressBar();

            textBox1.Text = textBox1.Text.Replace("еще", "ещё");


            await Task.Delay(500);
            button1.Text = "Исправлено";

            await Task.Delay(500);
            button1.Text = "Скопировать ?";

            Clipboard.SetDataObject(textBox1.Text);


        }

        async void ProgressBar()
        {
            await Task.Run(async () =>
            {
                while (progressBar1.Value != 100)
                {
                    progressBar1.Value++;
                    await Task.Delay(10);  // задержка милисек
                }
            });



        }


    }
}