class testclass
private sub class_Initialize 
msgbox("class initilaized")
end sub
private sub Class_Terminate
msgbox("class destroyed")
end sub

end class

set x = new testclass
set y = nothing