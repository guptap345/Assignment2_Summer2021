using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            var p = new Program();
            Console.WriteLine("Question 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 1 };
            int[] vs = p.Intersection(nums1, nums2);
            var output = vs;

            foreach (var item in output)
            {
                Console.Write(item.ToString());
            }


            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = int.Parse(Console.ReadLine());
            int v = SearchInsert (nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", v);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 2, 2, 3, 4 };
            int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();


            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" });
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = p.destCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();


        }

        //Q1
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            try
            {


                HashSet<int> hashset1 = new HashSet<int>(nums1);
                HashSet<int> hashset2 = new HashSet<int>(nums2);
                HashSet<int> result = new HashSet<int>();
                hashset1.IntersectWith(hashset2);

                foreach (int row in hashset1)
                {
                    result.Add(row);
                }

                
                return (result.ToArray());
            }

            catch (Exception)
            {

                throw;
            }
        }

        //Q2
        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                int test = 0, end = nums.Length - 1, output = -1;
                while (test <= end)
                {
                    int mid = test + (end - test) / 2;
                    if (nums[mid] == target) return mid;
                    else if (nums[mid] > target) { output = mid; end = mid - 1; }
                    else { output = mid + 1; test = mid + 1; }
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Q3
        private static int LuckyNumber(int[] nums)
        {
            try
            {
                int counter = 1;

                for (int i = nums.Length - 2; i > -1; i--)
                {
                    if (nums[i] == nums[i + 1]) counter++;
                    else
                    {
                        if (nums[i + 1] == counter) return counter;
                        counter = 1;
                    }
                }

                if (counter == nums[0]) return counter;

                return -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Q4
        private static int GenerateNums(int n)
        {
            try
            {

                int[] nums = new int[n + 1];
                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                nums[0] = 0;
                nums[1] = 1;
                int max = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (2 <= 2 * i && 2 * i <= n)
                    {
                        nums[2 * i] = nums[i];
                        max = Math.Max(nums[2 * i], max);
                    }
                    if (2 <= 2 * i + 1 && 2 * i + 1 <= n)
                    {
                        nums[2 * i + 1] = nums[i] + nums[i + 1];
                        max = Math.Max(nums[2 * i + 1], max);
                    }
                }
                return max;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Q5
        public String destCity(List<List<String>> paths)
        {
            List<string> list = new List<string>();

            foreach (var path in paths)
            {
                list.Add(path[1]);
            }

            foreach (var path in paths)
            {
                if (list.Contains(path[0]))
                {
                    list.Remove(path[0]);
                }

            }

            return list.Last();
        }



        /// Q6
        private static void targetSum(int[] nums, int target)
        {
            try
            {
                int start = 0, last = nums.Length - 1;
                while (start < last)
                    if (nums[start] + nums[last] > target) last--;
                    else if (nums[start] + nums[last] < target) start++;
                    else Console.WriteLine(new int[] { start + 1, last + 1 });
                Console.WriteLine( new int[2]);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

