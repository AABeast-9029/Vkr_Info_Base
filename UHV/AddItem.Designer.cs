namespace UHV
{
    partial class AddItem
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
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.l_ItemNumb = new System.Windows.Forms.Label();
            this.num_ItemNumb = new System.Windows.Forms.NumericUpDown();
            this.l_ItemName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.l_NomenkNumb = new System.Windows.Forms.Label();
            this.tb_NomenkNumb = new System.Windows.Forms.TextBox();
            this.l_ItemPrice = new System.Windows.Forms.Label();
            this.tb_ItemPrice = new System.Windows.Forms.TextBox();
            this.l_ArrivalDate = new System.Windows.Forms.Label();
            this.dtp_ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.l_ItemPlace = new System.Windows.Forms.Label();
            this.cb_Cabinet = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_ItemYear = new System.Windows.Forms.Label();
            this.tb_ItemYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ItemName.Location = new System.Drawing.Point(267, 14);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(156, 26);
            this.tb_ItemName.TabIndex = 0;
            // 
            // l_ItemNumb
            // 
            this.l_ItemNumb.AutoSize = true;
            this.l_ItemNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ItemNumb.Location = new System.Drawing.Point(17, 80);
            this.l_ItemNumb.Name = "l_ItemNumb";
            this.l_ItemNumb.Size = new System.Drawing.Size(100, 20);
            this.l_ItemNumb.TabIndex = 2;
            this.l_ItemNumb.Text = "Количество";
            // 
            // num_ItemNumb
            // 
            this.num_ItemNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_ItemNumb.Location = new System.Drawing.Point(267, 82);
            this.num_ItemNumb.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_ItemNumb.Name = "num_ItemNumb";
            this.num_ItemNumb.Size = new System.Drawing.Size(156, 26);
            this.num_ItemNumb.TabIndex = 3;
            // 
            // l_ItemName
            // 
            this.l_ItemName.AutoSize = true;
            this.l_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ItemName.Location = new System.Drawing.Point(14, 12);
            this.l_ItemName.Name = "l_ItemName";
            this.l_ItemName.Size = new System.Drawing.Size(122, 20);
            this.l_ItemName.TabIndex = 4;
            this.l_ItemName.Text = "Наименование";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(284, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 41);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(9, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // l_NomenkNumb
            // 
            this.l_NomenkNumb.AutoSize = true;
            this.l_NomenkNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_NomenkNumb.Location = new System.Drawing.Point(14, 47);
            this.l_NomenkNumb.Name = "l_NomenkNumb";
            this.l_NomenkNumb.Size = new System.Drawing.Size(191, 20);
            this.l_NomenkNumb.TabIndex = 17;
            this.l_NomenkNumb.Text = "Номенклатурный номер";
            // 
            // tb_NomenkNumb
            // 
            this.tb_NomenkNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NomenkNumb.Location = new System.Drawing.Point(267, 49);
            this.tb_NomenkNumb.Name = "tb_NomenkNumb";
            this.tb_NomenkNumb.Size = new System.Drawing.Size(156, 26);
            this.tb_NomenkNumb.TabIndex = 18;
            // 
            // l_ItemPrice
            // 
            this.l_ItemPrice.AutoSize = true;
            this.l_ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ItemPrice.Location = new System.Drawing.Point(17, 117);
            this.l_ItemPrice.Name = "l_ItemPrice";
            this.l_ItemPrice.Size = new System.Drawing.Size(48, 20);
            this.l_ItemPrice.TabIndex = 19;
            this.l_ItemPrice.Text = "Цена";
            // 
            // tb_ItemPrice
            // 
            this.tb_ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ItemPrice.Location = new System.Drawing.Point(267, 119);
            this.tb_ItemPrice.Name = "tb_ItemPrice";
            this.tb_ItemPrice.Size = new System.Drawing.Size(156, 26);
            this.tb_ItemPrice.TabIndex = 20;
            this.tb_ItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ItemPrice_KeyPress);
            // 
            // l_ArrivalDate
            // 
            this.l_ArrivalDate.AutoSize = true;
            this.l_ArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ArrivalDate.Location = new System.Drawing.Point(17, 195);
            this.l_ArrivalDate.Name = "l_ArrivalDate";
            this.l_ArrivalDate.Size = new System.Drawing.Size(126, 20);
            this.l_ArrivalDate.TabIndex = 21;
            this.l_ArrivalDate.Text = "Дата прибытия";
            // 
            // dtp_ArrivalDate
            // 
            this.dtp_ArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_ArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ArrivalDate.Location = new System.Drawing.Point(267, 196);
            this.dtp_ArrivalDate.Name = "dtp_ArrivalDate";
            this.dtp_ArrivalDate.Size = new System.Drawing.Size(156, 26);
            this.dtp_ArrivalDate.TabIndex = 22;
            // 
            // l_ItemPlace
            // 
            this.l_ItemPlace.AutoSize = true;
            this.l_ItemPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ItemPlace.Location = new System.Drawing.Point(15, 230);
            this.l_ItemPlace.Name = "l_ItemPlace";
            this.l_ItemPlace.Size = new System.Drawing.Size(238, 20);
            this.l_ItemPlace.TabIndex = 23;
            this.l_ItemPlace.Text = "Местоположение (Аудитория)";
            // 
            // cb_Cabinet
            // 
            this.cb_Cabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Cabinet.FormattingEnabled = true;
            this.cb_Cabinet.Items.AddRange(new object[] {
            "1 корпус",
            "2 корпус",
            "3 корпус",
            "4 корпус",
            "5 корпус"});
            this.cb_Cabinet.Location = new System.Drawing.Point(267, 231);
            this.cb_Cabinet.Name = "cb_Cabinet";
            this.cb_Cabinet.Size = new System.Drawing.Size(156, 28);
            this.cb_Cabinet.TabIndex = 25;
            this.cb_Cabinet.SelectionChangeCommitted += new System.EventHandler(this.cb_Cabinet_SelectionChangeCommitted);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_ItemYear
            // 
            this.l_ItemYear.AutoSize = true;
            this.l_ItemYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ItemYear.Location = new System.Drawing.Point(17, 158);
            this.l_ItemYear.Name = "l_ItemYear";
            this.l_ItemYear.Size = new System.Drawing.Size(103, 20);
            this.l_ItemYear.TabIndex = 26;
            this.l_ItemYear.Text = "Год выпуска";
            // 
            // tb_ItemYear
            // 
            this.tb_ItemYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ItemYear.Location = new System.Drawing.Point(267, 160);
            this.tb_ItemYear.Name = "tb_ItemYear";
            this.tb_ItemYear.Size = new System.Drawing.Size(156, 26);
            this.tb_ItemYear.TabIndex = 27;
            this.tb_ItemYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ItemYear_KeyPress);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 313);
            this.ControlBox = false;
            this.Controls.Add(this.tb_ItemYear);
            this.Controls.Add(this.l_ItemYear);
            this.Controls.Add(this.cb_Cabinet);
            this.Controls.Add(this.l_ItemPlace);
            this.Controls.Add(this.dtp_ArrivalDate);
            this.Controls.Add(this.l_ArrivalDate);
            this.Controls.Add(this.tb_ItemPrice);
            this.Controls.Add(this.l_ItemPrice);
            this.Controls.Add(this.tb_NomenkNumb);
            this.Controls.Add(this.l_NomenkNumb);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.l_ItemName);
            this.Controls.Add(this.num_ItemNumb);
            this.Controls.Add(this.l_ItemNumb);
            this.Controls.Add(this.tb_ItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddItem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление данных";
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_ItemNumb;
        private System.Windows.Forms.Label l_ItemName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label l_NomenkNumb;
        private System.Windows.Forms.Label l_ItemPrice;
        private System.Windows.Forms.Label l_ArrivalDate;
        private System.Windows.Forms.Label l_ItemPlace;
        protected internal System.Windows.Forms.DateTimePicker dtp_ArrivalDate;
        internal System.Windows.Forms.TextBox tb_ItemName;
        internal System.Windows.Forms.NumericUpDown num_ItemNumb;
        internal System.Windows.Forms.TextBox tb_NomenkNumb;
        internal System.Windows.Forms.TextBox tb_ItemPrice;
        protected internal System.Windows.Forms.ComboBox cb_Cabinet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_ItemYear;
        internal System.Windows.Forms.TextBox tb_ItemYear;
        protected internal System.Windows.Forms.Button btnAdd;
    }
}