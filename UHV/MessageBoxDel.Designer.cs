namespace UHV
{
    partial class MessageBoxDel
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
            this.l_CountItems = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.num_CountItems = new System.Windows.Forms.NumericUpDown();
            this.rtb_ReazonDel = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountItems)).BeginInit();
            this.SuspendLayout();
            // 
            // l_CountItems
            // 
            this.l_CountItems.AutoSize = true;
            this.l_CountItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_CountItems.Location = new System.Drawing.Point(12, 9);
            this.l_CountItems.Name = "l_CountItems";
            this.l_CountItems.Size = new System.Drawing.Size(442, 20);
            this.l_CountItems.TabIndex = 0;
            this.l_CountItems.Text = "Укажите количество предметов для списания и причину";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(348, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 33);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Списать";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // num_CountItems
            // 
            this.num_CountItems.Location = new System.Drawing.Point(127, 47);
            this.num_CountItems.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_CountItems.Name = "num_CountItems";
            this.num_CountItems.Size = new System.Drawing.Size(138, 20);
            this.num_CountItems.TabIndex = 1;
            // 
            // rtb_ReazonDel
            // 
            this.rtb_ReazonDel.Location = new System.Drawing.Point(16, 73);
            this.rtb_ReazonDel.Name = "rtb_ReazonDel";
            this.rtb_ReazonDel.Size = new System.Drawing.Size(326, 73);
            this.rtb_ReazonDel.TabIndex = 16;
            this.rtb_ReazonDel.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(348, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MessageBoxDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 153);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtb_ReazonDel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.num_CountItems);
            this.Controls.Add(this.l_CountItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MessageBoxDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списание";
            ((System.ComponentModel.ISupportInitialize)(this.num_CountItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_CountItems;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown num_CountItems;
        private System.Windows.Forms.RichTextBox rtb_ReazonDel;
        private System.Windows.Forms.Button btnExit;
    }
}