﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace Test_EF_CodeFirst
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Test_EF_CodeFirst.MyContext dbContext;
        public Form1()
        {
            InitializeComponent();
            using (var db = new MyContext())
            {
                if (!db.Database.Exists())
                {
                    db.Database.Initialize(true);

                }
            }

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Test_EF_CodeFirst.MyContext();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.User.Load();
            // This line of code is generated by Data Source Configuration Wizard
            userBindingSource.DataSource = dbContext.User.Local.ToBindingList();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Date", DateTime.Now.Date);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
    }
}