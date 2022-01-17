using System;

namespace CSharpExample2
{
    //Method Overloading (New) & Method Overriding(Virtual and Override)
    //In Method Overloading, the derived class object points to base class or derived class - shows base class only
    //In Method Overriding, the derived class object point to base class or derived class - shows derived class only
    //Points for method overriding,
    //1.Method cannot be private.
    //2.Only abstract or virtual method can be overridden.
    //3.Which method should be called is decided at run time.

    public class BaseClass
    {
        public int a;
        public virtual void printmessage()
        {
            Console.WriteLine("BaseClass method");
        }

    }
    public class Derivedclass1:BaseClass
    {
        
        private new void printmessage()
        {
            Console.WriteLine("Derivedclass 1 method : new ");
        }
    }
    public class Derivedclass2 : BaseClass
    {
        public override void printmessage()
        {
            Console.WriteLine("Derivedclass 2 method : override ");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Base class reference variable - Base class object - prints base class method
            BaseClass bas = new BaseClass();
            bas.printmessage();

            //Method Overloading - New
            //Base class reference variable - Derived class object - prints base class method
            BaseClass bas1 = new Derivedclass1();
            bas1.printmessage();

            //Method Overriding - Virtual/Abstract & Override 
            //Base class reference variable - Derived class object - prints derived class method
            BaseClass bas2 = new Derivedclass2();
            bas2.printmessage();

            //Method Overloading - New
            //Derived class reference variable - Derived class object - prints derived class method
            Derivedclass1 der1 = new Derivedclass1();
            der1.printmessage();

            //Method Overriding - Virtual/Abstract & Override 
            //Derived class reference variable - Derived class object - prints derived class method
            Derivedclass2 der2 = new Derivedclass2();
            der2.printmessage();

        }
    }
}
