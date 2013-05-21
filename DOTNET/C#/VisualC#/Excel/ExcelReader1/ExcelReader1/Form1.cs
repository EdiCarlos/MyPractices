using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Ex = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace ExcelReader1
{
    public partial class Form1 : Form
    {
        public string ExcelFileName = String.Empty;
        int NumberOfSheets;
        ArrayList sheetname = new ArrayList();
        string[] cellsname;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                ExcelFileName = textBox1.Text;
                ReadExcelFile();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DataColumn col = new DataColumn("col");
            table.Columns.Add(col);

            for (int i = 0; i < 10; i++)
            {
                DataRow row = table.NewRow();
                row["col"] = i;
            }
            this.dataGridView1.DataSource = table;
          


        }
        private void ReadExcelFile()
        {
            
            Ex.Application appObj = new Microsoft.Office.Interop.Excel.Application();
            Ex.Workbook workbook = appObj.Workbooks.Open(ExcelFileName, 0, true, 5, "", "", true, Ex.XlPlatform.xlWindows, "\t", false, false, 0, true, false, false);
            Ex.Sheets sheets = workbook.Worksheets;
            NumberOfSheets = sheets.Count;

            foreach (Ex.Worksheet _sheet in sheets)
            {
                sheetname.Add(_sheet.Name);
            }
            Ex.Worksheet worksheet = (Ex.Worksheet)sheets.get_Item(1);
            Ex.Range range = worksheet.get_Range("A1", "IV1");
            System.Object [,] obj = (Object [,])range.get_Value(Missing.Value);
            cellsname = new string[obj.Length];
            foreach (Object rng in obj)
            {
                if (rng != null)
                {
                    comboBox1.Items.Add(rng.ToString());
                   
                }
            }
            
            workbook.Close(false, ExcelFileName, false);
            appObj.Quit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ex.Application appObj = new Microsoft.Office.Interop.Excel.Application();
            Ex.Workbook workbook = appObj.Workbooks.Open(ExcelFileName, 0, true, 5, "", "", true, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            Ex.Sheets sheets = workbook.Worksheets;

            Ex.Worksheet worksheet = (Ex.Worksheet)sheets.get_Item(1);
            Ex.Range findObj = worksheet.get_Range("A1", "IV65536").Find(comboBox1.SelectedItem, Missing.Value, Ex.XlFindLookIn.xlValues, Ex.XlLookAt.xlPart, Ex.XlSearchOrder.xlByRows, Ex.XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
            string address = findObj.get_Address(Missing.Value, Missing.Value, Ex.XlReferenceStyle.xlA1, Missing.Value, Missing.Value);
            string[] ch = address.Split('$');
            string columnName = ch[1];
            int rowNumber = int.Parse(ch[2]);

            Ex.Range range = worksheet.get_Range(columnName + (rowNumber + 1), columnName + (rowNumber + 65500));

            Object[,] obj = (object[,])range.get_Value(Missing.Value);
            comboBox2.Items.Clear();
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            {
                //column.DataPropertyName = ColumnName.TitleOfCourtesy.ToString();
                column.HeaderText = "MyColumn";
                column.Items.Clear();
                column.FlatStyle = FlatStyle.Flat;
                column.DataPropertyName = "DiplayMember";
                column.DisplayMember = "columnasdf";
            }
            dataGridView1.Columns.Insert(1, column);
            foreach (object item in obj)
            {
                if (item != null)
                {
                    comboBox2.Items.Add(item.ToString());
                    ((DataGridViewComboBoxColumn)this.dataGridView1.Columns[1]).Items.Add(item.ToString());
                }
            }
           
            workbook.Close(Missing.Value, ExcelFileName, Missing.Value);
            appObj.Quit();

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                ComboBox box = e.Control as ComboBox;
                box.SelectedIndexChanged += new EventHandler(box_SelectedIndexChanged);
            
            }
        }

        void box_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).SelectedIndex = 10;
            int index = ((ComboBox)sender).SelectedIndex;
            MessageBox.Show(index.ToString());
        }

      
        
    }
}
