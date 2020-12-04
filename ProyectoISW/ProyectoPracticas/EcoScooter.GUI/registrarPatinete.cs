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
    public partial class registrarPatinete : Form
    {
        private IEcoScooterService service;
        ScooterState estado;
        public registrarPatinete(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean err = false;
            string mens = "";
            string est = "";
            try
            {
                if (txt_estacion.TextLength == 0)
                {
                    err = true;
                    mens += "El campo Estación es obligatorio \n";
                }
                else est = txt_estacion.Text;
                if (btn_disponible.Checked == true)
                {
                    estado = ScooterState.available;
                }
                if (btn_mantenimiento.Checked == true)
                {
                    estado = ScooterState.inMaintenance;
                }
                if (btn_disponible.Checked == false & btn_mantenimiento.Checked == false)
                {
                    err = true;
                    mens += "Elige una de las opciones en la sección del Estado \n";
                }
                if (!err)
                {
                    DialogResult answer = MessageBox.Show(this,
                        "Patinete agregado \n",
                        "Well done",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (answer == DialogResult.OK)
                    {
                        Scooter sc = new Scooter(txt_fecha.Value.Date, estado);
                        service.registerScooter(sc);
                        Station st = service.findStationById(est);
                        st.assignScooter(sc);
                        service.saveChanges();
                        this.Close();
                    }
                }
                else
                {
                    DialogResult answer = MessageBox.Show(this,
                        "Revise los datos introducidos \n" + mens,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
