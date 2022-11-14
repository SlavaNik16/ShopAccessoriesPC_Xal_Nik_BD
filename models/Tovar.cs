using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAccessoriesPC.models
{
    /// <summary>
    /// Товары
    /// </summary>
    public class Tovar
    {

        /// <summary>
        /// Уникальный номер пользователя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id пользователя товара
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// Товара
        /// </summary>
        public Products Product { get; set; }
        /// <summary>
        /// Кол-во товара
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Время заказа
        /// </summary>
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// Способ доставки
        /// </summary>
        public Delivery Мethod { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

    }
}
