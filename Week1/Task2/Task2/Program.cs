using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;//name of student
        public int id;//id of student
        public int yearOfStudy;//year of study of student
        public Student()
        {
            name = "";//initialize all vaariables
            id = 1;//initial id = 1
            yearOfStudy = 1990;//initial year = 1990
        }
        public Student(string name_new, int year)
        {
            name = name_new;//конструктор с двумя параметрами, устанавливаем полученные значения
            yearOfStudy = year;
        }
        public void setId(int new_id)//id setter
        {
            id = new_id;
        }
        public int getYear()
        {//получаем год обучения
            return yearOfStudy;//возвращаем год
        }
        public string getName()//получаем имя
        {
            return name;//возвращаем имя
        }
        public int getId()//метод получения номера студента
        {
            return id;//возвращаем номер стдуента
        }
        public void setName(string new_name) // name setter
        {
            name = new_name;//устанавливаем полученное имя
        }
        public void setYear(int newYear)
        {
            yearOfStudy = newYear;//устанавливаем полученный год
        }
        public void incYear()//increment year of study
        {
            yearOfStudy++;//add 1 to this value
        }
        public void display()//метод вывода всей информцции
        {
            Console.WriteLine("Имя студента: " + name);//вывоидм имя
            Console.WriteLine("Год поступления: " + yearOfStudy);//год
            Console.WriteLine("Номер студента: " + id);//и айди студента
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Isa = new Student();//создаем объект класса Стюдент - Иса
            Isa.setName("Kozhantayaev Isa");//устанавливаем имя
            Isa.setId(1);//номер
            Isa.setYear(2019);//год
            Isa.display();//выводим всю информацию
            Isa.incYear();//увеличиваем год поступления на 1
            Console.WriteLine("Инкрементировал год поступления!");//сообщаем об этом
            Isa.display();//выводим еще раз всю информацию
            Console.ReadKey();//ждем нажатия кнопки
        }
    }
}
