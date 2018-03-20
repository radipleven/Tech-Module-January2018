using System;
using System.Text;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            Console.WriteLine(CharSum(input[0],input[1]));
            
        }
        static int CharSum(string a, string b)
        {
            
            int sum = 0;

            if (a.Length>b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    sum = sum + a[i] * b[i];
                }
                for (int i = b.Length; i < a.Length; i++)
                {
                    sum += a[i];
                }
            }
            else if(a.Length<b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i] * b[i];
                }
                for (int i = a.Length; i < b.Length; i++)
                {
                    sum += b[i];
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i] * b[i];
                }
                
            }

            return sum;
        }
    }
}
