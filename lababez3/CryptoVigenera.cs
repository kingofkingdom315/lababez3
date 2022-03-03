using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lababez3
{
    class CryptoVigenera
    {
        static string alhavit = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

        public static string encrypt(string message, string key)
        {
            int[] kodkey = new int[key.Length];
            int s = 0;
            string res = "";
            foreach (char ch in key)
            {
                for (int i = 0; i < alhavit.Length; i++)
                {
                    if (ch == alhavit[i])
                    {
                        kodkey[s] = i;
                        s++;
                        break;
                    }
                }
            }
            s = 0;
            foreach (char ch in message)
            {
                if (s == kodkey.Length)
                    s = 0;
                for (int i = 0; i < alhavit.Length; i++)
                {
                    if (ch == ' ')
                    {
                        res += " ";
                        break;
                    }
                    if (ch == alhavit[i])
                    {
                        if (i + kodkey[s] >= 32)
                        {
                            res += alhavit[i + kodkey[s] - 32];
                            s++;
                            break;
                        }
                        else
                        {
                            res += alhavit[i + kodkey[s]];
                            s++;
                            break;
                        }
                    }
                }
            }
            return res;
        }
        public static string decrypt(string message, string key)
        {
            int[] kodkey = new int[key.Length];
            int s = 0;
            string res = "";
            foreach (char ch in key)
            {
                for (int i = 0; i < alhavit.Length; i++)
                {
                    if (ch == alhavit[i])
                    {
                        kodkey[s] = i;
                        s++;
                        break;
                    }
                }
            }
            s = 0;
            foreach (char ch in message)
            {
                if (s == kodkey.Length)
                    s = 0;
                for (int i = 0; i < alhavit.Length; i++)
                {
                    if (ch == ' ')
                    {
                        res += " ";
                        break;
                    }
                    if (ch == alhavit[i])
                    {
                        if (i - kodkey[s] < 0)
                        {
                            res += alhavit[i - kodkey[s] + 32];
                            s++;
                            break;
                        }
                        else
                        {
                            res += alhavit[i - kodkey[s]];
                            s++;
                            break;
                        }
                    }
                }
            }
            return res;
        }
    }
}
