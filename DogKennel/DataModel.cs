using System;
using System.Collections.Generic;

namespace DogKennel
{
    /// <summary>
    /// Питомник собак
    /// </summary>
    public class KennelOfDog
    {
        /// <summary>
        /// Название питомника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес питомника
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Собаки питомника
        /// </summary>
        public List<Dog> Dog { get; set; }

        /// <summary>
        /// Фотография питомника
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Работники питомника
        /// </summary>
        public List<Employee> Employee { get; set; }
    }

    /// <summary>
    /// Cобачка
    /// </summary>
    public class Dog
    {

        /// <summary>
        /// Порода
        /// </summary>
        public string Breed { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set ; }

        /// <summary>
        /// Цена в рублях
        /// </summary>
        public string CostInRubles { get; set; }

        public override string ToString()
        {
            var db = DateOfBirth.ToLongDateString();
            return $"Порода: {Breed}, Пол: {Gender}, Дата рождения: {db}, Цена в рублях: {CostInRubles} ";
        }
    }

    /// <summary>
    /// Работник питомника
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Post { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}, Должность: {Post}";
        }
    }
}
