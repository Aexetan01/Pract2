using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2_Ivan
{
    public partial class Form3 : Form
    {
        private Random random;
        private Array2D array;
        public Form3()
        {
            random = new Random();
            array = new Array2D(4, 5);
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            dgvArray.Rows.Clear();
            dgvArray.Columns.Clear();

            dgvArray.RowCount = array.SizeA;
            dgvArray.ColumnCount = array.SizeB;

            for (int i = 0; i < array.SizeA; i++)
            {
                for (int j = 0; j < array.SizeB; j++)
                {
                    array[i, j] = random.Next(1, 100);
                    dgvArray[i, j].Value = array[i, j];
                }
            }
        }

        int GetResult()
        {
            if (array.SizeA == 0 || array.SizeB == 0) throw new Exception("Error!");

            int min = int.MaxValue;
            int indexMin = -1;
            
            for(int i = 0; i < array.SizeA; i++)
            {
                int sum = 0;
                for(int j = 0; j < array.SizeB; j++)
                {
                    sum += array[i, j];
                }

                if(min > sum)
                {
                    min = sum;
                    indexMin = i;
                }
            }

            return indexMin + 1;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Результат(номер цеху): {GetResult()}");
            }
            catch
            {
                MessageBox.Show("З початку заповніть масив!");
            }
        }
    }
}
