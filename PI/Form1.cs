using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string DADOS_CONEXAO =
                "server=localhost;user=root;password=;database=db_carros_projeto_integrador";

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string campoPlaca = txtPlaca.Text;
            string campoModelo = txtModelo.Text;
            string campoMarca = txtMarca.Text;
            string campoData = dtpAno.Text;
            string campoCor = txtCor.Text;
            string campoQuilometragem = nudQuilometragem.Value.ToString();

            DateTime dataConvertida = DateTime.Parse(campoData); 

            int controleLinhasAfetadas = 0;

            
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO) )
            {// utilizo das informações
                conn.Open();
                string scriptInsert = "INSERT INTO tb_carros (placa, modelo, marca, ano, cor, quilometragem) " +
                      "VALUES (@placa, @modelo, @marca, @ano, @cor, @km)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert,conn))
                {
                    comando.Parameters.AddWithValue("@placa", campoPlaca);
                    comando.Parameters.AddWithValue("@modelo", campoModelo);
                    comando.Parameters.AddWithValue("@marca", campoMarca);
                    comando.Parameters.AddWithValue("@ano", campoData); // Se for int, o banco aceita direto
                    comando.Parameters.AddWithValue("@cor", campoCor);
                    comando.Parameters.AddWithValue("@km", campoQuilometragem); // Passando o decimal do NumericUpDown
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


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtPlaca.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtCor.Clear();

            dtpAno.Value = DateTime.Now;

            nudQuilometragem.Value = 0;

            txtPlaca.Focus();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {

                conn.Open();
                string idConsulta = txtPlaca.Text;
                string scriptConsultaIndividual = "SELECT * FROM tb_carros WHERE = @id_carro";

                using (MySqlCommand comando = new MySqlCommand(scriptConsultaIndividual, conn))
                {
                    comando.Parameters.AddWithValue("@id_carro", idConsulta);

                    var dadosResultado = comando.ExecuteReader();

                    //while (dadosResultado.Read())
                    //{
                    //    lbIdResultado.Text = dadosResultado["id"].ToString();
                    //    lbIdResultado.Text = dadosResultado["nome"].ToString();
                    //    lbIdResultado.Text = dadosResultado["serviço"].ToString();
                    //    lbIdResultado.Text = dadosResultado["data_serviço"].ToString();
                    //}

                }

                conn.Close();
            }
        }


        private void btnConsultarLista_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open ();
                //string campoServico = cbConsulta.Text;
                string scriptConsulta = "";

                //if (campoServico != "")
                //{
                //    scriptConsulta = "SELECT * FROM tb_carros WHERE servico = @servico";
                //}
                //else
                //{
                //    scriptConsulta = "SELECT * FROM tb_carros";
                //}


                //string scriptConsulta = "SELECT * FROM tb_carros";

                using (MySqlCommand comando = new MySqlCommand (scriptConsulta, conn))
                {
                    MySqlDataAdapter resultadoConsultaMySql = new MySqlDataAdapter(comando);

                    DataTable dt = new DataTable();

                    resultadoConsultaMySql.Fill(dt);

                    dgvCarros.DataSource = dt;

                }

                conn.Close();
            }
        }


        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
