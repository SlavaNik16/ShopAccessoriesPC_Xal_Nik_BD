namespace ShopAccessoriesPC
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butCansel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.MasBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SurBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.ErrorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BackgroundImage = global::ShopAccessoriesPC.Properties.Resources.colorgrad;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.butCansel);
            this.panel2.Controls.Add(this.butSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 84);
            this.panel2.TabIndex = 31;
            // 
            // butCansel
            // 
            this.butCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCansel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butCansel.Location = new System.Drawing.Point(387, 14);
            this.butCansel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(173, 57);
            this.butCansel.TabIndex = 1;
            this.butCansel.Text = "Отмена";
            this.butCansel.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Yellow;
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Enabled = false;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butSave.Location = new System.Drawing.Point(14, 14);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(173, 57);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // MasBoxEmail
            // 
            this.MasBoxEmail.Location = new System.Drawing.Point(196, 306);
            this.MasBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MasBoxEmail.Name = "MasBoxEmail";
            this.MasBoxEmail.Size = new System.Drawing.Size(346, 23);
            this.MasBoxEmail.TabIndex = 35;
            this.MasBoxEmail.TextChanged += new System.EventHandler(this.MasBoxEmail_TextChanged);
            this.MasBoxEmail.Leave += new System.EventHandler(this.MasBoxEmail_Leave);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(196, 183);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(346, 23);
            this.NameBox.TabIndex = 34;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // AdressBox
            // 
            this.AdressBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdressBox.Location = new System.Drawing.Point(24, 449);
            this.AdressBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdressBox.Multiline = true;
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(517, 71);
            this.AdressBox.TabIndex = 33;
            this.AdressBox.TextChanged += new System.EventHandler(this.AdressBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(210, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Адрес";
            // 
            // SurBox
            // 
            this.SurBox.Location = new System.Drawing.Point(196, 132);
            this.SurBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SurBox.Name = "SurBox";
            this.SurBox.Size = new System.Drawing.Size(346, 23);
            this.SurBox.TabIndex = 30;
            this.SurBox.TextChanged += new System.EventHandler(this.SurBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(2, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 33);
            this.label7.TabIndex = 29;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = "Почта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Имя";
            // 
            // GenderBox
            // 
            this.GenderBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(196, 240);
            this.GenderBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(346, 24);
            this.GenderBox.TabIndex = 25;
            this.GenderBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.GenderBox_DrawItem);
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация об Пользователе";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 102);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShopAccessoriesPC.Properties.Resources.people;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 77);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.ContainerControl = this;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(196, 361);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(346, 23);
            this.PhoneBox.TabIndex = 36;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.ContainerControl = this;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 612);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MasBoxEmail);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SurBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Button butCansel;
        private Button butSave;
        private MaskedTextBox MasBoxEmail;
        private TextBox NameBox;
        private TextBox AdressBox;
        private Label label5;
        private TextBox SurBox;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private ComboBox GenderBox;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private ErrorProvider ErrorEmail;
        private TextBox PhoneBox;
        private ErrorProvider ErrorPhone;
        private PictureBox pictureBox1;
    }
}