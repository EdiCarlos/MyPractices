using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using System.Text;

class Program
{
[STAThread]
static void Main()
{
Application.EnableVisualStyles();
Application.Run(new Form1());
}
}
class Form1 : Form
{
public DataGridView grid;
public Button btn;
public Form1()
{
InitializeComponent();
}

public void InitializeComponent()
{
grid = new DataGridView();
btn = new Button();
this.MinimumSize = new Size(400, 400);

this.btn.Click += new EventHandler(click_btn);
this.btn.Location = new Point(190, 100);
this.btn.Text = "Show Data";
this.Size = new Size(600, 600);
this.Text = "This is title";
this.grid.Size = new Size(500, 400);
this.grid.Location = new Point(50, 150);
this.grid.CellFormatting += new DataGridViewCellFormattingEventHandler(cellformatting);
this.Controls.Add(grid);
this.Controls.Add(btn);
}
int rvalue = 0;
private void cellformatting(object sender, DataGridViewCellFormattingEventArgs e)
{
if(grid.Columns[e.ColumnIndex].Name == "lane_id")
{
rvalue = Convert.ToInt32(e.Value);
//e.CellStyle.BackColor = Color.Red;
}
if(rvalue < 10)
{
this.grid.Rows[rvalue].DefaultCellStyle.BackColor = Color.Red;
}
else if(rvalue < 20)
{
this.grid.Rows[rvalue].DefaultCellStyle.BackColor = Color.Green;
}
else
{
this.grid.Rows[rvalue].DefaultCellStyle.BackColor = Color.Yellow;
}

}
private void CreateUnboundButtonColumn()
{
    // Initialize the button column.
    DataGridViewButtonColumn buttonColumn =  new DataGridViewButtonColumn();
    buttonColumn.Name = "Details";
    buttonColumn.HeaderText = "Details";
    buttonColumn.Text = "View Details";

    // Use the Text property for the button text for all cells rather
    // than using each cell's value as the text for its own button.
    buttonColumn.UseColumnTextForButtonValue = true;

    // Add the button column to the control.
    grid.Columns.Insert(1, buttonColumn);
}

public void click_btn(object sender, EventArgs e)
{
OleDbConnection con = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=D:\\");
try
{
con.Open();
//OleDbCommand cmd = new OleDbCommand(@"select * from d:\temp\mtab.dbf", con);
OleDbDataAdapter ad = new OleDbDataAdapter(@"select * from d:\temp\prac.dbf", con);
DataSet set = new DataSet();
ad.Fill(set);
this.grid.DataSource = set.Tables[0];
//this.grid.DataBind();
grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

}
catch(OleDbException ex)
{
Console.WriteLine(ex.Message);
}
finally
{
con.Close();
}
}
}