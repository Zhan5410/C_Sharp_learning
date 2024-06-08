using System;
using System.Text;
namespace C_Sharp{
    public class Aeiou{
        public static int Main(String[] args){
            Int32[] aeiou = {(int)'A', (int)'a', (int)'E', (int)'e', (int)'I', (int)'i', (int)'O', (int)'o', (int)'U', (int)'u'};
            Console.WriteLine("input String");
            String input = Console.ReadLine();
            foreach (var item in input)
            {
                foreach (var check in aeiou)
                {
                    if (((int)item).Equals(check))
                        {
                            Console.WriteLine("包含母音");
                            return 0;
                        }
                    }
                }
            Console.WriteLine("不包含母音");
            return 0;
        }
    }
}