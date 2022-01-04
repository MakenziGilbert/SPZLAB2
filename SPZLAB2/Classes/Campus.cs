using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB2.Classes
{
    public static class MyExtensionMethods
    {
        public static Campus AddDiningRoom(this Campus camp) // расширяющий метод
        {
            camp.NumberOfStaff += 5;
            camp.PaymentForAccommodation = (camp.PaymentForAccommodation + (camp.PaymentForAccommodation * 0.2));
            return camp;
        }
    }
    public class Campus : ICloneable // интерфес клонирования
    {
        private string _universityName; // название университета
        private string _address; // адрес
        private int _numberOfRooms; //количество комнат
        private int _numberOfStaff; //количество персонала
        private int _numberOfStudents; // количество студентов
        private double _paymentForAccommodation; // оплата за проживание

        public string UniversityName // свойство имени
        {
            get { return _universityName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"{value}");
                _universityName = value;
            }
        }
        public string Address //свойство адреса
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"{value}");
                _address = value;
            }
        }
        public int NumberOfRooms // свойство кол-ва комнат
        {
            get { return _numberOfRooms; }
            set 
            { 
                if(value < 0)
                    throw new ArgumentException($"{value}");
                _numberOfRooms = value; 
            }
        }
        public int NumberOfStaff// свойства кол-ва сотрудников
        {
            get { return _numberOfStaff; }
            set
            {
                if (value < 0)
                    throw new ArgumentException($"{value}");
                _numberOfStaff = value;
            }
        }
        public int NumberOfStudents// свойство кол-ва студенктов
        {
            get { return _numberOfStudents; }
            set
            {
                if (value < 0)
                    throw new ArgumentException($"{value}");
                _numberOfStudents = value;
            }
        }
        public double PaymentForAccommodation // свойства проживания
        {
            get { return _paymentForAccommodation; }
            set
            {
                if (value < 0)
                    throw new ArgumentException($"{value}");
                _paymentForAccommodation = value;
            }
        }
        public Campus(string name, string adres, int rooms, int staff, int students, double payment) // конструктор
        {
            UniversityName = name;
            Address = adres;
            NumberOfRooms = rooms;
            NumberOfStaff = staff;
            NumberOfStudents = students;
            PaymentForAccommodation = payment;
        }
        public void IncreaseNumberOfRooms(int newrooms)// увеличить количество комнат
        {
            if(newrooms <= NumberOfRooms )
                throw new ArgumentException($"{newrooms}");
            NumberOfRooms = newrooms;
        }

        public void PopulateStudents(int newpopulate) // заселить
        {
            NumberOfStudents += newpopulate;
        }

        public void EvictStudents(int newpopulate)// выселить
        {
            NumberOfStudents -= newpopulate;
        }
        public double CalculateIncomeMouth() // посчитать доход за месяц
        {
            return NumberOfStudents * PaymentForAccommodation;
        }
        public double CalculateIncomeHalfYear()// посчитать доход за пол года
        {
            return (NumberOfStudents * PaymentForAccommodation) * 6;
        }
        public double CalculateIncomeYear()// посчитать доход за год
        {
            return (NumberOfStudents * PaymentForAccommodation) * 12;
        }
        public object Clone() // клонирование
        {
            Campus temp = new Campus(this.UniversityName, this.Address, this.NumberOfRooms,
               this.NumberOfStaff, this.NumberOfStudents, this.PaymentForAccommodation);
            return temp;
        }
        public override string ToString() //  переопределение сттринг
        {
            return $"{_universityName} {_address}";
        }
    }
 
}
