namespace ShopAccessoriesPC
{
    partial class TovarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TovarForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderTimePick = new System.Windows.Forms.DateTimePicker();
            this.MethBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.butAdd = new System.Windows.Forms.Button();
            this.TovarBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.butCansel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNum)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 112);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бланк товара";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.OrderTimePick);
            this.panel2.Controls.Add(this.MethBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PriceBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CountNum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.TovarBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 340);
            this.panel2.TabIndex = 1;
            // 
            // OrderTimePick
            // 
            this.OrderTimePick.Location = new System.Drawing.Point(51, 157);
            this.OrderTimePick.Name = "OrderTimePick";
            this.OrderTimePick.Size = new System.Drawing.Size(255, 23);
            this.OrderTimePick.TabIndex = 11;
            this.OrderTimePick.ValueChanged += new System.EventHandler(this.OrderTimePick_ValueChanged);
            // 
            // MethBox
            // 
            this.MethBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MethBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethBox.FormattingEnabled = true;
            this.MethBox.Location = new System.Drawing.Point(51, 232);
            this.MethBox.Name = "MethBox";
            this.MethBox.Size = new System.Drawing.Size(255, 24);
            this.MethBox.TabIndex = 10;
            this.MethBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MethBox_DrawItem);
            this.MethBox.SelectedIndexChanged += new System.EventHandler(this.MethBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(74, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Способ отправки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(105, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата выдачи";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(88, 85);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(255, 23);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.Text = "100";
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена";
            // 
            // CountNum
            // 
            this.CountNum.Location = new System.Drawing.Point(88, 45);
            this.CountNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CountNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountNum.Name = "CountNum";
            this.CountNum.Size = new System.Drawing.Size(255, 23);
            this.CountNum.TabIndex = 4;
            this.CountNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountNum.ValueChanged += new System.EventHandler(this.CountNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Olive;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.butAdd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 259);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 81);
            this.panel5.TabIndex = 2;
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Yellow;
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butAdd.Location = new System.Drawing.Point(70, 22);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(214, 40);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            // 
            // TovarBox
            // 
            this.TovarBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TovarBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TovarBox.FormattingEnabled = true;
            this.TovarBox.Location = new System.Drawing.Point(88, 6);
            this.TovarBox.Name = "TovarBox";
            this.TovarBox.Size = new System.Drawing.Size(255, 24);
            this.TovarBox.TabIndex = 1;
            this.TovarBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TovarBox_DrawItem);
            this.TovarBox.SelectedIndexChanged += new System.EventHandler(this.TovarBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Товар";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CommentBox);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(367, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 340);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(87, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Комментарий";
            // 
            // CommentBox
            // 
            this.CommentBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommentBox.Location = new System.Drawing.Point(15, 48);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(329, 207);
            this.CommentBox.TabIndex = 11;
            this.CommentBox.TextChanged += new System.EventHandler(this.CommentBox_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Olive;
            this.panel6.Controls.Add(this.butCansel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 259);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 81);
            this.panel6.TabIndex = 3;
            // 
            // butCansel
            // 
            this.butCansel.BackColor = System.Drawing.Color.Silver;
            this.butCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCansel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butCansel.Location = new System.Drawing.Point(75, 22);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(214, 40);
            this.butCansel.TabIndex = 1;
            this.butCansel.Text = "Отменить";
            this.butCansel.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 452);
            this.panel4.TabIndex = 3;
            // 
            // TovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TovarForm";
            this.Text = "Добавление товаров";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNum)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private ComboBox TovarBox;
        private Panel panel5;
        private Panel panel6;
        private NumericUpDown CountNum;
        private Label label3;
        private Label label4;
        private TextBox PriceBox;
        private Label label5;
        private ComboBox MethBox;
        private Label label6;
        private Label label7;
        private TextBox CommentBox;
        private DateTimePicker OrderTimePick;
        private Button butAdd;
        private Button butCansel;
    }
}