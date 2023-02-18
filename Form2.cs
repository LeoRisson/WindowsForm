using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Usuario.Text.Equals("leonardo") && TB_Senha.Text.Equals("batata"))
                {
                    var calculo = new FrmInicio();
                    calculo.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos", 
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    TB_Usuario.Focus();
                    TB_Senha.Text = null;
                }
            } catch (Exception ex)
            {
                    MessageBox.Show(ex.Message,
                                "Desculpe",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }

        }

        private void TB_Usuario_Enter(object sender, EventArgs e)
        {
            TB_Usuario.BackColor = Color.LightYellow;
        }

        private void TB_Usuario_Leave(object sender, EventArgs e)
        {
            TB_Usuario.BackColor = Color.White;
        }

        private void TB_Senha_Enter(object sender, EventArgs e)
        {
            TB_Senha.BackColor = Color.LightYellow;
        }

        private void TB_Senha_Leave(object sender, EventArgs e)
        {
            TB_Senha.BackColor = Color.White;
        }

        private void TB_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla !=08 )
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras e numeros!","OPS!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TB_Usuario.SelectionStart = 0;
                TB_Usuario.SelectionLength = TB_Usuario.Text.Length;
                TB_Usuario.Focus();
            }
        }
    }
}
