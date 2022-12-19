namespace WinFormsArray2
{
    public partial class Form1 : Form
    {
        double[,] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            array = new double[(int)Row.Value, (int)Column.Value];
            InitializeArray(ref array);

            dataGridViewArray.ColumnCount = array.GetLength(1);
            dataGridViewArray.RowCount = array.GetLength(0);

            for (int j = 0; j < dataGridViewArray.RowCount; j++)
            {
                dataGridViewArray.Rows[j].HeaderCell.Value = j.ToString();
            }

            for (int i = 0; i < dataGridViewArray.ColumnCount; i++)
            {
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
                dataGridViewArray.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridViewArray.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }

        static void InitializeArray(ref double[,] array)
        {
            System.Random rand = new System.Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-28305, 12951) / 1000.0;
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewArray_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                object o = (sender as DataGridView).Rows[e.RowIndex].HeaderCell.Value;
                e.PaintBackground(e.CellBounds, true);

                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(o.ToString(),
                    e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }

        }

        private void Solution_Click(object sender, EventArgs e)
        {
            double[] minElements = new double[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double min = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }

                minElements[i] = min;
            }           

            // -------------- Exercise 2 -------------- 
            for (int i = 0; i < array.GetLength(1); i += 2)
            {
                int index = 0;
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        double temp = array[i, j];

                        array[i, j] = array[i, index];
                        array[i, index++] = temp;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridViewArray.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }

            textBox1.Text = minElements.Max().ToString("F2");
        }
    }
}