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


            char[] lines = "� �������� ���� ������� ������������� � ���� �� �������� �������� �����".ToCharArray();


            foreach (char line in lines)
            {
                label1.Text += line.ToString();
                await Task.Delay(50);
            }




        }

        async void ProgressBar()
        {
            await Task.Run(async () =>
            {
                while (progressBar1.Value != 100)
                {
                    progressBar1.Value++;
                    await Task.Delay(10);  // �������� �������
                }
            });



        }


    }
}