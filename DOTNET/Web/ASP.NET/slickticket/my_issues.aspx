<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="My Issues" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="my_issues.aspx.cs" Inherits="my_issues" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:TextBox ID="txtSubmitter" runat="server" Visible="False" />
    <asp:TextBox ID="txtGroup" runat="server" Visible="False" />
    
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
        
            <h2 class="header">
                <span class="title_header">
                    <asp:literal ID="litMyTickets" runat="server" meta:resourcekey="litMyTicketsResource1" />
                    <a href='javascript:void();' class='tooltip limited'><img src='images/info.png' alt='explanation' /><span class='border_color'>
                        <q class='inner_color base_text'>
                            <asp:literal ID="litMyTicketsTooltip" runat="server" meta:resourcekey="litMyTicketsTooltipResource1" />
                        </q></span>
                    </a>
                </span>
                <span class="clear"></span>
            <span class="smaller"><asp:Label ID="lblreportMy" runat="server" /></span>
            </h2>
            <fieldset class="inner_color">
                <asp:GridView ID="gvMy" runat="server"
                    AutoGenerateColumns="False" PageSize="5" CssClass="list" GridLines="None" 
                    AllowSorting="True"  OnSorting="gv_Sorting" meta:resourcekey="gvMyResource1" >
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
                                            <div><b><%= Resources.Common.LastAction %>: </b><%# Convert.ToDateTime(Eval("last_action")).ToString()%></div>
                                            <div><b><%= Resources.Common.TicketNumber %>: </b><%# Eval("id") %></div>
                                            <div><b><%= Resources.Common.Submitter %>: </b><%# Eval("user.userName")%></div>
                                            <div><b><%= Resources.Common.AssignedTo %>: </b><%# Eval("sub_unit.unit.unit_name") %> - <%# Eval("sub_unit.sub_unit_name") %></div>
                                            <div><b><%= Resources.Common.OriginatingGroup %>: </b><%# Eval("user.sub_unit1.unit.unit_name") %> - <%# Eval("user.sub_unit1.sub_unit_name") %></div>
                                    </q></span>
                                </a>
                            </ItemTemplate>
                            <HeaderStyle Width="400px"></HeaderStyle>
                        </asp:TemplateField>
                        
                        <asp:BoundField DataField="submitted" SortExpression="submitted" DataFormatString="{0:d}" HtmlEncode="False" meta:resourcekey="BoundFieldResource1" >
                            <HeaderStyle Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        
                        <asp:TemplateField SortExpression="status" HeaderStyle-CssClass="center" meta:resourcekey="TemplateFieldResource3">
                            <ItemTemplate>
                                <div class="color_it"><%# Eval("statuse.status_name") %></div>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    
                    </Columns>
                </asp:GridView>
            </fieldset>
            <div class="divider"></div>
            <h2 class="header">
                <span class="title_header"><asp:Label ID="lblMyGroup" runat="server" /> 
                    <asp:literal runat="server" Text="Tickets" ID="litTickets" 
                    meta:resourcekey="litTicketsResource1" />
                    <a href='javascript:void();' class='tooltip limited'><img src='images/info.png' alt='explanation' /><span class='border_color'>
                        <q class='inner_color base_text'>
                            <asp:literal runat="server" ID="litTeamTicketsTooltip" meta:resourcekey="litTeamTicketsTooltipResource1" />
                        </q>
                    </span></a>
                </span>
                <span class="clear"></span>
            <span class="smaller"><asp:Label ID="lblReportGroup" runat="server" /></span>
            </h2>
            <fieldset class="inner_color">
                <asp:GridView ID="gvGroup" runat="server" 
                    AutoGenerateColumns="False"  CssClass="list" GridLines="None" 
                    AllowSorting="True"  OnSorting="gv_Sorting" meta:resourcekey="gvGroupResource1" >
                    <Columns>
                        <asp:TemplateField HeaderText="Priority" SortExpression="priority" 
                            meta:resourcekey="TemplateFieldResource1">
                            <ItemTemplate>
                                <div class="color_it" style="background:<%# urgency[Int32.Parse(Eval("priority").ToString())] %>"><%# Eval("priority1.priority_name") %></div>
                            </ItemTemplate>
                            <HeaderStyle Width="60px"></HeaderStyle>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Ticket" SortExpression="title" 
                            meta:resourcekey="TemplateFieldResource2">
                            <ItemTemplate>
                                <a class="tooltip large" href="ticket.aspx?ticketID=<%# Eval("id") %>">
                                    <em><%# Utils.TrimForSideBar(Eval("title").ToString(), 50) %></em>
                                    <span class='border_color'><q class='inner_color base_text'>
                                            <div><b><%= Resources.Common.LastAction %>: </b><%# Convert.ToDateTime(Eval("last_action")).ToString()%></div>
                                            <div><b><%= Resources.Common.TicketNumber %>: </b><%# Eval("id") %></div>
                                            <div><b><%= Resources.Common.Submitter %>: </b><%# Eval("user.userName")%></div>
                                            <div><b><%= Resources.Common.AssignedTo %>: </b><%# Eval("sub_unit.unit.unit_name") %> - <%# Eval("sub_unit.sub_unit_name") %></div>
                                            <div><b><%= Resources.Common.OriginatingGroup %>: </b><%# Eval("user.sub_unit1.unit.unit_name") %> - <%# Eval("user.sub_unit1.sub_unit_name") %></div>
                                    </q></span>
                                </a>
                            </ItemTemplate>
                            <HeaderStyle Width="400px"></HeaderStyle>
                        </asp:TemplateField>
                        
                        <asp:BoundField DataField="submitted" HeaderText="Submitted" SortExpression="submitted" DataFormatString="{0:d}" HtmlEncode="False" meta:resourcekey="BoundFieldResource1" >
                            <HeaderStyle Width="80px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        
                        <asp:TemplateField SortExpression="status" HeaderStyle-CssClass="center" meta:resourcekey="TemplateFieldResource3">
                            <ItemTemplate>
                                <div class="color_it"><%# Eval("statuse.status_name") %></div>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    
                    </Columns>
                </asp:GridView>
            </fieldset>
        
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebar" Runat="Server">
</asp:Content>

