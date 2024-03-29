﻿using MantenimientoTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaCerca
{
    public partial class Cerca : Form
    {
        public Cerca()
        {
            InitializeComponent();
        }
        #region Variables
        //Creamos el dataset
        DataSet dts;
        //Instanciamos la ConnectionClass
        ConnectionClass.ClassBDD BDD = new ConnectionClass.ClassBDD();            
        //Hacemos la consulta
        public string query = "select * from Sectors";
        #endregion

        #region Metodos
        public void Inicializar()
        {
            dts = BDD.PortaPerConsulta(query);
        }
        public void RellenarGrid(DataSet dts)
        {
            dGVCerca.DataSource = dts.Tables[0];
            dGVCerca.Columns[0].Visible = false;
        }
        public void Bindings()
        {

        }
        #endregion

        #region Eventos
        private void Cerca_Load(object sender, EventArgs e)
        {
            //al cargar utilice el metodo RellenarGrid
            Inicializar();
            RellenarGrid(dts);
            dGVCerca.AllowUserToAddRows = false;
        }

        #endregion

        private void dGVCerca_DoubleClick(object sender, EventArgs e)
        {
            try
            {                
                MessageBox.Show(dGVCerca.SelectedCells[1].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecciona toda la linea.");
            }
            
        }
    }
}
