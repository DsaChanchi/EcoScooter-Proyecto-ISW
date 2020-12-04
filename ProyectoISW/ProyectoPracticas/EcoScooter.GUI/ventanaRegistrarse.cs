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
    public partial class ventanaRegistrarse : Form
    {
        private IEcoScooterService service;
        public ventanaRegistrarse(IEcoScooterService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUser();
            this.Close();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUser()
        {
            try
            {
                String nombre = txt_nombre.Text;  //nombre
                String dni = txt_dni.Text;  //dni
                DateTime fechaNac = txt_fechaNacimiento.Value.Date; //fechaNac
                String cvv = txt_cvv.Text;
                int tarjetaCvv = Convert.ToInt32(cvv); //Cvv
                int telefonoInt = Convert.ToInt32(txt_telefono.Text);

                //String telefono = txt_telefono.Text;
                //int telefonoInt = int.Parse(telefono);  //telefono

                String email = txt_correo.Text;  //email
                DateTime fechaCaducidad = txt_fechaCaducidad.Value.Date;  //caducidad de la tarjeta 
                String contraseña = txt_contraseña.Text;  //password
                int numeroTarjetaInt = Convert.ToInt32(txt_tarjetaCredito.Text);

                //String numeroTarjeta = txt_tarjetaCredito.Text;  
                //int numeroTarjetaInt = int.Parse(numeroTarjeta);  //numero tarjeta

                String login = txt_login.Text;  //login
                User u1 = new User(fechaNac, dni, email, nombre, telefonoInt, tarjetaCvv, fechaCaducidad, login, numeroTarjetaInt, contraseña);
                service.registerUser(u1);
                service.saveChanges();
            }
            catch (ServiceException ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btb_completarRegistro_Click(object sender, EventArgs e)
        {
            addUser();
            this.Close();
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
