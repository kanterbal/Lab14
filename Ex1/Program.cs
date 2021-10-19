using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Мурка";
            //cat.Say();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.Name = "Бобик";
            //dog.Say();
            dog.ShowInfo();
            Console.ReadKey();

        }
    }

    abstract class Animal
    {
        public abstract void Say();

        public abstract string Name { get; set; }

        public virtual void ShowInfo()
        {
            Console.Write("{0} ",Name);
            Say();
        }
    }

    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.WriteLine("издает звук \"Мяу\"");
        }

    }

    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.WriteLine("издает звук \"Гав\"");
        }

    }
}
