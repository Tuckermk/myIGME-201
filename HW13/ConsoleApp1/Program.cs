using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public abstract class Pet {
        private string name;
        public int age;

        public string Name;
        public void Eat(){}
        public void Play() { }
        public void GotoVet() { }
        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    public class Pets : Pet
    {

        List<Pet> petList = new List<Pet>();
        public int Count() { return petList.Count; }
        public void Add(Pet pet) { petList.Add(pet); }
        public void Remove(Pet pet) { petList.Remove(pet); }
        public void RemoveAt (int petEL) { petList.RemoveAt(petEL); }
        public Pet this[int nPetEl]
        {

            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }

        }
        
    }

    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();

    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }


    public class Cat : Pet, ICat
    {
        public void Eat()
        {
            Console.Write("only cat food, please");
        }

        public void Play()
        {
            Console.Write("yaaaay");
        }

        public void Purr()
        {
            Console.Write("prrrrrr");
        }

        public void Scratch()
        {
            Console.Write("That feels nice");
        }
        
        public Cat(string name, int age)
        {
            this.age = age;
            this.Name = name;
        }
    }
    public class Dog : Pet, IDog
    {
        public string License;
        public void Eat() { Console.Write("I will eat anything you throw this way"); }
        public void Play() { Console.Write("yay, play time "); }
        public void Bark() { Console.Write("bark"); }
        public void NeedWalk() { Console.Write("Can we go on a walk now?"); }
        public void GotoVet() { Console.Write("Adventure !"); }

        public Dog(string name, int age, string license)
        {
            License = license;
            Name = name;
            this.age = age;
        }
        public Dog(string name, int age)
        {
            this.age = age;
            this.Name = name;
        }
    }
    static public class Mainfunction
    {
        static public  void Main()
        {
            Pet thisPet = null;
            Dog dog = new Dog("",0);
            Cat cat = new Cat("",0);
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();



            for(int i = 0; i < 50; i++)
            {
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a Dog");
                        // add a dog
                        Console.Write("Input a name for you new dog ->");
                        string name = Console.ReadLine();
                        int age = rand.Next(1, 5);
                        int license = rand.Next(2, 1000);
                        Dog NewDog = new Dog(name,age,license.ToString());
                        pets.Add(NewDog);
                    }
                    else
                    {
                        Console.WriteLine("You bought a Cat");
                        // else add a cat
                        Console.Write("Input a name for you new cat ->");
                        string name = Console.ReadLine();
                        int age = rand.Next(1, 5);
                        Cat NewCat = new Cat(name, age);
                        pets.Add(NewCat);
                    }
                }

                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    try
                    {
                        
                        thisPet = pets[rand.Next(pets.Count())];
                        
                        if (thisPet.GetType() == dog.GetType())
                        {
                            
                            if(rand.Next(0,4) == 0) { Console.Write(thisPet.Name + ": "); dog.Bark(); }
                            else if (rand.Next(0, 4) == 1) { Console.Write(thisPet.Name + ": "); dog.Play(); }
                            else if (rand.Next(0, 4) == 2) { Console.Write(thisPet.Name + ": "); dog.NeedWalk(); }
                            else if (rand.Next(0, 4) == 3) { Console.Write(thisPet.Name + ": "); dog.Eat(); }
                            else if (rand.Next(0, 4) == 4) { Console.Write(thisPet.Name + ": "); dog.GotoVet(); }
                            Console.WriteLine();
                        }
                        else if (thisPet.GetType() == cat.GetType())
                        {
                            if (rand.Next(0, 3) == 0) { Console.Write(thisPet.Name + ": "); cat.Purr(); }
                            else if (rand.Next(0, 4) == 1) { Console.Write(thisPet.Name + ": "); cat.Play(); }
                            else if (rand.Next(0, 4) == 2) { Console.Write(thisPet.Name + ": "); cat.Eat(); }
                            else if (rand.Next(0, 4) == 3) { Console.Write(thisPet.Name + ": "); cat.Scratch(); }
                            Console.WriteLine();

                        }
                        
                    }
                    catch
                    {
                        continue;
                    }
                }

            }
        }
    }
}
