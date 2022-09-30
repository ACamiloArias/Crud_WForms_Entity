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

namespace CrudWnFormsClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        #region HELPER
       private void Refresh()
        { 
            using (WnFormsClienteEntities db = new WnFormsClienteEntities())
            {
                var lst = from d in db.Clientes
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
        private int? GetId()
        {
            try
            { 
               return int.Parse (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
             }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            exhibition.FormCliente oFormCliente = new exhibition.FormCliente();
            oFormCliente.ShowDialog();

            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? idCliente = GetId();
            if (idCliente != null)
            {
                exhibition.FormCliente oFormCliente = new exhibition.FormCliente(idCliente);
                oFormCliente.ShowDialog();

                Refresh();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? idCliente = GetId();
            if (idCliente != null)
            {
                using (WnFormsClienteEntities db= new WnFormsClienteEntities())
                {
                    Clientes oclientes = db.Clientes.Find(idCliente);
                    db.Clientes.Remove(oclientes);

                    db.SaveChanges();
                }
                Refresh();

            }
        }
    }
}
