namespace WindowsForm
{
    partial class FRM_Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Senha = new System.Windows.Forms.TextBox();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Cancelar);
            this.groupBox1.Controls.Add(this.BTN_Entrar);
            this.groupBox1.Controls.Add(this.TB_Senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Usuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TB_Usuario.Location = new System.Drawing.Point(10, 36);
            this.TB_Usuario.MaxLength = 50;
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(319, 20);
            this.TB_Usuario.TabIndex = 1;
            this.TB_Usuario.Enter += new System.EventHandler(this.TB_Usuario_Enter);
            this.TB_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Usuario_KeyPress);
            this.TB_Usuario.Leave += new System.EventHandler(this.TB_Usuario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // TB_Senha
            // 
            this.TB_Senha.Location = new System.Drawing.Point(10, 80);
            this.TB_Senha.Name = "TB_Senha";
            this.TB_Senha.Size = new System.Drawing.Size(319, 20);
            this.TB_Senha.TabIndex = 3;
            this.TB_Senha.UseSystemPasswordChar = true;
            this.TB_Senha.Enter += new System.EventHandler(this.TB_Senha_Enter);
            this.TB_Senha.Leave += new System.EventHandler(this.TB_Senha_Leave);
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Location = new System.Drawing.Point(297, 128);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Entrar.TabIndex = 4;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Location = new System.Drawing.Point(216, 128);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancelar.TabIndex = 5;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 172);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.TextBox TB_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.Label label1;
    }
}