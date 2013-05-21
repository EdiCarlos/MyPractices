' VBScript source code


do until dsp = vbNo
mynum = int (6 * Rnd + 1)
dsp = MsgBox(mynum &"put your name here", vbYesNo)
loop

do
mynum = int(8 * Rnd + 2)
dsp = MsgBox(mynum & " your random number", vbYesNo)
loop until dsp = vbNo

