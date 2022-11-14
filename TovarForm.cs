using Microsoft.VisualBasic.ApplicationServices;
using ShopAccessoriesPC.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAccessoriesPC
{
    public partial class TovarForm : Form
    {
        private readonly Tovar tovar;
        public NugetsPerevod<Tovar> cal;
        public TovarForm()
        {
            InitializeComponent();
            FillProducts();
            FillMethod();
            cal = new NugetsPerevod<Tovar>();
            this.Text = "Добавление товара";
            tovar = new Tovar()
            {
                Product = Products.Processor,
                Count = 1,
                Price = 100,
                OrderTime = DateTime.Now.AddDays(3),
                Мethod = Delivery.Self_call,
                Comment = "Без комментариев",
            };
            CommentBox.Text = tovar.Comment;
            TovarBox.SelectedItem = tovar.Product;
            CountNum.Value = tovar.Count;
            PriceBox.Text = tovar.Price.ToString();
            OrderTimePick.Text = tovar.OrderTime.ToString();
            MethBox.SelectedItem = tovar.Мethod;
            
        }
        public TovarForm(Tovar sourse) : this()
        {
            CommentBox.Text = sourse.Comment;
            TovarBox.SelectedItem = sourse.Product;
            CountNum.Value = sourse.Count;
            PriceBox.Text = sourse.Price.ToString();
            OrderTimePick.Text = sourse.OrderTime.ToString();
            MethBox.SelectedItem = sourse.Мethod;
        }
        public Tovar Tovar => tovar;
        public void FillProducts()
        {
            foreach (Products dir in Enum.GetValues(typeof(Products)))
            {
                TovarBox.Items.Add(dir);
            }
        }
        public void FillMethod()
        {
            foreach (Delivery dir in Enum.GetValues(typeof(Delivery)))
            {
                MethBox.Items.Add(dir);
            }
        }
        private void TovarBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Products products)
                    {
                        var t = cal.Perevod(products, Products.Processor,
                            "Процессор", "Материнска плата", "ОЗУ",
                            "Блок питания", "Видеокарта",
                            "SSD", "HHD", "Клавиатура", "Мышь",
                            "Монитор", "Микрофон", "Наушники");

                        e.Graphics.DrawString(
                            t,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                                parent.Items[e.Index].ToString(),
                                parent.Font,
                                brush,
                                e.Bounds);
                    }
                }

            }
        }

        private void MethBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Delivery delivery)
                    {
                        var text = cal.Perevod(delivery, Delivery.Self_call, "Самовызов", "Доставка на дом");

                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                                parent.Items[e.Index].ToString(),
                                parent.Font,
                                brush,
                                e.Bounds);
                    }
                }

            }
        }

        private void TovarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tovar.Product = (Products)TovarBox.SelectedItem;
        }

        private void CountNum_ValueChanged(object sender, EventArgs e)
        {
            tovar.Count = (int)CountNum.Value;
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            if (PriceBox.Text.Length > 0)
            {
                try
                {
                    tovar.Price = decimal.Parse(PriceBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверный формат!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PriceBox.Text = PriceBox.Text.Remove(PriceBox.Text.Length - 1);
                }
            }
        }

        private void OrderTimePick_ValueChanged(object sender, EventArgs e)
        {
            tovar.OrderTime = OrderTimePick.Value;
        }

        private void MethBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tovar.Мethod = (Delivery)MethBox.SelectedItem;
        }

        private void CommentBox_TextChanged(object sender, EventArgs e)
        {
            tovar.Comment = CommentBox.Text;
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
    }
}
