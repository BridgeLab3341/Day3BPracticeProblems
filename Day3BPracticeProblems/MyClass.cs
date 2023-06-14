using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BPracticeProblems
{
    public class MyClass
    {
        private static int count=0;

        // Default Constructor
        public MyClass()
        {
            count++;
            Console.WriteLine("Default Constructor called");
        }
        // Parameterized Constructor
        public MyClass(int value)
        {
            count++;
            Console.WriteLine("Parameterized Constructor called with value: " + value);
        }
        // Copy Constructor
        public MyClass(MyClass obj)
        {
            count++;
            Console.WriteLine("Copy Constructor called");
        }

        // Private Constructor
        public MyClass(string message)
        {
            Console.WriteLine("Private Constructor called with message: " + message);
        }
        static MyClass()
        {
            count = 0;
            Console.WriteLine("Static Constructor called");
        }

        public static int GetCount()
        {
            return count;
        }
    }
    public interface Inter1
    {
        public void Display()
        {
            
        }
    }
    public class TestClass : Inter1
    {
        public void Display()
        {
            Console.WriteLine("Hi Every One");
        }
    }
    public class AccessModiferDemo
    {
        public void PublicMethod()
        {
            int a=3, b=4;
            Console.WriteLine(a+b);
        }
        private void PrivateMethod()
        {
            int a=9, b=4;
            Console.WriteLine(a-b);
        }
        protected void ProtectedMethod()
        {
            int a = 9, b = 4;
            Console.WriteLine(a * b);
        }
        internal void InternalMethod()
        {
            int a = 9, b = 4;
            Console.WriteLine(a / b);
        }
    }
}
