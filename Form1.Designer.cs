
namespace ZadanieLsi
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRaport = new System.Windows.Forms.DataGridView();
            this.raportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSince = new System.Windows.Forms.DateTimePicker();
            this.LbSince = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.cbLokal = new System.Windows.Forms.ComboBox();
            this.database1DataSet = new ZadanieLsi.Database1DataSet();
            this.raportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raportTableAdapter = new ZadanieLsi.Database1DataSetTableAdapters.RaportTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRaport
            // 
            this.dataGridViewRaport.AllowUserToAddRows = false;
            this.dataGridViewRaport.AllowUserToDeleteRows = false;
            this.dataGridViewRaport.AutoGenerateColumns = false;
            this.dataGridViewRaport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewRaport.DataSource = this.raportBindingSource1;
            this.dataGridViewRaport.Location = new System.Drawing.Point(256, 33);
            this.dataGridViewRaport.Name = "dataGridViewRaport";
            this.dataGridViewRaport.ReadOnly = true;
            this.dataGridViewRaport.RowHeadersVisible = false;
            this.dataGridViewRaport.Size = new System.Drawing.Size(541, 405);
            this.dataGridViewRaport.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(31, 106);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // dateTimePickerSince
            // 
            this.dateTimePickerSince.Location = new System.Drawing.Point(31, 80);
            this.dateTimePickerSince.Name = "dateTimePickerSince";
            this.dateTimePickerSince.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSince.TabIndex = 3;
            // 
            // LbSince
            // 
            this.LbSince.AutoSize = true;
            this.LbSince.Location = new System.Drawing.Point(4, 86);
            this.LbSince.Name = "LbSince";
            this.LbSince.Size = new System.Drawing.Size(21, 13);
            this.LbSince.TabIndex = 4;
            this.LbSince.Text = "Od";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(7, 112);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(21, 13);
            this.lbTo.TabIndex = 5;
            this.lbTo.Text = "Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lokal";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(31, 157);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 8;
            this.btConfirm.Text = "Zatwierdź";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // cbLokal
            // 
            this.cbLokal.FormattingEnabled = true;
            this.cbLokal.Location = new System.Drawing.Point(45, 48);
            this.cbLokal.Name = "cbLokal";
            this.cbLokal.Size = new System.Drawing.Size(121, 21);
            this.cbLokal.TabIndex = 9;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raportBindingSource1
            // 
            this.raportBindingSource1.DataMember = "Raport";
            this.raportBindingSource1.DataSource = this.database1DataSet;
            // 
            // raportTableAdapter
            // 
            this.raportTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn3.HeaderText = "User";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lokal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lokal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLokal);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.LbSince);
            this.Controls.Add(this.dateTimePickerSince);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dataGridViewRaport);
            this.Name = "Form1";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRaport;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerSince;
        private System.Windows.Forms.Label LbSince;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.BindingSource raportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbLokal;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource raportBindingSource1;
        private Database1DataSetTableAdapters.RaportTableAdapter raportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

