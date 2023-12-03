using System;

namespace sealed_class_method{

// --------------------------------------------------- SEALED CLASS -----------------------------------------------------------

    sealed class BaseClass{
        public void show1(){
            Console.WriteLine("Method of Base Class");
        }
    }

    class DerivedClass : BaseClass{      // This wil give the error noe because BaseClass is sealed - 'DerivedClass': cannot derive from sealed type 'BaseClass'
        public void show2(){
            Console.WriteLine("Method of child Class");
        }
    }

    class Program{
        public static void Main(string[] args){
            DerivedClass d = new DerivedClass();
            d.show1();
            d.show2();

            C obj = new C();
            obj.print();
        }
    }

    // ---------------------------------------------- SEALED METHOD ------------------------------------------------------------

    class A{
        public virtual void print(){
            Console.WriteLine("This is the method of class A");
        }
    }

    class B : A{
        public sealed override void print(){
            Console.WriteLine("This is the method of class B");
        }
    }

    class C : B{
        public override void print(){                     // This will give the error now - cannot override inherited member 'B.print()' because it is sealed
            Console.WriteLine("This is the method of class C");
        }
    }
}