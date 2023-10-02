using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _19.ClassMethods
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; } //= "tuscias@mailas.lt";
        public List<Pet> Pets { get; set; } = new List<Pet>();

        //public Human() 
        //{ 
        //    //Pets = new List<Pet>();
        //}  
        public Human(string firstName, string lastName, int age) /*: this() */  //konstruktorius
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public void UpdateEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
            {
                Email = newEmail;
            }
            else
            {
                Console.WriteLine("Ivestas nevalidus email'as");
            }
        }
        public string GetFullName()
        { 
            return $"{FirstName} {LastName}"; 
        }
        private bool IsValidEmail(string email)
        {
            var regexPattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"; ;
            return Regex.IsMatch(email, regexPattern);
        }
        public void PrintPets()
        {
            foreach (var pet in Pets)
            {
                Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
            }
        }
        public void PrintPets(string animalType)
        {
            foreach(var pet in Pets)
            {
                if (pet.AnimalType == animalType)
                {
                    Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
                }
            }
        }
        public void PrintPets(int age)
        {
            foreach (var pet in Pets)
            {
                if (pet.Age > age)
                {
                    Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
                }
            }
        }
        public void PrintPets(string animalType, int age)
        {
            foreach (var pet in Pets)
            {
                if (pet.AnimalType == animalType && pet.Age > age)
                {
                    Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
                }
            }
        }
    }
}

