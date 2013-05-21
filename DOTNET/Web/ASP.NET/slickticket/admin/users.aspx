<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Administration - Users" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="admin_users" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="adminBody" Runat="Server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <h4 class="header">
                <span class="title_header">Users</span>
                <asp:TextBox ID="txtSearch" runat="server" CssClass="smaller" />&nbsp;
                <asp:Button ID="btnSearch" runat="server" CssClass="button smaller" OnClick="btnSearch_Click" meta:resourcekey="btnSearchResource1" />
                <span class="clear"></span>
                <asp:Label ID="lblReport" runat="server" />
            </h4>
            <div style="text-align:left;" class="header">
                <asp:literal runat="server" ID="litDescription" meta:resourcekey="litDescriptionResource1" />
            </div>
            <div class="divider"></div>
            <fieldset class="inner_color">
                <div style="text-align:center;">
                    <asp:Label ID="lblSearchBar" runat="server" />
                </div>
                <br />
                <asp:GridView ID="gvUsers" runat="server" CssClass="list" AllowSorting="True" GridLines="None"
                    AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ldsUsers" AllowPaging="True" 
                    onrowdeleted="gvUsers_RowDeleted" meta:resourcekey="gvUsersResource1"  >
                    <Columns>
                        <asp:TemplateField ShowHeader="False" >
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" 
                                meta:resourcekey="LinkButton1Resource1" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField SortExpression="userName" meta:resourcekey="TemplateFieldResource2">
                            <ItemTemplate>
                                <a href="javascript:void();" class="tooltip limited">
                                    <%# Eval("userName") %>
                                    <span class='border_color'><q class='inner_color base_text'>
                                       <div class="bold"><%# Eval("userName") %></div>
                                       <%# Eval("sub_unit1.unit.unit_name") %><br />
                                       <%# Eval("sub_unit1.sub_unit_name") %>
                                    </q></span>
                                </a>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="phone" SortExpression="phone" meta:resourcekey="BoundFieldResource1" />
                        <asp:TemplateField SortExpression="email" meta:resourcekey="TemplateFieldResource3">
                            <ItemTemplate>
                                <a href="mailto:<%# Eval("email") %>"><%# Eval("email") %></a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField SortExpression="is_admin" meta:resourcekey="TemplateFieldResource4">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("is_admin") %>' Enabled='<%# !Eval("userName").ToString().Equals(userName) %>'
                                    AutoPostBack="True" oncheckedchanged="CheckBox1_CheckedChanged" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:LinqDataSource ID="ldsUsers" runat="server" 
                    ContextTypeName="dbDataContext" EnableDelete="True" OrderBy="userName" TableName="users" 
                    Where="userName.StartsWith(@startsWith) && userName.Contains(@contains)">
                    <WhereParameters>
                        <asp:SessionParameter  Name="startsWith" SessionField="startswith"  Type="String" DefaultValue="" ConvertEmptyStringToNull="false" />
                        <asp:SessionParameter  Name="contains" SessionField="contains"  Type="String" DefaultValue="" ConvertEmptyStringToNull="false" />
                    </WhereParameters>
                </asp:LinqDataSource>
            </fieldset>
        
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

