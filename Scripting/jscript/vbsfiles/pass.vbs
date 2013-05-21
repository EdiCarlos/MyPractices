dim pass(8)
pass(o) = 115
pass(1) = 104
pass(2) = 121
pass(3) = 109
pass(4) = 97
pass(5) = 55
pass(6) = 56
pass(7) = 56
dim pStr

for each v in pass
pStr =  pStr + chr(v) 
next

wscript.echo pStr


