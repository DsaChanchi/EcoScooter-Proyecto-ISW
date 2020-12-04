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
    public partial class registrarIncidente : Form
    {
        private IEcoScooterService service;
        public registrarIncidente(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                User user = service.userLogged();
                Rental r = user.lastRental();
                bool err = false;
                string inc = "";
                if (txt_incidente.TextLength == 0)
                {
                    err = true;
                    MessageBox.Show("Por favor, indique el incidente");
                }
                else
                {
                    inc = txt_incidente.Text;
                    Incident i = new Incident(inc, DateTime.Now);
                    r.addIncident(i);
                    MessageBox.Show("Incidente registrado");
                    this.Hide();
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
