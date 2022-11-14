using Microsoft.EntityFrameworkCore;
using ShopAccessoriesPC.DataBase;
using ShopAccessoriesPC.models;
using System.Data;
using ApplicationContext = ShopAccessoriesPC.DataBase.ApplicationContext;

namespace ShopAccessoriesPC
{
    public partial class Form1 : Form
    {
        public int Key = 0;
        private NugetsPerevod<Users> cal;
        public DbContextOptions<ApplicationContext> options;
        public Form1()
        {
            InitializeComponent();

            UsersGridViev.AutoGenerateColumns = false;
           
            options = DataBaseHelper.Option();
            cal = new NugetsPerevod<Users>();
            ListAddSort();
            UsersGridViev.DataSource = ReadDB(options);
            StatusCol();
        }
        #region ListAdd
        private void ListAddSort()
        {
            ListUser.Items.Add("по Id(убыванию)");
            ListUser.Items.Add("по Id(возрастанию)");
            ListUser.Items.Add("по Фамилии(убыванию)");
            ListUser.Items.Add("по Фамилии(возрастанию)");
            ListUser.Items.Add("по Имени(убыванию)");
            ListUser.Items.Add("по Имени(возрастанию)");
            ListUser.SelectedIndex = 0;

            ListTovar.Items.Add("по Id(убыванию)");
            ListTovar.Items.Add("по Id(возрастанию)");
            ListTovar.Items.Add("по Номеру(убыванию)");
            ListTovar.Items.Add("по Номеру(возрастанию)");
            ListTovar.Items.Add("по Товару(убыванию)");
            ListTovar.Items.Add("по Товару(возрастанию)");
            ListTovar.Items.Add("по Цене(убыванию)");
            ListTovar.Items.Add("по Цене(возрастанию)");
           
            ListTovar.SelectedIndex = 0;
        }
        #endregion
        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Николаев В.А и Халле Александо ИП-20-3\n\rБаза данных на тему: \n\rМагазин запчастей ПК", "Индивидуальный вариант!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #region AddUsers
        private void AddTool_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            if (usersForm.ShowDialog(this) == DialogResult.OK)
            { 
                CreateDB(options, usersForm);
                UsersGridViev.DataSource = ReadDB(options);
                UsersGridViev.BackgroundColor = Color.FromArgb(255,192, 255,192);
                StatusCol();
            }


        }
        private void DeliteTool_Click(object sender, EventArgs e)
        {
            var id = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить \n\rId: {id.Id}\n\rФамилия:{id.Surname}\n\rИмя:{id.Name}", 
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveDB(options, id);
                UsersGridViev.DataSource = ReadDB(options);
                UsersGridViev.BackgroundColor = Color.FromArgb(255, 255, 192, 192); 
                StatusCol();
            }
        }


        private void ChangeTool_Click(object sender, EventArgs e)
        {
            var id = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
            var usersForm = new UsersForm(id);
            if (usersForm.ShowDialog(this) == DialogResult.OK)
            {
                id.Surname = usersForm.Users.Surname;
                id.Name = usersForm.Users.Name;
                id.Gender = usersForm.Users.Gender;
                id.Email = usersForm.Users.Email;
                id.Phone = usersForm.Users.Phone;
                id.Address = usersForm.Users.Address;
                UpdateDB(options, id);
                UsersGridViev.DataSource = ReadDB(options);
                UsersGridViev.BackgroundColor = Color.FromArgb(255, 255, 255, 192);
                StatusCol();
            }
        }
        #endregion

        #region MenuButton
        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddTool_Click(sender, e);
        }

        private void DeliteMenu_Click(object sender, EventArgs e)
        {
            DeliteTool_Click(sender, e);
        }

        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            ChangeTool_Click(sender, e);
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region UserCellFormating_ProverkaButton
        private void UsersGridViev_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UsersGridViev.Columns[e.ColumnIndex].Name == "ColumnGender")
            {
                var val = (Genders)e.Value;
                e.Value = cal.Perevod(val, Genders.Male, "Мужской", "Женский");
            } 
        }

        private void UsersGridViev_SelectionChanged(object sender, EventArgs e)
        {
           DeliteMenu.Enabled =
           ChangeMenu.Enabled =
           DeliteTool.Enabled =
           ChangeTool.Enabled =
           AddToolTovar.Enabled = 
           UsersGridViev.SelectedRows.Count > 0;
            if (UsersGridViev.SelectedRows.Count > 0)
            {
                var id = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
                TovarGridViev.DataSource = ReadTovarDB(options, id);
                
            }
            StatusCol();
        }
        #endregion

        #region TovarCellFormating_ProverkaButton
        private void TovarGridViev_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TovarGridViev.Columns[e.ColumnIndex].Name == "ColumnProduct")
            {
                var val = (Products)e.Value;
                e.Value = cal.Perevod(val, Products.Processor, "Процессор", "Материнска плата",
                    "ОЗУ", "Блок питания", "Видеокарта", "SSD", "HHD", "Клавиатура",
                    "Мышь", "Монитор", "Микрофон", "Наушники");

            }
            if (TovarGridViev.Columns[e.ColumnIndex].Name == "ColumnMethod")
            {
                var val = (Delivery)e.Value;
                e.Value = cal.Perevod(val, Delivery.Self_call, "Самовызов", "Доставка на дом");
            }
            if (TovarGridViev.Columns[e.ColumnIndex].Name == "ColumnComment")
            {
                TovarGridViev.Columns[e.ColumnIndex].Visible = false;
            }
        }

        private void TovarGridViev_SelectionChanged(object sender, EventArgs e)
        {
            ChangeToolTovar.Enabled =
            DeleteToolTovar.Enabled =
            TovarGridViev.SelectedRows.Count > 0;
            if (TovarGridViev.SelectedRows.Count > 0)
            {   
                var id = (Tovar)TovarGridViev.Rows[TovarGridViev.SelectedRows[0].Index].DataBoundItem;
                CommBox.Text = id.Comment;

            }
        }
        #endregion

        #region TovarButton 
        private void AddToolTovar_Click(object sender, EventArgs e)
        {
            var tovarInfo = new TovarForm();
            var id = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
            if (tovarInfo.ShowDialog(this) == DialogResult.OK)
            {
                CreateTovarDB(options, tovarInfo, id);
                TovarGridViev.DataSource = ReadTovarDB(options,id);
                TovarGridViev.BackgroundColor = Color.FromArgb(255, 192, 255, 192);
                StatusCol();
            }
        }
        private void ChangeToolTovar_Click(object sender, EventArgs e)
        {
            var idUser = new Users();
            if (UsersGridViev.SelectedRows.Count > 0)
            {
               idUser = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
            }
            var idTovar = (Tovar)TovarGridViev.Rows[TovarGridViev.SelectedRows[0].Index].DataBoundItem;
            var tovarInfo = new TovarForm(idTovar);
            if (tovarInfo.ShowDialog(this) == DialogResult.OK)
            {
                idTovar.Product = tovarInfo.Tovar.Product;                
                idTovar.Count = tovarInfo.Tovar.Count;
                idTovar.Price = tovarInfo.Tovar.Price;
                idTovar.OrderTime = tovarInfo.Tovar.OrderTime;
                idTovar.Мethod = tovarInfo.Tovar.Мethod;
                idTovar.Comment = tovarInfo.Tovar.Comment;
                UpdateTovarDB(options, idTovar);
                if (idUser.Email != null)
                {
                    TovarGridViev.DataSource = ReadTovarDB(options, idUser);
                }
                else
                {
                    TovarGridViev.DataSource = ReadAllTovarDB(options);
                }
                TovarGridViev.BackgroundColor = Color.FromArgb(255, 255, 255, 192);
                StatusCol();

            }
        }
       
        private void DeleteToolTovar_Click(object sender, EventArgs e)
        {
            var idUser = new Users();
            if (UsersGridViev.SelectedRows.Count > 0)
            {
                idUser = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
            }
            var idTovar = (Tovar)TovarGridViev.Rows[TovarGridViev.SelectedRows[0].Index].DataBoundItem;
            var text = cal.Perevod(idTovar.Product, Products.Processor, "Процессор", "Материнска плата",
                                    "ОЗУ", "Блок питания", "Видеокарта", "SSD", "HHD", "Клавиатура",
                                    "Мышь", "Монитор", "Микрофон", "Наушники");
            if (MessageBox.Show($"Вы действительно хотите удалить \n\rId: {idTovar.Id}\n\rПродукт:{text}\n\rВремя заказа:{idTovar.OrderTime:d}",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveTovarDB(options, idTovar);
                if (idUser.Email != null)
                {
                    TovarGridViev.DataSource = ReadTovarDB(options, idUser);
                }
                else
                {
                    TovarGridViev.DataSource = ReadAllTovarDB(options);
                }
                TovarGridViev.BackgroundColor = Color.FromArgb(255, 255, 192, 192);
                StatusCol();

            }
        } 
        #endregion

        #region CRUDUser_DB
        private static void CreateDB(DbContextOptions<ApplicationContext> options, UsersForm form)
        {
            using (var db = new ApplicationContext(options))
            {
                Users user = new Users();
                form.Users.Id = user.Id;
                db.UserBD.Add(form.Users);
                db.SaveChanges();
            }
        }
        private static void RemoveDB(DbContextOptions<ApplicationContext> options, Users users)
        {
            using (var db = new ApplicationContext(options))
            {
                var user = db.UserBD.FirstOrDefault(u => u.Id == users.Id);
                if (user != null)
                {   foreach(var tovar in db.TovarsBD.ToList())
                    {
                        if (tovar.IdUser == user.Id)
                        {
                            var tovars = db.TovarsBD.FirstOrDefault(u => u.Id == tovar.Id);
                            db.TovarsBD.Remove(tovars);
                        }
                    }
                    db.UserBD.Remove(user);
                    db.SaveChanges();
                }
            }

        }

        private static void UpdateDB(DbContextOptions<ApplicationContext> options, Users users)
        {
            using (var db = new ApplicationContext(options))
            {
                var user = db.UserBD.FirstOrDefault(u => u.Id == users.Id);
                if (user != null)
                {
                    user.Surname = users.Surname;
                    user.Name = users.Name;
                    user.Gender = users.Gender;
                    user.Email = users.Email;
                    user.Phone = users.Phone;
                    user.Address = users.Address;
                    db.SaveChanges();
                }
            }
        }
        private static List<Users> ReadDB(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                    return db.UserBD
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }
        }
        #endregion
        #region CRUDTovar_DB
        private static void CreateTovarDB(DbContextOptions<ApplicationContext> options, TovarForm form, Users index)
        {
            using (var db = new ApplicationContext(options))
            {
                Tovar t = new Tovar();
                form.Tovar.Id = t.Id;
                form.Tovar.IdUser = index.Id;
                db.TovarsBD.Add(form.Tovar);
                db.SaveChanges();
            }
        }
        private static void RemoveTovarDB(DbContextOptions<ApplicationContext> options, Tovar tovar)
        {
            using (var db = new ApplicationContext(options))
            {
                var t = db.TovarsBD.FirstOrDefault(u => u.Id == tovar.Id);
                if (t != null)
                {
                    db.TovarsBD.Remove(t);
                    db.SaveChanges();
                }
            }

        }

        private static void UpdateTovarDB(DbContextOptions<ApplicationContext> options, Tovar tovar)
        {
            using (var db = new ApplicationContext(options))
            {
                var id = db.TovarsBD.FirstOrDefault(u => u.Id == tovar.Id);
                if (id != null)
                {
                    id.Product = tovar.Product;
                    id.Count = tovar.Count;
                    id.Price = tovar.Price;
                    id.OrderTime = tovar.OrderTime;
                    id.Мethod = tovar.Мethod;
                    id.Comment = tovar.Comment;
                    db.SaveChanges();
                }
            }
        }
        private static List<Tovar> ReadTovarDB(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {  
                return db.TovarsBD
                    .Where(u => u.IdUser == user.Id)
                    .ToList();
            }
        }
        private static List<Tovar> ReadAllTovarDB(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.TovarsBD.ToList();
            }
        }


        #endregion

        #region SortList
        private void butSortUser_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                var result = db.UserBD
                    .OrderByDescending(x => x.Id)
                    .ToList();
                switch (ListUser.SelectedIndex) 
                {
                    case 0:
                    result = db.UserBD
                    .OrderByDescending(x => x.Id)
                    .ToList();
                        break;
                    case 1:
                    result = db.UserBD
                       .OrderBy(x => x.Id)
                       .ToList();
                        break;
                    case 2:
                        result = db.UserBD
                        .OrderByDescending(x=>x.Surname)
                        .ToList();
                        break;
                    case 3:
                        result = db.UserBD
                           .OrderBy(x => x.Surname)
                           .ToList();
                        break;
                    case 4:
                        result = db.UserBD
                        .OrderByDescending(x => x.Name)
                        .ToList();
                        break;
                    case 5:
                        result = db.UserBD
                           .OrderBy(x => x.Name)
                           .ToList();
                        break;
                }
                UsersGridViev.DataSource = result;
            }
        }

        private void butSortTovar_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                Users id = new Users();
                var result = db.TovarsBD
                    .OrderByDescending(x => x.Id)
                    .ToList();
               
                switch (ListTovar.SelectedIndex)
                {
                    case 0:
                        result = db.TovarsBD
                        .OrderByDescending(x => x.Id)
                        .ToList();
                        break;
                    case 1:
                        result = db.TovarsBD
                           .OrderBy(x => x.Id)
                           .ToList();
                        break;
                    case 2:
                        result = db.TovarsBD
                           .OrderByDescending(x=>x.IdUser)
                           .ToList();
                        break;
                    case 3:
                        result = db.TovarsBD
                           .OrderBy(x => x.IdUser)
                           .ToList();
                        break;
                    case 4:
                        result = db.TovarsBD
                        .OrderByDescending(x => x.Product)
                        .ToList();         
                        break;
                    case 5:
                        result = db.TovarsBD
                           .OrderBy(x => x.Product)
                           .ToList();
                        break;
                    case 6: 
                        result = db.TovarsBD
                        .OrderByDescending(x => x.Price)
                        .ToList();
                        break;
                    case 7:    
                        result = db.TovarsBD
                           .OrderBy(x => x.Price)
                           .ToList();
                        break;
                }
                if (UsersGridViev.SelectedRows.Count > 0)
                {
                    id = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
                    TovarGridViev.DataSource = result.Where(u => u.IdUser == id.Id).ToList();
                }
                else
                {
                    TovarGridViev.DataSource = result;
                }
                
            }
        }
        #endregion

        #region SearchWithId
        private void butSearchId_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                if (!string.IsNullOrWhiteSpace(IdBox.Text) && (IdBox.Text.Length < 10))
                {
                    var id = new Users()
                    {
                        Id = int.Parse(IdBox.Text),
                    };
                    ErrorId.Clear();
                    UsersGridViev.DataSource = db.UserBD.Where(x => x.Id == id.Id).ToList();
                }
                else
                {
                    ErrorId.SetError(this.IdBox,"Не найден Id");
                    UsersGridViev.DataSource = db.UserBD.ToList();
                }
            }
        }

        private void IdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        #endregion 
        #region SearchWithPhone
        private void butSearchPhone_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                if (!string.IsNullOrWhiteSpace(IdBox.Text))
                {
                    var id = new Users()
                    {
                        Phone = IdBox.Text,
                    };
                    ErrorId.Clear();
                    UsersGridViev.DataSource = db.UserBD.Where(x => x.Phone == id.Phone).ToList();
                }
                else
                {
                    ErrorId.SetError(this.IdBox, "Не найден Номер");
                    UsersGridViev.DataSource = db.UserBD.ToList();
                }
            }
        }
        #endregion

        #region SearchWithSurName
        private void butSearchWord_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                if (!string.IsNullOrWhiteSpace(WordBox.Text))
                {
                    var id = new Users()
                    {
                        Surname = WordBox.Text,
                    };
                    ErrorSur.Clear();
                    UsersGridViev.DataSource = db.UserBD.Where(x => x.Surname == id.Surname).ToList();
                }
                else
                {
                    ErrorSur.SetError(this.WordBox, "Не найдена Фамилия");
                    UsersGridViev.DataSource = db.UserBD.ToList();
                }
            }
        }
        #endregion
        #region SearchWithName
        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                if (!string.IsNullOrWhiteSpace(WordBox.Text))
                {
                    var id = new Users()
                    {
                        Name = WordBox.Text,
                    };
                    ErrorSur.Clear();
                    UsersGridViev.DataSource = db.UserBD.Where(x => x.Name == id.Name).ToList();
                }
                else
                {
                    ErrorSur.SetError(this.WordBox, "Не найдено имя");
                    UsersGridViev.DataSource = db.UserBD.ToList();
                }
            }
        }
        #endregion

        #region StatusBar
        public void StatusCol()
        {
            if (UsersGridViev.SelectedRows.Count > 0)
            {
                using (var db = new ApplicationContext(options))
                {
                    var id = (Users)UsersGridViev.Rows[UsersGridViev.SelectedRows[0].Index].DataBoundItem;
                    var tovar = db.TovarsBD.Where(x => x.IdUser == id.Id).ToList();
                    NumberTovarUser.Text = $"Общая сумма пользователей: {tovar.Sum(x=>x.Count * x.Price):C2}";
                    NumerTovarAmount.Text = $"Общая сумма: 0";
                }
            }
            else
            {
                using (var db = new ApplicationContext(options))
                {

                    NumerTovarAmount.Text = $"Общая сумма: {db.TovarsBD.Sum(x => x.Count * x.Price):C2}";
                    NumberTovarUser.Text = $"Общая сумма пользователей: 0";
                }
            }
            
            NumberUserCount.Text = $"Кол-во пользователей: {ReadDB(options).Count()}";
            NumberTovarCount.Text = $"Кол-во товаров: {ReadAllTovarDB(options).Count}";
        }
        #endregion
    }
}
