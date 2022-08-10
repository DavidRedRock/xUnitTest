using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLibrary
{
    public static class Calculator
    {
        public static string Longest_sub(string testdata)
        {
            if (testdata.Length > 0)
            {

                List<string> inputText = testdata.Split(' ').ToList();
                List<int> input = inputText.ConvertAll(int.Parse);


                List<int> longest_sub = new List<int>();
                List<int> current_sub = new List<int>();

                longest_sub.Add(input[0]);
                current_sub.Add(input[0]);

                //# check if next int is bigger than the previous int
                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] > input[i - 1])
                    {
                        current_sub.Add(input[i]);

                        if (i == (input.Count - 1) && (current_sub.Count) > longest_sub.Count)
                        {
                            longest_sub = new List<int>(current_sub.Count);
                            current_sub.ForEach((item) => { longest_sub.Add(item); });

                            current_sub.Clear();
                            current_sub.Add(input[i]);
                        }
                    }
                    else // # if next int is not bigger than previous, i.e. subsequence breaks
                    {
                        //# update longest subsequence if current subsequence is longer
                        if (current_sub.Count > longest_sub.Count)
                        {
                            longest_sub = new List<int>(current_sub.Count);
                            current_sub.ForEach((item) => { longest_sub.Add(item); });

                            //# reinitialise
                            current_sub.Clear();
                            current_sub.Add(input[i]);

                        }//#if current subsequence is not longer than previous longest subsequence, then reinitialise
                        else
                        {
                            //# reinitialise
                            current_sub.Clear();
                            current_sub.Add(input[i]);
                        }
                    }
                }

                List<string> strings = longest_sub.ConvertAll<string>(x => x.ToString());
                string s = String.Join(" ", strings);
                return s;
            }
            return null;
        }

    }
}
