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
    public partial class Form2 : Form
    {
        private Random random;
        private Array array;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            array = new Array((int)nudN.Value);
            dgvArray.Rows.Clear();

            for (int i = 0; i < array.Size; i++)
            {
                array[i] = random.Next(1, 100);
                dgvArray.Rows.Add(array[i]);
            }
        }

        int GetResult()
        {
            if (array.Size == 0) throw new Exception("Error!");

            int min = array[0];

            for (int i = 1; i < array.Size; i++)
            {
                if (min > array[i]) min = array[i];
            }

            return min;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Результат: {GetResult()}");
            }
            catch
            {
                MessageBox.Show("З початку заповніть масив!");
            }
        }
    }
}
