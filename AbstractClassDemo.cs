using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.UserName = "UserAlice";

            User u1 = new Student();
            u1.UserName = "userBob";


            User myUser = new Administrator();
           // ((Administrator))
        }
    }

    abstract class User
    {
        private int MyPrivateProperty { get; set; }
        protected int MyProtectedProperty { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public abstract void MyMethod();
        public virtual void HelloWorld()
        {
            Console.WriteLine("Hello from User Class");
        }
    }
class Administrator : User
{
    public string Department { get; set; }
        public new void HelloWorld()
        {
            Console.WriteLine("Hello from Admin Class");
        }
        public sealed override void MyMethod()
        {
            //MyPrivateProperty = 234;//private property cant be accessed outside the class.
            MyProtectedProperty = 17;
            Console.WriteLine("Hello from admin class");
        }
}
class Student : User
{
    public string Major { get; set; }
        public override void MyMethod()
        {
            Console.WriteLine("Hello from strudent class");
        }
    }
   
    class MyListClass<T> : List<T>
    {
        //add code here, this is a generic class
    }
    class MyIntListClass<T> : List<T>
    {
        //add code here, this is a non generic class, uses int
    }
}

