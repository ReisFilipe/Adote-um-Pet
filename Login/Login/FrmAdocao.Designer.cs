namespace Login
{
    partial class FrmAdocao
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.mtbHorario1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbHorario2 = new System.Windows.Forms.MaskedTextBox();
            this.cblSemana = new System.Windows.Forms.CheckedListBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbAnimal = new System.Windows.Forms.TextBox();
            this.btnBuscaAnimal = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbIdadePet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbPorte = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscaCpf = new System.Windows.Forms.Button();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Animal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Adotante :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local de adoção :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Adoção :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dia P/ Visita :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horario : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Responsavel : ";
            // 
            // txbLocal
            // 
            this.txbLocal.Location = new System.Drawing.Point(191, 188);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(266, 20);
            this.txbLocal.TabIndex = 9;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(199, 240);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(100, 20);
            this.mtbData.TabIndex = 11;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHorario1
            // 
            this.mtbHorario1.Location = new System.Drawing.Point(429, 278);
            this.mtbHorario1.Mask = "00:00";
            this.mtbHorario1.Name = "mtbHorario1";
            this.mtbHorario1.Size = new System.Drawing.Size(45, 20);
            this.mtbHorario1.TabIndex = 12;
            this.mtbHorario1.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "AS";
            // 
            // mtbHorario2
            // 
            this.mtbHorario2.Location = new System.Drawing.Point(561, 280);
            this.mtbHorario2.Mask = "00:00";
            this.mtbHorario2.Name = "mtbHorario2";
            this.mtbHorario2.Size = new System.Drawing.Size(45, 20);
            this.mtbHorario2.TabIndex = 15;
            this.mtbHorario2.ValidatingType = typeof(System.DateTime);
            // 
            // cblSemana
            // 
            this.cblSemana.FormattingEnabled = true;
            this.cblSemana.Location = new System.Drawing.Point(179, 278);
            this.cblSemana.Name = "cblSemana";
            this.cblSemana.Size = new System.Drawing.Size(120, 94);
            this.cblSemana.TabIndex = 16;
            this.cblSemana.SelectedIndexChanged += new System.EventHandler(this.cblSemana_SelectedIndexChanged);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbFoto.Location = new System.Drawing.Point(609, 30);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(163, 98);
            this.pcbFoto.TabIndex = 17;
            this.pcbFoto.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(471, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 33);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(256, 413);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(93, 33);
            this.btnCadastro.TabIndex = 27;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(368, 413);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 33);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbAnimal
            // 
            this.txbAnimal.Location = new System.Drawing.Point(191, 30);
            this.txbAnimal.Name = "txbAnimal";
            this.txbAnimal.Size = new System.Drawing.Size(266, 20);
            this.txbAnimal.TabIndex = 32;
            // 
            // btnBuscaAnimal
            // 
            this.btnBuscaAnimal.Location = new System.Drawing.Point(483, 27);
            this.btnBuscaAnimal.Name = "btnBuscaAnimal";
            this.btnBuscaAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaAnimal.TabIndex = 33;
            this.btnBuscaAnimal.Text = "Buscar";
            this.btnBuscaAnimal.UseVisualStyleBackColor = true;
            this.btnBuscaAnimal.Click += new System.EventHandler(this.btnBuscaAnimal_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(191, 141);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(266, 20);
            this.txbNome.TabIndex = 34;
            // 
            // txbIdadePet
            // 
            this.txbIdadePet.Location = new System.Drawing.Point(191, 56);
            this.txbIdadePet.Name = "txbIdadePet";
            this.txbIdadePet.Size = new System.Drawing.Size(85, 20);
            this.txbIdadePet.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Idade Animal :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Porte :";
            // 
            // txbPorte
            // 
            this.txbPorte.Location = new System.Drawing.Point(374, 56);
            this.txbPorte.Name = "txbPorte";
            this.txbPorte.Size = new System.Drawing.Size(85, 20);
            this.txbPorte.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "CPF :";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(191, 96);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 40;
            // 
            // btnBuscaCpf
            // 
            this.btnBuscaCpf.Location = new System.Drawing.Point(348, 91);
            this.btnBuscaCpf.Name = "btnBuscaCpf";
            this.btnBuscaCpf.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaCpf.TabIndex = 41;
            this.btnBuscaCpf.Text = "Buscar";
            this.btnBuscaCpf.UseVisualStyleBackColor = true;
            this.btnBuscaCpf.Click += new System.EventHandler(this.btnBuscaCpf_Click);
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.Location = new System.Drawing.Point(483, 338);
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(183, 20);
            this.txbResponsavel.TabIndex = 42;
            // 
            // FrmAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.txbResponsavel);
            this.Controls.Add(this.btnBuscaCpf);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbPorte);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbIdadePet);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnBuscaAnimal);
            this.Controls.Add(this.txbAnimal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.cblSemana);
            this.Controls.Add(this.mtbHorario2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtbHorario1);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.txbLocal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdocao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.MaskedTextBox mtbHorario1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbHorario2;
        private System.Windows.Forms.CheckedListBox cblSemana;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbAnimal;
        private System.Windows.Forms.Button btnBuscaAnimal;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbIdadePet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbPorte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Button btnBuscaCpf;
        private System.Windows.Forms.TextBox txbResponsavel;
    }
}