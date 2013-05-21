using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class TableCreateRowDeleteForm : System.Windows.Forms.Form
{
  private System.Windows.Forms.DataGrid dataGrid1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox textBox3;
  private System.Windows.Forms.Button DeleteRow;
  private System.Windows.Forms.Button AddRow;

  private System.ComponentModel.Container components = null;

  private System.Data.DataTable custTable;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.GroupBox groupBox3;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Button SearchButton;
  private System.Windows.Forms.TextBox SearchBox;
  private System.Data.DataSet dtSet;

  public TableCreateRowDeleteForm()
  {
    InitializeComponent();

  }

  protected override void Dispose( bool disposing )
  {
    if( disposing )
    {
      if (components != null) 
      {
        components.Dispose();
      }
    }
    base.Dispose( disposing );
  }

  private void InitializeComponent()
  {
    this.dataGrid1 = new System.Windows.Forms.DataGrid();
    this.label1 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.textBox1 = new System.Windows.Forms.TextBox();
    this.textBox2 = new System.Windows.Forms.TextBox();
    this.label3 = new System.Windows.Forms.Label();
    this.textBox3 = new System.Windows.Forms.TextBox();
    this.DeleteRow = new System.Windows.Forms.Button();
    this.AddRow = new System.Windows.Forms.Button();
    this.groupBox1 = new System.Windows.Forms.GroupBox();
    this.groupBox2 = new System.Windows.Forms.GroupBox();
    this.groupBox3 = new System.Windows.Forms.GroupBox();
    this.SearchButton = new System.Windows.Forms.Button();
    this.SearchBox = new System.Windows.Forms.TextBox();
    this.label4 = new System.Windows.Forms.Label();
    ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
    this.groupBox1.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.groupBox3.SuspendLayout();
    this.SuspendLayout();
    // 
    // dataGrid1
    // 
    this.dataGrid1.DataMember = "";
    this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
    this.dataGrid1.Location = new System.Drawing.Point(8, 0);
    this.dataGrid1.Name = "dataGrid1";
    this.dataGrid1.Size = new System.Drawing.Size(392, 200);
    this.dataGrid1.TabIndex = 0;
    // 
    // label1
    // 
    this.label1.Location = new System.Drawing.Point(16, 24);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(80, 24);
    this.label1.TabIndex = 1;
    this.label1.Text = "Name";
    // 
    // label2
    // 
    this.label2.Location = new System.Drawing.Point(144, 24);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(104, 24);
    this.label2.TabIndex = 2;
    this.label2.Text = "Address";
    // 
    // textBox1
    // 
    this.textBox1.Location = new System.Drawing.Point(16, 64);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new System.Drawing.Size(120, 20);
    this.textBox1.TabIndex = 3;
    this.textBox1.Text = "";
    // 
    // textBox2
    // 
    this.textBox2.Location = new System.Drawing.Point(144, 64);
    this.textBox2.Name = "textBox2";
    this.textBox2.Size = new System.Drawing.Size(240, 20);
    this.textBox2.TabIndex = 4;
    this.textBox2.Text = "";
    // 
    // label3
    // 
    this.label3.Location = new System.Drawing.Point(16, 32);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(88, 16);
    this.label3.TabIndex = 5;
    this.label3.Text = "Enter Row #";
    // 
    // textBox3
    // 
    this.textBox3.Location = new System.Drawing.Point(16, 64);
    this.textBox3.Name = "textBox3";
    this.textBox3.Size = new System.Drawing.Size(88, 20);
    this.textBox3.TabIndex = 6;
    this.textBox3.Text = "";
    // 
    // DeleteRow
    // 
    this.DeleteRow.BackColor = System.Drawing.Color.Silver;
    this.DeleteRow.Location = new System.Drawing.Point(16, 96);
    this.DeleteRow.Name = "DeleteRow";
    this.DeleteRow.Size = new System.Drawing.Size(96, 24);
    this.DeleteRow.TabIndex = 7;
    this.DeleteRow.Text = "Delete Row";
    this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
    // 
    // AddRow
    // 
    this.AddRow.BackColor = System.Drawing.Color.Silver;
    this.AddRow.Location = new System.Drawing.Point(288, 16);
    this.AddRow.Name = "AddRow";
    this.AddRow.Size = new System.Drawing.Size(96, 24);
    this.AddRow.TabIndex = 8;
    this.AddRow.Text = "Add Row";
    this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
    // 
    // groupBox1
    // 
    this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
    this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                        this.label2,
                                        this.textBox2,
                                        this.label1,
                                        this.textBox1,
                                        this.AddRow});
    this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
    this.groupBox1.Location = new System.Drawing.Point(0, 208);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new System.Drawing.Size(400, 104);
    this.groupBox1.TabIndex = 9;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Add Rows Section";
    // 
    // groupBox2
    // 
    this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
    this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                        this.textBox3,
                                        this.label3,
                                        this.DeleteRow});
    this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
    this.groupBox2.Location = new System.Drawing.Point(408, 8);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new System.Drawing.Size(136, 144);
    this.groupBox2.TabIndex = 10;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Remove Rows Section";
    // 
    // groupBox3
    // 
    this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
    this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                        this.SearchButton,
                                        this.SearchBox,
                                        this.label4});
    this.groupBox3.Location = new System.Drawing.Point(408, 176);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new System.Drawing.Size(136, 136);
    this.groupBox3.TabIndex = 11;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Search";
    // 
    // SearchButton
    // 
    this.SearchButton.BackColor = System.Drawing.Color.Silver;
    this.SearchButton.ForeColor = System.Drawing.Color.Black;
    this.SearchButton.Location = new System.Drawing.Point(16, 96);
    this.SearchButton.Name = "SearchButton";
    this.SearchButton.Size = new System.Drawing.Size(112, 24);
    this.SearchButton.TabIndex = 2;
    this.SearchButton.Text = "Search";
    this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
    // 
    // SearchBox
    // 
    this.SearchBox.Location = new System.Drawing.Point(16, 56);
    this.SearchBox.Name = "SearchBox";
    this.SearchBox.Size = new System.Drawing.Size(112, 20);
    this.SearchBox.TabIndex = 1;
    this.SearchBox.Text = "";
    // 
    // label4
    // 
    this.label4.Location = new System.Drawing.Point(16, 24);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(112, 24);
    this.label4.TabIndex = 0;
    this.label4.Text = "Enter Name";
    // 
    // TableCreateRowDeleteForm
    // 
    this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
    this.ClientSize = new System.Drawing.Size(552, 317);
    this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                    this.groupBox3,
                                    this.groupBox2,
                                    this.groupBox1,
                                    this.dataGrid1});
    this.Name = "TableCreateRowDeleteForm";
    this.Text = "TableCreateRowDeleteForm";
    this.Load += new System.EventHandler(this.TableCreateRowDeleteForm_Load);
    ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
    this.groupBox1.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox3.ResumeLayout(false);
    this.ResumeLayout(false);

  }
  [STAThread]
  static void Main() 
  {
    Application.Run(new TableCreateRowDeleteForm());
  }

  
    private void RefreshData()
    {
        dataGrid1.DataSource = dtSet.DefaultViewManager;
    }


  private void CreateMyNewTable()
  {
    custTable = new DataTable("MyNewTable");
    DataColumn dtColumn;
    
    // Create id Column
    dtColumn = new DataColumn();
    dtColumn.DataType = System.Type.GetType("System.Int32");
    dtColumn.ColumnName = "id";
    dtColumn.AutoIncrement = true;
    dtColumn.AutoIncrementSeed = 100;
    dtColumn.AutoIncrementStep = 1;
    dtColumn.Caption = "Cust ID";
    dtColumn.ReadOnly = true;
    dtColumn.Unique = true;
    // Add id Column to the DataColumnCollection.
    custTable.Columns.Add(dtColumn);

    // Create Name column.
    dtColumn = new DataColumn();
    dtColumn.DataType = System.Type.GetType("System.String");
    dtColumn.ColumnName = "Name";
    dtColumn.Caption = "Cust Name";
    dtColumn.AutoIncrement = false;
    dtColumn.ReadOnly = false;
    dtColumn.Unique = false;
    // Add Name column to the table.
    custTable.Columns.Add(dtColumn);


    // Create Address column.
    dtColumn = new DataColumn();
    dtColumn.DataType = System.Type.GetType("System.String");
    dtColumn.ColumnName = "Address";
    dtColumn.Caption = "Address";
    dtColumn.ReadOnly = false;
    dtColumn.Unique = false;
    // Add Address column to the table.
    custTable.Columns.Add(dtColumn);

    // Make the ID column the primary key column.
    DataColumn[] PrimaryKeyColumns = new DataColumn[1];
    PrimaryKeyColumns[0] = custTable.Columns["id"];
    custTable.PrimaryKey = PrimaryKeyColumns;

    // Instantiate the DataSet variable.
    dtSet = new DataSet("MyNewTable");
    // Add the custTable to the DataSet.
    dtSet.Tables.Add(custTable);  
    
    RefreshData();      
        
  }

  private void TableCreateRowDeleteForm_Load(object sender, System.EventArgs e)
  {
    CreateMyNewTable();
  }

  private void AddRow_Click(object sender, System.EventArgs e)
    {
        DataRow myDataRow = custTable.NewRow();
        myDataRow["Name"] = textBox1.Text.ToString();
        myDataRow["Address"] = textBox2.Text.ToString();
        custTable.Rows.Add(myDataRow);
        custTable.AcceptChanges();      
        RefreshData();
    }

    private void DeleteRow_Click(object sender, System.EventArgs e)
    {
        int idx = Convert.ToInt32(textBox3.Text.ToString());
        DataRow row = custTable.Rows[idx -1];
        row.Delete();
        row.AcceptChanges();
    }

    private void SearchButton_Click(object sender, System.EventArgs e)
    {
        string str = "Name <>'"+ SearchBox.Text +"'" ;
        DataRow[] rows = custTable.Select(str);
        
        if(rows.Length == 0)
        {
            MessageBox.Show("Name not found!");
            return;
        }

        for (int i=0; i< rows.Length; i++)
        {
            rows[i].Delete();
            rows[i].AcceptChanges();
        }
        RefreshData();
    }
}