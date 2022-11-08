using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite; //Agregamos esta Libreria
using System.Data.SqlClient;

namespace Base_de_SQLite
{
    public partial class Form1 : Form
    {
        //Agregamos la Base de Datos
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        //La Base de Datos se crea en la carpeta DEBUG

        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }

        private void Create_db()
        {
            if(!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using(var sqlite = new SQLiteConnection(@"Data Source="+path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(12));";
                    SQLiteCommand command = new SQLiteCommand(sql,sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("La base de datos no se puede crear");
                return;  
            }
        }

        private void data_show()
        {
            var conn = new SQLiteConnection(cs);
            conn.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private void insertarbutton_Click(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection(cs);
            conn.Open();
            var cmd = new SQLiteCommand(conn);
            try
            {
                cmd.CommandText = "INSERT INTO test(name, id) VALUES(@name, @id)";

                string NAME = textBox1.Text;
                string ID = textBox2.Text;
                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Nombre";
                dataGridView1.Columns[1].Name = "Id";
                string[] row = new string[] { NAME, ID };
                dataGridView1.Rows.Add(row);
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                Console.WriteLine("No se pudo insertar la informacion");
                return;
            }
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection(cs);
            conn.Open();
            var cmd = new SQLiteCommand(conn);
            try
            {
                cmd.CommandText = "DELETE FROM test WHERE name=@Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }catch(Exception)
            {
                Console.WriteLine("No se pudo eliminar la informacion");
            }
        }
    }
}
