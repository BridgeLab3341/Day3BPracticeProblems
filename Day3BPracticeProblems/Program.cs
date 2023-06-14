namespace Day3BPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //MyClass obj1 = new MyClass();
            //MyClass obj2 = new MyClass(10);  
            //MyClass obj3 = new MyClass(obj1);  
            //int count = MyClass.GetCount();
            //Console.WriteLine("Total objects created: " + count);
            // TestClass testClass = new TestClass();
            // testClass.Display();
            AccessModiferDemo demo = new AccessModiferDemo();
            demo.PublicMethod();
            demo.InternalMethod();
        }
    }
}
