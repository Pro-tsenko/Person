using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public Person(string name, string surname, string email, DateTime dateBirth)
        {
            Name = name;
            Surname = surname;
            Email = email;
            DateBirth = dateBirth;
        }

        public Person(string name, string surname, string email)
        {
            Name=name;
            Surname=surname;
            Email=email;
        }

        public Person(string name, string surname, DateTime dateBirth)
        {
            Name = name;
            Surname = surname;
            DateBirth = dateBirth;
        }

        public bool IsAdult
        {
            get
            {
                if((DateTime.Now.Year - DateBirth.Year) >= 18)
                {
                    return true;
                }
                return false;
            }
        }

        public string SunSign 
        {
            get
            {
                switch (DateBirth.Month)
                {
                    case 1:
                        {
                            return "Goat";
                            break;
                        }
                    case 2:
                        {
                            return "Water Bearer";
                            break;
                        }
                    case 3:
                        {
                            return "Fish";
                            break;
                        }
                    case 4:
                        {
                            return "Ram";
                            break;
                        }
                    case 5:
                        {
                            return "Bull";
                            break;
                        }
                    case 6:
                        {
                            return "Twins";
                            break;
                        }
                    case 7:
                        {
                            return "Crab";
                            break;
                        }
                    case 8:
                        {
                            return "Lion";
                            break;
                        }
                    case 9:
                        {
                            return "Virgin";
                            break;
                        }
                    case 10:
                        {
                            return "Balance";
                            break;
                        }
                    case 11:
                        {
                            return "Scorpion";
                            break;
                        }
                    case 12:
                        {
                            return "Archer";
                            break;
                        }
                    default:
                        {
                            return "None";
                        }
                }
            }
        }

        public string ChineseSign
        {
            get
            {
                if (DateBirth.Year % 10 == 1)
                {
                    return "Tiger";
                }
                if (DateBirth.Year % 10 == 2)
                {
                    return "Rabbit";
                }
                if (DateBirth.Year % 10 == 3)
                {
                    return "Dragon";
                }
                if (DateBirth.Year % 10 == 4)
                {
                    return "Snake";
                }
                if (DateBirth.Year % 10 == 5    )
                {
                    return "Horse";
                }
                if (DateBirth.Year % 10 == 6)
                {
                    return "Goat";
                }
                if (DateBirth.Year % 10 == 7)
                {
                    return "Monkey";
                }
                if (DateBirth.Year % 10 == 8)
                {
                    return "Rooster";
                }
                if (DateBirth.Year % 10 == 9)
                {
                    return "Dog";
                }
                if (DateBirth.Year % 10 == 0)
                {
                    return "Pig";
                }
                return "None";
            }
        }

        public bool IsBirthday
        {
            get
            {
                return DateBirth.Month == DateTime.Now.Month && DateBirth.Day == DateTime.Now.Day;
            }
        }

        public override string ToString()
        {
            return  "Name: " + Name + "\nSurname: " + Surname + "\nEmail: " + Email + "\nDateBirth" + DateBirth + "\nIsAdult: " + IsAdult + "\nSunSign: " + SunSign + "\nChinese Sign: " + ChineseSign + "\nIsBirtday: " + IsBirthday + "\n"; 
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime DateBirth { get; set; }
    }
}
