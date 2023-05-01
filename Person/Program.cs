namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;  // создаем переменную с типом Person и именем person1

            person1 = new Person();  // 1. создаем экземпляр класса (объект) Person и 2. присваиваем его переменной person1 

            person1.Name = "Kirill";
            person1.LastName = "Emelin";
            person1.Age = 23;
            person1.Nationality = "Uzbekistan";
            person1.Country = "Norwegian";
            person1.ComingOfAge = true;
            person1.Gender = "Man";


            Console.WriteLine("======================");
            Console.WriteLine("Name:");
            Console.WriteLine(person1.Name);
            Console.WriteLine("Last Name:");
            Console.WriteLine(person1.LastName);
            Console.WriteLine("Age:");
            Console.WriteLine(person1.Age);
            Console.WriteLine("Nationality");
            Console.WriteLine(person1.Nationality);
            Console.WriteLine("Locations:");
            Console.WriteLine(person1.Country);
            Console.WriteLine("Coming of age:");
            Console.WriteLine(person1.ComingOfAge);
            Console.WriteLine("Gender:");
            Console.WriteLine(person1.Gender);
            Console.WriteLine("======================");

            Person person2 = new Person();

            person2.Name = "Alica";
            person2.LastName = "Voronova";
            person2.Age = 17;
            person2.Nationality = "Russia";
            person2.Country = "Russia";
            person2.ComingOfAge = false;
            person2.Gender = "Girl";

            Console.WriteLine("======================");
            Console.WriteLine("Name:");
            Console.WriteLine(person2.Name);
            Console.WriteLine("Last Name:");
            Console.WriteLine(person2.LastName);
            Console.WriteLine("Age:");
            Console.WriteLine(person2.Age);
            Console.WriteLine("Nationality");
            Console.WriteLine(person2.Nationality);
            Console.WriteLine("Locations:");
            Console.WriteLine(person2.Country);
            Console.WriteLine("Coming of age:");
            Console.WriteLine(person2.ComingOfAge);
            Console.WriteLine("Gender:");
            Console.WriteLine(person2.Gender);
            Console.WriteLine("======================");

            Person person3 = new Person();

            person3.Name = "Daniel";
            person3.LastName = "Rodriguez";
            person3.Age = 19;
            person3.Nationality = "Spain";
            person3.Country = "Finland";
            person3.ComingOfAge = true;
            person3.Gender = "Man";

            Console.WriteLine("======================");
            Console.WriteLine("Name:");
            Console.WriteLine(person3.Name);
            Console.WriteLine("Last Name:");
            Console.WriteLine(person3.LastName);
            Console.WriteLine("Age:");
            Console.WriteLine(person3.Age);
            Console.WriteLine("Nationality");
            Console.WriteLine(person3.Nationality);
            Console.WriteLine("Locations:");
            Console.WriteLine(person3.Country);
            Console.WriteLine("Coming of age:");
            Console.WriteLine(person3.ComingOfAge);
            Console.WriteLine("Gender:");
            Console.WriteLine(person3.Gender);
            Console.WriteLine("======================");
        }
    }


    /// <summary>
    /// Класс представляет собой абстракцию (описание) объекта Person для сайта знакомств
    /// </summary>
    public class Person
    {
        public string _name;
        public string _lastName;
        public byte _age;
        public string _nationality;
        public string _country;
        public bool _comingOfAge;
        public string _gender;


        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }


        /// <summary>
        /// Возраст человека
        /// </summary>
        public byte Age
        {
            set
            {
                _age = value;
            }
            get
            {
                return _age;
            }
        }


        /// <summary>
        /// Национальность человека
        /// </summary>
        public string Nationality
        {
            set
            {
                _nationality = value;
            }
            get
            {
                return _nationality;
            }
        }


        /// <summary>
        /// Местоположения человека
        /// </summary>
        public string Country
        {
            set
            {
                _country = value;
            }
            get
            {
                return _country;
            }
        }


        /// <summary>
        /// достиг ли человек совершеннолетия
        /// </summary>
        public bool ComingOfAge
        {
            set 
            { 
                _comingOfAge = value; 
            }
            get 
            {
                return _comingOfAge;
            }
        }


        /// <summary>
        /// Гендер человека
        /// </summary>
        public string Gender
        {
            set
            {
                _gender = value;
            }
            get 
            { 
                return _gender; 
            }
        }
            
    }
}