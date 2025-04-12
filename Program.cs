using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        int n = s.Length;
        if (n == 0)
        {
            Console.WriteLine("");
            return;
        }

        int maxLen = 1;
        int startIndex = 0;

        for (int center = 0; center < n; ++center)
        {
            {
                int left = center, right = center;
                while (left >= 0 && right < n && s[left] == s[right])
                {
                    int length = right - left + 1;
                    if (length > maxLen)
                    {
                        maxLen = length;
                        startIndex = left;
                    }
                    left--;
                    right++;
                }
            }

            {
                int left = center, right = center + 1;
                while (left >= 0 && right < n && s[left] == s[right])
                {
                    int length = right - left + 1;
                    if (length > maxLen)
                    {
                        maxLen = length;
                        startIndex = left;
                    }
                    left--;
                    right++;
                }
            }
        }

        Console.WriteLine(s.Substring(startIndex, maxLen));
    }
}
