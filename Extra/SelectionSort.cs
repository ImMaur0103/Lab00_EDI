using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_EDI.Extra
{
    public class SelectionSort<T>
    {
        public delegate bool CallBack(int a, int b, List<T> list);

        static void swap(T a, T b, List<T> list, int i, int medium)
        {
            list.RemoveAt(i);
            list.Insert(i, b);
            list.RemoveAt(i + (medium - 1));
            list.Insert(i + (medium - i), a);
        }

        void selectionsort(List<T> ClientsList, int size, CallBack compare)
        {
            for (int i = 0; i < size - 1; i++)
            {
                int medium = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (compare(medium, j, ClientsList))
                    {
                        medium = j;
                    }
                }
                swap(ClientsList.ElementAt(i), ClientsList.ElementAt(medium), ClientsList, i, medium);
            }
        }

        static int Ascendente(string x, string y)
        {
            int value = string.Compare(x, y);
            return value;
        }
    }
}
