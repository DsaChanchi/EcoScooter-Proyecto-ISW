using Amazon.DirectoryService.Model;
using EcoScooter.Entities;
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
    public partial class ventanaIniciado : Form
    {
        private IEcoScooterService service;
        private object textIdStation;


        public ventanaIniciado(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
            label3.Text = service.userLogged().Name;
        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_idEstacion.TextLength == 0)
                {
                    MessageBox.Show("Introduce el id de la estación!");
                }
                else
                {
                    Station st = service.findStationById(txt_idEstacion.Text);
                    Scooter sc = st.chooseScooterToRent();
                    User u = service.userLogged();
                    Rental r = new Rental(DateTime.Now, st, sc, u);
                    service.rentScooter(r);
                    MessageBox.Show("Disfrute del recorrido y conduzca con precaución!");
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            devolverPatinete dp = new devolverPatinete(service);
            dp.ShowDialog();
        }

        private void btn_recorridos_Click(object sender, EventArgs e)
        {
            ventanaRutas vr = new ventanaRutas(service);
            vr.ShowDialog();
        }

        private void btn_desconectarse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
