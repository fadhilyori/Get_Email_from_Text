using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Get_Email_from_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Email from Any Text");
            string text = "";
            Console.WriteLine("Paste text here : ");
            text = Console.ReadLine();
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(pattern);
            Console.WriteLine("Email Address Lists : ");
            if (text != null)
            {
                MatchCollection matches = re.Matches(text);
                if (matches.Count > 0)
                {
                    for (int i = 0; i < matches.Count; i++)
                    {
                        System.Console.WriteLine(matches[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
