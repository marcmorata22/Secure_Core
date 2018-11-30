﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WookieTablas
{
    public partial class SpaceShipTypes : MantenimientoTest.MantenimentBase
    {
        public SpaceShipTypes()
        {
            InitializeComponent();
            query = "Select * from SpaceShipTypes";
            id = "idSpaceShipType";
        }

        private void SpaceShipTypes_Load(object sender, EventArgs e)
        {
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
            ButtonAtras.Visible = true;
            TittleScreen.Text = "SpaceShipTypes";
        }
    }
}