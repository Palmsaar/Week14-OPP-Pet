using System;

namespace Pet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratulations! you've adopted {name}");
            }
            public double Weight
            {
                get { return weight; }
            }
            public void ShowPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }
            public void Eat()
            {
                weight += 0.2;
                Console.WriteLine($"{name} ate!");
            }
            public void Train()
            {
                weight -= 0.1;
                Console.WriteLine($"{name} trained");
            }
        }
        
        
        static void Main(string[] args)
        {
            Pet myPet = new Pet("Peeter");
            myPet.ShowPetInfo();

            for (int i = 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($"Current weight: {myPet.Weight}");
                if (myPet.Weight >= 0.7)
                {
                    myPet.Train();
                    Console.WriteLine($"Weight after training: {myPet.Weight}");
                }
            }
        }
    }
}
