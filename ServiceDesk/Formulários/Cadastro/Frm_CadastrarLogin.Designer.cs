namespace ServiceDesk
{
    partial class Frm_CadastrarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastrarLogin));
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_SenhaCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_LoginCad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_End = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SobrenomeCad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NomeCad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(12, 421);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 17;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(134, 421);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 18;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_SenhaCad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_LoginCad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // tb_SenhaCad
            // 
            this.tb_SenhaCad.Location = new System.Drawing.Point(6, 90);
            this.tb_SenhaCad.Name = "tb_SenhaCad";
            this.tb_SenhaCad.Size = new System.Drawing.Size(100, 20);
            this.tb_SenhaCad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // tb_LoginCad
            // 
            this.tb_LoginCad.Location = new System.Drawing.Point(6, 42);
            this.tb_LoginCad.Name = "tb_LoginCad";
            this.tb_LoginCad.Size = new System.Drawing.Size(100, 20);
            this.tb_LoginCad.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_TipoUsuario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mtb_CPF);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rb_F);
            this.groupBox2.Controls.Add(this.rb_M);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_End);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_SobrenomeCad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_NomeCad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 224);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cadastrais";
            // 
            // cb_TipoUsuario
            // 
            this.cb_TipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_TipoUsuario.FormattingEnabled = true;
            this.cb_TipoUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_TipoUsuario.Items.AddRange(new object[] {
            "",
            "Colaborador",
            "Ti / Suporte",
            "Gerente"});
            this.cb_TipoUsuario.Location = new System.Drawing.Point(173, 89);
            this.cb_TipoUsuario.Name = "cb_TipoUsuario";
            this.cb_TipoUsuario.Size = new System.Drawing.Size(138, 21);
            this.cb_TipoUsuario.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo:";
            // 
            // mtb_CPF
            // 
            this.mtb_CPF.Location = new System.Drawing.Point(6, 90);
            this.mtb_CPF.Mask = "000.000.000-00";
            this.mtb_CPF.Name = "mtb_CPF";
            this.mtb_CPF.Size = new System.Drawing.Size(85, 20);
            this.mtb_CPF.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "CPF:";
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Location = new System.Drawing.Point(46, 200);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(67, 17);
            this.rb_F.TabIndex = 16;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "Feminino";
            this.rb_F.UseVisualStyleBackColor = true;
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(46, 177);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(73, 17);
            this.rb_M.TabIndex = 15;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "Masculino";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo:";
            // 
            // tb_End
            // 
            this.tb_End.Location = new System.Drawing.Point(9, 142);
            this.tb_End.Name = "tb_End";
            this.tb_End.Size = new System.Drawing.Size(302, 20);
            this.tb_End.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Endereço";
            // 
            // tb_SobrenomeCad
            // 
            this.tb_SobrenomeCad.Location = new System.Drawing.Point(173, 41);
            this.tb_SobrenomeCad.Name = "tb_SobrenomeCad";
            this.tb_SobrenomeCad.Size = new System.Drawing.Size(138, 20);
            this.tb_SobrenomeCad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome:";
            // 
            // tb_NomeCad
            // 
            this.tb_NomeCad.Location = new System.Drawing.Point(6, 41);
            this.tb_NomeCad.Name = "tb_NomeCad";
            this.tb_NomeCad.Size = new System.Drawing.Size(138, 20);
            this.tb_NomeCad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(254, 421);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(12, 421);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 15;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click_1);
            // 
            // Frm_CadastrarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 456);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Atualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CadastrarLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_CadastrarLogin_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_SenhaCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_LoginCad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_End;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SobrenomeCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NomeCad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cb_TipoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtb_CPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Atualizar;
    }
}