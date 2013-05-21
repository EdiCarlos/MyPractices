<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Administration - Settings" Language="C#" MasterPageFile="~/admin/admin.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="settings.aspx.cs" meta:resourcekey="PageResource1"Inherits="admin_settings" %>

<asp:Content ID="Content3" ContentPlaceHolderID="adminHead" Runat="Server">

<script type="text/javascript" src="../js/jquery.js"></script>
 <script type="text/javascript" src="../js/farbtastic.js"></script>
 <link rel="stylesheet" href="../css/farbtastic.css" type="text/css" />
 <style type="text/css" media="screen">
   .colorwell {
     border: 2px solid #fff;
     width: 6em;
     text-align: center;
     cursor: pointer;
   }
   body .colorwell-selected {
     border: 2px solid #000;
     font-weight: bold;
   }
 </style>
 
 <script type="text/javascript" charset="utf-8">
     $(document).ready(function() {
         var f = $.farbtastic('#picker');
         var p = $('#picker').css('opacity', 0.25);
         var selected;
         $('.colorwell')
      .each(function() { f.linkTo(this); $(this).css('opacity', 0.75); })
      .focus(function() {
          if (selected) {
              $(selected).css('opacity', 0.75).removeClass('colorwell-selected');
          }
          f.linkTo(this);
          p.css('opacity', 1);
          $(selected = this).css('opacity', 1).addClass('colorwell-selected');

      });
     });
 </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="adminBody" Runat="Server">
    
     
    <h2 class="header">
        <%= Resources.Common.Settings %>
        <span class="clear"></span>
        <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" />
    </h2>
    <div style="text-align:left;" class="header">
        <asp:literal runat="server" ID="litDescription" meta:resourcekey="litDescriptionResource1" />
    </div>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <asp:UpdatePanel ID="pnlSettings" runat="server">
            <ContentTemplate>
            
                <ajax:CollapsiblePanelExtender ID="cpeSettings" runat="server" 
                    CollapseControlID="lblSettings" ExpandControlID="lblSettings" 
                    TargetControlID="stdSettings" Collapsed="True" Enabled="True" />
            
                <h4>
                    <span id="stSettings" class="title_header pointer">
                        <asp:label ID="lblSettings" runat="server" 
                        meta:resourcekey="lblSettingsResource1">General Settings</asp:label>
                        <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>
                            <asp:literal runat="server" ID="litBasicSettings" meta:resourcekey="litBasicSettingsResource1" />
                        </q></span></a>
                    </span>
                    <span class="smaller clear">
                        <asp:Label ID="lblAttachmentReport" runat="server" />
                    </span>
                </h4>
                <asp:Panel runat="server" id="stdSettings" class="collapse" >
                    <asp:Panel ID="pnlTitle" runat="server" DefaultButton="btnTitle" >
                        <h3 style="text-align:left;">
                            <asp:label ID="lblSystemTitle" runat="server" cssclass="title_header" meta:resourcekey="lblSystemTitleResource1" />
                            <span class="clear"></span>
                            <asp:TextBox ID="txtTitle" runat="server" style="width:88%;" /> 
                            <asp:Button CssClass="button smaller" ID="btnTitle" runat="server" CommandArgument="title" onclick="updateSettings_Click" 
                                CommandName="txtTitle" meta:resourcekey="btnUpdateResource1"  />
                        </h3>
                    </asp:Panel>
                    <asp:Panel ID="pnlImage" runat="server" DefaultButton="btnImage" >
                        <h3 style="text-align:left;"><span class="clear"></span>
                            <asp:label ID="lblSystemTitleImage" runat="server" cssclass="title_header" meta:resourcekey="lblSystemTitleImageResource1" />
                            <asp:TextBox ID="txtImage" runat="server" style="width:88%;" /> 
                            <asp:Button CssClass="button smaller" ID="btnImage" runat="server" CommandArgument="image" onclick="updateSettings_Click" 
                                CommandName="txtImage" meta:resourcekey="btnUpdateResource1" />
                        </h3>
                    </asp:Panel>
                    <asp:Panel ID="pnlAdminEmail" runat="server" DefaultButton="btnAdminEmail" >
                        <h3 style="text-align:left;">
                            <asp:label runat="server" CssClass="title_header" ID="AdminContact" meta:resourcekey="AdminContactResource1" />
                            <span style="float:right;padding-right:66px;">
                                <asp:RequiredFieldValidator ID="rfvMailto" runat="server" ControlToValidate="txtAdminEmail" ValidationGroup="adminEmail" 
                                    CssClass="error" Display="Dynamic" meta:resourcekey="rfvRequiredResource1" />
                                <asp:RegularExpressionValidator ID="regEditMailTo" runat="server" ControlToValidate="txtAdminEmail" ForeColor="" ValidationGroup="adminEmail" 
                                    ValidationExpression="^[0-9]*[a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([a-zA-Z][-\w\.]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$" 
                                    Display="Dynamic" CssClass="error" meta:resourcekey="regEditMailToResource1" />
                            </span>
                            <span class="clear"></span>
                            <asp:TextBox ID="txtAdminEmail" runat="server" style="width:88%;" />
                            <asp:Button CssClass="button smaller" ID="btnAdminEmail" runat="server" CommandArgument="admin_email" onclick="updateSettings_Click" 
                                CommandName="txtAdminEmail" ValidationGroup="adminEmail" meta:resourcekey="btnUpdateResource1" />
                        </h3>
                    </asp:Panel>
                    <asp:Panel ID="pnlSystemEmail" runat="server" DefaultButton="btnSysEmail" 
                        meta:resourcekey="pnlSystemEmailResource1">
                        <h3 style="text-align:left;">
                            <asp:label runat="server" CssClass="title_header" ID="SystemEmail" meta:resourcekey="SystemEmailResource2" />
                            <span style="float:right;padding-right:66px;">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtSysEmail" ValidationGroup="sysEmail" 
                                    CssClass="error" Display="Dynamic" meta:resourcekey="rfvRequiredResource1" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="txtSysEmail" ForeColor="" ValidationGroup="sysEmail" 
                                    ValidationExpression="^[0-9]*[a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([a-zA-Z][-\w\.]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$" Display="Dynamic" CssClass="error" 
                                    meta:resourcekey="RegularExpressionValidator9Resource1" />
                            </span>
                            <span class="clear"></span>
                            <asp:TextBox ID="txtSysEmail" runat="server" style="width:88%;" />
                            <asp:Button CssClass="button smaller" ID="btnSysEmail" runat="server" CommandArgument="system_email" 
                                onclick="updateSettings_Click" CommandName="txtSysEmail" ValidationGroup="sysEmail" meta:resourcekey="btnUpdateResource1" />
                        </h3>
                    </asp:Panel>
                    <asp:Panel ID="pnlDC" runat="server" DefaultButton="btnDC" >
                        <h3 style="text-align:left;">
                            <asp:label runat="server" CssClass="title_header" ID="lblDomainController" meta:resourcekey="lblDomainControllerResource1" />
                            <span style="float:right;padding-right:66px;">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                CssClass="error" ControlToValidate="txtDC" ValidationGroup="dc" meta:resourcekey="rfvRequiredResource1" />
                            </span>
                            <asp:TextBox ID="txtDC" runat="server" style="width:88%;" /> 
                            <asp:Button CssClass="button smaller" ID="btnDC" runat="server" CommandArgument="domain_controller" 
                                onclick="updateSettings_Click" CommandName="txtDC" ValidationGroup="dc" meta:resourcekey="btnUpdateResource1" />
                        </h3>
                    </asp:Panel>
                    <asp:Panel ID="pnlSmtp" runat="server" DefaultButton="btnSmtp" >
                        <h3 style="text-align:left;">
                            <asp:label runat="server" CssClass="title_header" ID="lblSMTP" meta:resourcekey="lblSMTPResource1" />
                            <span style="float:right;padding-right:66px;">
                                <asp:RequiredFieldValidator ID="rfvSmtp" runat="server" CssClass="error" ControlToValidate="txtSmtp" 
                                    ValidationGroup="smtp" meta:resourcekey="rfvRequiredResource1" />
                            </span>
                            <asp:TextBox ID="txtSmtp" runat="server" style="width:88%;"  /> 
                            <asp:Button CssClass="button smaller" ID="btnSmtp" runat="server" CommandArgument="smtp" onclick="updateSettings_Click" 
                                CommandName="txtSmtp" ValidationGroup="smtp" meta:resourcekey="btnUpdateResource1" />
                        </h3>
                    </asp:Panel>
                    <asp:Panel ID="pnlAttachment" runat="server" DefaultButton="btnAttachment" >
                        <h3 style="text-align:left;">
                            <asp:label runat="server" CssClass="title_header" ID="lblAttachmentDirectory" meta:resourcekey="lblAttachmentDirectoryResource1" />
                            <asp:TextBox ID="txtAttachment" runat="server" style="width:88%;" /> 
                            <asp:Button CssClass="button smaller" ID="btnAttachment" runat="server" onclick="btnAttachment_Click" 
                                meta:resourcekey="btnUpdateResource1" />
                        </h3>
                    </asp:Panel>
                    <br />
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <asp:UpdatePanel ID="pnlEmail" runat="server">
            <ContentTemplate>
                <ajax:CollapsiblePanelExtender ID="cpeEmail" runat="server" CollapseControlID="lbl_Email" ExpandControlID="lbl_Email" 
                    TargetControlID="stdEmail" Collapsed="True" Enabled="True" />
                <h4>
                        <span class="title_header">
                            <asp:Label ID="lbl_Email" runat="server" CssClass="pointer" meta:resourcekey="lbl_EmailResource1" />
                            <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>
                                <asp:literal runat="server" ID="litUserEmailSettings" meta:resourcekey="litUserEmailSettingsResource1" />
                            </q></span></a>
                        </span>
                        <span class="smaller">
                          <asp:Button  ID="btnDomainPopup" CssClass="button smaller" runat="server" meta:resourcekey="btnDomainPopupResource1" />
                        </span>                        
                        <asp:Label ID="lblEmail" runat="server" meta:resourcekey="lblEmailResource1" />
                    </h4>
                    <asp:Panel id="stdEmail" runat="server" class="collapse clear" >
                        <h3>
                            <span class="title_header">
                                <asp:CheckBox ID="chkEmail" runat="server" AutoPostBack="True" oncheckedchanged="chkEmail_CheckedChanged" 
                                    meta:resourcekey="chkEmailResource1" />&nbsp;
                            </span>
                            <br /><br />
                        </h3>
                        <h3>
                            <span class="title_header">
                                <asp:CheckBox ID="chkRestrictDomains" runat="server" AutoPostBack="True" 
                                    oncheckedchanged="chkRestrictDomains_CheckedChanged" meta:resourcekey="chkRestrictDomainsResource1" />&nbsp;
                            </span>
                            <br /><br />
                        </h3>
                        <span class="clear"></span>
                        <asp:Panel ID="pnlDomains" runat="server" >
                            <asp:GridView ID="gvDomains" runat="server" AutoGenerateColumns="False" GridLines="None" DataKeyNames="id" 
                                DataSourceID="ldsDomains" CssClass="list" AllowSorting="True" onrowdeleted="gvDomains_RowDeleted" meta:resourcekey="gvDomainsResource1">
                                <Columns>
                                    <asp:TemplateField ShowHeader="False" >
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbDelete" runat="server" CausesValidation="False" CommandName="Delete" meta:resourcekey="lbDeleteResource1" />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update" meta:resourcekey="btnUpdateResource1" />&nbsp;
                                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" meta:resourcekey="btnCancelResource1" />
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="domain" SortExpression="domain" meta:resourcekey="BoundFieldResource1" />
                                </Columns>
                                <AlternatingRowStyle BackColor="#EFF5FF" />
                            </asp:GridView>
                            <br />
                            <asp:LinqDataSource ID="ldsDomains" runat="server" ContextTypeName="dbDataContext" EnableDelete="True" OrderBy="domain" 
                                TableName="allowed_email_domains" />
                        </asp:Panel>
                    </asp:Panel>
                
                <ajax:ModalPopupExtender ID="mpeAddDomain" runat="server" 
                    TargetControlID="btnDomainPopup" BackgroundCssClass="modal_background"
                    PopupControlID="pnlAddDomain" CancelControlID="btnCancel" 
                    DynamicServicePath="" Enabled="True" />
                
                <asp:Panel ID="pnlAddDomain" runat="server"  CssClass="modal_popup" 
                    style="display:none;" DefaultButton="btnAddDomain" 
                    meta:resourcekey="pnlAddDomainResource1">
                    
                    <div class="small_container border_color">
                        <fieldset class="inner_color">
                            <h3>
                                <asp:label runat="server" CssClass="title_header" ID="lblDomain" 
                                    meta:resourcekey="lblDomainResource1">Domain</asp:label>&nbsp;
                                <asp:RequiredFieldValidator ID="rfvDomainAdd" runat="server" Display="Dynamic" ForeColor="" CssClass="error"
                                    ValidationGroup="addDomain" ControlToValidate="txtDomainAdd" meta:resourcekey="rfvRequiredResource1" />
                                <asp:RegularExpressionValidator ID="regEmailDomain" runat="server" Display="Dynamic" ForeColor="" CssClass="error"
                                    ValidationGroup="addDomain" ControlToValidate="txtDomainAdd" 
                                    ValidationExpression="((\[([0-9]{1,3}\.){3}[0-9]{1,3}\])|(([\w\-]+\.)+)([a-zA-Z]{2,4}))$" meta:resourcekey="regEmailDomainResource1" />
                            </h3>
                            <asp:TextBox ID="txtDomainAdd" runat="server" CssClass="inside_small_container" />
                            <br /><br />
                            <div style="text-align:center;">
                                <asp:Button ID="btnAddDomain" runat="server" CssClass="button" ValidationGroup="addDomain" onclick="btnAddDomain_Click" 
                                    meta:resourcekey="btnAddDomainResource1" />&nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="button" meta:resourcekey="btnCancelResource1" />
                            </div>
                        </fieldset>
                    </div>
                </asp:Panel>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <asp:UpdatePanel ID="pnlAccess" runat="server">
            <ContentTemplate>
                <ajax:CollapsiblePanelExtender ID="cpeAccess" runat="server" 
                    CollapseControlID="lblAccess" ExpandControlID="lblAccess" 
                    TargetControlID="stdAccess" Collapsed="True" Enabled="True" />
                <h4>
                    <span class="title_header">
                        <asp:Label CssClass="pointer" runat="server" ID="lblAccess">
                            <asp:literal runat="server" ID="litAccessLevels" meta:resourcekey="litAccessLevelsResource1" />
                            <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>
                                <asp:literal runat="server" ID="litAccessDesc" meta:resourcekey="litAccessDescResource1" />
                            </q></span></a>
                        </asp:Label>
                    </span>
                    <span class="clear"></span>
                    <asp:Label ID="lblAccessReport" runat="server" />
                </h4>
                <asp:Panel ID="stdAccess" runat="server" class="collapse" >
                    <asp:GridView ID="gvAccessLevels" runat="server" AutoGenerateColumns="False" CssClass="list" 
                        DataKeyNames="id" DataSourceID="ldsAccessLevels" AllowSorting="True" GridLines="None" >
                        <Columns>
                            <asp:CommandField ShowEditButton="True" >
                            <ItemStyle Width="110px" />

                            </asp:CommandField>
                            <asp:BoundField DataField="id" ReadOnly="True" SortExpression="id"  />
                            <asp:BoundField DataField="security_level_name" SortExpression="security_level_name" meta:resourcekey="BoundFieldResource3" >
                            <ControlStyle Width="100%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="security_level_description" SortExpression="security_level_description" meta:resourcekey="BoundFieldResource4" >
                            <ControlStyle Width="100%" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                    <asp:LinqDataSource ID="ldsAccessLevels" runat="server" ContextTypeName="dbDataContext" TableName="security_levels"  Where="id &gt; 0" EnableUpdate="True" />
                    <br />
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
    
        <ajax:CollapsiblePanelExtender ID="cpeImport" runat="server" 
            CollapseControlID="lblImport" ExpandControlID="lblImport" 
            TargetControlID="pnlImport" Collapsed="True" Enabled="True" />
    
        <h4>
            <span class="title_header">
                <asp:Label CssClass="pointer" runat="server" ID="lblImport" >
                    <asp:literal runat="server" ID="litImpExp" meta:resourcekey="litImpExpResource1" />
                    <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>
                        <asp:literal runat="server" ID="litImpExpDesc" meta:resourcekey="litImpExpDescResource1" />
                    </q></span></a>
                </asp:Label></span><span class="clear">
            </span>
            <asp:Label ID="lblImportReport" style="text-align:left;" runat="server"  />
        </h4>
        <asp:Panel ID="pnlImport" runat="server" class="collapse" >
            <h3 style="text-align:left;">
                <asp:literal runat="server" ID="litImport" meta:resourcekey="litImportResource1" />
            </h3>
            <asp:Button ID="btnStyleImport" runat="server" CssClass="button" onclick="btnImport_Click" ValidationGroup="import" 
                meta:resourcekey="btnStyleImportResource1" />
            <asp:Button ID="btnFaqImport" runat="server" CssClass="button" onclick="btnImport_Click" ValidationGroup="import" 
                meta:resourcekey="btnFaqImportResource1" />
            <asp:FileUpload ID="fuImport" runat="server" />
            <asp:RequiredFieldValidator ID="rfvImport" CssClass="bold" ValidationGroup="import" 
                runat="server" ControlToValidate="fuImport" meta:resourcekey="rfvRequiredResource1" />
            <h3 style="text-align:left;">
                <asp:literal ID="Literal1" runat="server" meta:resourcekey="Literal1Resource1" />
            </h3>
            <asp:Button CssClass="button" ID="btnExportStyles" runat="server" OnClick="btnExport_Click" meta:resourcekey="btnExportStylesResource1" />
            <asp:Button CssClass="button" ID="btnExportFaqs" runat="server" OnClick="btnExport_Click" meta:resourcekey="btnExportFaqsResource1" />
            <div><br /></div>
        </asp:Panel>
    </fieldset>
     <div class="divider"></div>
    <fieldset class="inner_color">
        <ajax:CollapsiblePanelExtender ID="colAppearance" 
            runat="server" TargetControlID="pnlAppearance" Collapsed="True" 
            CollapseControlID="lblAppearance" ExpandControlID="lblAppearance" 
            Enabled="True" />
        <h4>
            <span class="title_header">
                <asp:Label CssClass="pointer" runat="server" ID="lblAppearance" meta:resourcekey="lblAppearanceResource1" />
                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>
                    <asp:literal runat="server" ID="litAppearance" meta:resourcekey="litAppearanceResource1" />
                </q></span></a>
            </span>
            <span class="smaller">
                <asp:Button ID="btnApplyAppearance" CssClass="button smaller" ValidationGroup="style" runat="server" 
                    onclick="btnApplyAppearance_Click" meta:resourcekey="btnApplyAppearanceResource1" />&nbsp; 
                <asp:Button ID="btnCssReset" runat="server" CssClass="button smaller"  onclick="btnCssReset_Click" meta:resourcekey="btnCssResetResource1" />
            </span>
            <asp:Label ID="lblCAppearance" runat="server" meta:resourcekey="lblCAppearanceResource1" />
        </h4>
        <asp:Panel ID="pnlAppearance" runat="server"  class="collapse" >
            <h3 style="text-align:left;">
                <asp:Literal runat="server" ID="litSideBar" meta:resourcekey="litSideBarResource1" />
                <asp:RadioButton ID="left" runat="server" GroupName="radSidebar" CssClass="checkbox" meta:resourcekey="leftResource1" />
                <asp:RadioButton ID="right" runat="server" GroupName="radSidebar" CssClass="checkbox" meta:resourcekey="rightResource1" />
            </h3>
            <h3>
                <span class="title_header">
                    <asp:DropDownList ID="ddlThemes" runat="server" DataSourceID="ldsThemes" AutoPostBack="True" AppendDataBoundItems="True" 
                        DataTextField="style_name" DataValueField="id" onselectedindexchanged="ddlThemes_SelectedIndexChanged" >
                        <asp:ListItem Value="0" meta:resourcekey="ListItemResource1">Pre-Set Themes</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button CssClass="button smaller"  runat="server" onclick="btnThemeDelete_Click" ID="btnThemeDelete" 
                        Visible="False" meta:resourcekey="btnThemeDeleteResource1" />
                    <asp:Label ID="lblThemeDelete" runat="server" /></span>    
                <asp:LinqDataSource ID="ldsThemes" runat="server" ContextTypeName="dbDataContext" OrderBy="style_name" TableName="styles" Where="id &gt; @id" >
                    <WhereParameters>
                        <asp:Parameter DefaultValue="2" Name="id" Type="Int32" />
                    </WhereParameters>
                </asp:LinqDataSource>
            </h3>
            
            <ajax:CollapsiblePanelExtender ID="cpeCustomize" runat="server" TargetControlID="pnlCustomize" CollapseControlID="lblCustomize" 
                ExpandControlID="lblCustomize" Collapsed="True" Enabled="True" />
            <h3 style="text-align:left;" class="clear">
                <asp:Label ID="lblCustomize" runat="server" CssClass="link pointer" meta:resourcekey="lblCustomizeResource1" />
            </h3>
            <asp:Panel ID="pnlCustomize" runat="server" class="collapse" >
            <div id="picker" style="float: right;"></div>
            <asp:ValidationSummary ID="valStyle" runat="server" CssClass="error_area border_color header" 
                ValidationGroup="style" style="width:370px;" />
            <asp:RegularExpressionValidator ID="regText" ControlToValidate="styleText" runat="server" ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" 
                ValidationGroup="style"  Display="None" meta:resourcekey="regTextResource1" />
            <asp:RequiredFieldValidator ID="rfvText" ControlToValidate="styleText" runat="server" ValidationGroup="style" Display="None" 
                meta:resourcekey="rfvTextResource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="styleBorders" 
                runat="server" ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" 
                ValidationGroup="style"  Display="None" meta:resourcekey="RegularExpressionValidator1Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="styleBorders" runat="server"  ValidationGroup="style" Display="None" 
                meta:resourcekey="RequiredFieldValidator1Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="styleBody" runat="server" 
                ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator2Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="styleBody" runat="server" ValidationGroup="style" Display="None" 
                meta:resourcekey="RequiredFieldValidator2Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="styleLink" runat="server" 
                ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator3Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="styleLink" runat="server" ValidationGroup="style" Display="None" 
                meta:resourcekey="RequiredFieldValidator3Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="styleLinkHover" runat="server"
                ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator4Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="styleLinkHover" runat="server" ValidationGroup="style" Display="None" 
                meta:resourcekey="RequiredFieldValidator4Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" ControlToValidate="styleButtonText" runat="server" 
                ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator5Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="styleButtonText" runat="server"  ValidationGroup="style" 
                Display="None" meta:resourcekey="RequiredFieldValidator5Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" ControlToValidate="styleHeader" runat="server" 
                ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator6Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="styleHeader" runat="server" ValidationGroup="style" Display="None" 
                meta:resourcekey="RequiredFieldValidator6Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" ControlToValidate="styleAlternatingRows" 
                runat="server" ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator7Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="styleAlternatingRows" runat="server" 
                ValidationGroup="style" Display="None" meta:resourcekey="RequiredFieldValidator7Resource1" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator8" ControlToValidate="styleBg" runat="server" 
                ValidationExpression="^#([a-f]|[A-F]|[0-9]){3}(([a-f]|[A-F]|[0-9]){3})?$" ValidationGroup="style"  Display="None" 
                meta:resourcekey="RegularExpressionValidator8Resource1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="styleBg" runat="server" ValidationGroup="style" Display="None" 
                meta:resourcekey="RequiredFieldValidator8Resource1" /><table style="width:370px;">
                <tr>
                    <td style="width:150px;">
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litText" meta:resourcekey="litTextResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litTextDesc" meta:resourcekey="litTextDescResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleText" cssclass="colorwell" meta:resourcekey="styleTextResource1" />
                    </td>
                    <td style="width:150px;">
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litBorders" meta:resourcekey="litBordersResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>
                                    <asp:literal runat="server" ID="litBordersDesc" meta:resourcekey="litBordersDescResource1" />
                                </q></span></a> 
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleBorders" cssclass="colorwell" meta:resourcekey="styleBordersResource1" />
                    </td>
                    <td style="width:150px;">
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litBody" meta:resourcekey="litBodyResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litBodyDesc" meta:resourcekey="litBodyDescResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleBody" cssclass="colorwell" meta:resourcekey="styleBodyResource1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litLinks" meta:resourcekey="litLinksResource1" />
                                    <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litLinksDesc" meta:resourcekey="litLinksDescResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleLink" cssclass="colorwell" meta:resourcekey="styleLinkResource1" />
                    </td>
                    <td>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litLinkHover" meta:resourcekey="litLinkHoverResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litLinkHoverDesc" meta:resourcekey="litLinkHoverDescResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleLinkHover" cssclass="colorwell" meta:resourcekey="styleLinkHoverResource1" />
                    </td>
                    <td>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litButtonText" meta:resourcekey="litButtonTextResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litButtonTextDesc" meta:resourcekey="litButtonTextDescResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleButtonText" cssclass="colorwell" meta:resourcekey="styleButtonTextResource1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litHeaders" meta:resourcekey="litHeadersResource1" /><a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litHeadersDescs" meta:resourcekey="litHeadersDescsResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleHeader" name="color4" cssclass="colorwell" meta:resourcekey="styleHeaderResource1" />
                    </td>
                    <td>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litAltRows" meta:resourcekey="litAltRowsResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litAtlRowsDesc" meta:resourcekey="litAtlRowsDescResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleAlternatingRows" name="color4" cssclass="colorwell" meta:resourcekey="styleAlternatingRowsResource1" />
                    </td>
                    <td>
                        <h3>
                            <span class="title_header">
                                <asp:literal runat="server" ID="litBackground" meta:resourcekey="litBackgroundResource1" />
                                <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'> 
                                    <asp:literal runat="server" ID="litBackgroundDescs" meta:resourcekey="litBackgroundDescsResource1" />
                                </q></span></a>
                            </span>
                        </h3>
                        <asp:TextBox runat="server" ID="styleBg" name="color4" cssclass="colorwell" meta:resourcekey="styleBgResource1" />
                    </td>
                </tr>
              </table>
              <br />
              <br />
                <h3 style="clear:both; text-align:left;">
                    <asp:literal runat="server" ID="litSaveCurrent" meta:resourcekey="litSaveCurrentResource1" />: 
                    <asp:TextBox ID="txtNewTheme" runat="server" />
                    <asp:Button ID="btnNewTheme" runat="server" ValidationGroup="newTheme"  
                        CssClass="button smaller" onclick="btnNewTheme_Click" meta:resourcekey="btnNewThemeResource1"  /><br />
                    <asp:RequiredFieldValidator ID="rfvTheme" runat="server" ControlToValidate="txtNewTheme" 
                        ValidationGroup="newTheme" CssClass="error_area error" display="Dynamic" meta:resourcekey="rfvThemeResource1" />
                        <asp:Label ID="lblNewTheme" runat="server" /></h3>
                <div class="clear"></div><br />
            </asp:Panel>
        </asp:Panel>
    </fieldset>
</asp:Content>

