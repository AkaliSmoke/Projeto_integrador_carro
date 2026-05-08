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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbCor = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lbQuilometragem = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 37);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(124, 401);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 37);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(242, 401);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 37);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Consultar";
            this.btnExcluir.UseVisualStyleBackColor = true;
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
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(358, 401);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 37);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
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
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
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
            this.lbQuilometragem.Location = new System.Drawing.Point(13, 208);
            this.lbQuilometragem.Name = "lbQuilometragem";
            this.lbQuilometragem.Size = new System.Drawing.Size(123, 19);
            this.lbQuilometragem.TabIndex = 15;
            this.lbQuilometragem.Text = "Quilometragem:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 121);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbQuilometragem);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Tela do projeto integrador sobre carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lbQuilometragem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

