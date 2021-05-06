using Ejercicio_Grupo_1.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Grupo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Carga();
        }

        void Carga()
        {
            dtgDatos.Rows.Clear();
            using (Grupo1Entities db = new Grupo1Entities())
            {
                var Lista = db.Tbl_Datos1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgDatos.Rows.Add( iteracion.Datos);
                }
            }
        }

        void Clear()
        {
            txtDatos.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Grupo1Entities db = new Grupo1Entities())
                {
                    Tbl_Datos1 userList = new Tbl_Datos1();

                    userList.Datos = txtDatos.Text;
                    
                    db.Tbl_Datos1.Add(userList);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Carga();
            Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            String Datos = dtgDatos.CurrentRow.Cells[0].Value.ToString();


            txtDatos.Text = Datos;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
