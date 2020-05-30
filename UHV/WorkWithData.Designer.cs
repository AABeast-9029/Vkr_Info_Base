namespace UHV
{
    partial class WorkWithData
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_Numb = new System.Windows.Forms.Label();
            this.l_Price = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.btn_Chose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l_FilterInvNumber = new System.Windows.Forms.Label();
            this.cb_FilterInvNumber = new System.Windows.Forms.ComboBox();
            this.l_FilterNomNumber = new System.Windows.Forms.Label();
            this.cb_FilterNomNumber = new System.Windows.Forms.ComboBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 72);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(727, 254);
            this.dgvData.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(14, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(141, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Списать";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(272, 398);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 41);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(519, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Location = new System.Drawing.Point(401, 398);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 41);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_Numb
            // 
            this.l_Numb.AutoSize = true;
            this.l_Numb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Numb.Location = new System.Drawing.Point(14, 338);
            this.l_Numb.Name = "l_Numb";
            this.l_Numb.Size = new System.Drawing.Size(156, 20);
            this.l_Numb.TabIndex = 17;
            this.l_Numb.Text = "Единиц предметов";
            // 
            // l_Price
            // 
            this.l_Price.AutoSize = true;
            this.l_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Price.Location = new System.Drawing.Point(288, 338);
            this.l_Price.Name = "l_Price";
            this.l_Price.Size = new System.Drawing.Size(78, 20);
            this.l_Price.TabIndex = 18;
            this.l_Price.Text = "На сумму";
            // 
            // cb_Tables
            // 
            this.cb_Tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Items.AddRange(new object[] {
            "Предметы",
            "Списаные предметы"});
            this.cb_Tables.Location = new System.Drawing.Point(488, 345);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(151, 28);
            this.cb_Tables.TabIndex = 19;
            // 
            // btn_Chose
            // 
            this.btn_Chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Chose.Location = new System.Drawing.Point(645, 338);
            this.btn_Chose.Name = "btn_Chose";
            this.btn_Chose.Size = new System.Drawing.Size(94, 41);
            this.btn_Chose.TabIndex = 20;
            this.btn_Chose.Text = "Выбрать";
            this.btn_Chose.UseVisualStyleBackColor = true;
            this.btn_Chose.Click += new System.EventHandler(this.btn_Chose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фильтр";
            // 
            // l_FilterInvNumber
            // 
            this.l_FilterInvNumber.AutoSize = true;
            this.l_FilterInvNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_FilterInvNumber.Location = new System.Drawing.Point(90, 9);
            this.l_FilterInvNumber.Name = "l_FilterInvNumber";
            this.l_FilterInvNumber.Size = new System.Drawing.Size(163, 20);
            this.l_FilterInvNumber.TabIndex = 23;
            this.l_FilterInvNumber.Text = "Инвентарный номер";
            // 
            // cb_FilterInvNumber
            // 
            this.cb_FilterInvNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterInvNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_FilterInvNumber.FormattingEnabled = true;
            this.cb_FilterInvNumber.Location = new System.Drawing.Point(95, 32);
            this.cb_FilterInvNumber.Name = "cb_FilterInvNumber";
            this.cb_FilterInvNumber.Size = new System.Drawing.Size(140, 28);
            this.cb_FilterInvNumber.TabIndex = 24;
            // 
            // l_FilterNomNumber
            // 
            this.l_FilterNomNumber.AutoSize = true;
            this.l_FilterNomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_FilterNomNumber.Location = new System.Drawing.Point(288, 9);
            this.l_FilterNomNumber.Name = "l_FilterNomNumber";
            this.l_FilterNomNumber.Size = new System.Drawing.Size(191, 20);
            this.l_FilterNomNumber.TabIndex = 25;
            this.l_FilterNomNumber.Text = "Номенклатурный номер";
            // 
            // cb_FilterNomNumber
            // 
            this.cb_FilterNomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterNomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_FilterNomNumber.FormattingEnabled = true;
            this.cb_FilterNomNumber.Location = new System.Drawing.Point(292, 32);
            this.cb_FilterNomNumber.Name = "cb_FilterNomNumber";
            this.cb_FilterNomNumber.Size = new System.Drawing.Size(140, 28);
            this.cb_FilterNomNumber.TabIndex = 26;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Filter.Location = new System.Drawing.Point(645, 21);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(94, 41);
            this.btn_Filter.TabIndex = 27;
            this.btn_Filter.Text = "Выбрать";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // WorkWithData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.cb_FilterNomNumber);
            this.Controls.Add(this.l_FilterNomNumber);
            this.Controls.Add(this.cb_FilterInvNumber);
            this.Controls.Add(this.l_FilterInvNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Chose);
            this.Controls.Add(this.cb_Tables);
            this.Controls.Add(this.l_Price);
            this.Controls.Add(this.l_Numb);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WorkWithData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с данными";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_Numb;
        private System.Windows.Forms.Label l_Price;
        protected internal System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cb_Tables;
        private System.Windows.Forms.Button btn_Chose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_FilterInvNumber;
        private System.Windows.Forms.ComboBox cb_FilterInvNumber;
        private System.Windows.Forms.Label l_FilterNomNumber;
        private System.Windows.Forms.ComboBox cb_FilterNomNumber;
        private System.Windows.Forms.Button btn_Filter;
    }
}

