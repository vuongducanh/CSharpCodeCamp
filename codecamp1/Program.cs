using System;

namespace codecamp
{
    class Program
    {
        static void SecondLargest()
        {
            try
            {
                int[] array1 = new int[100];
                System.Console.Write("nhap do dai cua mang input = ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhan {0} phan tu vao mang ", input);
                for (int i = 0; i < input; i++)
                {
                    Console.Write("phan tu thu array1[{0}] = ", i);
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("mang vua nhap la ");
                for (int j = 0; j < input; j++)
                {
                    Console.Write(array1[j] + " ");
                }
                for (int k = 0; k < input; k++)
                {
                    for (int m = k + 1; m < input; m++)
                    {
                        if (array1[k] < array1[m])
                        {
                            int temp = array1[k];
                            array1[k] = array1[m];
                            array1[m] = temp;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("so lon  thu hai trong mang la {0}", array1[1]);
                // Console.WriteLine(array1[1]);
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Application ends !!!");
            }
        }
        static void QuadraticFunc()
        {
            try
            {
                float a, b, c, delta;
                float num, x1, x2;
                Console.Write("nhap so a=");
                a = float.Parse(Console.ReadLine());
                Console.Write("nhap so b=");
                b = float.Parse(Console.ReadLine());
                Console.Write("nhap so c=");
                c = float.Parse(Console.ReadLine());
                delta = (b * b - (4 * a * c));
                if (a == 0)
                {
                    if (b == 0 && c != 0)
                        Console.WriteLine("Phuong trinh vo nghiem");
                    else
                    {
                        num = -c / b;
                        Console.WriteLine("Phuong trinh co nghiem x = {0} ", num.ToString());
                    }
                }
                else
                {
                    if (delta < 0)
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                    else if (delta == 0)
                    {
                        num = -b / 2 * a;
                        Console.WriteLine("phuong trinh co hai nghiem kep X1 = x2 = {0}", num);
                    }
                    else
                    {
                        x1 = (-b - (float)Math.Sqrt(delta)) / 2 * a;
                        x2 = (-b + (float)Math.Sqrt(delta)) / 2 * a;
                        Console.WriteLine("phuong trinh co ngiem x1 = {0}", x1);
                        Console.WriteLine("phuong trinh co ngiem x2 = {0}", x2);
                    }
                }
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Application ends !!!");
            }
        }
        static void Capitalise()
        {
            try
            {    
                string input;
                string result = " ";
                Console.Write("nhap chuoi string  = ");
                input = Console.ReadLine();
                string[] words = input.Split(' ');
                if (input == " " || input == null)
                {
                    Console.WriteLine("chuoi rong ");
                }
                foreach (string word in words)
                {
                    if (word.Trim() != "")
                    {
                        if (word.Length > 1)
                            result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                        else
                            result += word.ToUpper() + " ";
                    }
                }
                Console.WriteLine(result);
            }
            catch (System.Exception)
            { 
                 throw new ArgumentNullException("nhap vao chuoi ");
            }
            finally{
                Console.WriteLine("the end");
            }
        }
        static void CountDigits()
        {
            try
            {
                string input;
                int num = 0;
                Console.Write("nhap vao mang input = ");
                input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    num += Convert.ToInt32(input[i].ToString());
                }
                Console.WriteLine("ket qua la {0}", num);
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("the ends !!!");
            }
        }
        static void Factorial()
        {
            try
            {
                int input;
                Console.Write("nhap giai so input = ");
                input = Convert.ToInt32(Console.ReadLine());
                int gt = 1;
                for (int i = 1; i <= input; i++)
                {
                    gt = gt * i;
                }
                Console.WriteLine(gt);
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Application ends !!!");
            }
        }
        static void Main(string[] args)
        {
            // SecondLargest();
            // QuadraticFunc();
            // Capitalise();
            //  CountDigits();
            //  Factorial();
        }
    }
}