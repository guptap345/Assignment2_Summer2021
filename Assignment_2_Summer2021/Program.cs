using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            var p = new Program();
            Console.WriteLine("Question 1");
            Console.WriteLine("Enter the total number of values for num1 Array:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Start Entering the values for num1 with Enter after each:");
            int [] nums1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                int int_to_add = int.Parse(Console.ReadLine());
                nums1[i] = int_to_add;
            }

            Console.WriteLine("Enter the total number of values for num2 Array:");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Start Entering the values for num1 with Enter after each:");
            int[] nums2 = new int[N2];
            for (int i = 0; i < N2; i++)
            {
                int int_to_add = int.Parse(Console.ReadLine());
                nums2[i] = int_to_add;
            }


            //int[] nums1 = { 1, 2, 2, 1 }; ---Sample Case given in the document 
            //int[] nums2 = { 2, 1 };
            Intersection(nums1, nums2);
            Console.WriteLine(" ");

            //Question 2 
            Console.WriteLine("");
            Console.WriteLine("Question 2");

            Console.WriteLine("Enter the total number of values for nums Array:");
            int N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Start Entering the values for num1 with Enter after each:");
            int[] nums3 = new int[N3];
            for (int i = 0; i < N3; i++)
            {
                int int_to_add = int.Parse(Console.ReadLine());
                nums3[i] = int_to_add;
            }
            //int[] nums = { 0, 1, 0, 3, 12 }; ---Sample Case given in the document 
            Console.WriteLine("Enter the target number:");
            int target = int.Parse(Console.ReadLine());
            int v = SearchInsert(nums3, target);
            Console.WriteLine("Insert Position of the target is : {0}", v);
            Console.WriteLine("");


            //Question3
            Console.WriteLine("");
            Console.WriteLine("Question 3");

            Console.WriteLine("Enter the total number of values for nums Array:");
            int N4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Start Entering the values for num1 with Enter after each:");
            int[] ar3 = new int[N4];
            for (int i = 0; i < N4; i++)
            {
                int int_to_add = int.Parse(Console.ReadLine());
                ar3[i] = int_to_add;
            }
            //int[] ar3 = { 2, 2, 3, 4 }; ---Sample case
            int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();

            //Question 4
            Console.WriteLine("");
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("");
            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" }); //using default values for input
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = p.DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("");
            Console.WriteLine("Question 6");
            int[] arr = { 2, 3, 4 };
            int target_sum = 5;
            targetSum(arr, target_sum);
            Console.WriteLine();

            //Question 7
            Console.WriteLine("");
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();


            //Question 8
            Console.WriteLine("");
            Console.WriteLine("Question 8");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 }; 
            int K = 3;
            p.RotateArray(arr1, K);
            Console.WriteLine();

            //Question 9
            Console.WriteLine("");
            Console.WriteLine("Question 9");
            int[] arr9 = { -2,1,-3,4,-1,2,1,-5,4};
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ms);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("");
            Console.WriteLine("Question 10");
            int[] costs = { 10, 15, 20 };
            int minCost = p.MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();
        }


        //Q1
        public static void Intersection(int[] nums1, int[] nums2)
        {
            try
            {
                HashSet<int> hashset1 = new HashSet<int>(nums1); //converting to hashset
                HashSet<int> hashset2 = new HashSet<int>(nums2);
                HashSet<int> result = new HashSet<int>(); 
                hashset1.IntersectWith(hashset2); //using Intersect function to find common values

                foreach (int row in hashset1) //adding common values in result
                {
                    result.Add(row);
                }

                Console.Write("The instersection is:");
                var output = (result.ToArray()); //converting output to array
                foreach (var item in output) //print output
                {
                    Console.Write(item.ToString() + " ");
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
            {   //using bianry search for O(log n)
                int test = 0, end = nums.Length - 1, output = -1; //declaring variables
                while (test <= end) 
                {
                    int mid = test + (end - test) / 2;  //to find the mid index value
                    if (nums[mid] == target) return mid; //checking condition for mid value and target
                    else if (nums[mid] > target) { output = mid; end = mid - 1; } //checking if mid value is greater than target for search
                    else { output = mid + 1; test = mid + 1; } //if mid is smaller than target, checking the other side
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
                int counter = 1; //setting the counter as 1

                for (int i = nums.Length - 2; i > -1; i--)  //loop for length of the nums array except nums[0]
                {
                    if (nums[i] == nums[i + 1]) counter++; //counting the equal numbers in counter
                    else
                    {
                        if (nums[i + 1] == counter) return counter; //checking for lucky number condition
                        counter = 1; //setting the counter back to 1
                    }
                }

                if (counter == nums[0]) return counter; //returning counter for counter=num[0]

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
                    int[] result = new int[n + 1]; //defining result array of n+1 length

                    if (n < 2)
                    {
                        return n; //from given conditions
                    }

                    result[1] = 1; //given

                    for (int i = 1; 2 * i <= n; i++) 
                    {
                        int next = 2 * i;
                        result[next] = result[i];

                        if (next + 1 <= n)
                        {
                            result[next + 1] = result[i] + result[i + 1]; //given condition
                        }
                    }

                    return result.Max(); //returning the max value from result
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Q5
        public String DestCity(List<List<String>> paths)
        {
            List<string> list = new List<string>(); //using list to store string values

            foreach (var path in paths) //adding destination places from paths in list
            {
                list.Add(path[1]);
            }

            foreach (var path in paths) //checking if all origin places are present in the destination list
            {
                if (list.Contains(path[0])) //if yes remove all common values
                {
                    list.Remove(path[0]);
                }

            }

            return list.Last(); //returning the last destination place
        }



        // Q6
        private static void targetSum(int[] arr, int target)
        {
            try
            {   // Time O(N) Space O(1)
                int l = 0, r = arr.Length - 1, sum; //declaring left and right values in array
                while (true)
                {
                    sum = arr[l] + arr[r];  //checking sum of values one by one from left and right
                    if (sum == target) //condition for checking sum and target
                        break;
                    else if (sum < target) //incrementing left if sum<target
                        l += 1;
                    else
                        r -= 1;            //otherwise reducing right to check all values
                }
                var output = (new int[2] { l + 1, r + 1 });  //printing array with right values

                foreach (var item in output) //loop for printing index of true condition 
                {
                    Console.Write(item.ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Q7
        public static void HighFive(int[,] scores)
        {
            try
            {

                SortedDictionary<int, List<int>> map = new SortedDictionary<int, List<int>>(); //using sorted dictionary 
                for (int i = 0; i < scores.Length / 2; i++) 
                {
                    int id = scores[i, 0]; //looking each student id
                    int score = scores[i, 1]; //looking each student score
                    if (!map.ContainsKey(id)) //if the student is already added in the dictonary 
                    {
                        map.Add(id, new List<int>()); //if not add the student in dictonary
                    }
                    map[id].Add(score); // addingscore of student 
                }

                int[][] result = new int[map.Count][]; //Result storage
                int j = 0;
                foreach (KeyValuePair<int, List<int>> key in map)
                {
                    int total = 0;
                    key.Value.Sort(); // Sorting for the top 5 score
                    key.Value.Reverse(); //reverse for the top score
                    for (int m = 0; m < 5; m++)
                    {
                        total += key.Value[m]; //Totaling the top scores
                    }
                    int avg = total / 5; //Calculating the average
                    result[j] = new int[] { key.Key, avg }; //Store the key and value key = student id and store the average as value
                    j++;
                }

                foreach (var item in result) //Printing the results
                {
                    Console.Write(item[0].ToString() + " ");
                    Console.Write(item[1].ToString());
                    Console.WriteLine();

                }

            }
            catch (Exception)
            {

                throw;
            }

    }

            //Q8
            public void RotateArray(int[] arr1, int k)
            {
            k %= arr1.Length;  //checking the position of array where rotation is needed
            int temp, previous;
            for (int i = 0; i < k; i++) //2-pointer loop , repeating the  outer loop k times 
            {
                previous = arr1[arr1.Length - 1]; //declaring previous with end values of array
                for (int j = 0; j < arr1.Length; j++) //loop for the length of array and swapping values before k with values after k 
                {
                    temp = arr1[j];
                    arr1[j] = previous;
                    previous = temp;
                }
                
            }
            foreach(int item in arr1) //printing swapped values as item
            {
                Console.Write(item.ToString());
            }

        }

        //Q9
        static int MaximumSum(int[] a)
        {
            int size = a.Length; //declaring size as length of array
            int max_till_now = int.MinValue, //keeping track of lowest value 
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i]; //adding all values 

                if (max_till_now < max_ending_here) //comparing both variables
                    max_till_now = max_ending_here; //

                if (max_ending_here < 0)//case where negative value exists
                    max_ending_here = 0; // set max ending value to zero 
            }

            return max_till_now; //returning current max value
        }


        //Q10
        public int MinCostToClimb(int[] costs)
        {
            for (int i = 2; i < costs.Length; i++) //loop for checking minimum cost for optimized steps
            {
                costs[i] = Math.Min(costs[i - 1], costs[i - 2]) + costs[i]; //choosing min value out of first and second step and adding cost of further steps
            }
            return Math.Min(costs[costs.Length - 1], costs[costs.Length - 2]);//skipping the steps with higher costs
        }
    }
}

