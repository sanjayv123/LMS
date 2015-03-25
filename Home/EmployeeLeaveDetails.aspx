<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeLeaveDetails.aspx.cs" Inherits="Home.EmployeeLeaveDetails" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .textboxside {
            float: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="well well-sm">
            <strong><%--<span class="glyphicon glyphicon-asterisk"></span>Required Field--%>
                <asp:Label ID="lblEmployeeLeaveType" runat="server">Search Leave Details</asp:Label></strong>
        </div>
        <div class="row col-sm-12">
            <div class="input-group textboxside">
                <asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div class="">
                <div class="input-group textboxside">
                    <asp:TextBox class="form-control textboxside" ID="TextBox2" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="input-group">
                <asp:Button ID="Button1" class="btn btn-primary textboxside" runat="server" Text="Button" />
            </div>
            <br />

            <div class="well well-sm">
                <strong><%--<span class="glyphicon glyphicon-asterisk"></span>Required Field--%>
                    <asp:Label ID="Label1" runat="server">Details</asp:Label></strong>
            </div>
        </div>



        <div class="row">
            <div>
                <asp:GridView ID="gvEmployeeLeave" runat="server" Border="0px" AutoGenerateColumns="False" CssClass="table table-bordered table-striped" Width="1166px">
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

                        <asp:TemplateField HeaderText="Department">
                            <ItemTemplate>
                                <%#Eval("DepartmentName") %>
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



                        <asp:TemplateField HeaderText="Leave Approved By">
                            <ItemTemplate>
                                <%#Eval("LeaveApprovedBy") %>
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
                        
                          <asp:TemplateField HeaderText="Weekends or Holiday In Leave">
                            <ItemTemplate>
                                <%#Eval("WeekendOrHolidayInLeave") %>
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

                        <%--                          <asp:TemplateField HeaderText="Remaining Days">
                            <ItemTemplate>
                              <button class="btn btn-primary" type="button">
                                   <span class="badge">4</span>
                                      </button>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    </div>
</asp:Content>
