using Microsoft.VisualBasic.ApplicationServices;
using ShopAccessoriesPC.models;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ShopAccessoriesPC
{
    public partial class UsersForm : Form
    {
        private readonly Users user;
        public NugetsPerevod<Users> cal;

        public UsersForm()
        {
            InitializeComponent();
            FillGender();
            cal = new NugetsPerevod<Users>();
            this.Text = "Добавление пользователей";
            user = new Users
            {
                 Gender = Genders.Male,
            };
            GenderBox.SelectedItem = user.Gender;
        }

        public UsersForm(Users source) : this()
        {
            this.Text = "Редактирование пользователей";
            SurBox.Text = source.Surname;
            NameBox.Text = source.Name;
            GenderBox.SelectedItem = source.Gender;
            MasBoxEmail.Text = source.Email;
            PhoneBox.Text = source.Phone.ToString();
            AdressBox.Text = source.Address;

        }
        public Users Users => user;
        
        private void FillGender()
        {
            foreach (Genders dir in Enum.GetValues(typeof(Genders)))
            {
                GenderBox.Items.Add(dir);
            }
        }
        private void GenderBox_DrawItem(object sender, DrawItemEventArgs e)
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
                    if (parent.Items[e.Index] is Genders gender)
                    {
                        var text = cal.Perevod(gender,Genders.Male,"Мужской","Женский");

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

        private void SurBox_TextChanged(object sender, EventArgs e)
        {
            user.Surname = SurBox.Text.Trim();
            Validates();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            user.Name = NameBox.Text.Trim();
            Validates();
        }


        private void AdressBox_TextChanged(object sender, EventArgs e)
        {
            user.Address = AdressBox.Text.Trim();
            Validates();
        }
        private void MasBoxEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(MasBoxEmail.Text, pattern))
            {
                ErrorEmail.Clear();
                user.Email = MasBoxEmail.Text;  
                Validates();
            }
            else
            {
                butSave.Enabled = false;
                ErrorEmail.SetError(this.MasBoxEmail, "Неправильный формат!!!");
            }

        }
        public void Validates()
        {
            butSave.Enabled =
                !string.IsNullOrWhiteSpace(user.Surname) &&
                !string.IsNullOrWhiteSpace(user.Name) &&
                !string.IsNullOrWhiteSpace(user.Email) &&
                !string.IsNullOrWhiteSpace(user.Phone) &&
                !string.IsNullOrWhiteSpace(user.Address);
           
        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.Gender = (Genders)GenderBox.SelectedItem;
            Validates();
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneBox.Text.Length >=6 && PhoneBox.Text.Length <= 11)
            {
                user.Phone = PhoneBox.Text;
                ErrorPhone.Clear(); 
                Validates();
            }
            else
            {
                butSave.Enabled = false;
                ErrorPhone.SetError(this.PhoneBox, "Длина номера больше 6 символов(не больше 11)");
            }
           

        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) ) 
            {
                e.Handled = true;
            }
        }

        private void MasBoxEmail_TextChanged(object sender, EventArgs e)
        {
            user.Email = MasBoxEmail.Text;
        }
    }
}
