<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeLeaveApproval.aspx.cs" Inherits="Home.EmployeeLeaveApproval" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div>
                <asp:GridView ID="gvEmployeeLeave"  runat="server" Border="0px" AutoGenerateColumns="False" CssClass="table table-bordered table-striped" Width="1166px" OnRowCommand="_updateApproval">
                    <Columns>
                        <asp:TemplateField HeaderText="Employee leave ID">
                            <ItemTemplate>
                                <%#Eval("EmployeeleaveId") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Employee ID">
                            <ItemTemplate>
                                <%#Eval("EmployeeId") %>
                            </ItemTemplate>                        
                        </asp:TemplateField>
                        
                            <asp:TemplateField HeaderText="Employee FullName">
                            <ItemTemplate>
                                <%#Eval("EmployeeFullName") %>
                            </ItemTemplate>                        
                        </asp:TemplateField>
                       
                           <asp:TemplateField HeaderText="Job Role">
                            <ItemTemplate>
                                <%#Eval("JobName") %>
                            </ItemTemplate>                        
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Leave Type">
                            <ItemTemplate>
                                <%#Eval("LeaveType") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                       

                 
                        <asp:TemplateField HeaderText="Leave Reason">
                            <ItemTemplate>
                                <%#Eval("LeaveReason") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                       
                         <asp:TemplateField HeaderText="Leave From">
                            <ItemTemplate>
                                <%#Eval("LeaveFromDateTime") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        
                         <asp:TemplateField HeaderText="Leave To">
                            <ItemTemplate>
                                <%#Eval("LeaveTodatDateTime") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Joining Date">
                            <ItemTemplate>
                                <%#Eval("JoiningDateTime") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Total days On Leave">
                            <ItemTemplate>
                                <%#Eval("TotaldaysOnLeaveCurrent") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Total Leave Taken In Year">
                            <ItemTemplate>
                                <%#Eval("TotalLeaveTakenInYear") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                         <asp:TemplateField HeaderText="Leave Status">
                            <ItemTemplate>
                                <%#Eval("LeaveStatus") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Leave Approval Status">
                            <ItemTemplate>
                                <%#Eval("LeaveApprovalStatus") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                          <asp:TemplateField HeaderText="Remaining Days">
                            <ItemTemplate>
                              <button class="btn btn-primary" type="button">
                                   <span class="badge">4</span>
                                      </button>
                            </ItemTemplate>
                        </asp:TemplateField>
                                            
                         <asp:TemplateField HeaderText="Grant">
                            <ItemTemplate>
                                <asp:LinkButton CommandArgument='<%#Eval("EmployeeleaveId") %>' CommandName="UpdateLeaveApproval" ID="lnkButtonUpdateApproval" runat="server">Approve</asp:LinkButton>
                                <asp:LinkButton CommandArgument='<%#Eval("EmployeeleaveId") %>' CommandName="UpdateLeaveReject" ID="lnkButtonUpdateReject" runat="server">Reject</asp:LinkButton>
                          </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        
    </div>
</asp:Content>
