' VBScript source code

dim fname

fname = "kha"

if fname = "arif" then
wscript.echo fname + "your first name"
elseif fname = " khan" then
wscript.echo fname + "last name"
elseif fname = "hasan" then
wscript.echo fname + " middle name"
else
wscript.echo "invalid"
end if
