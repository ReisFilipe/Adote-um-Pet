namespace Login
{
    partial class FrmBuscaAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbRaca = new System.Windows.Forms.TextBox();
            this.txbCor = new System.Windows.Forms.TextBox();
            this.txbPorte = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleciona = new System.Windows.Forms.Button();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.ani_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ani_raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ani_cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ani_porte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ani_idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raça :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porte :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade :";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(113, 265);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 5;
            // 
            // txbRaca
            // 
            this.txbRaca.Location = new System.Drawing.Point(312, 263);
            this.txbRaca.Name = "txbRaca";
            this.txbRaca.ReadOnly = true;
            this.txbRaca.Size = new System.Drawing.Size(100, 20);
            this.txbRaca.TabIndex = 6;
            // 
            // txbCor
            // 
            this.txbCor.Location = new System.Drawing.Point(542, 265);
            this.txbCor.Name = "txbCor";
            this.txbCor.ReadOnly = true;
            this.txbCor.Size = new System.Drawing.Size(100, 20);
            this.txbCor.TabIndex = 7;
            // 
            // txbPorte
            // 
            this.txbPorte.Location = new System.Drawing.Point(113, 295);
            this.txbPorte.Name = "txbPorte";
            this.txbPorte.ReadOnly = true;
            this.txbPorte.Size = new System.Drawing.Size(100, 20);
            this.txbPorte.TabIndex = 8;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(312, 295);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.ReadOnly = true;
            this.txbIdade.Size = new System.Drawing.Size(100, 20);
            this.txbIdade.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(422, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 33);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleciona
            // 
            this.btnSeleciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleciona.Location = new System.Drawing.Point(207, 332);
            this.btnSeleciona.Name = "btnSeleciona";
            this.btnSeleciona.Size = new System.Drawing.Size(93, 33);
            this.btnSeleciona.TabIndex = 30;
            this.btnSeleciona.Text = "Selecionar";
            this.btnSeleciona.UseVisualStyleBackColor = true;
            this.btnSeleciona.Click += new System.EventHandler(this.btnSeleciona_Click);
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ani_nome,
            this.ani_raca,
            this.ani_cor,
            this.ani_porte,
            this.ani_idade});
            this.dgvAnimal.Location = new System.Drawing.Point(1, 0);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.ReadOnly = true;
            this.dgvAnimal.Size = new System.Drawing.Size(754, 249);
            this.dgvAnimal.TabIndex = 33;
            this.dgvAnimal.Click += new System.EventHandler(this.dgvAnimal_Click);
            // 
            // ani_nome
            // 
            this.ani_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ani_nome.DataPropertyName = "ani_nome";
            this.ani_nome.HeaderText = "Nome";
            this.ani_nome.Name = "ani_nome";
            this.ani_nome.ReadOnly = true;
            // 
            // ani_raca
            // 
            this.ani_raca.DataPropertyName = "ani_raca";
            this.ani_raca.HeaderText = "Raça";
            this.ani_raca.Name = "ani_raca";
            this.ani_raca.ReadOnly = true;
            this.ani_raca.Width = 110;
            // 
            // ani_cor
            // 
            this.ani_cor.DataPropertyName = "ani_cor";
            this.ani_cor.HeaderText = "Cor";
            this.ani_cor.Name = "ani_cor";
            this.ani_cor.ReadOnly = true;
            this.ani_cor.Width = 110;
            // 
            // ani_porte
            // 
            this.ani_porte.DataPropertyName = "ani_porte";
            this.ani_porte.HeaderText = "Porte";
            this.ani_porte.Name = "ani_porte";
            this.ani_porte.ReadOnly = true;
            this.ani_porte.Width = 110;
            // 
            // ani_idade
            // 
            this.ani_idade.DataPropertyName = "ani_idade";
            this.ani_idade.HeaderText = "Idade";
            this.ani_idade.Name = "ani_idade";
            this.ani_idade.ReadOnly = true;
            this.ani_idade.Width = 80;
            // 
            // FrmBuscaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 377);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleciona);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbPorte);
            this.Controls.Add(this.txbCor);
            this.Controls.Add(this.txbRaca);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscaAnimal";
            this.Text = "Busca ";
            this.Load += new System.EventHandler(this.FrmBuscaAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbRaca;
        private System.Windows.Forms.TextBox txbCor;
        private System.Windows.Forms.TextBox txbPorte;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleciona;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ani_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ani_raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ani_cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ani_porte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ani_idade;
    }
}