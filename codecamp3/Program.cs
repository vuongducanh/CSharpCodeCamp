using System;
using System.Collections.Generic;
using System.Linq;
namespace codecamp3
{
    class Program
    {
         static void bai1()
        {
            string[] cities = { "ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS" };
            List<string> list = new List<string>(); 
            foreach (var item in cities)
            {
                list.Add(item);
            }
            list.Sort();
          var kq = from s in list orderby s.Length select s;
          foreach (var item in kq)
          {
              System.Console.WriteLine(item);
          }
        }
        static bool bai2(int[] arr1 , int[] arr2)
        {
            var num = from s in arr1 let s1=s*s select s1;
            var result = num.Except(arr2);
            if(result.Count()==0 && arr1.Length ==arr2.Length)
            {
              return true;
            }
            return false;
        }
        static string bai3(string[] words)
        {
           var num = from s in words where s.Contains("e") || s.Contains("E") orderby s  select s;
           if(num == null)
           {
               System.Console.WriteLine("null");
           }
           else
           {
               System.Console.Write("the last word is ",num.Last());
           }
           return num.Last();
        }
          static void Main(string[] args)
        {
        //    bai1();
        
        //bai2;
        //  int[] arr1 = new int[]{1,2,3,4};
        //  int[] arr2 = new int[]{1,4,9,16};
        //  bool kq = bai2(arr1,arr2);
        //  System.Console.WriteLine(kq);

        string[] arrstring = new string[]{"anh","m","ai","w","a"};
        string kq2 = bai3(arrstring);
        System.Console.WriteLine(kq2); 

         
        }
    }
}
