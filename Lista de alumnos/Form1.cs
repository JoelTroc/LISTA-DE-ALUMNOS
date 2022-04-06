using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem LISTA = new ListViewItem(t1.Text); //instancia al list view Y AGREGA EL TEXTO
            LISTA.SubItems.Add(t2.Text); // AGREGA EL TEXTO AL LITS VIEW
            LISTA.SubItems.Add(t3.Text); // AGREGA EL TEXTO AL LIST VIEW
            listView1.Items.Add(LISTA);
            t1.Text = ""; //BORRA EL TEXTO DEL TEXT BOX CUADNO APRIETO EN EL BOTON GUARDAR
            t2.Text = ""; //BORRA EL TEXTO DEL TEXT BOX CUANDO APRIETO EN EL BOTON GUARDAR
            t3.Text = ""; //BORRA EL TEXTO DEL TEXT BOX CUANDO APRIETO EN EL BOTON GUARDAR
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // CIERRA EL PROGRAMA CUANDO APRIETO EN EL BOTON SALIR
        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listView1.Items.Add(label4.Text);
              


        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
            label4.Text = listView1.SelectedItems.ToString();

        }
        //SACAR DATOS DEL LIST VIWE Y MOVERLOS A UN LABEL
    }
}
