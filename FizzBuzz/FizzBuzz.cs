using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public List<string> Execute(int init, int end, Dictionary<int, string> tokens, ref string message)
        {
            message = "Success";
            if (!Validate(init, end, ref message))
                return null;

            if (!validateTokens(tokens, ref message))
                return null;

            return Process(Enumerable.Range(init, end).ToList(), tokens);
        }

        private bool validateTokens(Dictionary<int, string> tokens, ref string message)
        {
            foreach (KeyValuePair<int, string> value in tokens)
                if (value.Key == 0)
                {
                    message = "No zero allowed in token range";
                    return false;
                }
            return true;
        }

        private bool Validate(int init, int end, ref string message)
        {
            if (init > end)
            {
                message = "Falied Initial value could not be higher than end value";
                return false;
            }
            if (init <= 0)
            {
                message = "Falied Initial value could not be 0 or less";
                return false;
            }
            return true;
        }

        protected List<string> Process(List<int> range, Dictionary<int, string> tokens)
        {
            var orderedTokens = new SortedDictionary<int, string>(tokens);
            var list = new List<string>();
            foreach (int i in range)
            {
                string value = string.Empty;
                foreach (KeyValuePair<int, string> token in orderedTokens)
                {
                    if (i.IsDivisor(token.Key))
                        value += token.Value;
                }
                value = (string.IsNullOrEmpty(value)) ? i.ToString() : value;
                list.Add(value);
            }
            return list;
        }
    }
}
