<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Administration - User Groups" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="permissions.aspx.cs" meta:resourcekey="PageResource1"Inherits="admin_user_groups" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminBody" Runat="Server">

     <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
        
        <h4 class="header">
            <span class="title_header">Permissions</span>
            <asp:Button ID="btnAddGroup" runat="server" CssClass="button smaller" 
                Text="Add Group" meta:resourcekey="btnAddGroupResource1" />&nbsp;
            <asp:Button ID="btnResetADxml" runat="server" CssClass="button smaller" 
                Text="Refresh AD" onclick="btnResetADxml_Click" meta:resourcekey="btnResetADxmlResource1"  />
            <span class="smaller"><asp:Label ID="lblReport" runat="server" /></span>
        </h4>
        <div style="text-align:left;" class="header">
            <asp:literal runat="server" ID="litDescription" meta:resourcekey="litDescriptionResource1" />
        </div>
        <div class="divider"></div>
        
        <fieldset class="inner_color">
            
            <asp:ValidationSummary ID="valSumEdit" runat="server" ValidationGroup="edit" CssClass="error_area" />
        
            <asp:GridView ID="gvADGroups" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ldsADGroups" 
                CssClass="list" AllowSorting="True" GridLines="None" meta:resourcekey="gvADGroupsResource1">
                <Columns>
                    <asp:TemplateField ShowHeader="False" meta:resourcekey="TemplateFieldResource1">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                CommandName="Edit" meta:resourcekey="LinkButton1Resource1"></asp:LinkButton>&nbsp;
                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                CommandName="Delete" meta:resourcekey="LinkButton2Resource1" />     
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="lbUpdate" runat="server"  ValidationGroup="edit" 
                                CommandName="Update" meta:resourcekey="lbUpdateResource1" />&nbsp;
                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                CommandName="Cancel" meta:resourcekey="btnCancelResource1" />
                        </EditItemTemplate>
                        <ItemStyle Width="110px" />
                    </asp:TemplateField>
                    <asp:TemplateField SortExpression="ad_group" meta:resourcekey="TemplateFieldResource2">
                        <ItemTemplate>
                            <asp:Label ID="lblADGroup" runat="server" Text='<%# Bind("ad_group") %>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtADGroup" Width="100%" runat="server" Text='<%# Bind("ad_group") %>' />
                            <asp:RequiredFieldValidator ID="rfvEditDisplay" runat="server" ValidationGroup="edit" ControlToValidate="txtADGroup" Display="None" 
                                meta:resourcekey="rfvEditDisplayResource1" />
                            <ajax:AutoCompleteExtender runat="server" ID="aceEditDisplay" 
                                TargetControlID="txtADGroup" ServiceMethod="getGroups" ServicePath="~/web_services/services.asmx" MinimumPrefixLength="1" 
                                CompletionListItemCssClass="autoSuggest" CompletionListHighlightedItemCssClass="autoSuggest autoSuggestSelect" 
                                DelimiterCharacters="" Enabled="True" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField SortExpression="security_level" meta:resourcekey="TemplateFieldResource3">
                        <EditItemTemplate>
                            <div style="text-align:center;">
                                <asp:DropDownList ID="ddlEditSecurityLevel" runat="server" SelectedValue='<%# Bind("security_level") %>'  
                                 DataSourceID="ldsAccessLevels" DataValueField="id" DataTextField="id" />
                            </div>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <div style="text-align:center;"><asp:Label ID="Label1" runat="server" Text='<%# Bind("security_level") %>' /></div>
                        </ItemTemplate>
                        <HeaderStyle Width="120px" />
                    </asp:TemplateField>
                </Columns>

                <AlternatingRowStyle BackColor="#EFF5FF"></AlternatingRowStyle>
            </asp:GridView>
            
            <asp:LinqDataSource ID="ldsAccessLevels" runat="server" 
                ContextTypeName="dbDataContext" EnableDelete="True" EnableUpdate="True" 
                OrderBy="id" TableName="security_levels" />
            
            <asp:LinqDataSource ID="ldsADGroups" runat="server" 
                ContextTypeName="dbDataContext" EnableDelete="True" EnableUpdate="True" 
                OrderBy="security_level, ad_group" TableName="user_groups" />
            
            
        </fieldset>
        
        <ajax:ModalPopupExtender ID="mpeNewGroup" runat="server" 
                TargetControlID="btnAddGroup" BackgroundCssClass="modal_background"
            PopupControlID="pnlNew" CancelControlID="btnCancel" DynamicServicePath="" 
                Enabled="True" />

        <asp:Panel ID="pnlNew" runat="server"  CssClass="modal_popup" style="display:none;" DefaultButton="btnNewSubmit" >
            
            <div class="small_container border_color">
                <fieldset class="inner_color">
                    <div>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litADGroup" meta:resourcekey="litADGroupResource1" />
                                <a href='javascript:void();' class='tooltip limited'>
                                    <img src='../images/info.png' alt='explanation' />
                                    <span class='border_color'>
                                        <q class='inner_color base_text'>
                                            <asp:literal ID="litADAssociated" runat="server" meta:resourcekey="litADAssociatedResource1" />
                                        </q>
                                    </span>
                                </a>    
                            </span>
                            <asp:RequiredFieldValidator ID="rfvDisplay" runat="server" ControlToValidate="txtADGroup" CssClass="error" 
                                ValidationGroup="new" meta:resourcekey="rfvDisplayResource1" />
                        </h3>
                        <asp:TextBox ID="txtADGroup" Width="100%" runat="server" />
                        <ajax:AutoCompleteExtender runat="server" ID="aceEditDisplay" 
                            TargetControlID="txtADGroup" ServiceMethod="getGroups" 
                            ServicePath="~/web_services/services.asmx" MinimumPrefixLength="1" 
                            CompletionListItemCssClass="autoSuggest" 
                            CompletionListHighlightedItemCssClass="autoSuggest autoSuggestSelect" 
                            DelimiterCharacters="" Enabled="True" />
                    </div>
                    <div>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litAccessLevel" meta:resourcekey="litAccessLevelResource1" />
                            </span>&nbsp;</h3>
                        <asp:DropDownList ID="ddlSecurityLevel" runat="server"   Width="100%" />
                    </div>
                    <br />
                    <div style="text-align:center;">
                        <asp:Button ID="btnNewSubmit"  runat="server" CssClass="button" ValidationGroup="new" onclick="btnNewSubmit_Click" 
                            meta:resourcekey="btnNewSubmitResource1" />&nbsp;
                        <asp:Button ID="btnCancel" runat="server" CssClass="button" meta:resourcekey="btnCancelResource1" />
                    </div>
                </fieldset>
            </div>
            
        </asp:Panel>
        
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
