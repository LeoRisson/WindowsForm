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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BTN_Calcula_Click(object sender, EventArgs e)
        {
            if ((TB_Base.Text !="") && (TB_Altura.Text != ""))
            {
                float res = float.Parse(TB_Base.Text) * float.Parse(TB_Altura.Text) / 2;
                TB_Area.Text = res.ToString();
                LB_Mensagem.Text = "Cálculo realizado com Sucesso!";
            }
            else
            {
                LB_Mensagem.Text = "Digite os Valores da Base e da Altura!";
            } 

        }

        private void BTN_Limpa_Click(object sender, EventArgs e)
        {
            TB_Base.Text = null;
            TB_Altura.Text = null;
            TB_Area.Text = null;
            LB_Mensagem.Text = null;
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
