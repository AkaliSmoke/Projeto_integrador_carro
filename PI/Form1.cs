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

            // CORRIGIDO: Captura apenas o número do ano (ex: 2026) para enviar ao banco INT
            int campoAno = dtpAno.Value.Year;

            string campoCor = txtCor.Text;
            string campoQuilometragem = nudQuilometragem.Value.ToString();

            int controleLinhasAfetadas = 0;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptInsert = "INSERT INTO tb_carros (placa, modelo, marca, ano, cor, quilometragem) " +
                      "VALUES (@placa, @modelo, @marca, @ano, @cor, @km)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@placa", campoPlaca);
                    comando.Parameters.AddWithValue("@modelo", campoModelo);
                    comando.Parameters.AddWithValue("@marca", campoMarca);
                    comando.Parameters.AddWithValue("@ano", campoAno); // Enviando o ano como número
                    comando.Parameters.AddWithValue("@cor", campoCor);
                    comando.Parameters.AddWithValue("@km", campoQuilometragem);

                    // CORRIGIDO: Faltava esta linha para realmente executar o comando no MySQL
                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }

            if (controleLinhasAfetadas > 0)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Ops, Algo deu errado!!!");
            }
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string campoPlaca = txtPlaca.Text;
            int controleLinhasAfetadas = 0;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptDelete = "DELETE FROM tb_carros WHERE placa = @placa";

                using (MySqlCommand comando = new MySqlCommand(scriptDelete, conn))
                {
                    comando.Parameters.AddWithValue("@placa", campoPlaca);

                    // Executa a exclusão no MySQL
                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }

            // ADICIONADO: Feedback para o usuário
            if (controleLinhasAfetadas > 0)
            {
                MessageBox.Show("Veículo excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhum veículo encontrado com esta placa para excluir.");
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string campoPlaca = txtPlaca.Text;
            string campoModelo = txtModelo.Text;
            string campoMarca = txtMarca.Text;

            // Captura apenas o ano selecionado no DateTimePicker
            int campoAno = dtpAno.Value.Year;

            string campoCor = txtCor.Text;

            // Captura o valor numérico do NumericUpDown
            decimal campoQuilometragem = nudQuilometragem.Value;

            int controleLinhasAfetadas = 0;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                // utilize das informações
                conn.Open();
                string scriptUpdate = "UPDATE tb_carros SET " +
                "placa = @placa, modelo = @modelo, marca = @marca, ano = @ano, cor = @cor, quilometragem = @quilometragem " +
                "WHERE id_carro = @id_carro";

                using (MySqlCommand comando = new MySqlCommand(scriptUpdate, conn))
                {
                    comando.Parameters.AddWithValue("@placa", campoPlaca);
                    comando.Parameters.AddWithValue("@modelo", campoModelo);
                    comando.Parameters.AddWithValue("@marca", campoMarca);
                    comando.Parameters.AddWithValue("@ano", campoAno);
                    comando.Parameters.AddWithValue("@cor", campoCor);
                    comando.Parameters.AddWithValue("@quilometragem", campoQuilometragem);

                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

    }
}
