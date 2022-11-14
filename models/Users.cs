using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShopAccessoriesPC.models
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class Users
    {
        /// <summary>
        /// Уникальный номер пользователя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Genders Gender { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

    }
}
