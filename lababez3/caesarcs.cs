using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lababez3
{
    class caesarcs
    {
        static string alhavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string encrypt(string message, int k)
        {
            string res = "";
            foreach(char ch in message)
            {
                for (int i = 0; i < alhavit.Length; i++)
                {
                    if (ch == ' ')
                    {
                        res += " ";
                        break;
                    }
                    if (ch == alhavit[i])
                    {
                        if (i + k >= alhavit.Length)
                        {
                            res += alhavit[i + k - alhavit.Length];
                        }
                    else
                    res += alhavit[i + k];
                    break;
                    }
                }
            }
            return res;
        }
        public static string decrypt(string message, int k)
        {
            string res = "";
            foreach (char ch in message)
            {
                for (int i = 0; i < alhavit.Length; i++)
                {
                    if (ch == ' ')
                    {
                        res += " ";
                        break;
                    }
                    if (ch == alhavit[i])
                    {
                        if (i - k < 0)
                        {
                            res += alhavit[i - k + alhavit.Length];
                        }
                        else
                            res += alhavit[i - k];
                        break;
                    }
                }
            }
            return res;
        }
    }
}
