<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDataControlEmployee.aspx.cs" Inherits="SqlDataSourceSample.SqlDataControlEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:SqlDataSource ID="SqlEmployeeDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:sqlDataSourceConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Employees]" InsertCommandType="StoredProcedure"
                DeleteCommand="DeleteEmployee"
                DeleteCommandType="StoredProcedure"
                >
                <DeleteParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="EmployeeID" PropertyName="SelectedValue" />
                </DeleteParameters>
            </asp:SqlDataSource>


            <asp:SqlDataSource ID="sqlDDLDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:sqlDataSourceConnectionString %>"
                SelectCommand="SELECT * FROM [Employees] where [EmployeeID] = @empID"
                InsertCommandType="StoredProcedure"
                InsertCommand="dbo.InsertIntoEmployee" 
                UpdateCommandType="StoredProcedure"
                UpdateCommand="dbo.UpdateEmployee">
                <SelectParameters>
                    <asp:Parameter Name="empID" Type="Int32" DefaultValue="0" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="EmployeeID" Type="Int32" DefaultValue="" />
                    <asp:Parameter Name="FirstName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="LastName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="MiddleName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="FatherName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="MotherName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="DateOfBith" Type="DateTime" DefaultValue="" />
                    <asp:Parameter Name="DriverLincense" Type="String" DefaultValue="" />
                </UpdateParameters>
                <InsertParameters>
                    <asp:Parameter Name="FirstName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="LastName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="MiddleName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="FatherName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="MotherName" Type="String" DefaultValue="" />
                    <asp:Parameter Name="DateOfBith" Type="DateTime" DefaultValue="" />
                    <asp:Parameter Name="DriverLincense" Type="String" DefaultValue="" />
                </InsertParameters>
            </asp:SqlDataSource>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlEmployeeDataSource" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                DataKeyNames="EmployeeID"
                >
                <Columns>
                    <asp:ButtonField Text="Select Field" HeaderText="Select" CommandName="Select" />
                    <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                    <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" SortExpression="MiddleName" />
                    <asp:BoundField DataField="FatherName" HeaderText="Father Name" SortExpression="FatherName" />
                    <asp:BoundField DataField="MotherName" HeaderText="Mother Name" SortExpression="MotherName" />
                    <asp:BoundField DataField="DateOfBith" HeaderText="Date Of Bith" SortExpression="DateOfBith" />
                    <asp:BoundField DataField="DriverLincense" HeaderText="Driver Lincense" SortExpression="DriverLincense" />
                    <asp:TemplateField HeaderText="Delete Row">
                        <ItemTemplate>
                            <asp:LinkButton ID="linkButton" runat="server" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    First Name
                    <asp:TextBox ID="txtFirstname" runat="server" />
                    Last Name
                    <asp:TextBox ID="txtLastName" runat="server" />
                    Middle Name
                    <asp:TextBox ID="txtMiddleName" runat="server" />
                    Father Name
                    <asp:TextBox ID="txtFatherName" runat="server" />
                    Mother Name
                    <asp:TextBox ID="txtMotherName" runat="server" />
                    Date Of Birth
                    <asp:Calendar ID="calendar1" runat="server"></asp:Calendar>
                    Driver License
                    <asp:TextBox ID="txtDL" runat="server" />

                </EmptyDataTemplate>
            </asp:GridView>
            <asp:Button ID="InsertFromForm" runat="server" Text="Add" OnClick="InsertFromForm_Click" />
            <asp:FormView ID="FormView1" runat="server" DataSourceID="sqlDDLDataSource" OnItemInserting="FormView1_ItemInserting"
                OnItemInserted="FormView1_ItemInserted" OnItemUpdating="FormView1_ItemUpdating" OnItemUpdated="FormView1_ItemUpdated" OnItemDeleted="FormView1_ItemDeleted">
                <EditItemTemplate>
                    EmployeeID:
                    <asp:Label ID="EmployeeIDLabel1" runat="server" Text='<%# Bind("EmployeeID") %>' />
                    <br />
                    FirstName:
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    MiddleName:
                    <asp:TextBox ID="MiddleNameTextBox" runat="server" Text='<%# Bind("MiddleName") %>' />
                    <br />
                    FatherName:
                    <asp:TextBox ID="FatherNameTextBox" runat="server" Text='<%# Bind("FatherName") %>' />
                    <br />
                    MotherName:
                    <asp:TextBox ID="MotherNameTextBox" runat="server" Text='<%# Bind("MotherName") %>' />
                    <br />
                    DateOfBith:
                    <asp:TextBox ID="DateOfBithTextBox" runat="server" Text='<%# Bind("DateOfBith") %>' />
                    <br />
                    DriverLincense:
                    <asp:TextBox ID="DriverLincenseTextBox" runat="server" Text='<%# Bind("DriverLincense") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    FirstName:
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    MiddleName:
                    <asp:TextBox ID="MiddleNameTextBox" runat="server" Text='<%# Bind("MiddleName") %>' />
                    <br />
                    FatherName:
                    <asp:TextBox ID="FatherNameTextBox" runat="server" Text='<%# Bind("FatherName") %>' />
                    <br />
                    MotherName:
                    <asp:TextBox ID="MotherNameTextBox" runat="server" Text='<%# Bind("MotherName") %>' />
                    <br />
                    DateOfBith:
                    <asp:Calendar ID="DateOfBithTextBox" runat="server" SelectedDate='<%# Bind("DateOfBith") %>' />
                    <br />
                    DriverLincense:
                    <asp:TextBox ID="DriverLincenseTextBox" runat="server" Text='<%# Bind("DriverLincense") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    EmployeeID:
                    <asp:Label ID="EmployeeIDLabel" runat="server" Text='<%# Eval("EmployeeID") %>' />
                    <br />
                    FirstName:
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    MiddleName:
                    <asp:Label ID="MiddleNameLabel" runat="server" Text='<%# Bind("MiddleName") %>' />
                    <br />
                    FatherName:
                    <asp:Label ID="FatherNameLabel" runat="server" Text='<%# Bind("FatherName") %>' />
                    <br />
                    MotherName:
                    <asp:Label ID="MotherNameLabel" runat="server" Text='<%# Bind("MotherName") %>' />
                    <br />
                    DateOfBith:
                    <asp:Label ID="DateOfBithLabel" runat="server" Text='<%# Bind("DateOfBith") %>' />
                    <br />
                    DriverLincense:
                    <asp:Label ID="DriverLincenseLabel" runat="server" Text='<%# Bind("DriverLincense") %>' />
                    <br />
                    <asp:Button ID="Edit" runat="server" Text="Edit" CommandName="Edit" />
                </ItemTemplate>
            </asp:FormView>

            <asp:CheckBoxList ID="checkBoxList" runat="server" DataSourceID="SqlEmployeeDataSource" DataTextField="FirstName" DataValueField="FirstName">
            </asp:CheckBoxList>
        </div>
    </form>
</body>
</html>
