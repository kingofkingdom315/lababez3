using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lababez3
{
    class WordKeyCrypt
    {
        static string alhavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        static char[] newalhavit = new char[33];

        public static string encrypt(string message)
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
                        res += newalhavit[i];
                        break;
                    }
                }
            }
            return res;
        }
        public static string decrypt(string message)
        {
            string res = "";
            foreach (char ch in message)
            {
                for (int i = 0; i < newalhavit.Length; i++)
                {
                    if (ch == ' ')
                    {
                        res += " ";
                        break;
                    }
                    if (ch == newalhavit[i])
                    {
                        res += alhavit[i];
                        break;
                    }
                }
            }
            return res;
        }
        public static void createNewAlpha(string keyWord, int key)
        {
            bool findSame = false;
            key--;
            int beg = 0, current = key;
            for (int i = key; i < keyWord.Length + key; i++)
            {
                for (int j = key; j < keyWord.Length + key; j++)
                {
                    if (keyWord[i - key] == newalhavit[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newalhavit[current] = keyWord[i - key];
                    current++;
                }
                findSame = false;
            }


            for (int i = 0; i < alhavit.Length; i++)
            {
                for (int j = 0; j < newalhavit.Length; j++)
                {
                    if (alhavit[i] == newalhavit[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newalhavit[current] = alhavit[i];
                    current++;
                }
                findSame = false;
                if (current == newalhavit.Length)
                {
                    beg = i;
                    break;
                }
            }

            current = 0;
            for (int i = beg; i < alhavit.Length; i++)
            {
                for (int j = 0; j < newalhavit.Length; j++)
                {
                    if (alhavit[i] == newalhavit[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newalhavit[current] = alhavit[i];
                    current++;
                }
                findSame = false;
            }
        }
        public static void deleteNewAlpha()
        {
            for (int i = 0; i < newalhavit.Length; i++)
                newalhavit[i] = ' ';
        }
        public static string getNewAlpha()
        {
            string strNewAlpha = new string(newalhavit);
            return strNewAlpha;
        }
    }
}
