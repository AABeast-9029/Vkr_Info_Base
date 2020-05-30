using DGVPrinterHelper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace UHV
{
    public partial class WorkWithData : Form
    {
        public bool haveArt;
        int CountDelItems;

        public int CountDelItem { get => CountDelItems; set => CountDelItems = value; }

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public WorkWithData()
        {
            InitializeComponent();

            FillDataGrid();
            FillFilterInvNumber_NomNumber();
        }

        private void FillDataGrid()
        {
            string Query = "SELECT Id_Items, InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, C.Cabinet FROM Items I" +
                "Inner join Cabinets C on C.Id_Cabinets = Cabinets_Id ";

            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                adapter = new SqlDataAdapter(Query, cn);

                ds = new DataSet();
                adapter.Fill(ds, "Items");
                dgvData.DataSource = ds.Tables[0];
                dgvData.Columns["Id_Items"].Visible = false;
                dgvData.Columns["Id_Items"].ReadOnly = true;
                dgvData.Columns["InvNumb"].ReadOnly = true;
                dgvData.Columns["ItemName"].ReadOnly = true;
                dgvData.Columns["NomenkNumb"].ReadOnly = true;
                dgvData.Columns["ItemNumb"].ReadOnly = true;
                dgvData.Columns["ItemPrice"].ReadOnly = true;
                dgvData.Columns["ItemYear"].ReadOnly = true;
                dgvData.Columns["ItemArrDate"].ReadOnly = true;
                dgvData.Columns["Cabinet"].ReadOnly = true;

                dgvData.Columns[1].HeaderText = "Инвентарный номер";
                dgvData.Columns[2].HeaderText = "Наименование";
                dgvData.Columns[3].HeaderText = "Номенклатурный номер";
                dgvData.Columns[4].HeaderText = "Количество";
                dgvData.Columns[5].HeaderText = "Цена";
                dgvData.Columns[6].HeaderText = "Год выпуска";
                dgvData.Columns[7].HeaderText = "Дата прибытия";
                dgvData.Columns[8].HeaderText = "Аудитория";

                dgvData.Columns[1].Width = 90;
                dgvData.Columns[2].Width = 120;
                dgvData.Columns[3].Width = 110;
                dgvData.Columns[4].Width = 80;
                dgvData.Columns[5].Width = 60;
                dgvData.Columns[6].Width = 80;
                dgvData.Columns[7].Width = 80;
                dgvData.Columns[8].Width = 64;


                DataGridViewCellStyle style = dgvData.ColumnHeadersDefaultCellStyle;
                    style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                SqlCommand command = new SqlCommand(Query, cn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    haveArt = true;
                }
                else
                {
                    haveArt = false;
                }
            }
        }

        private void TableWrittItems()
        {
            string Query = "SELECT Id, InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, C.Cabinet, WrittReason FROM WrittenOffItems W" +
                "Inner join Cabinets C on C.Id_Cabinets = WrittenCabinet_Id ";

            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                adapter = new SqlDataAdapter(Query, cn);

                ds = new DataSet();
                adapter.Fill(ds, "WrittenOffItems");
                dgvData.DataSource = ds.Tables[0];
                dgvData.Columns["Id"].Visible = false;
                dgvData.Columns["Id"].ReadOnly = true;
                dgvData.Columns["ItemName"].ReadOnly = true;
                dgvData.Columns["NomenkNumb"].ReadOnly = true;
                dgvData.Columns["ItemNumb"].ReadOnly = true;
                dgvData.Columns["ItemPrice"].ReadOnly = true;
                dgvData.Columns["ItemYear"].ReadOnly = true;
                dgvData.Columns["ItemArrDate"].ReadOnly = true;
                dgvData.Columns["Cabinet"].ReadOnly = true;
                dgvData.Columns["WrittReason"].ReadOnly = true;

                dgvData.Columns[1].HeaderText = "Наименование";
                dgvData.Columns[2].HeaderText = "Номенклатурный номер";
                dgvData.Columns[3].HeaderText = "Количество";
                dgvData.Columns[4].HeaderText = "Цена";
                dgvData.Columns[5].HeaderText = "Год выпуска";
                dgvData.Columns[6].HeaderText = "Дата прибытия";
                dgvData.Columns[7].HeaderText = "Аудитория";
                dgvData.Columns[8].HeaderText = "Причина списания";

                dgvData.Columns[1].Width = 90;
                dgvData.Columns[2].Width = 120;
                dgvData.Columns[3].Width = 110;
                dgvData.Columns[4].Width = 80;
                dgvData.Columns[5].Width = 60;
                dgvData.Columns[6].Width = 80;
                dgvData.Columns[7].Width = 65;
                dgvData.Columns[8].Width = 110;


                DataGridViewCellStyle style = dgvData.ColumnHeadersDefaultCellStyle;
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void FillFilterInvNumber_NomNumber()
        {
            string Query = "SELECT Id_Items, InvNumb From Items";
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
                cb_FilterInvNumber.DataSource = dt;
                cb_FilterInvNumber.ValueMember = "Id_Items";
                cb_FilterInvNumber.DisplayMember = "InvNumb";
                cb_FilterInvNumber.SelectedIndex = -1;
            }

            string Query1 = "SELECT Id_Items, NomenkNumb From Items";
            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(Query1, cn);
                    SqlDataReader myReader = cmd.ExecuteReader();
                    dt.Load(myReader);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
                cb_FilterNomNumber.DataSource = dt;
                cb_FilterNomNumber.ValueMember = "Id_Items";
                cb_FilterNomNumber.DisplayMember = "NomenkNumb";
                cb_FilterNomNumber.SelectedIndex = -1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem additem = new AddItem();
            additem.ShowDialog();
            FillDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxDel mbd = new MessageBoxDel();

            mbd.SelectedRow = Convert.ToString(dgvData.CurrentRow.Cells[0].Value);
            mbd.haveArt = haveArt;

            mbd.ShowDialog();
            FillDataGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddItem additem = new AddItem();
            additem.edit = true;
            additem.old_id = Convert.ToString(dgvData.CurrentRow.Cells[0].Value);
            additem.tb_ItemName.Text = Convert.ToString(dgvData.CurrentRow.Cells[2].Value);
            additem.tb_NomenkNumb.Text = Convert.ToString(dgvData.CurrentRow.Cells[3].Value);
            additem.num_ItemNumb.Value = Convert.ToInt32(dgvData.CurrentRow.Cells[4].Value);
            additem.tb_ItemPrice.Text = Convert.ToString(dgvData.CurrentRow.Cells[5].Value);
            additem.tb_ItemYear.Text = Convert.ToString(dgvData.CurrentRow.Cells[6].Value);
            additem.dtp_ArrivalDate.Value = Convert.ToDateTime(dgvData.CurrentRow.Cells[7].Value);
            additem.cb_Cabinet.SelectedIndex = -1;
            additem.btnAdd.Text = "Изменить";
            additem.Text = "Изменение данных";
            additem.ShowDialog();

            FillDataGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Текст";
            printer.SubTitle = string.Format("Дата: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Текст";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Connection.Connect))
            {
                cn.Open();
                SqlCommand sql = new SqlCommand();
                string Query = "SELECT SUM(ItemNumb) FROM Items";
                sql.CommandText = Query;
                sql.Connection = cn;
                l_Numb.Text = "Единиц предметов: " + sql.ExecuteScalar().ToString() + " шт";
            }

            //using (var cn = new SqlConnection(Connection.Connect))
            //{
            //    cn.Open();
            //    SqlCommand sql = new SqlCommand();
            //    string Query = "SELECT SUM(ItemPrice) FROM Items";
            //    sql.CommandText = Query;
            //    sql.Connection = cn;
            //    decimal ItemTotalPrice = Convert.ToDecimal(sql.ExecuteScalar().ToString());
            //    l_Price.Text = "На сумму: " + ItemTotalPrice.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU"));
            //}

            if (cb_Tables.SelectedIndex == -1)
            {
                btn_Chose.Enabled = false;
            }
            else
            {
                btn_Chose.Enabled = true;
            }

            if (cb_Tables.Text == "Списаные предметы")
            {
                btn_Filter.Enabled = false;
            }
        }

        private void btn_Chose_Click(object sender, EventArgs e)
        {
            if (cb_Tables.Text == "Предметы")
            {
                FillDataGrid();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else if (cb_Tables.Text == "Списаные предметы")
            {
                TableWrittItems();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали таблицу");
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (cb_FilterInvNumber.Text.Length != 0 && cb_FilterNomNumber.Text.Length != 0)
            {
                string Query = "SELECT Id_Items, InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, C.Cabinet FROM Items I" +
                "Inner join Cabinets C on C.Id_Cabinets = Cabinets_Id " +
                "Where InvNumb = '" + cb_FilterInvNumber.Text + "' and NomenkNumb = '" + cb_FilterNomNumber.Text + "'";

                using (var cn = new SqlConnection(Connection.Connect))
                {
                    cn.Open();
                    adapter = new SqlDataAdapter(Query, cn);

                    ds = new DataSet();
                    adapter.Fill(ds, "Items");
                    dgvData.DataSource = ds.Tables[0];
                    dgvData.Columns["Id_Items"].Visible = false;
                    dgvData.Columns["Id_Items"].ReadOnly = true;
                    dgvData.Columns["InvNumb"].ReadOnly = true;
                    dgvData.Columns["ItemName"].ReadOnly = true;
                    dgvData.Columns["NomenkNumb"].ReadOnly = true;
                    dgvData.Columns["ItemNumb"].ReadOnly = true;
                    dgvData.Columns["ItemPrice"].ReadOnly = true;
                    dgvData.Columns["ItemYear"].ReadOnly = true;
                    dgvData.Columns["ItemArrDate"].ReadOnly = true;
                    dgvData.Columns["Cabinet"].ReadOnly = true;

                    dgvData.Columns[1].HeaderText = "Инвентарный номер";
                    dgvData.Columns[2].HeaderText = "Наименование";
                    dgvData.Columns[3].HeaderText = "Номенклатурный номер";
                    dgvData.Columns[4].HeaderText = "Количество";
                    dgvData.Columns[5].HeaderText = "Цена";
                    dgvData.Columns[6].HeaderText = "Год выпуска";
                    dgvData.Columns[7].HeaderText = "Дата прибытия";
                    dgvData.Columns[8].HeaderText = "Аудитория";


                    dgvData.Columns[1].Width = 90;
                    dgvData.Columns[2].Width = 120;
                    dgvData.Columns[3].Width = 110;
                    dgvData.Columns[4].Width = 80;
                    dgvData.Columns[5].Width = 60;
                    dgvData.Columns[6].Width = 80;
                    dgvData.Columns[7].Width = 80;
                    dgvData.Columns[8].Width = 65;



                    DataGridViewCellStyle style = dgvData.ColumnHeadersDefaultCellStyle;
                    style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            else if (cb_FilterInvNumber.Text.Length != 0)
            {
                string Query = "SELECT Id_Items, InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, C.Cabinet FROM Items I" +
                "Inner join Cabinets C on C.Id_Cabinets = Cabinets_Id " +
                "Where InvNumb = '" + cb_FilterInvNumber.Text + "'";

                using (var cn = new SqlConnection(Connection.Connect))
                {
                    cn.Open();
                    adapter = new SqlDataAdapter(Query, cn);

                    ds = new DataSet();
                    adapter.Fill(ds, "Items");
                    dgvData.DataSource = ds.Tables[0];
                    dgvData.Columns["Id_Items"].Visible = false;
                    dgvData.Columns["Id_Items"].ReadOnly = true;
                    dgvData.Columns["InvNumb"].ReadOnly = true;
                    dgvData.Columns["ItemName"].ReadOnly = true;
                    dgvData.Columns["NomenkNumb"].ReadOnly = true;
                    dgvData.Columns["ItemNumb"].ReadOnly = true;
                    dgvData.Columns["ItemPrice"].ReadOnly = true;
                    dgvData.Columns["ItemYear"].ReadOnly = true;
                    dgvData.Columns["ItemArrDate"].ReadOnly = true;
                    dgvData.Columns["Cabinet"].ReadOnly = true;

                    dgvData.Columns[1].HeaderText = "Инвентарный номер";
                    dgvData.Columns[2].HeaderText = "Наименование";
                    dgvData.Columns[3].HeaderText = "Номенклатурный номер";
                    dgvData.Columns[4].HeaderText = "Количество";
                    dgvData.Columns[5].HeaderText = "Цена";
                    dgvData.Columns[6].HeaderText = "Год выпуска";
                    dgvData.Columns[7].HeaderText = "Дата прибытия";
                    dgvData.Columns[8].HeaderText = "Аудитория";

                    dgvData.Columns[1].Width = 90;
                    dgvData.Columns[2].Width = 120;
                    dgvData.Columns[3].Width = 110;
                    dgvData.Columns[4].Width = 80;
                    dgvData.Columns[5].Width = 60;
                    dgvData.Columns[6].Width = 80;
                    dgvData.Columns[7].Width = 80;
                    dgvData.Columns[8].Width = 65;


                    DataGridViewCellStyle style = dgvData.ColumnHeadersDefaultCellStyle;
                    style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            else if (cb_FilterNomNumber.Text.Length != 0)
            {
                string Query = "SELECT Id_Items, InvNumb, ItemName, NomenkNumb, ItemNumb, ItemPrice, ItemYear, ItemArrDate, C.Cabinet FROM Items I" +
                "Inner join Cabinets C on C.Id_Cabinets = Cabinets_Id " +
                "Where NomenkNumb = '" + cb_FilterNomNumber.Text + "'";

                using (var cn = new SqlConnection(Connection.Connect))
                {
                    cn.Open();
                    adapter = new SqlDataAdapter(Query, cn);

                    ds = new DataSet();
                    adapter.Fill(ds, "Items");
                    dgvData.DataSource = ds.Tables[0];
                    dgvData.Columns["Id_Items"].Visible = false;
                    dgvData.Columns["Id_Items"].ReadOnly = true;
                    dgvData.Columns["InvNumb"].ReadOnly = true;
                    dgvData.Columns["ItemName"].ReadOnly = true;
                    dgvData.Columns["NomenkNumb"].ReadOnly = true;
                    dgvData.Columns["ItemNumb"].ReadOnly = true;
                    dgvData.Columns["ItemPrice"].ReadOnly = true;
                    dgvData.Columns["ItemYear"].ReadOnly = true;
                    dgvData.Columns["ItemArrDate"].ReadOnly = true;
                    dgvData.Columns["Cabinet"].ReadOnly = true;

                    dgvData.Columns[1].HeaderText = "Инвентарный номер";
                    dgvData.Columns[2].HeaderText = "Наименование";
                    dgvData.Columns[3].HeaderText = "Номенклатурный номер";
                    dgvData.Columns[4].HeaderText = "Количество";
                    dgvData.Columns[5].HeaderText = "Цена";
                    dgvData.Columns[6].HeaderText = "Год выпуска";
                    dgvData.Columns[7].HeaderText = "Дата прибытия";
                    dgvData.Columns[8].HeaderText = "Аудитория";

                    dgvData.Columns[1].Width = 90;
                    dgvData.Columns[2].Width = 120;
                    dgvData.Columns[3].Width = 110;
                    dgvData.Columns[4].Width = 80;
                    dgvData.Columns[5].Width = 60;
                    dgvData.Columns[6].Width = 80;
                    dgvData.Columns[7].Width = 80;
                    dgvData.Columns[8].Width = 65;


                    DataGridViewCellStyle style = dgvData.ColumnHeadersDefaultCellStyle;
                    style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            else
            {
                MessageBox.Show("Не выбрана не одна из категорий сортировок!");
            }
        }
    }
}
