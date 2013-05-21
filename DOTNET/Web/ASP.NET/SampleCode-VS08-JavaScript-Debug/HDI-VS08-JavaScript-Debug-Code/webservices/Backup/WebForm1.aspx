<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="ExerciseSoapReverserExtension.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="buttonCallHelloWorld" style="Z-INDEX: 101; LEFT: 96px; POSITION: absolute; TOP: 107px"
				runat="server" Text="Call HelloWorld" Width="162px"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 96px; POSITION: absolute; TOP: 144px" runat="server"
				Width="208px"></asp:Label>
			<asp:TextBox id="TextBoxName" style="Z-INDEX: 103; LEFT: 212px; POSITION: absolute; TOP: 73px"
				runat="server"></asp:TextBox>
			<asp:Label id="label2" style="Z-INDEX: 104; LEFT: 101px; POSITION: absolute; TOP: 72px" runat="server"
				Width="87px">Enter Name:</asp:Label>
		</form>
	</body>
</HTML>
