using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWnFormsClientes.Models;

namespace CrudWnFormsClientes.exhibition
{
    public partial class FormCliente : Form
    {
        public int? idCliente;
        Clientes oclientes = null;
        public FormCliente(int? idCliente=null)
        {
            InitializeComponent();

            this.idCliente = idCliente;
            if (idCliente != null)
                CargaDatos();

        }

        private void CargaDatos()
        {
            using (WnFormsClienteEntities db = new WnFormsClienteEntities())
            {
                oclientes = db.Clientes.Find(idCliente);
                txtNombres.Text = oclientes.Nombres;
                txtApellidos.Text = oclientes.Apellidos;
                txtDireccion.Text = oclientes.Direccion;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WnFormsClienteEntities db= new WnFormsClienteEntities())
            {
                if(idCliente==null)
                oclientes = new Clientes();
                oclientes.Nombres = txtNombres.Text;
                oclientes.Apellidos = txtApellidos.Text;
                oclientes.Direccion = txtDireccion.Text;

                if (idCliente==null)
                    db.Clientes.Add(oclientes);
                else
                {
                    db.Entry(oclientes).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                this.Close();

            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
