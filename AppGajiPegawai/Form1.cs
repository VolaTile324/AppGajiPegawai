using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace AppGajiPegawai
{
    public partial class Form1 : Form
    {
        OleDbConnection connectdb = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            ConnectionSet connectString = new ConnectionSet();
            connectdb.ConnectionString = connectString.conString;
        }

        string Query;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
            GetGolongan();
            GenderPegawai.Text = "Laki-Laki";
            GolPegawai.Text = "1A";
            SettingGolPegawai.Text = "1A";
        }

        private void GetData()
        {
            connectdb.Open();
            OleDbCommand command = connectdb.CreateCommand();
            command.Connection = connectdb;
            Query = "SELECT DataPegawai.NIK, DataPegawai.NamaPegawai, DataPegawai.JenisKelamin, DataPegawai.GolonganPegawai, DataGolongan.DataGaji, DataPegawai.Tunjangan, DataPegawai.Potongan, [DataGolongan.DataGaji]+[DataPegawai.Tunjangan]-[DataPegawai.Potongan] " +
                "AS TotalGaji FROM DataGolongan INNER JOIN DataPegawai ON DataGolongan.DaftarGolongan = DataPegawai.GolonganPegawai;";
            command.CommandText = Query;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            int rowcount = ds.Tables[0].Rows.Count;
            tampilanPegawai.Rows.Add(rowcount);

            int num = 0;
            for (int i = 0; i < rowcount; i++)
            {
                num = num + 1;
                DataRow row = ds.Tables[0].Rows[i];
                tampilanPegawai.Rows[i].Cells[0].Value = row.ItemArray.GetValue(0).ToString();
                tampilanPegawai.Rows[i].Cells[1].Value = row.ItemArray.GetValue(1).ToString();
                tampilanPegawai.Rows[i].Cells[2].Value = row.ItemArray.GetValue(2).ToString();
                tampilanPegawai.Rows[i].Cells[3].Value = row.ItemArray.GetValue(3).ToString();
                tampilanPegawai.Rows[i].Cells[4].Value = Convert.ToDecimal(row.ItemArray.GetValue(4).ToString());
                tampilanPegawai.Rows[i].Cells[5].Value = Convert.ToDecimal(row.ItemArray.GetValue(5).ToString());
                tampilanPegawai.Rows[i].Cells[6].Value = Convert.ToDecimal(row.ItemArray.GetValue(6).ToString());
                tampilanPegawai.Rows[i].Cells[7].Value = Convert.ToDecimal(row.ItemArray.GetValue(7).ToString());
            }
            tampilanPegawai.Rows[0].Visible = false;
            tampilanPegawai.Columns[4].DefaultCellStyle.Format = "C0";
            tampilanPegawai.Columns[5].DefaultCellStyle.Format = "C0";
            tampilanPegawai.Columns[6].DefaultCellStyle.Format = "C0";
            tampilanPegawai.Columns[7].DefaultCellStyle.Format = "C0";

            connectdb.Close();
        }

        private void GetGolongan()
        {
            connectdb.Open();
            OleDbCommand command = connectdb.CreateCommand();
            command.Connection = connectdb;
            Query = "SELECT DaftarGolongan, DataGaji FROM DataGolongan;";
            command.CommandText = Query;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            int rowcount = ds.Tables[0].Rows.Count;
            tampilanGolongan.Rows.Add(rowcount);

            int num = 0;
            for (int i = 0; i < rowcount; i++)
            {
                num = num + 1;
                DataRow row = ds.Tables[0].Rows[i];
                tampilanGolongan.Rows[i].Cells[0].Value = row.ItemArray.GetValue(0).ToString();
                tampilanGolongan.Rows[i].Cells[1].Value = Convert.ToDecimal(row.ItemArray.GetValue(1).ToString());
            }
            tampilanGolongan.Columns[1].DefaultCellStyle.Format = "C0";

            connectdb.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textTunjangan.Text == String.Empty)
            {
                textTunjangan.Text = "0";
            }

            if(textPotongan.Text == String.Empty)
            { 
                textPotongan.Text = "0";
            }

            try
            {
                connectdb.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectdb;
                Query = "INSERT INTO `DataPegawai` (`NIK`, `NamaPegawai`, `JenisKelamin`, `GolonganPegawai`, `Tunjangan`, `Potongan`)" +
                    "VALUES ('" + textNIK.Text.ToString() + "', '" + textNama.Text.ToString() + "', '" + GenderPegawai.Text.ToString() + "', '" + GolPegawai.Text.ToString() + "', '" + textTunjangan.Text.ToString() + "', '" + textPotongan.Text.ToString() + "');";
                command.CommandText = Query;
                
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan!");
                connectdb.Close();

                textNIK.Clear();
                textNama.Clear();
                textTunjangan.Clear();
                textPotongan.Clear();

                tampilanPegawai.Rows.Clear();
                tampilanGolongan.Rows.Clear();
                GetData();
                GetGolongan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
                connectdb.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(textNIK.Text == String.Empty)
            {
                MessageBox.Show("Isi NIK terlebih dahulu!");
            }
            else
            {
                if (textTunjangan.Text == String.Empty)
                {
                    textTunjangan.Text = "0";
                }

                if (textPotongan.Text == String.Empty)
                {
                    textPotongan.Text = "0";
                }

                try
                {
                    connectdb.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectdb;
                    Query = "UPDATE `DataPegawai` SET NamaPegawai = '" + textNama.Text.ToString() + "', JenisKelamin = '" + GenderPegawai.Text.ToString() + "', " +
                        "GolonganPegawai = '" + GolPegawai.Text.ToString() + "', Tunjangan = '" + textTunjangan.Text.ToString() + "', Potongan = '" + textPotongan.Text.ToString() + "' " +
                        "WHERE NIK = '" + textNIK.Text.ToString() + "';";
                    command.CommandText = Query;

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diubah!");
                    connectdb.Close();

                    textNIK.Clear();
                    textNama.Clear();
                    textTunjangan.Clear();
                    textPotongan.Clear();

                    tampilanPegawai.Rows.Clear();
                    tampilanGolongan.Rows.Clear();
                    GetData();
                    GetGolongan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                    connectdb.Close();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textNIK.Text == String.Empty || textNIK.Text == "0")
            {
                MessageBox.Show("Gunakan NIK untuk menghapus!");
            }
            else
            {
                try
                {
                    connectdb.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectdb;
                    Query = "DELETE FROM DataPegawai WHERE NIK = '" + textNIK.Text.ToString() + "';";
                    command.CommandText = Query;

                    command.ExecuteNonQuery();
                    MessageBox.Show("Penghapusan berhasil!");
                    connectdb.Close();

                    textNIK.Clear();
                    textNama.Clear();
                    textTunjangan.Clear();
                    textPotongan.Clear();

                    tampilanPegawai.Rows.Clear();
                    tampilanGolongan.Rows.Clear();
                    GetData();
                    GetGolongan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                    connectdb.Close();
                }
            }
        }

        private void textSetGaji_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonSetGaji_Click(object sender, EventArgs e)
        {
            if (textSetGaji.Text == String.Empty)
            {
                MessageBox.Show("Isi Gaji Pokok yang ingin ditetapkan!");
            }
            else
            {
                try
                {
                    connectdb.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectdb;
                    Query = "UPDATE `DataGolongan` SET DataGaji = '" + textSetGaji.Text.ToString() + "' " + 
                        "WHERE DaftarGolongan = '" + SettingGolPegawai.Text.ToString() + "';";
                    command.CommandText = Query;

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diubah!");
                    connectdb.Close();

                    textSetGaji.Clear();

                    tampilanPegawai.Rows.Clear();
                    tampilanGolongan.Rows.Clear();
                    GetData();
                    GetGolongan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                    connectdb.Close();
                }
            }
        }
    }
}
