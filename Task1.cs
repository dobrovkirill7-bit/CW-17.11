using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CW_17._11_TEST
{
    internal class Albom
    {
        public string _name { get; set; }
        public string _author { get; set; }
        public int _bornYear { get; set; }
        public double _time {  get; set; }
        public string _studio { get; set; }

        public Albom(string name, string author, int bornYear, double time, string studio)
        {
            _name = name;
            _author = author;
            _bornYear = bornYear;
            _time = time;
            _studio = studio;
        }

        public Albom() // компилятор сам предложил создать
        {
        }

        public void Input()
        {
            Console.WriteLine("Введи информацию про Альбом");
            
            Console.WriteLine("Название: ");
            _name = Console.ReadLine();
            
            Console.WriteLine("Автора: ");
            _author = Console.ReadLine();

            Console.WriteLine("Год выхода: ");
            _bornYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Продолжительность: ");
            _time = double.Parse(Console.ReadLine());

            Console.WriteLine("Студия: ");
            _studio = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Информация об Альбоме");
            Console.WriteLine($"Название: {_name}");
            Console.WriteLine($"Автор: {_author}");
            Console.WriteLine($"Год выпуска: {_bornYear}");
            Console.WriteLine($"Продолжительность: {_time}");
            Console.WriteLine($"Студия: {_studio}");
        }
    }
}
