Imports System
Imports System.Drawing
Imports System.Windows.Forms

class myFirstFrm 
inherits System.Windows.Forms.Form

public shared Sub Main()
Dim frm as new Form

with frm
.BackColor = System.Drawing.Color.Red
.ForeColor = Color.Black
.Text = "this is the title of my first form in Vb.net"
.TopMost = true
.MinimizeBox = false
.Enabled = true
.ShowDialog()
end with

Dim lbl as new Label

with lbl
.Text = "this is mylabel"
.ForeColor = Color.Black
.Location = new Point(10, 20)
End With

frm.Controls.Add(lbl)

End Sub

End Class
 