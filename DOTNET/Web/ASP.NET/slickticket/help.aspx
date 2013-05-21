<%@ Page Title="Help/FAQ" Language="C#" MasterPageFile="~/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="help.aspx.cs" Inherits="info" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script language="JavaScript" type="text/javascript" src="js/wysiwyg/scripts/wysiwyg.js" ></script>
    <script language="JavaScript" type="text/javascript" src="js/wysiwyg/scripts/wysiwyg-settings.js"></script>
     <script type="text/javascript">
         var mysettings = new WYSIWYG.Settings();
         WYSIWYG.attach('ctl00_body_txtA', mysettings);

         function showHide(showDivId, hideDivId) {
             document.getElementById(showDivId).style.display = 'block';
             document.getElementById(hideDivId).style.display = 'none';
         } 
    </script> 
</asp:Content>
<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <fieldset class="inner_color">
                <a id="home"></a>
                <span class="larger bold">
                    <asp:Label ID="lblReport" runat="server" />
                </span>
                <h2>
                    <asp:Button CssClass="smaller button right" runat="server" ID="btnNew" meta:resourcekey="btnNewResource1" />
                    <asp:literal runat="server" ID="litIndexTitle" meta:resourcekey="litIndexTitleResource1"></asp:literal>
                </h2>
                <ul class="bold">
                    <asp:Repeater ID="rptIndex" runat="server" DataSourceID="lds">
                        <ItemTemplate>
                            <li>
                                <asp:Button ID="btnEdit" style="font-size:.7em;padding:1px"  CssClass="button"  runat="server" CommandArgument='<%# Eval("id") %>' 
                                    OnClick="btnEdit_Click" meta:resourcekey="btnEditResource1" /> 
                                <asp:Button style="font-size:.7em;padding:1px"  CssClass="button"  ID="btnDelete" runat="server" CommandArgument='<%# Eval("id") %>' OnClick="btnDelete_Click"
                                     meta:resourcekey="btnDeleteResource1"  /> 
                                <a href="#<%# trimJunk(Eval("title").ToString()) %>"><%# Eval("title").ToString() %></a>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </fieldset>
            
            <div class="divider"></div>
                       
            <asp:Repeater ID="rpt" runat="server" DataSourceID="lds">
                <ItemTemplate>
                    <fieldset class="inner_color">
                        <h2>
                            <span class="faq">
                                <% if (isAdmin) { %>
                                   <span class="smaller">
                                        <asp:Button ID="btnEdit" style="padding:3px;"  CssClass="smaller button" runat="server"  CommandArgument='<%# Eval("id") %>' 
                                        OnClick="btnEdit_Click" meta:resourcekey="btnEditResource1" />
                                        <asp:Button style="padding:3px;" CssClass="smaller button" ID="btnDelete" runat="server" CommandArgument='<%# Eval("id") %>' 
                                        OnClick="btnDelete_Click" meta:resourcekey="btnDeleteResource1"  /> 
                                   </span>
                                <% } %>
                                <a id="<%# trimJunk(Eval("title").ToString()) %>"></a>
                                <%# Eval("title").ToString() %>
                            </span>
                                    <span class="smaller right">
                                        <a href="#home"><%= Resources.Common.BackToTop %></a>
                                    </span>
                                    <span class="clear"></span>
                                </h2>
                                <div class="faq_body">
                            <%# Eval("body") %>
                        </div>
                        <br />
                        <a class="bold" href="#home"><%= Resources.Common.BackToTop %></a>
                    </fieldset>
                    <div class="divider"></div>
                </ItemTemplate>
            </asp:Repeater>   
            <asp:LinqDataSource ID="lds" runat="server" ContextTypeName="dbDataContext" 
                OrderBy="title" TableName="faqs" />
            
            <ajax:ModalPopupExtender ID="mpe" runat="server" TargetControlID="btnNew" 
                PopupControlID="pnlNew" BackgroundCssClass="modal_background" 
                DynamicServicePath="" Enabled="True" />
            
            <asp:Panel ID="pnlNew" runat="server" style="display:none;" >
                <div class="large_container border_color">
                    <fieldset class="inner_color">
                        <h3>
                            <asp:Label ID="lblQuestion" runat="server" CssClass="title_header" meta:resourcekey="lblQuestionResource1" />
                            <asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="txtQ" ValidationGroup="new" meta:resourcekey="rfvSubjectResource1" />
                        </h3>
                        <h2><asp:TextBox ID="txtQ" runat="server" CssClass="full_window" /></h2>
                        <h3>
                            <asp:Label ID="lblAnswer" cssclass="title_header" runat="server" meta:resourcekey="lblAnswerResource1">Answer</asp:Label>&nbsp;
                        </h3>
                        <asp:TextBox ID="txtA" runat="server" CssClass="full_window"  TextMode="MultiLine"  Height="100px" Width="100%"  />
                        <br />
                        <div style="text-align:center;">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="button" CommandArgument="0" ValidationGroup="new" onclick="btnSubmit_Click" meta:resourcekey="btnSubmitResource1"  />
                            <asp:Button ID="btnCancel" runat="server" CssClass="button" OnClick="btnCancel_Click" meta:resourcekey="btnCancelResource1" />
                        </div>
                    </fieldset>
                </div>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebar" Runat="Server">
</asp:Content>

