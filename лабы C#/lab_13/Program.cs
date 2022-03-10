using System;
using static System.Console;
using static System.Convert;
using static System.String;


namespace lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0, k1=0;
            Write("Введите последовательность открывающихся и закрывающихся скобок ");
            string s = new String(ReadLine());
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    k++;
                else if(s[i] == ')' || s[i] == ']' || s[i] == '}')
                    k1++;
            }
            if (k == k1)
                Write("Число закрывающихся и открывающихся скобок равно");
            else
                Write("Число закрывающихся и открывающихся скобок не равно");
        }
    }
}
