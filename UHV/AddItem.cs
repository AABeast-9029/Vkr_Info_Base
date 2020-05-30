using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UHV
{
    public partial class AddItem : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public bool edit = false;
        public string old_id;
        string IdCabinet;
        string [] splitedNumber;
        string getedNumber;
        private int rInvNumber;
        string invNumber;

        public AddItem()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            FillCabinet();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillCabinet()
        {
            string Query = "SELECT * From Cabinets";
            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    SqlDataReader myReader = cmd.ExecuteReader();
                    dt.Load(myReader);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
                cb_Cabinet.DataSource = dt;
                cb_Cabinet.ValueMember = "Id_Cabinets";
                cb_Cabinet.DisplayMember = "Cabinet";
                cb_Cabinet.SelectedIndex = -1;
            }
        }

        public string FindIdCabinet()
        {
            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                SqlCommand sql = new SqlCommand();
                string Query = "SELECT Id_Cabinets From Cabinets Where Cabinet = N'" + cb_Cabinet.Text + "'";
                sql.CommandText = Query;
                sql.Connection = cn;
                IdCabinet = sql.ExecuteScalar().ToString();
            }
            return IdCabinet;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ParsedDate = dtp_ArrivalDate.Value.ToString("yyyy-MM-dd");
            int number = 0;
            string categoryCode = "";
            bool haveCategory = false;

            string Query = "SELECT CategoryNumbers FROM Categories WHERE CategoryName = N'" + tb_ItemName.Text + "'";
            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                SqlCommand sql = new SqlCommand(Query, cn);
                SqlDataReader reader = sql.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    getedNumber = reader.GetString(0);
                    splitedNumber = getedNumber.Split('-');
                    MessageBox.Show(splitedNumber[0] + " " + splitedNumber[1]);
                    haveCategory = true;
                }
            }

            if (haveCategory != false)
            {
                if (!edit)
                {
                    if ((int)num_ItemNumb.Value == 1)
                    {
                        invNumber = (Convert.ToInt32(splitedNumber[1]) + 1).ToString();
                    }
                    else
                    {
                        rInvNumber = Convert.ToInt32(splitedNumber[1]) + (int)num_ItemNumb.Value;
                        int plus = Convert.ToInt32(splitedNumber[1]) + 1;
                        invNumber = plus + "-" + rInvNumber;
                    }

                    if (tb_ItemName.Text.Length != 0 && tb_NomenkNumb.Text.Length != 0 && tb_ItemPrice.Text.Length != 0 && (int)num_ItemNumb.Value != 0 && tb_ItemYear.Text.Length != 0 && cb_Cabinet.Text.Length != 0)
                    {
                        string QueryCheck = "SELECT CategoryCode FROM Categories WHERE CategoryName = N'" + tb_ItemName.Text + "'";
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            SqlCommand sql = new SqlCommand(QueryCheck, cn);
                            number = sql.ExecuteNonQuery();
                            categoryCode = sql.ExecuteScalar().ToString();
                            Close();
                        }

                        string inventoryNumber = categoryCode + " " + invNumber;

                        string QueryAdd = "INSERT INTO Items (InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, Cabinets_Id) " +
                                    "VALUES (N'" + inventoryNumber + "', N'" + tb_ItemName.Text + "', N'" + tb_NomenkNumb.Text + "', '" + (int)num_ItemNumb.Value + "', '" + tb_ItemPrice.Text + "', N'" + tb_ItemYear.Text + "', '" + ParsedDate + "', N'" + IdCabinet + "')";
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            SqlCommand sql = new SqlCommand(QueryAdd, cn);
                            number = sql.ExecuteNonQuery();
                            MessageBox.Show("В информационную базу УМЦ добавлен новый предмет");
                            Close();
                        }


                        string categoryNumber = categoryCode + " " + rInvNumber;

                        string Query1 = String.Format("UPDATE Categories SET CategoryNumbers = N'{0}' WHERE CategoryName = N'{1}'",
                                    categoryNumber, tb_ItemName.Text);
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            SqlCommand sql = new SqlCommand(Query1, cn);
                            number = sql.ExecuteNonQuery();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены!");
                    }
                }
                else
                {
                    if ((int)num_ItemNumb.Value == 1)
                    {
                        invNumber = (Convert.ToInt32(splitedNumber[1]) + 1).ToString();
                    }
                    else
                    {
                        rInvNumber = Convert.ToInt32(splitedNumber[1]) + (int)num_ItemNumb.Value;
                        int plus = Convert.ToInt32(splitedNumber[1]) + 1;
                        invNumber = plus + "-" + rInvNumber;
                    }

                    if (tb_ItemName.Text.Length != 0 && tb_NomenkNumb.Text.Length != 0 && tb_ItemPrice.Text.Length != 0 && (int)num_ItemNumb.Value != 0 && tb_ItemYear.Text.Length != 0 && cb_Cabinet.Text.Length != 0)
                    {
                        string QueryCheck = "SELECT CategoryCode FROM Categories WHERE CategoryName = N'" + tb_ItemName.Text + "'";
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            SqlCommand sql = new SqlCommand(QueryCheck, cn);
                            number = sql.ExecuteNonQuery();
                            categoryCode = sql.ExecuteScalar().ToString();
                            Close();
                        }

                        string inventoryNumber = categoryCode + " " + invNumber;

                        string QueryEdit = String.Format("UPDATE Items SET InvNumb = N'{0}', ItemName = N'{1}', NomenkNumb = N'{2}'," +
                        "ItemNumb = N'{3}', ItemPrice = N'{4}', ItemYear= N'{5}', ItemArrDate= N'{6}', Cabinets_Id = N'{7}' WHERE Id_Items = N'{8}'",
                        inventoryNumber, tb_ItemName.Text, tb_NomenkNumb.Text, (int)num_ItemNumb.Value, tb_ItemPrice.Text, tb_ItemYear.Text, ParsedDate, IdCabinet, old_id);
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            SqlCommand command = new SqlCommand(QueryEdit, cn);
                            int h = command.ExecuteNonQuery();
                            if (h > 0)
                            {
                                MessageBox.Show("Информация изменена");
                                btnAdd.Text = "Добавить";
                                AddItem.ActiveForm.Text = "Добавление данных";
                                Close();
                            }
                        }


                        string categoryNumber = categoryCode + " " + rInvNumber;

                        string Query1 = String.Format("UPDATE Categories SET CategoryNumbers = N'{0}' WHERE CategoryName = N'{1}'",
                                    categoryNumber, tb_ItemName.Text);
                        using (var cn = new SqlConnection(Connection.Connect))
                        {
                            cn.Open();
                            SqlCommand sql = new SqlCommand(Query1, cn);
                            number = sql.ExecuteNonQuery();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Такой категории нету в информационной системе!");
            }
        }

        private void tb_ItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46) //цифры, backspace и точка
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tb_ItemYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры и backspace
            {
                e.Handled = true;
            }
        }

        private void cb_Cabinet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FindIdCabinet();
        }
    }
}
