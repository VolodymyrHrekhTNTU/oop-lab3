namespace WinFormArray1
{
    public partial class Form1 : Form
    {
        double[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = (int)numericUpDown1.Value;

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] - (int)array[i] >= 0.5)
                {
                    sum += System.Math.Abs(array[i]);
                }
            }

            int middleEle = array.Length / 2;

            Array.Sort(array, middleEle, array.Length - middleEle);
            Array.Reverse(array, middleEle, array.Length - middleEle);


            for (int i = 0; i < array.Length; i++)
            {
                dataGridView2[i, 0].Value = array[i];
                dataGridView2.Columns[i].HeaderText = i.ToString();
            }

            textBox1.Text = (sum).ToString("F2");
        }

        public static void Initialize(ref double[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i] = rand.Next(-153, 533) / 10.0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            array = new double[(int)numericUpDown1.Value];
            Initialize(ref array);

            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1[i, 0].Value = array[i];
                dataGridView1.Columns[i].HeaderText = i.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}