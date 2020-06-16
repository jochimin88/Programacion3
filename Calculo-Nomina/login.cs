using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Nomina_Luis_Contreras_2019_04211
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuarioAcceso = new accesos();

            usuarioAcceso.usuario = "adminSD";
            usuarioAcceso.pass = "adminPassSD";

            var usuario = usuarioTxt.Text;
            var pass = passTxt.Text;

            if(usuario == usuarioAcceso.usuario && pass == usuarioAcceso.pass)
            {
                Hide();
                var nomina = new Form1();
                nomina.Show();
            } else
            {
                MessageBox.Show("Los datos fueron incorrectos, favor intentar de nuevo");
            }
        }
    }
}
