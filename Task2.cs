using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CW_17._11_TEST
{
    internal class Song
    {
        public string _nameSong {  get; set; }
        public double _SongTime { get; set; }
        public string _SongStyle { get; set; }

        public Song(string nameSong, double songTime, string songStyle)
        {
            _nameSong = nameSong;
            _SongTime = songTime;
            _SongStyle = songStyle;
        }

        public void Input()
        {
            Console.WriteLine("Введи информацию о пеcне");
            
            Console.WriteLine("Введи название: ");
            _nameSong = Console.ReadLine();

            Console.WriteLine("Продолжительность: ");
            _SongTime = double.Parse(Console.ReadLine());

            Console.WriteLine("Стиль: ");
            _SongStyle = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Информация об Альбоме");
            Console.WriteLine($"Название: {_nameSong}");
            Console.WriteLine($"Продолжительность: {_SongTime}");
            Console.WriteLine($"Стиль: {_SongStyle}");
        }
    }
}
