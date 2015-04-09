<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeLeaveDetails.aspx.cs" Inherits="Home.EmployeeLeaveDetails" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script type="text/javascript" src="datetimepicker/jquery-latest.js"></script>
    <script type="text/javascript" src="datetimepicker/ui.datepicker.js"></script>
    <link rel="stylesheet" type="text/css" href="datetimepicker/flora.datepicker.css" />
    <link rel="stylesheet" type="text/css" href="datetimepicker/ui.datepicker.css" />
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
        <div class="row">
        <div class="col-lg-7">
              <div class="form-inline">
               
                      <div class="form-group ">
                         <div class="col-lg-3">                        
                             <asp:TextBox id="txtFromDate" style="width:150px" placeholder="From Date"  class="form-control input-sm" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                          <div class="col-lg-3">
                         <asp:TextBox id="txtToDate" style="width:150px" placeholder="To Date"  class="form-control input-sm" runat="server"></asp:TextBox>
                         </div>
                      </div>
                     <%-- <div class="form-group">
                          <div class="col-lg-3">
                         <asp:TextBox id="txtEmployeeId" style="width:150px" placeholder="EmployeeId"  class="form-control input-sm" runat="server"></asp:TextBox>
                         </div>
                      </div>--%>
                   <div class="form-group">
                          <div class="col-lg-3">
                              <asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
                         </div>
                      </div>
                 </div>
           <p class="help-block"></p>
           </div>
        </div>
        <div class="row">
                                <div class="well well-sm">
            <strong><%--<span class="glyphicon glyphicon-asterisk"></span>Required Field--%>
                <asp:Label ID="Label1" runat="server">Details</asp:Label></strong>
        </div>

        <div class="row">
            <div>
 
        </div>
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
                                <%#Eval("LeaveToDateTime") %>
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

                        <%-- <asp:TemplateField HeaderText="Remaining Days">
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

   
      
      <script type="text/javascript">
          
          $(document).ready(function () {
              $('#<%=txtToDate.ClientID%>').datepicker(
              {
                  dateFormat: "dd/mm/yy",
                  duration: "",
                  showOn: "both",
                  buttonImage: "/datetimepicker/calendar.gif",
                  buttonImageOnly: true

              });
              $('#<%=txtFromDate.ClientID %>').datepicker(
              {
                  dateFormat: "dd/mm/yy",
                  duration: "",
                  showOn: "both",
                  buttonImage: "/datetimepicker/calendar.gif",
                  buttonImageOnly: true

              });
      
          })

      </script>
</asp:Content>
