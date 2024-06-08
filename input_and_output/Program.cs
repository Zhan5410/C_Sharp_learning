using System;
using System.Reflection;
namespace C_Sharp
{
    public class Input_and_put{
        public static void Main(String[] agrs){
            // Console.WriteLine("input age: ");
            // String age = Console.ReadLine();
            
            // Console.WriteLine("input name");
            // String name = Console.ReadLine();
            
            // Console.WriteLine("age is " + age + ", name is " + name);
            print();
        }

        private static void print(){
            String age = "23";
            String name = "zhan";
            Console.WriteLine($"age = {age}, name = {name}");
        }
    }
}