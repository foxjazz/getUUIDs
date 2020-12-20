using System.Collections.Generic;

namespace ConsoleApp1
{
    public class collectUUID
    {
        public List<string> getUUIDs(string data)
        {
            var actual = new List<string>();
            Dictionary<string, string> results = new Dictionary<string, string>();
            var d = data.Split('_');
            foreach (var s in d)
            {
                if (s.Length == 36)
                {
                    if (!results.ContainsKey(s))
                        results.Add(s,s);
                }
            }
            foreach(var l in results.Keys)
            {
                actual.Add(l);
            }

            return actual;
        }
       
    }
}