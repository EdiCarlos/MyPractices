<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Administration - Groups" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="groups.aspx.cs" Inherits="admin_units" culture="auto" meta:resourcekey="PageResource1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" Runat="Server">
    
    
    <h4 class="header">
        <span class="title_header"><%= Resources.Common.Groups %></span>
        <span class="clear"></span>
        <span class="smaller"><asp:Label ID="lblReport" runat="server" /></span>
    </h4>
    <div style="text-align:left;" class="header">
        <asp:literal runat="server" ID="litDescription" meta:resourcekey="litDescriptionResource1" />
    </div>
    <div class="divider"></div>
    <asp:UpdatePanel ID="upUnit" runat="server">
        <ContentTemplate>
            <fieldset class="inner_color">
                <h4>
                    <span class="title_header"><%= Resources.Common.Groups %></span>
                    <span class="smaller"><asp:Button ID="btnAddUnit" CssClass="smaller button" runat="server" meta:resourcekey="btnAddUnitResource1" /></span>
                    <span class="clear" >
                    <span class="smaller"><asp:Label ID="lblUnitReport" runat="server" /></span>
                    </span>
                </h4>
                <asp:ValidationSummary ID="valUnit" runat="server" CssClass="error_area border_color" ValidationGroup="unitEdit" />
                <asp:GridView ID="gvUnits" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ldsUnits" AllowPaging="True" 
                    AllowSorting="True" CssClass="list" GridLines="None" OnRowUpdated= "gvUnits_RowUpdated"
                    onrowdeleted="gvUnits_RowDeleted" meta:resourcekey="gvUnitsResource1" >
                    <Columns>
                        <asp:TemplateField ShowHeader="False" >
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                    CommandName="Edit" meta:resourcekey="LinkButton1Resource2" />
                                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                    CommandName="Delete" meta:resourcekey="LinkButton2Resource2" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update" ValidationGroup="unitEdit" 
                                    meta:resourcekey="LinkButton1Resource1" />
                                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                    CommandName="Cancel" Text="Cancel" meta:resourcekey="btnCancelSubUnitResource1" />
                            </EditItemTemplate>
                            <ItemStyle Width="110px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Group" SortExpression="unit_name" 
                            meta:resourcekey="TemplateFieldResource2">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("unit_name") %>' 
                                    meta:resourcekey="Label1Resource1"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:RequiredFieldValidator ID="rfvUnit" runat="server" 
                                    ControlToValidate="txtUnit" Display="None" ValidationGroup="unitEdit" meta:resourcekey="rfvUnitResource1" />
                                <asp:TextBox ID="txtUnit" runat="server" Width="100%" 
                                    Text='<%# Bind("unit_name") %>' meta:resourcekey="txtUnitResource1"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                
                <asp:LinqDataSource ID="ldsUnits" runat="server" ContextTypeName="dbDataContext" EnableDelete="True" EnableUpdate="True" OrderBy="unit_name" TableName="units" />
                <asp:LinqDataSource ID="ldsAccessLevels" runat="server" ContextTypeName="dbDataContext" Select="new (id)" TableName="security_levels" />
                
                
                <ajax:ModalPopupExtender ID="mpeNewUnit" runat="server" 
                    TargetControlID="btnAddUnit" BackgroundCssClass="modal_background"
                    PopupControlID="pnlNewUnit" CancelControlID="btnCancelUnit" 
                    DynamicServicePath="" Enabled="True" />

                <asp:Panel ID="pnlNewUnit" runat="server"  CssClass="modal_popup" 
                    style="display:none;" DefaultButton="btnNewUnitSubmit" 
                    meta:resourcekey="pnlNewUnitResource1" >
                    
                    <div class="small_container border_color">
                        <fieldset class="inner_color">
                            <div>
                                <h3>
                                    <span class="title_header"><%= Resources.Common.Group %></span>
                                    <asp:RequiredFieldValidator ID="rfvDisplay" runat="server" ControlToValidate="txtNewUnit" CssClass="error" 
                                        ValidationGroup="newUnit" meta:resourcekey="rfvResource1" />
                                </h3>
                                <asp:TextBox ID="txtNewUnit" Width="100%" runat="server" 
                                    meta:resourcekey="txtNewUnitResource1" />
                            </div>
                            <br />
                            <div style="text-align:center;">
                                <asp:Button ID="btnNewUnitSubmit"  runat="server" CssClass="button" ValidationGroup="newUnit" 
                                    onclick="btnNewUnitSubmit_Click" meta:resourcekey="btnNewUnitSubmitResource1"  />&nbsp;
                                <asp:Button ID="btnCancelUnit" runat="server" Text="Cancel" CssClass="button" 
                                    meta:resourcekey="btnCancelSubUnitResource1" />
                            </div>
                        </fieldset>
                    </div>
                    
                </asp:Panel>
            </fieldset>
            <div class="divider"></div>
            
            <fieldset class="inner_color">
        
            
                <h4>
                    <span class="title_header"><%= Resources.Common.Subgroups %></span>
                    <span class="smaller">
                        <asp:DropDownList ID="ddlUnitSelected" runat="server" CssClass="smaller" 
                        DataSourceID="ldsUnits" DataTextField="unit_name" DataValueField="id" 
                        AutoPostBack="True" 
                        onselectedindexchanged="ddlUnitSelected_SelectedIndexChanged" 
                        meta:resourcekey="ddlUnitSelectedResource1" />
                        &nbsp;
                        <asp:Button ID="btnAddSubUnit" CssClass="smaller button" runat="server" meta:resourcekey="btnAddSubUnitResource1" />
                    </span>
                    <span class="clear" ></span>
                    <span class="smaller"><asp:Label ID="lblSubUnitReport" runat="server" meta:resourcekey="lblSubUnitReportResource1" /></span>
                </h4>
                <asp:ValidationSummary ID="valSubUnitEdit" runat="server" 
                    CssClass="error_area border_color" ValidationGroup="subUnitEdit" 
                    meta:resourcekey="valSubUnitEditResource1" />


                <asp:GridView ID="gvSubUnits" runat="server" DataSourceID="ldsSubUnits" DataKeyNames="id"  
                    AllowPaging="True" AllowSorting="True" CssClass="list" GridLines="None" AutoGenerateColumns="False"
                    onrowdeleted="gvSubUnits_RowDeleted" meta:resourcekey="gvSubUnitsResource1" >
                    <Columns>
                        <asp:TemplateField ShowHeader="False" meta:resourcekey="TemplateFieldResource3">
                            
                            <ItemTemplate>
                                <div class="gv_buttons">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                        CommandName="Edit" meta:resourcekey="LinkButton1Resource2" />&nbsp;
                                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" 
                                        meta:resourcekey="LinkButton2Resource4" />
                                </div>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <div class="gv_buttons">
                                    <asp:LinkButton ID="LinkButton1" runat="server"  CommandName="Update" 
                                        ValidationGroup="subUnitEdit" meta:resourcekey="LinkButton1Resource1" />
                                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                        CommandName="Cancel" meta:resourcekey="btnCancelSubUnitResource1" />
                                </div>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sub-Group" SortExpression="sub_unit_name" 
                            meta:resourcekey="TemplateFieldResource4">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("sub_unit_name") %>' 
                                    meta:resourcekey="Label2Resource1"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:RequiredFieldValidator ID="rfvSubSunitEdit" 
                                    ControlToValidate="txtSubUnitEdit" ValidationGroup="subUnitEdit" 
                                    ErrorMessage="Sub-Group required" Display="None" runat="server" 
                                    meta:resourcekey="rfvSubSunitEditResource1" />
                                <asp:TextBox ID="txtSubUnitEdit" runat="server" 
                                    Text='<%# Bind("sub_unit_name") %>' meta:resourcekey="txtSubUnitEditResource1"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mail To <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>The email address that will be notified when a ticket is assigned to this group.</q></span></a>" 
                            SortExpression="mailto" meta:resourcekey="TemplateFieldResource5">
                            <ItemTemplate>
                                <a href="mailto:<%# Eval("mailto") %>">
                                    <%# Utils.TrimForSideBar(Eval("mailto").ToString(), 21) %>
                                </a>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:RequiredFieldValidator ID="rfvMailto" runat="server" 
                                    ControlToValidate="txtMailto" ValidationGroup="subUnitEdit" 
                                    ErrorMessage="Mail to email address required" CssClass="error" Display="None" 
                                    meta:resourcekey="rfvMailtoResource1" />
                                <asp:RegularExpressionValidator ID="regEditMailTo" runat="server" 
                                    ErrorMessage="Invalid Email Address" ControlToValidate="txtMailto" ForeColor="" ValidationGroup="subUnitEdit" 
                                    
                                    ValidationExpression="^[0-9]*[a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([a-zA-Z][-\w\.]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$" 
                                    Display="None" CssClass="error" meta:resourcekey="regEditMailToResource1" />
                                <asp:TextBox ID="txtMailto" runat="server" Text='<%# Bind("mailto") %>' 
                                    meta:resourcekey="txtMailtoResource1" />
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField 
                            HeaderText="Req Access <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>This is the required access level a user must have in order to modify a ticket assigned to this group.</q></span></a>" 
                            SortExpression="security_level" meta:resourcekey="TemplateFieldResource6">
                            <EditItemTemplate>
                                <div class="gv_buttons" style="text-align:center;">
                                    <asp:DropDownList ID="ddlEditSecurityLevel" runat="server" SelectedValue='<%# Bind("access_level") %>'  
                                     DataSourceID="ldsAccessLevels" DataValueField="id" DataTextField="id" 
                                        meta:resourcekey="ddlEditSecurityLevelResource1" />
                                </div>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div class="gv_buttons" style="text-align:center;"><asp:Label ID="Label1" 
                                        runat="server" Text='<%# Bind("access_level") %>' 
                                        meta:resourcekey="Label1Resource2"></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                <asp:LinqDataSource ID="ldsSubUnits" runat="server" 
                    ContextTypeName="dbDataContext" EnableDelete="True" EnableUpdate="True" 
                    OrderBy="sub_unit_name" TableName="sub_units" Where="unit_ref == @unit_ref">
                    <WhereParameters>
                        <asp:ControlParameter ControlID="ddlUnitSelected" DefaultValue="0" 
                            Name="unit_ref" PropertyName="SelectedValue" Type="Int32" />
                    </WhereParameters>
                </asp:LinqDataSource>

            </fieldset>
                        
            <ajax:ModalPopupExtender ID="mpeSubUnit" runat="server" 
                TargetControlID="btnAddSubUnit" BackgroundCssClass="modal_background"
                PopupControlID="pnlAddSubUnit" CancelControlID="btnCancelSubUnit" 
                DynamicServicePath="" Enabled="True" />
            
            <asp:Panel ID="pnlAddSubUnit" runat="server"  CssClass="modal_popup" 
                style="display:none;" DefaultButton="btnNewSubUnitSubmit" 
                meta:resourcekey="pnlAddSubUnitResource1" >
                
                <div class="large_container border_color">
                
                    <fieldset class="inner_color">
                        
                        <table class="by2">
                            <tr>
                                <td style="width:50%;">
                                    <h3><span class="title_header">Group</span>&nbsp;</h3>
                                    <asp:DropDownList ID="ddlNewSubUnit" runat="server" cssClass="half_table" 
                                        DataSourceID="ldsUnits" DataTextField="unit_name" DataValueField="id" 
                                        meta:resourcekey="ddlNewSubUnitResource1" />
                                </td>
                                <td style="width:50%;">
                                    <h3>
                                        <span class="title_header">Sub-Group</span>
                                        <asp:RequiredFieldValidator ID="rfvNewSubUnit" runat="server" 
                                            ControlToValidate="txtNewSubUnit" CssClass="error" ValidationGroup="new" meta:resourcekey="rfvResource1" />
                                    </h3>
                                    <asp:TextBox ID="txtNewSubUnit" cssClass="half_table" runat="server" 
                                        meta:resourcekey="txtNewSubUnitResource1" />
                                </td>
                             </tr>
                             <tr>
                                <td>
                                    <h3><span class="title_header">
                                        <asp:Literal ID="litReqAccessLevel" runat="server" meta:resourcekey="litReqAccessLevelResource1" />
                                        <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>This is the required access level a user must have in order to be able to join, assign tickets to, or modify a ticket assigned to this group.</q></span></a>
                                    </span>&nbsp;</h3>
                                    <asp:DropDownList ID="ddlSecurityLevel" runat="server" cssClass="half_table" 
                                        meta:resourcekey="ddlSecurityLevelResource1" />
                                </td>
                                <td>
                                    <h3>
                                        <span class="title_header">
                                            <asp:Literal ID="litMailTo" runat="server" meta:resourcekey="litMailToResource1" />
                                            <a href='javascript:void();' class='tooltip limited'><img src='../images/info.png' alt='explanation' /><span class='border_color'><q class='inner_color base_text'>The email address that will be notified when a ticket is assigned to this group.</q></span></a>
                                        </span>&nbsp;
                                        <asp:RequiredFieldValidator ID="rfvMailto" runat="server" ControlToValidate="txtMailto" ValidationGroup="new" 
                                            CssClass="error" Display="Dynamic" meta:resourcekey="rfvResource1" />
                                        <asp:RegularExpressionValidator ID="regEditMailTo" runat="server" 
                                            ErrorMessage="Invalid Email Address" ControlToValidate="txtMailto" ForeColor="" ValidationGroup="new" 
                                            
                                            ValidationExpression="^[0-9]*[a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([a-zA-Z][-\w\.]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$" 
                                            Display="Dynamic" CssClass="error" meta:resourcekey="regEditMailToResource2" />
                                    </h3>
                                    <asp:TextBox runat="server" ID="txtMailto" cssClass="half_table" 
                                        meta:resourcekey="txtMailtoResource2" />
                                </td>
                             </tr>
                        </table>
                        <br />
                        <div style="text-align:center;">
                            <asp:Button ID="btnNewSubUnitSubmit"  runat="server" CssClass="button" ValidationGroup="new" 
                                onclick="btnNewSubUnitSubmit_Click" meta:resourcekey="btnNewSubUnitSubmitResource1" />&nbsp;
                            <asp:Button ID="btnCancelSubUnit" runat="server" CssClass="button" meta:resourcekey="btnCancelSubUnitResource1" />
                        </div>
                    </fieldset>
                </div>
                
            </asp:Panel>
    
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>

