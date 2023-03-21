using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void obtenertotal()
        {
            float costot = 0;
            int contador = 0;
            contador = dvglista.Rows.Count;
            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dvglista.Rows[i].Cells[4].Value.ToString());
                
            }
            IBItotalapagar.Text = costot.ToString();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dvglista);

            file.Cells[0].Value = IBIcodigo.Text;
            file.Cells[1].Value = IBInombre.Text;
            file.Cells[2].Value = IBIprecio.Text;
            file.Cells[3].Value = txtcantidad.Text;
            file.Cells[4].Value = (float.Parse(IBIprecio.Text) * float.Parse(txtcantidad.Text)).ToString();
            dvglista.Rows.Add(file);
            IBIcodigo.Text = IBInombre.Text = txtcantidad.Text = "";

            obtenertotal();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {


            try
            {
                DialogResult rrpta = MessageBox.Show("Deseas eliminar el producto",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rrpta == DialogResult.Yes)
                {
                    dvglista.Rows.Remove(dvglista.CurrentRow);
                }



            }
            catch { }
            obtenertotal();
        }

        private void cmbproducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int cod;
            string nom;
            float precio;
            cod = cmbproducto.SelectedIndex;
            nom = cmbproducto.SelectedItem.ToString();
            precio = cmbproducto.SelectedIndex;

            switch (cod)
            {
                case 0: IBIcodigo.Text = "0011"; break;
                case 1: IBIcodigo.Text = "0022"; break;
                default: IBIcodigo.Text = "0033"; break;


            }
            switch (nom)
            {

                case "zapatos": IBInombre.Text = "zapatos"; break;
                case "zapatillas": IBInombre.Text = "zapatillas"; break;
                default: IBInombre.Text = "medias"; break;
            }
            switch (precio)
            {
                case 0: IBIprecio.Text = "130"; break;
                case 1: IBIprecio.Text= "120"; break;
                default: IBIprecio.Text = "160"; break;

            }


        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvglista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IBIdevolucion.Text = (float.Parse(txtefectivo.Text), float.Parse(IBItotalapagar.Text)).ToString();




            }
            catch
            {
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (dvglista.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dvglista.CurrentRow.Cells[0].Value);

                this.Close();
            }
            else
                MessageBox.Show("debe de selecionar una fila");
        }
    }
    }

