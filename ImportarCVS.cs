﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Inventarios
{
    public partial class ImportarCVS : Form
    {
        MySqlConnection conexion = new MySqlConnection( "datasource=127.0.0.1;port=3306;username=root;password=;database=inventariodsa;");
        double progreso = 0;
        int conteoProgreso = 0;
        int progres=0;


        public ImportarCVS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {

            try
            {
                //Open file dialog, allows you to select a csv file
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        dataGridView1.DataSource = ReadCsv(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //oledb csv parser
        public DataTable ReadCsv(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
                Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                //Execute select query
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select * from [{0}]", new FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand truncar = new MySqlCommand("TRUNCATE TABLE productos;", conexion);
            truncar.ExecuteNonQuery();
            //conexion.Close();
            //conexion.Open();
            MySqlCommand agregar = new MySqlCommand("INSERT INTO productos (codigo, codigo1, codigo2, linea, nombre, paqxcaja, unixcaja, unixdisp) VALUES (?codigo, ?codigo1, ?codigo2, ?linea, ?nombre, ?paqxcaja, ?unixcaja, ?unixdisp)", conexion);
            

            int contador = 0;
            contador = dataGridView1.RowCount;
            MessageBox.Show(Convert.ToString(contador));
            progreso = contador;
            conteoProgreso=0;
            progressBar1.Maximum = contador;

            try
            {
                for (int i = 0; i < contador; i++)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.Add("?codigo", MySqlDbType.Int64).Value = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                    if(dataGridView1.Rows[i].Cells[3].Value != DBNull.Value)
                    {
                        agregar.Parameters.Add("?codigo1", MySqlDbType.Int64).Value = Convert.ToInt64(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        agregar.Parameters.Add("?codigo1", MySqlDbType.Int64).Value = 0;
                    }
                    if (dataGridView1.Rows[i].Cells[4].Value != DBNull.Value)
                    {
                        agregar.Parameters.Add("?codigo2", MySqlDbType.Int64).Value = Convert.ToInt64(dataGridView1.Rows[i].Cells[4].Value);
                    }
                    else
                    {
                        agregar.Parameters.Add("?codigo2", MySqlDbType.Int64).Value = 0;
                    }
                    agregar.Parameters.Add("?linea", MySqlDbType.Int32).Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    agregar.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    agregar.Parameters.Add("?paqxcaja", MySqlDbType.Int32).Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[20].Value);
                    agregar.Parameters.Add("?unixcaja", MySqlDbType.Int32).Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[21].Value);
                    agregar.Parameters.Add("?unixdisp", MySqlDbType.Int32).Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[22].Value);
                    agregar.CommandTimeout = 300;
                    agregar.ExecuteNonQuery();

                    if (progreso >= 0 && progreso > conteoProgreso)
                    {
                        progressBar1.Value = conteoProgreso;
                        conteoProgreso+=1;
                    }
                }

                conexion.Close();
                MessageBox.Show("Exportación exitosa!");
                this.Close();

            }

            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
