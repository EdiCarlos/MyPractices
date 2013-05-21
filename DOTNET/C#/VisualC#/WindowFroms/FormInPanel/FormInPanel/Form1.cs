using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormInPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form frm = new Form2();
            //frm.TopLevel = false;
            //frm.ControlBox = false;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Dock = DockStyle.Bottom;
            //frm.Show();

            //panel1.Controls.Add(frm);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //    button1.DoDragDrop(button1.Text, DragDropEffects.Copy | DragDropEffects.Move);
            //button1.DoDragDrop(button1, DragDropEffects.Copy | DragDropEffects.Move);
            //mDraggin = true;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
                // textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.Button"))
            {
                e.Effect = DragDropEffects.Move;
                //panel1.Controls.Add((Control)DragDropEffects.Copy);
                // panel1.Controls.Add((Control)e.Data.GetData("System.Windows.Forms.Button"));
                //panel1.Controls[0].Location = MouseLocation;
            }

        }



        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            MouseLocation = e.Location;
        }


        private void panel1_Move(object sender, EventArgs e)
        {

        }

        private void panel1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            toolStripStatusLabel2.Text = e.Action.ToString();
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

        }
        Point MouseLocation;
        bool mDraggin = false;
        bool mPanel = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPanel = true;
        }



        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mDraggin = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mDraggin = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDraggin)
            {
                //button1.DoDragDrop(button1, DragDropEffects.Copy | DragDropEffects.Move);
                if (this.PointToClient(e.Location).X >= 0 && this.PointToClient(e.Location).Y >= 0)
                {
                    label1.Location = this.PointToClient(new Point(e.X, e.Y));
                    toolStripStatusLabel1.Text = "X : " + e.X + "Y : " + e.Y;
                    toolStripStatusLabel2.Text = "Location = (X " + e.Location.X + ", Y " + e.Location.Y + ")";
                }
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mPanel = false;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "mouse left";
        }


    }
}
