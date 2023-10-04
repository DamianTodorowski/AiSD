//przyciski robia click XD
namespace Cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wynik = Fib(6);
            MessageBox.Show(wynik.ToString());
        }

        int Fib(int n)
        {


            if (n == 1)
            {

                return 1;
            }
            if (n == 0)
            {
                return 0;
            }


            return Fib(n - 1) + Fib(n - 2);

        }
    }
}
