using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string campoPlaca = txtPlaca.Text;
            int controleLinhasAfetadas = 0;

            string dadosConexao = 
                "server=localhost;user=root;password=;database=db_carros_projeto_integrador";
            using (MySqlConnection conn = new MySqlConnection(dadosConexao) )
            {// utilizo das informações
                conn.Open();
                string scriptInsert = "INSERT INTO tb_carros (placa) VALUE (@placa)"; 

                using (MySqlCommand comando = new MySqlCommand(scriptInsert,conn))
                {
                    comando.Parameters.AddWithValue("@placa", campoPlaca);

                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }//MysqlConnection
            if (controleLinhasAfetadas > 0){
                MessageBox.Show("Dados salvo com sucesso!");
            } else
            {
                MessageBox.Show("Ops, Algo deu errado!!!");
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
