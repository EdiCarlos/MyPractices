// JScript source code

var oexcel;
var excelsheet;
oexcel = new ActiveXObject("Excel.Application");
excelsheet = new ActiveXObject("Excel.Sheet");

excelsheet.Application.Visible = true;
excelsheet.ActiveSheet.Cells(1,1).Value = "100";
excelsheet.SaveAs("d:\\documents and settings\axkhan2\desktop\myexcel.xls");
