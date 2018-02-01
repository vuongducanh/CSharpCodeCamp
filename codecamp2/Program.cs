using System;
using System.Collections.Generic;
using System.Linq;

namespace codecamp2
{
    class Program
    {
        static void doanso()
        {
            try
            {
                System.Console.WriteLine("chao mung ban da den voi ket qua so xo mien bac ngay hom nay");
                System.Console.Write("nhap moi so bat ki a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int random = rnd.Next(-100, 100);
                int count = 1;
                while (a != random)
                {
                    if (a > random)
                    {
                        System.Console.Write("Guess Lower {0}--->> ", a);
                        a = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {
                        System.Console.WriteLine("Guess Higher {0}--->> ", a);
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    count++;
                    if (count == 7)
                    {
                        System.Console.WriteLine("game over");
                        break;
                    }

                }

                System.Console.WriteLine("You win with ...");

            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("ban nhap vao moi so");
            }
        }
        static void baiba()
        {
            System.Console.Write("ban nhap vao phan tu cua mang n phan tu  = ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n<3)
            {
                System.Console.Write("so phan tu nho qua nhap lai n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] array = new int[n];
            System.Console.WriteLine("ban nhap {0} phan  tu vao mang ", n);
            for (int i = 0; i <n; i++)
            {
                System.Console.Write(" phan tu thu  array[{0}] =  ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("mang vua nhap la");
            for (int i =0 ; i <n; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
            int count=array[0];
            int count2 = array[0];
            string num="";
            foreach (var item in array)
            {
                if(item == count || item == count2)
                {
                    num = "day la day so lien tiep";
                }
                else{
                    num="day khong phai la so lien tiep";
                    break;
                }
                 count++;
                 count2--;
            }
            System.Console.WriteLine(num);
            
        }
        static void Main(string[] args)
        {
            // doanso();    
            // baiba();
        }
    }
   
}
