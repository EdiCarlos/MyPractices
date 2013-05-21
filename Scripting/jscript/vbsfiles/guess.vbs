Dim gu, rand

rand = Int(100 * Rnd(6) + 1)
gu = CInt(InputBox("Enter your gues",,0))

do 
if Eval("rand = gu")  Then
msgbox "congrates"
else
gu = CInt(InputBox("Enter you guess Again " & CStr(rand),, 0))
end if 
loop until gu = 1
