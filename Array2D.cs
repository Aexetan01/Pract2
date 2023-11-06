using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2_Ivan
{
    public class Array2D
    {
        private int[,] array;
        private int sizeA;
        private int sizeB;

        public Array2D()
        {
            MyArray = new int[0, 0];
        }

        public Array2D(int size)
        {
            MyArray = new int[size, size];
        }
        public Array2D(int sizeA, int sizeB)
        {
            MyArray = new int[sizeA, sizeB];
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    result += array[i, j].ToString() + " ";
                }
                result += "\n";
            }
            return result;
        }

        public string GetAllArrayToString()
        {
            return this.ToString();
        }

        public string GetElementToString(int indexI, int indexJ)
        {
            return this[indexI, indexJ].ToString();
        }

        public int this[int indexI, int indexJ]
        {
            get
            {
                if (indexI < 0 || indexI >= sizeA)
                    throw new IndexOutOfRangeException($"Index out of range ([{indexI}, {indexJ}] from size: [{sizeA}, {sizeB}])");
                return array[indexI, indexJ];
            }
            set
            {
                if (indexI < 0 || indexI >= sizeA) 
                    throw new IndexOutOfRangeException($"Index out of range ([{indexI}, {indexJ}] from size: [{sizeA}, {sizeB}])");
                array[indexI, indexJ] = value;
            }
        }

        public int[,] MyArray
        {
            get
            {
                return array;
            }
            set
            {
                sizeA = array.GetLength(0);
                sizeB = array.GetLength(1);
                array = value;
            }
        }
        public int SizeA { get => sizeA; }
        public int SizeB { get => sizeB; }
    }
}
