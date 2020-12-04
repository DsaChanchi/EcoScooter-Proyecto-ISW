using EcoScooter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoScooter.GUI
{
    public partial class ventanaRutas : Form
    {
        private IEcoScooterService service;
        public ventanaRutas(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void tablaDeRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
