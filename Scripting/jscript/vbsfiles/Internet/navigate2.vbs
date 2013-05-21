' VBScript source code

on error resume next

set intr = CreateObject("InternetExplorer.Application")
intr.Visible = True 
intr.left = 50
intr.top = 50
intr.height = 275
intr.width = 360
intr.menubar = 1
intr.toolbar = 1
intr.statusbar = 1

intr.Navigate2("http://www.google.com")