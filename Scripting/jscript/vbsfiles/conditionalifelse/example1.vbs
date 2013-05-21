' VBScript source code

Dim a, b, c
a = 60
b = 40
c = 30

if a >= b then
if a >= c then
wscript.Echo "a is greatest "
else 
wscript.echo "c is greatest" 
end if
else
if b > c then
wscript.echo "b is greatest"
else
wscript.echo "c is greatest"
end if
end if