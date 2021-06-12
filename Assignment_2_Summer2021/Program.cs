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
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = int.Parse(Console.ReadLine());
            int v = SearchInsert(nums, target);
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
            Console.WriteLine("question 6");
            int[] arr = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(arr, target_sum);
            Console.WriteLine();

            ////Question 7
            //  Console.WriteLine("Question 7");
            //  int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            //  HighFive(scores);
            //  Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            p.RotateArray(arr1, K);
            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] arr9 = { -2,1,-3,4,-1,2,1,-5,4};
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ms);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int[] costs = { 10, 15, 20 };
            int minCost = p.MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();
        }

        private static void HighFive(int[,] scores)
        {
            throw new NotImplementedException();
        }

        //Q1
        public static void Intersection(int[] nums1, int[] nums2)
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

                var output = (result.ToArray());

                foreach (var item in output)
                {
                    Console.Write(item.ToString());
                }
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

                {
                    int[] result = new int[n + 1];

                    if (n < 2)
                    {
                        return n;
                    }

                    result[1] = 1;

                    for (int i = 1; 2 * i <= n; i++)
                    {
                        int next = 2 * i;
                        result[next] = result[i];

                        if (next + 1 <= n)
                        {
                            result[next + 1] = result[i] + result[i + 1];
                        }
                    }

                    return result.Max();
                }
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



        // Q6
        public static void targetSum(int[] arr, int target)
        {
            try
            {   // Time O(N) Space O(1)
                int l = 0, r = arr.Length - 1, sum;
                while (true)
                {
                    sum = arr[l] + arr[r];
                    if (sum == target)
                        break;
                    else if (sum < target)
                        l += 1;
                    else
                        r -= 1;
                }
                var output = (new int[2] { l + 1, r + 1 });

                foreach (var item in output)
                {
                    Console.Write(item.ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        ////Q7

        //public int[][] highfive(int[][] items)
        //{
        //    int rows = items.Length;
        //    hashset<int> set = new hashset<int>();

        //    // first sort all items by grades
        //    for (int i = 0; i < rows; i++)
        //    {
        //        int min = i;
        //        set.Add(items[i][0]);

        //        for (int j = i + 1; j < rows; j++)
        //        {
        //            if (items[j][1] < items[min][1])
        //            {
        //                min = j;
        //            }
        //        }
        //        if (min != i)
        //        {
        //            int[] temp = items[i];
        //            items[i] = items[min];
        //            items[min] = temp;
        //        }
        //    }

        //    // now start construct the answer array
        //    object[] obj = set.toarray();
        //    int id[] = new int[obj.Length];
        //    int[][] ans = new int[obj.Length][2];

        //    for (int i = 0; i < obj.Length; i++)
        //    {
        //        id[i] = (int)obj[i];
        //        ans[i][0] = id[i];
        //    }

        //    // now focus on calculating the average score
        //    for (int i = 0; i < obj.Length; i++)
        //    {
        //        int count = 0;
        //        int sum = 0;
        //        int j = rows - 1;
        //        while (count < 5)
        //        {
        //            if (items[j][0] == ans[i][0])
        //            {
        //                sum += items[j][1];
        //                count += 1;
        //                j -= 1;
        //            }

        //            else { j -= 1; continue; }
        //        }
        //        ans[i][1] = sum / 5;
        //    }
        //    return ans;
        //}



        //Q8
        public void RotateArray(int[] arr1, int k)
        {
            // speed up the rotation
            k %= arr1.Length;
            int temp, previous;
            for (int i = 0; i < k; i++)
            {
                previous = arr1[arr1.Length - 1];
                for (int j = 0; j < arr1.Length; j++)
                {
                    temp = arr1[j];
                    arr1[j] = previous;
                    previous = temp;
                }
                
            }
            foreach(int item in arr1)
            {
                Console.Write(item.ToString());
            }

        }

        //Q9
        static int MaximumSum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }


        //Q10
        public int MinCostToClimb(int[] costs)
        {
            for (int i = 2; i < costs.Length; i++)
            {
                costs[i] = Math.Min(costs[i - 1], costs[i - 2]) + costs[i];
            }
            return Math.Min(costs[costs.Length - 1], costs[costs.Length - 2]);
        }
    }
}

