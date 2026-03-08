namespace TP_MODUL3_103022400117
{
    public partial class Form1 : Form
    {
        int totalJumlah = 0;
        string angkaSementara = "";
        string riwayatHitung = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "2";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (angkaSementara != "")
            {
                totalJumlah = totalJumlah + int.Parse(angkaSementara);
                labelOutput.Text = riwayatHitung + angkaSementara + " = " + totalJumlah.ToString();
                angkaSementara = "";
                riwayatHitung = "";
                totalJumlah = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "1";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "3";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "4";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "5";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "6";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "7";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "8";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "9";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            angkaSementara = angkaSementara + "0";
            labelOutput.Text = riwayatHitung + angkaSementara;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (angkaSementara != "")
            {
                totalJumlah = totalJumlah + int.Parse(angkaSementara);
                riwayatHitung = riwayatHitung + angkaSementara + " + ";
                angkaSementara = "";
                labelOutput.Text = riwayatHitung;
            }
        }
    }
}
