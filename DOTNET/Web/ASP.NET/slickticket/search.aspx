<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Search" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <fieldset class="inner_color">
        
        <asp:UpdatePanel ID="up" runat="server">
            <ContentTemplate>
            
                <asp:Panel ID="pnlSearch" runat="server" DefaultButton="btnSearch" 
                    meta:resourcekey="pnlSearchResource1">
                    <table class="by2">
                        <tr>
                            <td style="width:50%">
                                <h3><span class="title_header"><asp:literal runat="server" Text="Title" 
                                        ID="litTitle" meta:resourcekey="litTitleResource1" /></span>&nbsp;</h3>
                                    <asp:TextBox ID="txtTitle" runat="server" cssclass="half_table" />
                            </td>
                            <td style="width:50%">
                                <h3><span class="title_header"><asp:literal runat="server" ID="litUser" meta:resourcekey="litUserResource1" /></span>&nbsp;</h3>
                                <asp:TextBox ID="txtUser" runat="server" CssClass="half_table" />
                                <ajax:AutoCompleteExtender runat="server" ID="aceUser" 
                                    TargetControlID="txtUser" ServiceMethod="getUsers" 
                                    ServicePath="~/web_services/services.asmx" MinimumPrefixLength="1" 
                                    CompletionListItemCssClass="autoSuggest" 
                                    CompletionListHighlightedItemCssClass="autoSuggest autoSuggestSelect" 
                                    DelimiterCharacters="" Enabled="True" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h3><span class="title_header"><%= Resources.Common.Group %></span>&nbsp;</h3>
                                <asp:DropDownList ID="ddlUnit" runat="server"  CssClass="half_table" onselectedindexchanged="ddlUnit_SelectedIndexChanged" AutoPostBack="True"  />
                            </td>
                            <td>
                                <h3><span class="title_header"><%= Resources.Common.Subgroup %></span>&nbsp;</h3>
                                <asp:DropDownList ID="ddlSubUnit" runat="server" CssClass="half_table" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h3><span class="title_header"><asp:literal runat="server" ID="litFrom" meta:resourcekey="litFromResource1" /></span>&nbsp;</h3>
                                <asp:TextBox ID="txtFrom" runat="server"  CssClass="half_table" />
                                <ajax:CalendarExtender ID="calFrom" runat="server" TargetControlID="txtFrom" Enabled="True" />
                            </td>
                            <td>
                                <h3><span class="title_header"><asp:literal runat="server" ID="litTo" meta:resourcekey="litToResource1" /></span>&nbsp;</h3>
                                <asp:TextBox ID="txtTo" runat="server" CssClass="half_table" />
                                <ajax:CalendarExtender ID="calTo" runat="server" TargetControlID="txtTo" Enabled="True" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h3><span class="title_header"><%= Resources.Common.Priority %></span>&nbsp;</h3>
                                <asp:DropDownList ID="ddlPriority" runat="server"  CssClass="half_table" 
                                    DataSourceID="ldsPriority" DataTextField="priority_name" DataValueField="id"  AppendDataBoundItems="True" >
                                    <asp:ListItem Value="0" meta:resourcekey="ListItemResource1">Any</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <h3><span class="title_header"><%= Resources.Common.Status %></span>&nbsp;</h3>
                                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="half_table" 
                                    DataSourceID="ldsStatus" DataTextField="status_name" DataValueField="id" AppendDataBoundItems="True" >
                                    <asp:ListItem Value="0" meta:resourcekey="ListItemResource1">Any</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
                        <tr>
                            <td>
                                <h3><span class="title_header"><asp:CheckBox ID="chkOpenOnly" Checked="True" 
                                        runat="server" meta:resourcekey="chkOpenOnlyResource1" /></span></h3>
                            </td>
                            <td style="text-align:center;">
                                <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" CssClass="button" meta:resourcekey="btnSearchResource1" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <div style="text-align:center;">
                    </div>
                    <br />
                    <asp:GridView ID="gvResults" runat="server" AutoGenerateColumns="False"  CssClass="list" GridLines="None" 
                        AllowSorting="True" OnSorting="gv_Sorting" meta:resourcekey="gvResultsResource1" >
                        
                        <Columns>
                            <asp:TemplateField SortExpression="priority" meta:resourcekey="TemplateFieldResource1">
                                <ItemTemplate>
                                    <div class="color_it" style="background:<%# urgency[Int32.Parse(Eval("priority").ToString())] %>"><%# Eval("priority1.priority_name") %></div>
                                </ItemTemplate>
                                <HeaderStyle Width="60px"></HeaderStyle>
                            </asp:TemplateField>
                            
                            <asp:TemplateField SortExpression="title" meta:resourcekey="TemplateFieldResource2">
                                <ItemTemplate>
                                    <a class="tooltip large" href="ticket.aspx?ticketID=<%# Eval("id") %>">
                                        <em><%# Utils.TrimForSideBar(Eval("title").ToString(), 50) %></em>
                                        <span class='border_color'><q class='inner_color base_text'>
                                            <div><b><%= Resources.Common.LastAction %> </b><%# Convert.ToDateTime(Eval("last_action")).ToString()%></div>
                                            <div><b><%= Resources.Common.TicketNumber %> </b><%# Eval("id") %></div>
                                            <div><b><%= Resources.Common.Submitter %> </b><%# Eval("user.userName")%></div>
                                            <div><b><%= Resources.Common.AssignedTo %> </b><%# Eval("sub_unit.unit.unit_name") %> - <%# Eval("sub_unit.sub_unit_name") %></div>
                                            <div><b><%= Resources.Common.OriginatingGroup %> </b><%# Eval("user.sub_unit1.unit.unit_name") %> - <%# Eval("user.sub_unit1.sub_unit_name") %></div>
                                        </q></span>
                                    </a>
                                </ItemTemplate>
                                <HeaderStyle Width="400px"></HeaderStyle>
                            </asp:TemplateField>
                            
                            <asp:BoundField DataField="submitted" SortExpression="submitted" DataFormatString="{0:d}" HtmlEncode="False" 
                                meta:resourcekey="BoundFieldResource1" >
                            
                            <HeaderStyle Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            
                            <asp:TemplateField SortExpression="status" meta:resourcekey="TemplateFieldResource3">
                                <ItemTemplate>
                                    <div class="color_it" style="width:83px;text-align:center;"><%# Eval("statuse.status_name") %></div>
                                </ItemTemplate>
                                <HeaderStyle CssClass="center" HorizontalAlign="Center" />
                            </asp:TemplateField>
                        
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </fieldset>
    
    <asp:LinqDataSource ID="ldsPriority" runat="server" 
        ContextTypeName="dbDataContext" OrderBy="level" 
        Select="new (id, priority_name)" TableName="priorities" />
    <asp:LinqDataSource ID="ldsStatus" runat="server" 
        ContextTypeName="dbDataContext" OrderBy="status_order" 
        Select="new (id, status_name)" TableName="statuses" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebar" Runat="Server">
</asp:Content>

