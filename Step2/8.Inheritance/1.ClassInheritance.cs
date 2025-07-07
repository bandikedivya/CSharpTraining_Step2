
using System;

namespace Family
{
    class Father
    {
        public string Name { get; set; }

        //public Father(string name)
        //{
        //    Name = name;
        //    Console.WriteLine($"name paramter is is {name}");
        //}
        public Father()
        {
            Name = "Alice";
            Console.WriteLine($"name paramter is is {Name}");
        }

        public Father(string name)
        {
            Console.WriteLine($"Hello my kid name is {name}");
        }



        public void ShowMessage()
        {
            Console.WriteLine($"Hello, I am {Name}, the Father.");
        }
    }

    class Mother
    {
        ///
    }

    class Child : Father
    {
        public Child()
        {
            Console.WriteLine($"From Child Class and myfather name is {Name}");
        }

        public Child(string kidName) : base(kidName)
        {
            {
                Console.WriteLine($"After my father decided now my name is {kidName}");
            }
        }

        public string[] myClassFreinds()
        {
            return new string[] { "Ram", "Raki" };
        }
    }

    class Program
    {
        static void Main()
        {
            //Child child = new Child();
            Child child = new Child("Jurnior Alice");
            child.myClassFreinds(); //ownmembers
            child.ShowMessage();   //parent


            Father father = new Father();
            //father.myclass

        }
    }


}
//using System;
//namespace OnlineShopping
//{
//    class Ajio
//    {
//        public string Name { get; set; }

//        public Ajio()
//        {
//            Name = "Jack";
//            Console.WriteLine($"{Name} purchased from Ajio");
//        }
//        public Ajio( string name )
//        {
//            Console.WriteLine($"{name} purchased from BBSale in Ajio");
//        }

//        public void ShowMessage()
//        {
//            Console.WriteLine($"BBSALE is Live, {Name} ordered product in BBSALE in Ajio");
//        }
//    }
//    class Myntra : Ajio
//    {
//        public string Name { get; set; }

//        public Myntra()
//        {
//            Name = "Jack";
//            Console.WriteLine($"{Name} purchased from Myntra");
//        }
//        public Myntra(string myname) : base(myname) 
//        {


//            Console.WriteLine($"{myname} purchased from Flat80% SALE in Myntra");
//        }
//        public void ShowSaleMessage()
//        {
//            Console.WriteLine($"BBSALE is Live, {Name} ordered product in BBSALE in Ajio");
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Myntra myntra = new Myntra("Sky");
//            myntra.ShowSaleMessage();
//            myntra.ShowMessage();






//            Ajio ajio = new Ajio();


//        }
//    }

//}
