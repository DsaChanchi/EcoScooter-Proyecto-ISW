using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.DirectoryService.Model;
using EcoScooter.Entities;
using EcoScooter.Services;

namespace EcoScooter.GUI
{
    public partial class Inicio : Form
    {
        private IEcoScooterService service;
        private Employee loginEmployee = null;
        private User loginUser = null;

        public Inicio(IEcoScooterService service)
        {

            InitializeComponent();
            this.service = service;           
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            ventanaRegistrarse vr = new ventanaRegistrarse(service);
            vr.ShowDialog();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(this, "¿Estas seguro de que quieres salir?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void inicioSesionUsuario(object sender, EventArgs e)
        {
            try
            {
                Boolean err = false;
                string mens = "";
                string id = "";
                string pin = "";
                if (txt_loginUsuario.TextLength == 0)
                {
                    err = true;
                    mens += "El campo Login es obligatorio \n";
                }
                else id = txt_loginUsuario.Text;
                if (txt_contraseñaUsuario.TextLength == 0)
                {
                    err = true;
                    mens += "El campo Password es obligatorio \n";
                }
                else pin = txt_contraseñaUsuario.Text;
                if (err)
                {
                    DialogResult answer = MessageBox.Show(this,
                        "Revise los datos introducidos \n" + mens,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    loginUser = service.login(id, pin);
                    ventanaIniciado vi = new ventanaIniciado(service);
                    vi.ShowDialog();
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            registroEmpleado re = new registroEmpleado(service);
            re.ShowDialog();
        }*/

        private void btn_iniciaEmpleado_Click(object sender, EventArgs e)
        {
            Boolean err = false;
            string mens = "";
            string id1 = "";
            int pin1 = 0;
            if (txt_loginEmpleado.TextLength == 0)
            {
                err = true;
                mens += "El campo Login es obligatorio \n";
            }
            else id1 = txt_loginEmpleado.Text;
            try
            {
                pin1 = int.Parse(txt_contraseñaEmpleado.Text);
            }
            catch (FormatException a)
            {
                err = true;
                mens += "El campo Password es obligatorio \n";
            }
            if (err)
            {
                DialogResult answer = MessageBox.Show(this,
                    "Revise los datos introducidos \n" + mens,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                loginEmployee = service.login(id1, pin1);
                ventanaIniciadoEmpleado vLe = new ventanaIniciadoEmpleado(service); 
                vLe.ShowDialog();
            }
        }

        private void txt_contraseñaUsuario_TextChanged(object sender, EventArgs e)
        {
            txt_contraseñaUsuario.PasswordChar = '*';
        }

        private void txt_contraseñaEmpleado_TextChanged(object sender, EventArgs e)
        {
            txt_contraseñaEmpleado.PasswordChar = '*';
        }
    }
}
