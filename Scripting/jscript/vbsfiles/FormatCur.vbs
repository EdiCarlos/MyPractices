' VBScript source code

Dim cur
cur = 100000000
ncur = FormatCurrency(cur)
wscript.Echo ncur
for i = 0 to WScript.Arguments.Count - 1
wscript.echo WScript.Arguments.Named(0)
next
