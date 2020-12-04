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
    public partial class registrarEstacion : Form
    {
        private IEcoScooterService service;
        public registrarEstacion(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void txt_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Boolean err = false;
            string mens = "";
            string dir = "";
            string id = "";
            double lat = 0.0;
            double lon = 0.0;
            if (txt_direccion.TextLength == 0)
            {
                err = true;
                mens += "El campo Direccion es obligatorio \n";
            }
            else dir = txt_direccion.Text;
            if (txt_identificador.TextLength == 0)
            {
                err = true;
                mens += "El campo Id es obligatorio \n";
            }
            else id = txt_identificador.Text;
            try
            {
                lat = double.Parse(txt_latitud.Text);
                if (lat < -90.0 || lat > 90.0)
                {
                    mens += "El valor de latitud tiene que estar entre 90 y -90 \n";
                }
            }
            catch (FormatException a)
            {
                err = true;
                mens += "El campo Latitud es obligatorio \n";
            }
            try
            {
                lon = double.Parse(txt_longitud.Text);
                if (lon < -18 - .0 || lat > 180.0)
                {
                    mens += "El valor de longitud tiene que estar entre 180 y -180 \n";
                }
            }
            catch (FormatException a)
            {
                err = true;
                mens += "El campo Longitud es obligatorio \n";
            }
            if (!err)
            {
                DialogResult answer = MessageBox.Show(this,
                    "Estacion agregada \n",
                    "Well done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (answer == DialogResult.OK)
                {
                    Station st = new Station(dir, id, lat, lon);
                    service.registerStation(st);
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
    }
}
