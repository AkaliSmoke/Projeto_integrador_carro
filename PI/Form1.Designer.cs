namespace PI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbCor = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lbQuilometragem = new System.Windows.Forms.Label();
            this.nudQuilometragem = new System.Windows.Forms.NumericUpDown();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.lbResultadoPlaca = new System.Windows.Forms.Label();
            this.lbResultadoModelo = new System.Windows.Forms.Label();
            this.lbResultadoMarca = new System.Windows.Forms.Label();
            this.lbResultadoAno = new System.Windows.Forms.Label();
            this.lbResultadoCor = new System.Windows.Forms.Label();
            this.lbResultadoQuilometragem = new System.Windows.Forms.Label();
            this.btnConsultarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuilometragem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 358);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 37);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(12, 401);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 37);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(134, 401);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 37);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(13, 18);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(49, 19);
            this.lbPlaca.TabIndex = 3;
            this.lbPlaca.Text = "Placa:";
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(491, 261);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(433, 177);
            this.dgvCarros.TabIndex = 4;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(12, 54);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(66, 19);
            this.lbModelo.TabIndex = 5;
            this.lbModelo.Text = "Modelo:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(12, 87);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(56, 19);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca:";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(12, 121);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(42, 19);
            this.lbAno.TabIndex = 7;
            this.lbAno.Text = "Ano:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(134, 358);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 37);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCor.Location = new System.Drawing.Point(13, 158);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(37, 19);
            this.lbCor.TabIndex = 9;
            this.lbCor.Text = "Cor:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(85, 17);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(386, 20);
            this.txtPlaca.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(85, 52);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(386, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(85, 86);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(386, 20);
            this.txtMarca.TabIndex = 12;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(85, 158);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(386, 20);
            this.txtCor.TabIndex = 14;
            // 
            // lbQuilometragem
            // 
            this.lbQuilometragem.AutoSize = true;
            this.lbQuilometragem.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuilometragem.Location = new System.Drawing.Point(13, 192);
            this.lbQuilometragem.Name = "lbQuilometragem";
            this.lbQuilometragem.Size = new System.Drawing.Size(123, 19);
            this.lbQuilometragem.TabIndex = 15;
            this.lbQuilometragem.Text = "Quilometragem:";
            // 
            // nudQuilometragem
            // 
            this.nudQuilometragem.Location = new System.Drawing.Point(143, 191);
            this.nudQuilometragem.Name = "nudQuilometragem";
            this.nudQuilometragem.Size = new System.Drawing.Size(208, 20);
            this.nudQuilometragem.TabIndex = 17;
            // 
            // dtpAno
            // 
            this.dtpAno.Location = new System.Drawing.Point(85, 121);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(231, 20);
            this.dtpAno.TabIndex = 18;
            // 
            // lbResultadoPlaca
            // 
            this.lbResultadoPlaca.AutoSize = true;
            this.lbResultadoPlaca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoPlaca.Location = new System.Drawing.Point(487, 18);
            this.lbResultadoPlaca.Name = "lbResultadoPlaca";
            this.lbResultadoPlaca.Size = new System.Drawing.Size(51, 19);
            this.lbResultadoPlaca.TabIndex = 19;
            this.lbResultadoPlaca.Text = "label1";
            // 
            // lbResultadoModelo
            // 
            this.lbResultadoModelo.AutoSize = true;
            this.lbResultadoModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoModelo.Location = new System.Drawing.Point(487, 54);
            this.lbResultadoModelo.Name = "lbResultadoModelo";
            this.lbResultadoModelo.Size = new System.Drawing.Size(51, 19);
            this.lbResultadoModelo.TabIndex = 20;
            this.lbResultadoModelo.Text = "label2";
            // 
            // lbResultadoMarca
            // 
            this.lbResultadoMarca.AutoSize = true;
            this.lbResultadoMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoMarca.Location = new System.Drawing.Point(487, 87);
            this.lbResultadoMarca.Name = "lbResultadoMarca";
            this.lbResultadoMarca.Size = new System.Drawing.Size(51, 19);
            this.lbResultadoMarca.TabIndex = 21;
            this.lbResultadoMarca.Text = "label3";
            // 
            // lbResultadoAno
            // 
            this.lbResultadoAno.AutoSize = true;
            this.lbResultadoAno.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoAno.Location = new System.Drawing.Point(487, 124);
            this.lbResultadoAno.Name = "lbResultadoAno";
            this.lbResultadoAno.Size = new System.Drawing.Size(51, 19);
            this.lbResultadoAno.TabIndex = 22;
            this.lbResultadoAno.Text = "label4";
            // 
            // lbResultadoCor
            // 
            this.lbResultadoCor.AutoSize = true;
            this.lbResultadoCor.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoCor.Location = new System.Drawing.Point(487, 159);
            this.lbResultadoCor.Name = "lbResultadoCor";
            this.lbResultadoCor.Size = new System.Drawing.Size(51, 19);
            this.lbResultadoCor.TabIndex = 23;
            this.lbResultadoCor.Text = "label5";
            // 
            // lbResultadoQuilometragem
            // 
            this.lbResultadoQuilometragem.AutoSize = true;
            this.lbResultadoQuilometragem.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoQuilometragem.Location = new System.Drawing.Point(488, 192);
            this.lbResultadoQuilometragem.Name = "lbResultadoQuilometragem";
            this.lbResultadoQuilometragem.Size = new System.Drawing.Size(51, 19);
            this.lbResultadoQuilometragem.TabIndex = 24;
            this.lbResultadoQuilometragem.Text = "label6";
            // 
            // btnConsultarLista
            // 
            this.btnConsultarLista.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLista.Location = new System.Drawing.Point(250, 358);
            this.btnConsultarLista.Name = "btnConsultarLista";
            this.btnConsultarLista.Size = new System.Drawing.Size(235, 80);
            this.btnConsultarLista.TabIndex = 25;
            this.btnConsultarLista.Text = "Consultar Lista de Carros";
            this.btnConsultarLista.UseVisualStyleBackColor = true;
            this.btnConsultarLista.Click += new System.EventHandler(this.btnConsultarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.btnConsultarLista);
            this.Controls.Add(this.lbResultadoQuilometragem);
            this.Controls.Add(this.lbResultadoCor);
            this.Controls.Add(this.lbResultadoAno);
            this.Controls.Add(this.lbResultadoMarca);
            this.Controls.Add(this.lbResultadoModelo);
            this.Controls.Add(this.lbResultadoPlaca);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.nudQuilometragem);
            this.Controls.Add(this.lbQuilometragem);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Tela do projeto integrador sobre carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuilometragem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lbQuilometragem;
        private System.Windows.Forms.NumericUpDown nudQuilometragem;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.Label lbResultadoPlaca;
        private System.Windows.Forms.Label lbResultadoModelo;
        private System.Windows.Forms.Label lbResultadoMarca;
        private System.Windows.Forms.Label lbResultadoAno;
        private System.Windows.Forms.Label lbResultadoCor;
        private System.Windows.Forms.Label lbResultadoQuilometragem;
        private System.Windows.Forms.Button btnConsultarLista;
    }
}

