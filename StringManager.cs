using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Burya
{
    class StringManager
    {
        private string _s;
        private Dictionary<int, string> valuePairs = new();

        public string Reverse(string s)
        {
            _s = s;
            Stack<char> cStack = new();
            string temp = null;

            for (int i = 0; i < _s.Length; i++)
            {
                cStack.Push(_s[i]);
            }
            for (int i = 0; i < _s.Length; i++)
            {
                temp += cStack.Pop();
            }
            return temp;
        }
        public string Reverse(string s, bool b)
        {
            if (!b)
            {
                return Reverse(s);
            }
            else
            {
                _s = s;
                string temp = null;
                Stack<char> stack = new();
                bool[] isCapital = new bool[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].ToString() == s[i].ToString().ToUpper() && s[i] != ' ')
                    {
                        isCapital[i] = true;
                    }
                    else
                    {
                        isCapital[i] = false;
                    }
                    stack.Push(s[i]);
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (isCapital[i])
                    {
                        temp += stack.Pop().ToString().ToUpper();
                    }
                    else
                    {
                        temp += stack.Pop().ToString().ToLower();
                    }

                }
                return temp;
            }

        }
        public bool Symmetric(string s)
        {
            _s = s;
            if (s == Reverse(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string t = null;
            int ASCII = 0;
            valuePairs.Add(-1,"Negative One");
            valuePairs.Add(48, "Zero");
            valuePairs.Add(49, "One");
            valuePairs.Add(50, "Two");
            valuePairs.Add(51, "Three");
            valuePairs.Add(52, "Four");
            valuePairs.Add(53, "Five");
            valuePairs.Add(54, "Six");
            valuePairs.Add(55, "Seven");
            valuePairs.Add(56, "Eight");
            valuePairs.Add(57, "Nine");

            foreach (char c in _s)
            {
                ASCII += (int)c;
            }

            if (ASCII == 0)
            {
                return valuePairs[-1];
            }
            else
            {
                string sASCII = ASCII.ToString();
                for (int i = 0; i < sASCII.Length; i++)
                {
                    if (i == 0)
                    {
                        t = valuePairs[sASCII[i]];
                    }
                    else
                    {
                        t += " " + valuePairs[sASCII[i]];
                    }
                }

                return t;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return _s == obj.ToString();
            }
            else
            {
                return false;
            }
        }
    }
}
