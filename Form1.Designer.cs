namespace WindowsForm
{
    partial class FrmInicio
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
            this.TB_Base = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Altura = new System.Windows.Forms.TextBox();
            this.BTN_Calcula = new System.Windows.Forms.Button();
            this.BTN_Limpa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Area = new System.Windows.Forms.TextBox();
            this.LB_Mensagem = new System.Windows.Forms.Label();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Base
            // 
            this.TB_Base.Location = new System.Drawing.Point(169, 40);
            this.TB_Base.Name = "TB_Base";
            this.TB_Base.Size = new System.Drawing.Size(125, 20);
            this.TB_Base.TabIndex = 0;
            this.TB_Base.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura:";
            // 
            // TB_Altura
            // 
            this.TB_Altura.Location = new System.Drawing.Point(169, 81);
            this.TB_Altura.Name = "TB_Altura";
            this.TB_Altura.Size = new System.Drawing.Size(125, 20);
            this.TB_Altura.TabIndex = 2;
            this.TB_Altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_Calcula
            // 
            this.BTN_Calcula.Location = new System.Drawing.Point(117, 116);
            this.BTN_Calcula.Name = "BTN_Calcula";
            this.BTN_Calcula.Size = new System.Drawing.Size(75, 52);
            this.BTN_Calcula.TabIndex = 4;
            this.BTN_Calcula.Text = "Calcular";
            this.BTN_Calcula.UseVisualStyleBackColor = true;
            this.BTN_Calcula.Click += new System.EventHandler(this.BTN_Calcula_Click);
            // 
            // BTN_Limpa
            // 
            this.BTN_Limpa.Location = new System.Drawing.Point(219, 116);
            this.BTN_Limpa.Name = "BTN_Limpa";
            this.BTN_Limpa.Size = new System.Drawing.Size(75, 52);
            this.BTN_Limpa.TabIndex = 5;
            this.BTN_Limpa.Text = "Limpar";
            this.BTN_Limpa.UseVisualStyleBackColor = true;
            this.BTN_Limpa.Click += new System.EventHandler(this.BTN_Limpa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Área:";
            // 
            // TB_Area
            // 
            this.TB_Area.Location = new System.Drawing.Point(169, 184);
            this.TB_Area.Name = "TB_Area";
            this.TB_Area.ReadOnly = true;
            this.TB_Area.Size = new System.Drawing.Size(125, 20);
            this.TB_Area.TabIndex = 6;
            this.TB_Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LB_Mensagem
            // 
            this.LB_Mensagem.AutoSize = true;
            this.LB_Mensagem.ForeColor = System.Drawing.Color.Red;
            this.LB_Mensagem.Location = new System.Drawing.Point(114, 210);
            this.LB_Mensagem.Name = "LB_Mensagem";
            this.LB_Mensagem.Size = new System.Drawing.Size(0, 13);
            this.LB_Mensagem.TabIndex = 8;
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Location = new System.Drawing.Point(313, 200);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sair.TabIndex = 9;
            this.BTN_Sair.Text = "Sair";
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 232);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.LB_Mensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Area);
            this.Controls.Add(this.BTN_Limpa);
            this.Controls.Add(this.BTN_Calcula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Altura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Base);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula Área Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Altura;
        private System.Windows.Forms.Button BTN_Calcula;
        private System.Windows.Forms.Button BTN_Limpa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Area;
        private System.Windows.Forms.Label LB_Mensagem;
        private System.Windows.Forms.Button BTN_Sair;
    }
}

