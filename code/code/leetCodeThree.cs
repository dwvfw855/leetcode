using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
  public  class leetCodeThree
    {
        //        输入: "abcabcbb"
        //输出: 3 
        //解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
//        输入: "bbbbb"
//输出: 1
//解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
              public static void Getlenth()
            {
            string str = "abcabcbb";
            Dictionary<char, int> dt = new Dictionary<char, int>();
            int ans = 0;
            #region 第一种
            for (int i = 0; i < str.Length; i++)
            {
                if (dt.ContainsKey(str[i]))
                {
                    // dt.Remove(str[i]);
                }
                else
                {

                    dt.Add(str[i], i);
                    ans += 1;
                }



            }



            #endregion




        }


               public static void reversal(int x)
        {

           // x = 123;
            string ask = "";
            while (x != 0)
            {
                int i=  x % 10;
                x = x / 10;
                ask += i.ToString();

            }



           // 95647123   32174659
            int cccc = 0;
        }




    }
}
