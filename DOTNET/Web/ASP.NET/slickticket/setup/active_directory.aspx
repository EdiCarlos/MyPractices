<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/setup/setup.master" AutoEventWireup="true" CodeFile="active_directory.aspx.cs" Inherits="setup_active_directory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div class="container">
            <h2>
                <asp:HyperLink style="float:right;" ID="lnkNext" Visible="false" runat="server" NavigateUrl="followup.aspx" Text="next" />
                Initial AD Setup
                <asp:Label ID="lblFinished" CssClass="success" runat="server"> - finished</asp:Label>
            </h2>
            Here you will see a list of AD groups you are a part of.  Initially, you must pick at 
            least one of these groups and assign it an access level greater than 1.
            You can change this later.
            <br /><br />
            <asp:DropDownList ID="ddlAD" runat="server" />
            <asp:DropDownList ID="ddlLevels" runat="server" />
            <asp:Button ID="btnCommit" runat="server" Text="Commit" 
                onclick="btnCommit_Click" />
            <asp:Label CssClass="error" runat="server" ID="lblError" />
                
            <div class="border">
            <asp:GridView ID="gvADGroups" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ldsADGroups"
                 AlternatingRowStyle-BackColor="#FFFFFF" GridLines="None" HeaderStyle-BackColor="#FFFFFF" CssClass="list"
                EmptyDataText="&lt;span class='error'&gt;No groups in the System!&lt;/span&gt;">
                <Columns>
                    <asp:TemplateField HeaderText="AD Group"   SortExpression="ad_group">
                        <ItemTemplate>
                            <asp:Label ID="lblADGroup" runat="server" Text='<%# Bind("ad_group") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Access Level" SortExpression="security_level" HeaderStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("security_level") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            
            <asp:LinqDataSource ID="ldsADGroups" runat="server" 
                ContextTypeName="dbDataContext" 
                OrderBy="security_level, ad_group" TableName="user_groups" />
            </div>
        </div>
        
</asp:Content>

