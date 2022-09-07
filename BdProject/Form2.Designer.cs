namespace BdProject
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tarif_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif_network_experince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count_of_clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.NumericUpDown();
            this.ToSmt = new System.Windows.Forms.NumericUpDown();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Список Послуг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add_name,
            this.add_price});
            this.dataGridView1.Location = new System.Drawing.Point(35, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 459);
            this.dataGridView1.TabIndex = 15;
            // 
            // add_name
            // 
            this.add_name.HeaderText = "Ім\'я послуги";
            this.add_name.MinimumWidth = 9;
            this.add_name.Name = "add_name";
            this.add_name.Width = 175;
            // 
            // add_price
            // 
            this.add_price.HeaderText = "Ціна послуги";
            this.add_price.MinimumWidth = 9;
            this.add_price.Name = "add_price";
            this.add_price.Width = 175;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1065, -3);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 40);
            this.exit.TabIndex = 19;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Розрахувати за ціною";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Список абонентов по тарифу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(301, 29);
            this.button4.TabIndex = 22;
            this.button4.Text = "Найпоширеніні тарифи";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(927, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 31);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Звонки";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client_Name,
            this.userSurname,
            this.balance});
            this.dataGridView2.Location = new System.Drawing.Point(35, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1068, 459);
            this.dataGridView2.TabIndex = 24;
            // 
            // client_Name
            // 
            this.client_Name.HeaderText = "Ім\'я кліенту";
            this.client_Name.MinimumWidth = 10;
            this.client_Name.Name = "client_Name";
            this.client_Name.Width = 200;
            // 
            // userSurname
            // 
            this.userSurname.HeaderText = "Прізвище Кл.";
            this.userSurname.MinimumWidth = 10;
            this.userSurname.Name = "userSurname";
            this.userSurname.Width = 200;
            // 
            // balance
            // 
            this.balance.HeaderText = "Баланс на счету";
            this.balance.MinimumWidth = 9;
            this.balance.Name = "balance";
            this.balance.Width = 175;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarif_id,
            this.tarif_name,
            this.tarif_price,
            this.popularity,
            this.tarif_network_experince,
            this.Count_of_clients});
            this.dataGridView3.Location = new System.Drawing.Point(35, 148);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1043, 459);
            this.dataGridView3.TabIndex = 25;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.dataGridView3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            // 
            // tarif_id
            // 
            this.tarif_id.HeaderText = "Column1";
            this.tarif_id.MinimumWidth = 9;
            this.tarif_id.Name = "tarif_id";
            this.tarif_id.Visible = false;
            // 
            // tarif_name
            // 
            this.tarif_name.HeaderText = "Назв. Тарифа";
            this.tarif_name.MinimumWidth = 10;
            this.tarif_name.Name = "tarif_name";
            // 
            // tarif_price
            // 
            this.tarif_price.HeaderText = "Цена тарифа";
            this.tarif_price.MinimumWidth = 9;
            this.tarif_price.Name = "tarif_price";
            // 
            // popularity
            // 
            this.popularity.HeaderText = "Популярность";
            this.popularity.MinimumWidth = 10;
            this.popularity.Name = "popularity";
            // 
            // tarif_network_experince
            // 
            this.tarif_network_experince.HeaderText = "Дата регистрации";
            this.tarif_network_experince.MinimumWidth = 9;
            this.tarif_network_experince.Name = "tarif_network_experince";
            // 
            // Count_of_clients
            // 
            this.Count_of_clients.HeaderText = "Количество клиентов";
            this.Count_of_clients.MinimumWidth = 9;
            this.Count_of_clients.Name = "Count_of_clients";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(691, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 49);
            this.button5.TabIndex = 26;
            this.button5.Text = "Список абонентів";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(886, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 49);
            this.button6.TabIndex = 27;
            this.button6.Text = "Список абонентів, що не оплачують";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // From
            // 
            this.From.AccessibleName = "";
            this.From.Location = new System.Drawing.Point(307, 84);
            this.From.Margin = new System.Windows.Forms.Padding(2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(68, 22);
            this.From.TabIndex = 28;
            // 
            // ToSmt
            // 
            this.ToSmt.Location = new System.Drawing.Point(307, 113);
            this.ToSmt.Margin = new System.Windows.Forms.Padding(2);
            this.ToSmt.Name = "ToSmt";
            this.ToSmt.Size = new System.Drawing.Size(68, 22);
            this.ToSmt.TabIndex = 29;
            this.ToSmt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.status});
            this.dataGridView4.Location = new System.Drawing.Point(35, 198);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 33;
            this.dataGridView4.Size = new System.Drawing.Size(1068, 459);
            this.dataGridView4.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ім\'я кліенту";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Прізвище Кл.";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Баланс на счету";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // status
            // 
            this.status.HeaderText = "Статус договору";
            this.status.MinimumWidth = 9;
            this.status.Name = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label1.Location = new System.Drawing.Point(264, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Від ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label2.Location = new System.Drawing.Point(265, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "До";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 49);
            this.button7.TabIndex = 33;
            this.button7.Text = "Список Тарифов";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(588, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 93);
            this.button8.TabIndex = 35;
            this.button8.Text = "График";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 742);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToSmt);
            this.Controls.Add(this.From);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_price;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown From;
        private System.Windows.Forms.NumericUpDown ToSmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn popularity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif_network_experince;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count_of_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}