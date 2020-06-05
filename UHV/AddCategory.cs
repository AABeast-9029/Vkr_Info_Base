using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHV
{
    public partial class AddCategory : Form
    {
        bool haveCategoryName, haveCategoryCode = false;

        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCategoryCode_TextChanged(object sender, EventArgs e)
        {
            tbCategoryNumb.Text = tbCategoryCode.Text + " 0";
        }

        private void tbCategoryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, backspace
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = 0;

            string QueryCheckName = "SELECT CategoryName FROM Categories WHERE CategoryName = N'" + tbCategoryName.Text + "'";
            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                SqlCommand sql = new SqlCommand(QueryCheckName, cn);
                SqlDataReader reader = sql.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Такая категория уже имееться в информационной системе!");
                    haveCategoryName = true;
                }
            }

            string QueryCheckCode = "SELECT CategoryCode FROM Categories WHERE CategoryCode = N'" + tbCategoryCode.Text + "'";
            using (var cn = new SqlConnection(Connection.Connect))
            {

                cn.Open();
                SqlCommand sql = new SqlCommand(QueryCheckCode, cn);
                SqlDataReader reader = sql.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Такой код категории уже имееться в информационной системе!");
                    haveCategoryCode = true;
                }
                Close();
            }

            if (haveCategoryName != true && haveCategoryCode != true)
            {
                string QueryAdd = "INSERT INTO Categories (CategoryName, CategoryCode, CategoryNumbers) " +
                                    "VALUES (N'" + tbCategoryName.Text + "', N'" + tbCategoryCode.Text + "', N'" + tbCategoryNumb.Text + "')";
                using (var cn = new SqlConnection(Connection.Connect))
                {
                    cn.Open();
                    SqlCommand sql = new SqlCommand(QueryAdd, cn);
                    number = sql.ExecuteNonQuery();
                    MessageBox.Show("В информационную базу УМЦ добавлена новая категория");
                    Close();
                }
            }
        }
    }
}
