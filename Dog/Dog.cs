using System;

namespace DogLibrary
{
    public class Dog
    {
        private string _name;
        private int _age;
        private double _weight;

        public int Age
        {
            get => _age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Age), value, "Age cannot be below 0");
                }
                _age = value;
            }
        }

        public string Name
        {
            get => _name; private
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(Name), value, "Name cannot be empty");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(Name), value, "Name is too short");
                }
                _name = value;
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Weight), value, "Weight cannot be below 0");
                }
                _weight = value;
            }
        }
        public Colors Color { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public enum Colors
        {
            White,
            Black,
            Brown
        }
    }
}
