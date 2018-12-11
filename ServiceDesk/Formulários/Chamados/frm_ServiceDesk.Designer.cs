namespace ServiceDesk
{
    partial class frm_ServiceDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ServiceDesk));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Chamados = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_TipoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Tratativa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtb_DtEncerrado = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Servico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Descricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_DataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Solicitante = new System.Windows.Forms.TextBox();
            this.Btn_AbrirChamado = new System.Windows.Forms.Button();
            this.btn_EncerrarChamado = new System.Windows.Forms.Button();
            this.btn_AlterarChamado = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Encerra = new System.Windows.Forms.Button();
            this.lklAtualizar = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chamados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.chamadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.alterarCadastroToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Enabled = false;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loginToolStripMenuItem.Text = "Cadastrar Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // alterarCadastroToolStripMenuItem
            // 
            this.alterarCadastroToolStripMenuItem.Enabled = false;
            this.alterarCadastroToolStripMenuItem.Name = "alterarCadastroToolStripMenuItem";
            this.alterarCadastroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.alterarCadastroToolStripMenuItem.Text = "Alterar Cadastro";
            this.alterarCadastroToolStripMenuItem.Click += new System.EventHandler(this.alterarCadastroToolStripMenuItem_Click);
            // 
            // chamadosToolStripMenuItem
            // 
            this.chamadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadoToolStripMenuItem});
            this.chamadosToolStripMenuItem.Name = "chamadosToolStripMenuItem";
            this.chamadosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.chamadosToolStripMenuItem.Text = "Chamados";
            // 
            // abrirChamadoToolStripMenuItem
            // 
            this.abrirChamadoToolStripMenuItem.Name = "abrirChamadoToolStripMenuItem";
            this.abrirChamadoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.abrirChamadoToolStripMenuItem.Text = "Abrir Chamado";
            this.abrirChamadoToolStripMenuItem.Click += new System.EventHandler(this.abrirChamadoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lklAtualizar);
            this.groupBox1.Controls.Add(this.dgv_Chamados);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chamado";
            // 
            // dgv_Chamados
            // 
            this.dgv_Chamados.Location = new System.Drawing.Point(6, 19);
            this.dgv_Chamados.Name = "dgv_Chamados";
            this.dgv_Chamados.RowTemplate.ReadOnly = true;
            this.dgv_Chamados.Size = new System.Drawing.Size(825, 192);
            this.dgv_Chamados.TabIndex = 0;
            this.dgv_Chamados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Chamados_CellClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_Usuario,
            this.toolStripStatusLabel2,
            this.tssl_TipoUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(855, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // tssl_Usuario
            // 
            this.tssl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssl_Usuario.Name = "tssl_Usuario";
            this.tssl_Usuario.Size = new System.Drawing.Size(118, 17);
            this.tssl_Usuario.Text = "toolStripStatusLabel2";
            this.tssl_Usuario.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel2.Text = "Tipo Usuário:";
            // 
            // tssl_TipoUsuario
            // 
            this.tssl_TipoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssl_TipoUsuario.Name = "tssl_TipoUsuario";
            this.tssl_TipoUsuario.Size = new System.Drawing.Size(118, 17);
            this.tssl_TipoUsuario.Text = "toolStripStatusLabel3";
            this.tssl_TipoUsuario.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Tratativa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mtb_DtEncerrado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_Servico);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_Descricao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_Titulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_Status);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mtb_DataCriacao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Solicitante);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes";
            // 
            // tb_Tratativa
            // 
            this.tb_Tratativa.Location = new System.Drawing.Point(555, 96);
            this.tb_Tratativa.Multiline = true;
            this.tb_Tratativa.Name = "tb_Tratativa";
            this.tb_Tratativa.ReadOnly = true;
            this.tb_Tratativa.Size = new System.Drawing.Size(276, 95);
            this.tb_Tratativa.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tratativa";
            // 
            // mtb_DtEncerrado
            // 
            this.mtb_DtEncerrado.Location = new System.Drawing.Point(555, 39);
            this.mtb_DtEncerrado.Mask = "00/00/0000 90:00";
            this.mtb_DtEncerrado.Name = "mtb_DtEncerrado";
            this.mtb_DtEncerrado.ReadOnly = true;
            this.mtb_DtEncerrado.Size = new System.Drawing.Size(100, 20);
            this.mtb_DtEncerrado.TabIndex = 3;
            this.mtb_DtEncerrado.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Encerrado";
            // 
            // tb_Servico
            // 
            this.tb_Servico.AutoCompleteCustomSource.AddRange(new string[] {
            "Subsitituição",
            "Limpeza",
            "Formataçâo",
            "Instalação de Software",
            "Remoção de Vírus"});
            this.tb_Servico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tb_Servico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_Servico.Location = new System.Drawing.Point(9, 171);
            this.tb_Servico.Name = "tb_Servico";
            this.tb_Servico.ReadOnly = true;
            this.tb_Servico.Size = new System.Drawing.Size(159, 20);
            this.tb_Servico.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Serviço";
            // 
            // tb_Descricao
            // 
            this.tb_Descricao.AcceptsReturn = true;
            this.tb_Descricao.Location = new System.Drawing.Point(188, 96);
            this.tb_Descricao.Multiline = true;
            this.tb_Descricao.Name = "tb_Descricao";
            this.tb_Descricao.ReadOnly = true;
            this.tb_Descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Descricao.Size = new System.Drawing.Size(285, 96);
            this.tb_Descricao.TabIndex = 8;
            this.tb_Descricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Descricao_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(9, 105);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.ReadOnly = true;
            this.tb_Titulo.Size = new System.Drawing.Size(159, 20);
            this.tb_Titulo.TabIndex = 4;
            this.tb_Titulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Titulo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Título";
            // 
            // tb_Status
            // 
            this.tb_Status.Location = new System.Drawing.Point(373, 39);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.ReadOnly = true;
            this.tb_Status.Size = new System.Drawing.Size(100, 20);
            this.tb_Status.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // mtb_DataCriacao
            // 
            this.mtb_DataCriacao.Location = new System.Drawing.Point(191, 39);
            this.mtb_DataCriacao.Mask = "00/00/0000 90:00";
            this.mtb_DataCriacao.Name = "mtb_DataCriacao";
            this.mtb_DataCriacao.ReadOnly = true;
            this.mtb_DataCriacao.Size = new System.Drawing.Size(100, 20);
            this.mtb_DataCriacao.TabIndex = 1;
            this.mtb_DataCriacao.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aberto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitante";
            // 
            // tb_Solicitante
            // 
            this.tb_Solicitante.Location = new System.Drawing.Point(9, 39);
            this.tb_Solicitante.Name = "tb_Solicitante";
            this.tb_Solicitante.ReadOnly = true;
            this.tb_Solicitante.Size = new System.Drawing.Size(159, 20);
            this.tb_Solicitante.TabIndex = 0;
            this.tb_Solicitante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Solicitante_KeyDown);
            // 
            // Btn_AbrirChamado
            // 
            this.Btn_AbrirChamado.Location = new System.Drawing.Point(130, 516);
            this.Btn_AbrirChamado.Name = "Btn_AbrirChamado";
            this.Btn_AbrirChamado.Size = new System.Drawing.Size(107, 23);
            this.Btn_AbrirChamado.TabIndex = 12;
            this.Btn_AbrirChamado.Text = "Abrir Chamado";
            this.Btn_AbrirChamado.UseVisualStyleBackColor = true;
            this.Btn_AbrirChamado.Click += new System.EventHandler(this.Btn_AbrirChamado_Click);
            // 
            // btn_EncerrarChamado
            // 
            this.btn_EncerrarChamado.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EncerrarChamado.Enabled = false;
            this.btn_EncerrarChamado.Location = new System.Drawing.Point(580, 516);
            this.btn_EncerrarChamado.Name = "btn_EncerrarChamado";
            this.btn_EncerrarChamado.Size = new System.Drawing.Size(107, 23);
            this.btn_EncerrarChamado.TabIndex = 14;
            this.btn_EncerrarChamado.Text = "Fechar Chamado";
            this.btn_EncerrarChamado.UseVisualStyleBackColor = true;
            this.btn_EncerrarChamado.Click += new System.EventHandler(this.btn_EncerrarChamado_Click);
            // 
            // btn_AlterarChamado
            // 
            this.btn_AlterarChamado.Enabled = false;
            this.btn_AlterarChamado.Location = new System.Drawing.Point(355, 516);
            this.btn_AlterarChamado.Name = "btn_AlterarChamado";
            this.btn_AlterarChamado.Size = new System.Drawing.Size(107, 23);
            this.btn_AlterarChamado.TabIndex = 13;
            this.btn_AlterarChamado.Text = "Alterar Chamado";
            this.btn_AlterarChamado.UseVisualStyleBackColor = true;
            this.btn_AlterarChamado.Click += new System.EventHandler(this.btn_AlterarChamado_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.BackgroundImage")));
            this.btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Location = new System.Drawing.Point(12, 475);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(41, 44);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Visible = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(808, 475);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(41, 44);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Encerra
            // 
            this.btn_Encerra.BackColor = System.Drawing.Color.Transparent;
            this.btn_Encerra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Encerra.BackgroundImage")));
            this.btn_Encerra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Encerra.FlatAppearance.BorderSize = 0;
            this.btn_Encerra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Encerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Encerra.Location = new System.Drawing.Point(12, 475);
            this.btn_Encerra.Name = "btn_Encerra";
            this.btn_Encerra.Size = new System.Drawing.Size(41, 44);
            this.btn_Encerra.TabIndex = 15;
            this.btn_Encerra.UseVisualStyleBackColor = false;
            this.btn_Encerra.Visible = false;
            this.btn_Encerra.Click += new System.EventHandler(this.btn_Encerra_Click);
            // 
            // lklAtualizar
            // 
            this.lklAtualizar.AutoSize = true;
            this.lklAtualizar.Location = new System.Drawing.Point(776, 220);
            this.lklAtualizar.Name = "lklAtualizar";
            this.lklAtualizar.Size = new System.Drawing.Size(47, 13);
            this.lklAtualizar.TabIndex = 1;
            this.lklAtualizar.TabStop = true;
            this.lklAtualizar.Text = "Atualizar";
            this.lklAtualizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAtualizar_LinkClicked);
            // 
            // frm_ServiceDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 576);
            this.Controls.Add(this.btn_Encerra);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_AlterarChamado);
            this.Controls.Add(this.btn_EncerrarChamado);
            this.Controls.Add(this.Btn_AbrirChamado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ServiceDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ServiceDesk_FormClosed);
            this.Load += new System.EventHandler(this.frm_ServiceDesk_Load);
            this.VisibleChanged += new System.EventHandler(this.frm_ServiceDesk_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chamados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Usuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_TipoUsuario;
        private System.Windows.Forms.DataGridView dgv_Chamados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Descricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_DataCriacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Solicitante;
        private System.Windows.Forms.TextBox tb_Tratativa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtb_DtEncerrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_AbrirChamado;
        private System.Windows.Forms.Button btn_EncerrarChamado;
        private System.Windows.Forms.Button btn_AlterarChamado;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ToolStripMenuItem alterarCadastroToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_Servico;
        private System.Windows.Forms.Button btn_Encerra;
        private System.Windows.Forms.LinkLabel lklAtualizar;
    }
}