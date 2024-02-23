using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CommTcper
{
    /// <summary>
    /// 时间对比帮助类
    /// </summary>
   public static  class ContrastTime
    {
        public static void GetMoth(this string month ,ref string result)
        {
            string _month = month;
            if (Regex.IsMatch(_month, @"[1-9A-C]"))
            {
                switch (_month)
                {
                    case "1":
                        result = "1";
                        break;
                    case "2":
                        result = "2";
                        break;
                    case "3":
                        result = "3";
                        break;
                    case "4":
                        result = "4";
                        break;
                    case "5":
                        result = "5";
                        break;
                    case "6":
                        result = "6";
                        break;
                    case "7":
                        result = "7";
                        break;
                    case "8":
                        result = "8";
                        break;
                    case "9":
                        result = "9";
                        break;
                    case "A":
                        result = "10";
                        break;
                    case "B":
                        result = "11";
                        break;
                    case "C":
                        result = "12";
                        break;
                }
            }
            else
            {
                result = "_1";
            }
        
        }
    }
}
