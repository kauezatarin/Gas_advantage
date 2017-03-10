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
    public partial class config_form : Form
    {
        Main pai;

        public config_form(Main instancia_main)
        {
            InitializeComponent();

            pai = instancia_main;
        }

        private void config_form_Load(object sender, EventArgs e)
        {
            load_actual_configs();
        }

        private void numbers_only(object sender, KeyPressEventArgs e)//função para a textbox aceitar apenas numeros
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {
                Properties.Settings.Default.tanque = Convert.ToInt32(tb_tanque.Text);
                Properties.Settings.Default.km_gas = Convert.ToInt32(tb_gasolina.Text);
                Properties.Settings.Default.km_etanol = Convert.ToInt32(tb_etanol.Text);

                Properties.Settings.Default.Save();

                pai.load_config();//atualiza as config no main

                this.Close();
            }
        }

        /*------operacionais---------*/
        private bool validar()//confere se todos os campos estão preenchidos
        {
            if (tb_etanol.TextLength < 1 || tb_gasolina.TextLength < 1 || tb_tanque.TextLength < 1)
                return false;

            else return true;
        }

        private void load_actual_configs()
        {
            tb_tanque.Text = Properties.Settings.Default.tanque.ToString();
            tb_gasolina.Text = Properties.Settings.Default.km_gas.ToString();
            tb_etanol.Text = Properties.Settings.Default.km_etanol.ToString();
        }
    }
}
