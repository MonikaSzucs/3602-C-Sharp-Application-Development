using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingIntegerDemo
{
    class IntegerList : List<int>
    {
        public int Total
        {
            get
            {
                int total = 0;

                foreach (int number in this)
                {
                    total += number;
                }

                return total;
            }
        }

        public int EvenCount
        {
            get
            {
                int count = 0;

                foreach (int number in this)
                {
                    if ((number & 1) == 0)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public int EvenTotal
        {
            get
            {
                int total = 0;

                foreach (int number in this)
                {
                    if ((number & 1) == 0)
                    {
                        total += number;
                    }
                }

                return total;
            }
        }
    }
}
