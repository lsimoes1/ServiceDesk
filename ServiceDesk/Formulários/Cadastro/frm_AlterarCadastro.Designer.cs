namespace ServiceDesk
{
    partial class frm_AlterarCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AlterarCadastro));
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.pn_ConsultaUsuario = new System.Windows.Forms.Panel();
            this.pn_ConsultaUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Consulta
            // 
            resources.ApplyResources(this.btn_Consulta, "btn_Consulta");
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tb_CPF
            // 
            resources.ApplyResources(this.tb_CPF, "tb_CPF");
            this.tb_CPF.Name = "tb_CPF";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tb_Nome
            // 
            resources.ApplyResources(this.tb_Nome, "tb_Nome");
            this.tb_Nome.Name = "tb_Nome";
            // 
            // pn_ConsultaUsuario
            // 
            resources.ApplyResources(this.pn_ConsultaUsuario, "pn_ConsultaUsuario");
            this.pn_ConsultaUsuario.Controls.Add(this.label1);
            this.pn_ConsultaUsuario.Controls.Add(this.tb_Nome);
            this.pn_ConsultaUsuario.Controls.Add(this.btn_Consulta);
            this.pn_ConsultaUsuario.Controls.Add(this.label3);
            this.pn_ConsultaUsuario.Controls.Add(this.btn_Cancelar);
            this.pn_ConsultaUsuario.Controls.Add(this.label2);
            this.pn_ConsultaUsuario.Controls.Add(this.tb_CPF);
            this.pn_ConsultaUsuario.Name = "pn_ConsultaUsuario";
            // 
            // frm_AlterarCadastro
            // 
            this.AcceptButton = this.btn_Consulta;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.Controls.Add(this.pn_ConsultaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_AlterarCadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_AlterarCadastro_FormClosed);
            this.pn_ConsultaUsuario.ResumeLayout(false);
            this.pn_ConsultaUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Panel pn_ConsultaUsuario;
    }
}