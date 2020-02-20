using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrays_and_GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring array, showing default values
            int[] val = { 1, 6, 7, 8 };
            int[] another2 = new int[10];
            Console.WriteLine(another2[2]);
            another2[2] = 10;
            Console.WriteLine(another2[2]);

            //what is the default value of a string?

            string[] stng = { "Blah", "Blah" };
            string[] emptee = new string[5];
            if (emptee == new string[1])
            {
                Console.WriteLine("empty");
            }
            else if (emptee == null)
            {
                Console.WriteLine("Null");
            }
            else
                Console.WriteLine("unknown");
            Console.WriteLine(stng[1].ToLower());

            int[] ids = { 2, 3, 8, 9, -2, 10 };
            ids.Append(34);

            Console.WriteLine(ids.Count());

            ArrayList myList = new ArrayList();
            
            myList.Add(2);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(22);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(322);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(45);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(80);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(51);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(27);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(98);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            myList.Add(101);
            Console.WriteLine("count={0}, capacity={1}", myList.Count, myList.Capacity);
            // "new" is a constructor
            MyOwnArrayList myOwnList = new MyOwnArrayList();//creates new instance of MyOwnArrayList
            MyOwnArrayList myOwnList1 = new MyOwnArrayList();
            MyOwnArrayList myOwnList2 = new MyOwnArrayList();
            MyOwnArrayList myOwnList3 = new MyOwnArrayList();
            myOwnList1.Add(34);
            myOwnList1.Add(3);
            myOwnList1.Add(4);
            //myOwnList1.Count = 7;
            //myOwnList1.Count = myOwnList1.Count + 20;
            Console.WriteLine(myOwnList1.Count);

            Console.WriteLine(myOwnList1.Capacity);
            myOwnList1.Capacity = 10;
            Console.WriteLine(myOwnList1.Capacity);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
            myOwnList1.Add(4);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
            myOwnList1.Add(34);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
            myOwnList1.Add(24);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
            myOwnList1.Add(5);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
            myOwnList1.Add(4);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
            myOwnList1.Add(64);
            myOwnList1.Append(5);
            Console.WriteLine("count={0}, capacity={1}", myOwnList1.Count, myOwnList1.Capacity);
        }
    }
        
    class MyOwnArrayList
    {
        //data
        private int[] values;//store values of the list in here
        private int _count;
        public int Count { get { return _count; } }

        public int Capacity { get; set; }
        //private int _capacity;
        //public int Capacity { get { return _capacity; }
        //    set {if(value>0 || value<100) _capacity = value; } }
        ////Methods have ()
        public void Add(int SomeValue)
        {
           if (Count == Capacity)
            {
                Resize();
                values[Count] = SomeValue;
                _count++;
            }
        }
        public void Append(int SomeValue)
        {
            Add(SomeValue);
        }
        private void Resize()
        {
            if (Capacity == 0)
            {
                values = new int[4];
                Capacity = 4;
            }
            else
            {
                Capacity *= 2;
                int[] oldValues = values;//keeps track of old values, creatd new handle to that array.
                values = new int[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    values[1] = oldValues[i];
                }
            }
        }
        //public override string ToString()
        //{
        //    string ret = "";
        //    for (int i= 0; i < Count; i++)
        //    {
        //        Console.WriteLine(i);
        //        ret = ret + " ";
        //        return ret;
        //    }
        //}
        //Constructor
        public MyOwnArrayList()
        {
            //values = new int[0];
            //Capacity = 0;
            //Count = 0;
        }

    }
    
}
