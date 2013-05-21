' VBScript source code

do 'while count <> 20
count = count + 1
wscript.echo(count)
if count = 10 then
exit do
end if
loop until count = 20
