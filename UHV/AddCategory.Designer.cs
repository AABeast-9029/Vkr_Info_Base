namespace UHV
{
    partial class AddCategory
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
            this.lCategoryName = new System.Windows.Forms.Label();
            this.lCategoryCode = new System.Windows.Forms.Label();
            this.lCategoryNumb = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbCategoryCode = new System.Windows.Forms.TextBox();
            this.tbCategoryNumb = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCategoryName
            // 
            this.lCategoryName.AutoSize = true;
            this.lCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategoryName.Location = new System.Drawing.Point(11, 17);
            this.lCategoryName.Name = "lCategoryName";
            this.lCategoryName.Size = new System.Drawing.Size(122, 20);
            this.lCategoryName.TabIndex = 0;
            this.lCategoryName.Text = "Наименование";
            // 
            // lCategoryCode
            // 
            this.lCategoryCode.AutoSize = true;
            this.lCategoryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategoryCode.Location = new System.Drawing.Point(12, 49);
            this.lCategoryCode.Name = "lCategoryCode";
            this.lCategoryCode.Size = new System.Drawing.Size(121, 20);
            this.lCategoryCode.TabIndex = 1;
            this.lCategoryCode.Text = "Код категории";
            // 
            // lCategoryNumb
            // 
            this.lCategoryNumb.AutoSize = true;
            this.lCategoryNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategoryNumb.Location = new System.Drawing.Point(12, 82);
            this.lCategoryNumb.Name = "lCategoryNumb";
            this.lCategoryNumb.Size = new System.Drawing.Size(174, 20);
            this.lCategoryNumb.TabIndex = 2;
            this.lCategoryNumb.Text = "Нумеровка категории";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCategoryName.Location = new System.Drawing.Point(216, 11);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(139, 26);
            this.tbCategoryName.TabIndex = 3;
            // 
            // tbCategoryCode
            // 
            this.tbCategoryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCategoryCode.Location = new System.Drawing.Point(216, 43);
            this.tbCategoryCode.Name = "tbCategoryCode";
            this.tbCategoryCode.Size = new System.Drawing.Size(139, 26);
            this.tbCategoryCode.TabIndex = 4;
            this.tbCategoryCode.TextChanged += new System.EventHandler(this.tbCategoryCode_TextChanged);
            this.tbCategoryCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCategoryCode_KeyPress);
            // 
            // tbCategoryNumb
            // 
            this.tbCategoryNumb.Enabled = false;
            this.tbCategoryNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCategoryNumb.Location = new System.Drawing.Point(216, 76);
            this.tbCategoryNumb.Name = "tbCategoryNumb";
            this.tbCategoryNumb.Size = new System.Drawing.Size(139, 26);
            this.tbCategoryNumb.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 41);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(216, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 41);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 167);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCategoryNumb);
            this.Controls.Add(this.tbCategoryCode);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.lCategoryNumb);
            this.Controls.Add(this.lCategoryCode);
            this.Controls.Add(this.lCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCategoryName;
        private System.Windows.Forms.Label lCategoryCode;
        private System.Windows.Forms.Label lCategoryNumb;
        private System.Windows.Forms.TextBox tbCategoryCode;
        private System.Windows.Forms.TextBox tbCategoryNumb;
        protected internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        protected internal System.Windows.Forms.TextBox tbCategoryName;
    }
}