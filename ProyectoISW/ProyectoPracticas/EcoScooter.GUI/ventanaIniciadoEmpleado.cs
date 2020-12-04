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
    
    public partial class ventanaIniciadoEmpleado : Form
    {
        private IEcoScooterService service;
        public ventanaIniciadoEmpleado(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
            label3.Text = service.employeeLogged().Name;
        }

        private void btn_registrarPatinete_Click(object sender, EventArgs e)
        {
            registrarPatinete rp = new registrarPatinete(service);
            rp.ShowDialog();
        }

        private void btn_registrarEstacion_Click(object sender, EventArgs e)
        {
            registrarEstacion re = new registrarEstacion(service);
            re.ShowDialog();
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
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_desconectarse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_recorridos_Click(object sender, EventArgs e)
        {
            ventanaRutas vr = new ventanaRutas(service);
            vr.ShowDialog();
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            devolverPatinete dp = new devolverPatinete(service);
            dp.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
