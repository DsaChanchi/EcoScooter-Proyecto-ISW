using Amazon.DirectoryService.Model;
using Amazon.IdentityManagement.Model;
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
    public partial class devolverPatinete : Form
    {

        private IEcoScooterService service;
        public devolverPatinete(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            Entities.User user = service.userLogged();
            Rental r = user.lastRental();
            bool err = false;
            string id = "";

            try
            {
                if (txt_estacion.TextLength == 0)
                {
                    err = true;
                    MessageBox.Show("Por favor, indique una estación");
                }
                else
                {
                    if (r == null)
                    {
                        MessageBox.Show("No dispone de ningun alquiler");
                        throw new ServiceException("Ha-ha");
                    }
                    id = txt_estacion.Text;
                    if (btn_si.Checked == true)
                    {
                        Station st = service.findStationById(id);
                        service.returnScooter(r, st);
                        MessageBox.Show("Patinete devuelto, se procede a registrar incidente" + "\nPrecio del recorrido: " + r.Price);
                        registrarIncidente RegistrarIncidente = new registrarIncidente(service);
                        RegistrarIncidente.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        if (btn_no.Checked == true)
                        {
                            Station st = service.findStationById(id);
                            service.returnScooter(r, st);
                            MessageBox.Show("Patinete devuelto sin incidentes" + "\nPrecio del recorrido: " + r.Price);
                            this.Hide();
                        }
                        else MessageBox.Show("Por favor, seleccione si desea registrar un incidente");
                    }
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Entities.User user = service.userLogged();
            Rental r = user.lastRental();
            bool err = false;
            string id = "";

            try
            {
                if (txt_estacion.TextLength == 0)
                {
                    err = true;
                    MessageBox.Show("Por favor, indique una estación");
                }
                else
                {
                    if (r == null)
                    {
                        MessageBox.Show("No dispone de ningun alquiler");
                        throw new ServiceException("Ha-ha");
                    }
                    id = btn_si.Text;
                    if (btn_si.Checked == true)
                    {
                        Station st = service.findStationById(id);
                        service.returnScooter(r, st);
                        MessageBox.Show("Patinete devuelto, se procede a registrar incidente" + "\nPrecio del recorrido: " + r.Price);
                        registrarIncidente ri = new registrarIncidente(service);
                        ri.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        if (btn_no.Checked == true)
                        {
                            Station st = service.findStationById(id);
                            service.returnScooter(r, st);
                            MessageBox.Show("Patinete devuelto sin incidentes" + "\nPrecio del recorrido: " + r.Price);
                            this.Hide();
                        }
                        else MessageBox.Show("Por favor, seleccione si desea registrar un incidente");
                    }
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_estacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_no_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
