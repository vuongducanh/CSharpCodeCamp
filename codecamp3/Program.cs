using System;
using System.Collections.Generic;
using System.Linq;
namespace codecamp3 {
    class Program {
        static void bai1 () {
            string[] cities = { "ROME", "ZURICH", "AMSTERDAM", "SAIGON", "LONDON", "HANOI", "CALIFORNIA", "Anh" };
            IEnumerable<string> query = from word in cities
            orderby word.Length
            select word; // orderby word.Length không khai báo gì cả thì mặc định là ascending (sắp tăng)
            foreach (string str in query)
                Console.WriteLine (str);
        }
        static bool bai2 (int[] arr1, int[] arr2) {
            var num = from s in arr1
            let s1 = s * s select s1;
            var result = num.Except (arr2);
            if (result.Count () == 0 && arr1.Length == arr2.Length) {
                return true;
            }
            return false;
        }
        static string bai3 (List<string> words) {
            var num = from s in words where s.Contains ("e") || s.Contains ("E") orderby s select s;
            if (num.Count () == 0) {
                System.Console.WriteLine ("null");
            } else {
                System.Console.Write ("the last word is ", num.Last ());
            }
            return num.Last ();
        }
        static void Main (string[] args) {
            try {
                   bai1();
                //bai2;
                //  int[] arr1 = new int[]{1,2,3,4};
                //  int[] arr2 = new int[]{1,4,9,16};
                //  bool kq = bai2(arr1,arr2);
                //  System.Console.WriteLine(kq);

                // List<string> arrstring = new List<string> () { "hieu", "em", "anh", "con", "phep", "tet" };
                // string kq2 = bai3 (arrstring);
                // System.Console.WriteLine (kq2);
            } catch (Exception) {
                System.Console.WriteLine ("the end");
            }
        }
    }
}