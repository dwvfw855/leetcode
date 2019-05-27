using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
   public class leetcodeOne
    {

      

        public  static string GetData()
        {
            //给定 nums = [2, 7, 11, 15], target = 9 因为 nums[0] +nums[1] = 2 + 7 = 9
            // 所以返回0, 1
            string str = "";
            //leetcode 第一题
            //方法1
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == target - numbers[i])
                    {

                        str= i + "&" + j;
                    }

                }


            }



            return str;

        }


        public static string GetdataTwo()
        {

            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;
            string str = "";
            Dictionary<int, int> dt = new Dictionary<int, int>();
            //添加所有
            for (int i = 0; i < numbers.Length; i++)
            {

                dt.Add(numbers[i],i );


            }
            //判断
            for (int i = 0; i < numbers.Length; i++)
            {
                int result = target - numbers[i];  //7=9-2
                if (dt.ContainsKey(result))
                {
                    int T = 0;
                    dt.TryGetValue(result,out T);
                    if (T != i)
                    {
                        str = i + "&" + T;
                    }


                }



            }





            return str;




        }



        public static string GetDataThree()
        {

            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;
            string str = "";
            //改进上述方法
            Dictionary<int, int> dt = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int result = target - numbers[i];  //7=9-2
                if (dt.ContainsKey(result))
                {
                    int T = 0;
                    dt.TryGetValue(result, out T);


                    return i + "&" + T;

                }

                dt.Add(numbers[i], i);

            }






            return str;




        }




    }
}
