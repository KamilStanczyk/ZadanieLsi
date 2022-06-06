using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZadanieLsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartSettings();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string lokal = cbLokal.SelectedItem.ToString();
            DateTime dateTo = dateTimePickerTo.Value;
            DateTime dateSince = dateTimePickerSince.Value;
            using (Database1Entities context = new Database1Entities())
            {
                var raports = context.Raport.Where(r=>r.Lokal==lokal&&dateTo.CompareTo(r.Data)>0&&dateSince.CompareTo(r.Data)<0).ToList();
                dataGridViewRaport.DataSource = raports;


            }
        }

        private void StartSettings()
        {
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            dateTimePickerSince.Format = DateTimePickerFormat.Custom;
            dateTimePickerSince.CustomFormat = "dd/MM/yyyy";
            using (Database1Entities context = new Database1Entities())
            {
                var lokals = context.Raport.Select(r => r.Lokal).Distinct().ToList();
                foreach (string lokal in lokals)
                {
                    cbLokal.Items.Add(lokal);
                }
            }
        }
    }
}
