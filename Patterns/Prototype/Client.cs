namespace Patterns.Prototype
{
    class Client
    {
        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Address Address { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}, {Address}";
        }
    }

    class Address
    {
        public Address(string city)
        {
            City = city;
        }

        public string City { get; }

        public override string ToString()
        {
            return $"{City}";
        }
    }
}
