using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_advantage
{
    public partial class Main : Form
    {
        config_form configurar;
        int tanque;
        float km_gas, km_etanol;
        float km_tanque_gas, km_tanque_etanol;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            load_config();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular_vantagem();
        }

        private void bt_conf_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<config_form>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                configurar = new config_form(this);//cria o form

                int x = this.Left + (this.Width / 2) - (configurar.Width / 2);
                int y = this.Top + (this.Height / 2) - (configurar.Height / 2);

                configurar.Location = new Point(x, y);//seta a posição do formulario filho

                configurar.Show();//mostra o formulario
            }
            else
            {
                configurar.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        public void load_config()//carrega as configurações do carro e calcula quantos quilometros faz com um tanque
        {
            tanque = Properties.Settings.Default.tanque;
            km_gas = Properties.Settings.Default.km_gas;
            km_etanol = Properties.Settings.Default.km_etanol;

            km_tanque_etanol = km_etanol * tanque;
            km_tanque_gas = km_gas * tanque;
        }

        private void calcular_vantagem()
        {
            float rl_km_gas_etanol;//armazena qual a porcentagem do etanol em relação a gasolina
            float rl_preco_gas_etanol;//armazena o valor do etanol em relação a gasolina em %
            float valor_etanol = float.Parse(mtb_etanol.Text);
            float valor_gas = float.Parse(mtb_gasolina.Text);

            rl_km_gas_etanol = (km_tanque_etanol / km_tanque_gas) * 100;
            rl_preco_gas_etanol = (valor_etanol / valor_gas) * 100;

            lb_price_tanque_etanol.Text = String.Format(@"{0:\R\$000\.00}", Convert.ToInt64(Convert.ToString((tanque * float.Parse(mtb_etanol.Text)))));
            lb_price_tanque_gas.Text = String.Format(@"{0:\R\$000\.00}", Convert.ToInt64(Convert.ToString((tanque * float.Parse(mtb_gasolina.Text)))));

            if (rl_preco_gas_etanol <= rl_km_gas_etanol)//se a realação de preço for menor ou igual a relação de km/litro
            {
                lb_compensa.Text = "Etanol Compensa";
            }
            else
            {
                lb_compensa.Text = "Gasolina Compensa";
            }
        }
    }
}
