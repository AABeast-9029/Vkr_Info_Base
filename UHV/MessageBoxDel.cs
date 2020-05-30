using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UHV
{
    public partial class MessageBoxDel : Form
    {
        public string SelectedRow = " ";
        public bool haveArt;

        public MessageBoxDel()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(num_CountItems.Value) != 0 || rtb_ReazonDel.Text == " ")
            {
                string WOI_InvNumb = " ", WOI_ItemName = " ", WOI_NomenkNumb = " ", WOI_ItemArrDate = " ";
                int WOI_ItemNumb = 0, WOI_ItemPlace = 0, WOI_ItemYear = 0;
                decimal WOI_ItemPrice = 0;

                if (haveArt)
                {
                    DialogResult dr = MessageBox.Show("Вы уверены, что хотите списать предмет?\n" +
                            "предмет из информационной системы?", "Подтверждение действия",
                            MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        string Query = "SELECT Id_Items, InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, Cabinets_Id From Items Where Id_Items = '" + SelectedRow + "'";
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            DataTable dt = new DataTable();
                            SqlCommand cmd = new SqlCommand(Query, cn);
                            SqlDataReader myReader = cmd.ExecuteReader();
                            while (myReader.Read())
                            {
                                WOI_InvNumb = myReader.GetString(1);
                                WOI_ItemName = myReader.GetString(2);
                                WOI_NomenkNumb = myReader.GetString(3);
                                WOI_ItemNumb = myReader.GetInt32(4);
                                WOI_ItemPrice = myReader.GetDecimal(5);
                                WOI_ItemYear = myReader.GetInt32(6);
                                WOI_ItemArrDate = myReader.GetDateTime(7).ToString("yyyy-MM-dd");
                                WOI_ItemPlace = myReader.GetInt32(8);
                            }
                        }

                        int EditedCountItem = WOI_ItemNumb - Convert.ToInt32(num_CountItems.Value);

                        if (EditedCountItem != 0)
                        {
                            if (EditedCountItem < 0)
                            {
                                MessageBox.Show("Такого количества предметов нету!");
                            }
                            else
                            {
                                string Query1 = "INSERT INTO WrittenOffItems (InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrdate, WrittenCabinet_Id, WrittReason) " +
                                        "VALUES (N'" + WOI_InvNumb + "', N'" + WOI_ItemName + "', N'" + WOI_NomenkNumb + "', '" + num_CountItems.Value + "', '" + WOI_ItemPrice + "', '" + WOI_ItemYear + "', N'" + WOI_ItemArrDate + "', N'" + WOI_ItemPlace + "', N'" + rtb_ReazonDel.Text + "')";
                                using (var cn = new SqlConnection(Connection.Connect))
                                {
                                    cn.Open();
                                    SqlCommand command = new SqlCommand(Query1, cn);
                                    int number = command.ExecuteNonQuery();
                                }

                                string Query2 = String.Format("UPDATE Items SET InvNumb = N'{0}', ItemName = N'{1}', NomenkNumb = N'{2}'," +
                                "ItemNumb = N'{3}', ItemPrice = N'{4}', ItemArrDate= N'{5}', ItemYear= N'{6}', Cabinets_Id = N'{7}' WHERE Id_Items = N'{8}'",
                                WOI_InvNumb, WOI_ItemName, WOI_NomenkNumb, EditedCountItem, WOI_ItemPrice, WOI_ItemArrDate, WOI_ItemYear, WOI_ItemPlace, SelectedRow);

                                using (var cn = new SqlConnection(Connection.Connect))
                                {
                                    cn.Open();
                                    SqlCommand command = new SqlCommand(Query2, cn);
                                    int number = command.ExecuteNonQuery();
                                    if (number > 0)
                                    {
                                        MessageBox.Show("Предмет списан!");
                                    }
                                }
                            }
                        }
                        else
                        {
                            string Query1 = "INSERT INTO WrittenOffItems (InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, WrittenCabinet_Id, WrittReason) " +
                                       "VALUES (N'" + WOI_InvNumb + "', N'" + WOI_ItemName + "', N'" + WOI_NomenkNumb + "', '" + num_CountItems.Value + "', '" + WOI_ItemPrice + "', N'" + WOI_ItemArrDate + "', '" + WOI_ItemYear + "', N'" + WOI_ItemPlace + "', N'" + rtb_ReazonDel.Text + "')";
                            using (var cn = new SqlConnection(Connection.Connect))
                            {
                                cn.Open();
                                SqlCommand command = new SqlCommand(Query1, cn);
                                int number = command.ExecuteNonQuery();
                            }

                            string Query2 = "DELETE FROM Items Where Id_Items = '" + SelectedRow + "'";

                            using (var cn = new SqlConnection(Connection.Connect))
                            {
                                cn.Open();
                                SqlCommand command = new SqlCommand(Query2, cn);
                                int number = command.ExecuteNonQuery();
                                if (number > 0)
                                {
                                    MessageBox.Show("Предмет списан!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Данных нет или они не выбраны");
                }

                Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали количество списываемых предметов или не указали причину!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
