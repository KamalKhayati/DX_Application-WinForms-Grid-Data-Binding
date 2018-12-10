﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace Test__EF_Code_First
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Entity_Framework_Data.DBContext dbContext = new Entity_Framework_Data.DBContext();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.DimProducts.Load();
            // This line of code is generated by Data Source Configuration Wizard
            dimProductsBindingSource.DataSource = dbContext.DimProducts.Local.ToBindingList();
        }
    }
}
