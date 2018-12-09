using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Working_with_Columns_In_Code
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            //gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridControl1.DataSource = questionsBindingSource;
            //gridView1.PopulateColumns();
            gridView1.Columns.Remove(gridView1.Columns["Class"]);
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { Caption="My Column",Visible=true,FieldName="Class",VisibleIndex=0});
            gridView1.Columns[0].AppearanceHeader.ForeColor = Color.Red;
            gridView1.Columns[0].AppearanceCell.BackColor = Color.Yellow;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EFCF_DXApplication_Exercise_04DataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.dB_EFCF_DXApplication_Exercise_04DataSet.Questions);

        }
    }
}
