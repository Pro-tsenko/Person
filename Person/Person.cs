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
            //Викликаємо перевірку для дати
            CheckFutureAndPastDate(dateBirth);

            //Викликаємо перевірку для email
            CheckEmail(email);

            Name = name;
            Surname = surname;
            Email = email;
            DateBirth = dateBirth;
        }

        public Person(string name, string surname, string email)
        {
            CheckEmail(email);
            Name = name;
            Surname = surname;
            Email = email;
        }

        public Person(string name, string surname, DateTime dateBirth)
        {
            CheckFutureAndPastDate(dateBirth);
            Name = name;
            Surname = surname;
            DateBirth = dateBirth;
        }

        public bool IsAdult
        {
            get
            {
                if ((DateTime.Now.Year - DateBirth.Year) >= 18)
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
                        return "Goat";
                    case 2:
                        return "Water Bearer";
                    case 3:
                        return "Fish";
                    case 4:
                        return "Ram";
                    case 5:
                        return "Bull";
                    case 6:
                        return "Twins";
                    case 7:
                        return "Crab";
                    case 8:
                        return "Lion";
                    case 9:
                        return "Virgin";
                    case 10:
                        return "Balance";
                    case 11:
                        return "Scorpion";
                    case 12:
                        return "Archer";
                    default:
                        return "None";
                }
            }
        }

        public string ChineseSign
        {
            get
            {
                if (DateBirth.Year % 10 == 1)
                    return "Tiger";
                if (DateBirth.Year % 10 == 2)
                    return "Rabbit";
                if (DateBirth.Year % 10 == 3)
                    return "Dragon";
                if (DateBirth.Year % 10 == 4)
                    return "Snake";
                if (DateBirth.Year % 10 == 5)
                    return "Horse";
                if (DateBirth.Year % 10 == 6)
                    return "Goat";
                if (DateBirth.Year % 10 == 7)
                    return "Monkey";
                if (DateBirth.Year % 10 == 8)
                    return "Rooster";
                if (DateBirth.Year % 10 == 9)
                    return "Dog";
                if (DateBirth.Year % 10 == 0)
                    return "Pig";

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
            return "Name: " + Name + "\nSurname: " + Surname + "\nEmail: " + Email + "\nDateBirth" + DateBirth + "\nIsAdult: " + IsAdult + "\nSunSign: " + SunSign + "\nChinese Sign: " + ChineseSign + "\nIsBirtday: " + IsBirthday + "\n";
        }

        private void CheckFutureAndPastDate(DateTime dateTime)
        {
            //Якщо дата більша за сьогоднішню, то це помилка
            if (dateTime.Date > DateTime.Now)
                throw new FutureDate();

            //Якщо дата менша за сьогодняшну на 130 років - це помилка
            if (dateTime.Year < DateTime.Now.Year - 130)
                throw new PastDate();
        }

        private void CheckEmail(string email)
        {
            if (email != "joeschmoe@mydomain.com")
                throw new EmailExeption();
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime DateBirth { get; set; }
    }

    class FutureDate : Exception
    {
        public DateTime ErrorCode { get { return errorCode; } }

        private DateTime errorCode;

        public FutureDate(DateTime birthYear, string message = "Дата народження у майбутньому") : base(message)
        {
            //Зберігаємо код помилки(неправильну дату)
            errorCode = birthYear;
        }

        public FutureDate(string message = "Дата народження у майбутньому") : base(message)
        {
        }
    }

    class PastDate : Exception
    {
        public DateTime ErrorCode { get { return errorCode; } }

        private DateTime errorCode;

        public PastDate(DateTime birthYear, string message = "Дата народження дуже давня") : base(message)
        {
            //Зберігаємо код помилки(неправильну дату)
            errorCode = birthYear;
        }

        public PastDate(string message = "Дата народження дуже давня") : base(message)
        {
        }
    }

    class EmailExeption : Exception
    {
        public string ErrorCode { get { return errorCode; } }

        private string errorCode;

        public EmailExeption(string email, string message = "Невірна пошта") : base(message)
        {
            //Зберігаємо код помилки(неправильний email)
            errorCode = email;
        }

        public EmailExeption(string message = "Невірна пошта") : base(message)
        {
        }
    }
}
