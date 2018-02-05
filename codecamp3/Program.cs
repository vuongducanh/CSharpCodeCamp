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
          static void Main(string[] args)
        {
           bai1();
        }
    }
}
