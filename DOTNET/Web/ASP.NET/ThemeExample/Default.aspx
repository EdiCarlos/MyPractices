<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/MasterPage.master" %>

<%@ Register src="MyControl.ascx" tagname="MyControl" tagprefix="uc1" %>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
--%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat='server' ID="defaultPage" >
    <asp:Label ID="lbl1" runat='server' Text="Login Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <uc1:MyControl ID="MyControl1" runat="server"/>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Change Theme" />
</asp:Content>
