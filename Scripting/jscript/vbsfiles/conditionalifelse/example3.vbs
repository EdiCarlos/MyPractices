' VBScript source code

dim var1

var1 = 4

select case var1
Case 1 
wscript.echo " = 1"
Case 2
wscript.echo " = 2"
Case 3 
wscript.echo " = 3"
Case 10 
wscript.echo " = 10"
case else
wscript.echo "invalid"
end select