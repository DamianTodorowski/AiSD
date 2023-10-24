namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 5;
            int[] tab = { 5, 7, 2, 4, 5 };
            sortuj(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                listBox1.Items.Add(tab[i]);
            }


        }

        static void sortuj(int[] tab)
        {
            int n = tab.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
        }
       

    }

}

