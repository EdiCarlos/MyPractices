using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load_form();
        }
        public void load_form()
        {
            DataTable table = new DataTable();
            //table.Columns.Add();
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.AutoComplete = true;
            comboColumn.DisplayIndex = 2;
            comboColumn.Items.Add("Mumbai");
            comboColumn.Items.Add("Delhi");
            comboColumn.Items.Add("Kolkatta");
            dataGridView1.Columns.Add(comboColumn);
            //((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells[1]).DisplayMember = "Mumbai";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[1];
                cell.Value = "Delhi";
            }
            //dataGridView1.Refresh();
            //dataGridView1.Rows[0].Cells.Add(cell);// = cell;//(DataGridView) as cell;
            //dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            //((DataGridViewComboBoxColumn)this.dataGridView1.Columns[0]).Items.AddRange("Mumbai", "Delhi", "Kolkata");
        }
        void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = (ComboBox)e.Control;
            combo.SelectedIndex = 2;
        }
    }
}
