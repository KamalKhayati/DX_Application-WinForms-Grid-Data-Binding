namespace Working_with_Columns_In_Code
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCase2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCase3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCase4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnswer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dB_EFCF_DXApplication_Exercise_04DataSet = new Working_with_Columns_In_Code.DB_EFCF_DXApplication_Exercise_04DataSet();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource();
            this.questionsTableAdapter = new Working_with_Columns_In_Code.DB_EFCF_DXApplication_Exercise_04DataSetTableAdapters.QuestionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EFCF_DXApplication_Exercise_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(971, 549);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGroupId,
            this.colClass,
            this.colQuestionText,
            this.colCase1,
            this.colCase2,
            this.colCase3,
            this.colCase4,
            this.colAnswer,
            this.colCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.Visible = true;
            this.colGroupId.VisibleIndex = 1;
            // 
            // colClass
            // 
            this.colClass.FieldName = "Class";
            this.colClass.Name = "colClass";
            this.colClass.Visible = true;
            this.colClass.VisibleIndex = 2;
            // 
            // colQuestionText
            // 
            this.colQuestionText.FieldName = "QuestionText";
            this.colQuestionText.Name = "colQuestionText";
            this.colQuestionText.Visible = true;
            this.colQuestionText.VisibleIndex = 3;
            // 
            // colCase1
            // 
            this.colCase1.FieldName = "Case1";
            this.colCase1.Name = "colCase1";
            this.colCase1.Visible = true;
            this.colCase1.VisibleIndex = 4;
            // 
            // colCase2
            // 
            this.colCase2.FieldName = "Case2";
            this.colCase2.Name = "colCase2";
            this.colCase2.Visible = true;
            this.colCase2.VisibleIndex = 5;
            // 
            // colCase3
            // 
            this.colCase3.FieldName = "Case3";
            this.colCase3.Name = "colCase3";
            this.colCase3.Visible = true;
            this.colCase3.VisibleIndex = 6;
            // 
            // colCase4
            // 
            this.colCase4.FieldName = "Case4";
            this.colCase4.Name = "colCase4";
            this.colCase4.Visible = true;
            this.colCase4.VisibleIndex = 7;
            // 
            // colAnswer
            // 
            this.colAnswer.FieldName = "Answer";
            this.colAnswer.Name = "colAnswer";
            this.colAnswer.Visible = true;
            this.colAnswer.VisibleIndex = 8;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 9;
            // 
            // dB_EFCF_DXApplication_Exercise_04DataSet
            // 
            this.dB_EFCF_DXApplication_Exercise_04DataSet.DataSetName = "DB_EFCF_DXApplication_Exercise_04DataSet";
            this.dB_EFCF_DXApplication_Exercise_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.dB_EFCF_DXApplication_Exercise_04DataSet;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 549);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working with Columns In Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EFCF_DXApplication_Exercise_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestionText;
        private DevExpress.XtraGrid.Columns.GridColumn colCase1;
        private DevExpress.XtraGrid.Columns.GridColumn colCase2;
        private DevExpress.XtraGrid.Columns.GridColumn colCase3;
        private DevExpress.XtraGrid.Columns.GridColumn colCase4;
        private DevExpress.XtraGrid.Columns.GridColumn colAnswer;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DB_EFCF_DXApplication_Exercise_04DataSet dB_EFCF_DXApplication_Exercise_04DataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private DB_EFCF_DXApplication_Exercise_04DataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
    }
}

