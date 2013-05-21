using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsApplication1
{
      public class ListViewWithComboBox : ListView 
    {
        private ListViewItem item;
        string subItemText = "";
        int selectedSubItem = 0;
        private int X=0;
        private int Y=0;
        private System.Windows.Forms.ComboBox comboBoxLanguages = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.ComboBox comboBoxCountries = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

        public ListViewWithComboBox()
        {
            // set comboBoxLanguages (comboBox1)
            comboBoxLanguages.Items.Add("C#");
            comboBoxLanguages.Items.Add("Java");
            comboBoxLanguages.Items.Add("C++");
            comboBoxLanguages.Items.Add("PHP");
            comboBoxLanguages.Items.Add("Python");
            comboBoxLanguages.Items.Add("VB.Net");
            comboBoxLanguages.Items.Add("J#");
            comboBoxLanguages.Size = new System.Drawing.Size(0, 0);
            comboBoxLanguages.Location = new System.Drawing.Point(0, 0);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.comboBoxLanguages });
            comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.LanguageSelected);
            comboBoxLanguages.LostFocus += new System.EventHandler(this.LanguageFocusExit);
            comboBoxLanguages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LanguageKeyPress);
            comboBoxLanguages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguages.Hide();

            // set comboBoxCountries (comboBox2)
            comboBoxCountries.Items.Add("India");
            comboBoxCountries.Items.Add("USA");
            comboBoxCountries.Items.Add("UK");
            comboBoxCountries.Items.Add("Australia");
            comboBoxCountries.Items.Add("Japan");
            comboBoxCountries.Items.Add("China");
            comboBoxCountries.Items.Add("Africa");
            comboBoxCountries.Size = new System.Drawing.Size(0, 0);
            comboBoxCountries.Location = new System.Drawing.Point(0, 0);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.comboBoxCountries });
            comboBoxCountries.SelectedIndexChanged += new System.EventHandler(this.CountrySelected);
            comboBoxCountries.LostFocus += new System.EventHandler(this.CountryFocusExit);
            comboBoxCountries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryKeyPress);
            comboBoxCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountries.Hide();


            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        
            this.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                            this.columnHeader1,
                                                                            this.columnHeader2,
                                                                           });
            
            this.Name = "listViewWithComboBox1";
            this.Size = new System.Drawing.Size(0,0);
            this.TabIndex = 0;
            this.View = System.Windows.Forms.View.Details;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseDown);
            this.DoubleClick += new System.EventHandler(this.ListViewDoubleClick);
            this.GridLines = true ;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Languages";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Countries";
            this.columnHeader2.Width = 100;
        }

        private void LanguageKeyPress(object sender , System.Windows.Forms.KeyPressEventArgs e)
        {
            if ( e.KeyChar == 13 || e.KeyChar == 27 )
            {
                comboBoxLanguages.Hide();
            }
        }

        private void CountryKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 27)
            {
                comboBoxCountries.Hide();
            }
        }

        private void LanguageSelected(object sender , System.EventArgs e)
        {
            int i = comboBoxLanguages.SelectedIndex;
            if ( i >= 0 )
            {
                string str = comboBoxLanguages.Items[i].ToString();
                item.SubItems[selectedSubItem].Text = str;
            }
        }

        private void CountrySelected(object sender, System.EventArgs e)
        {
            int i = comboBoxCountries.SelectedIndex;
            if (i >= 0)
            {
                string str = comboBoxCountries.Items[i].ToString();
                item.SubItems[selectedSubItem].Text = str;
            }
        }

        private void LanguageFocusExit(object sender , System.EventArgs e)
        {
            comboBoxLanguages.Hide();
        }
        private void CountryFocusExit(object sender, System.EventArgs e)
        {
            comboBoxCountries.Hide();
        }

        public  void ListViewDoubleClick(object sender, System.EventArgs e)
        {
            // Check whether the subitem was clicked
            int start = X ;
            int position = 0 ; 
            int end = this.Columns[0].Width ;
            for ( int i=0; i < this.Columns.Count ; i++)
            {
                if ( start > position && start < end ) 
                {
                    selectedSubItem = i ;
                    break; 
                }
                
                position = end ; 
                end += this.Columns[i].Width;
            }

            subItemText = item.SubItems[selectedSubItem].Text ;

            string column = this.Columns[selectedSubItem].Text ;
            if (column == "Languages") 
            {
                Rectangle r = new Rectangle(position, item.Bounds.Top ,end  , item.Bounds.Bottom);
                comboBoxLanguages.Size  = new System.Drawing.Size(end - position , item.Bounds.Bottom-item.Bounds.Top);
                comboBoxLanguages.Location = new System.Drawing.Point(position, item.Bounds.Y);
                comboBoxLanguages.Show();
                comboBoxLanguages.Text = subItemText;
                comboBoxLanguages.SelectAll();
                comboBoxLanguages.Focus();
            }
            else if(column == "Countries")
            {
                Rectangle r = new Rectangle(position, item.Bounds.Top, end, item.Bounds.Bottom);
                comboBoxCountries.Size = new System.Drawing.Size(end - position, item.Bounds.Bottom - item.Bounds.Top);
                comboBoxCountries.Location = new System.Drawing.Point(position, item.Bounds.Y);
                comboBoxCountries.Show();
                comboBoxCountries.Text = subItemText;
                comboBoxCountries.SelectAll();
                comboBoxCountries.Focus();
            }
        }

        public void ListViewMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            item  = this.GetItemAt(e.X , e.Y);
            X = e.X ;
            Y = e.Y ;
        }

    }
}
