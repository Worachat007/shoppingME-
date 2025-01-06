namespace WinFormsApp1
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputCFP = cf_Price.Text;
            string inputCFQ = cf_Quantity.Text;
            string inputGTP = gt_Price.Text;
            string inputGTQ = gt_Quantity.Text;

            int iCF_Price = 0;
            int iCF_Quantity = 0;
            int iGT_Price = 0;
            int iGT_Quantity = 0;

            try
            {
                if (checkCoffee.Checked)
                {
                    iCF_Price = int.Parse(inputCFP);
                    iCF_Quantity = int.Parse(inputCFQ);
                }
                if (checkGreentea.Checked)
                {
                    iGT_Price = int.Parse(inputGTP);
                    iGT_Quantity = int.Parse(inputGTQ);
                }
            }
            catch (FormatException ex)
            {
                iCF_Price = 0;
                iCF_Quantity = 0;
                iGT_Price = 0;
                iGT_Quantity = 0;

            }

            int sum1 = iCF_Price * iCF_Quantity;
            int sum2 = iGT_Price * iGT_Quantity;
            int sum = sum1 + sum2;
            tbTotai.Text = sum.ToString();
        }


        private void cf_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Total = tbTotai.Text;
            string Cashe = tbCash.Text;
            int iTotal = int.Parse(Total);
            int iCash = int.Parse(Cashe);
            int change = iCash - iTotal;
            tbChange.Text = change.ToString();

            int OneT = 0;
            int FiveH = 0;
            int oneH = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            while (change > 0)
            {
                if (change >= 1000)
                {
                    change -= 1000;
                    OneT++;
                }
                else if (change >= 500)
                {
                    change -= 500;
                    FiveH++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    oneH++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    fifty++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    twenty++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    ten++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    five++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    one++;
                }
            }
            OneThousand.Text = OneT.ToString();
            FiveHundred.Text = FiveH.ToString();
            OneHundred.Text = oneH.ToString();
            Fifty.Text = fifty.ToString();
            Twenty.Text = twenty.ToString();
            Ten.Text = ten.ToString();
            Five.Text = five.ToString();
            One.Text = one.ToString();

        }
    }
}