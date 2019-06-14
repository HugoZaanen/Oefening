using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    class Program
    {
        static int[] arr = {-98,-82,-70,-49,58,26,-69,-79,-98};
        //static int[] arr = { 1,4,5,6,3};
        static void Main(string[] args)
        {
            candies(10,5);
        }

        public static int[] primeFactors(int n)
        {
            ArrayList list = new ArrayList();

            double i = 2;

            while (n >= i && n != 1)
            {
                if ((n / i) % 1 == 0)
                {
                    list.Add((int)i);
                    n = n / (int)(i);
                }
                else
                {
                    i++;
                }
            }

            if (n > 1)
            {
                list.Add((int)i);
            }

            return list.ToArray(typeof(int)) as int[];
        }      

        public static int[] mutateArr(int n, int[] a)
        {
            int[] b = new int[n];

            if (a.Length > 3)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == 0)
                    {
                        b[i] = 0 + a[0] + a[1];
                    }
                    else if (i < n - 1)
                    {
                        b[i] = a[i - 1] + a[i] + a[i + 1];
                    }
                    else
                    {
                        b[i] = a[i - 1] + a[i] + 0;
                    }
                }
            }
            else
            {
                return a;
            }

            return b;
        }

        public static bool alternatingSort(int[] a)
        {
            int[] b = new int[a.Length];
            bool check = true;
            int j = 1;
            int k = 1;
            for(int i = 0;i < a.Length;i++)
            {
                if (i == 0)
                {
                    b[i] = a[i];
                }
                else if(!(i%2 == 0))
                {                   
                    b[i] = a[a.Length - j];
                    j++;
                }
                else
                {                   
                    b[i] = a[k];
                    k++;
                }
            }
            
            for(int i = 1; i < b.Length;i++)
            {
                if(b[i - 1] > b[i])
                {
                    check = false;
                }
            }

            return check;
        }

        public static void addTwoDigits(int n)
        {
            int i = n % 10;
            int j = n / 10;

            int k = i + j;
        }

        public static int largestNumber(int n)
        {
            string s = "";

            for(int i =0;i < n;i++)
            {
                s += "9";
            }

            return Int32.Parse(s);
        }

        public static int candies(int n, int m)
        {
            int i = m/n;
            return i * n;
        }
    }
}
