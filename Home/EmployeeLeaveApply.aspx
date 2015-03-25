<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeLeaveApply.aspx.cs" Inherits="Home.EmployeeLeaveApply" %>

<script runat="server">

   
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="datetimepicker/jquery-latest.js"></script>
    <script type="text/javascript" src="datetimepicker/ui.datepicker.js"></script>
    <link rel="stylesheet" type="text/css" href="datetimepicker/flora.datepicker.css" />
    <link rel="stylesheet" type="text/css" href="datetimepicker/ui.datepicker.css" />
    <style>
        .input-group-addon {
            width: 10% !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div>
                <div class="col-lg-12">
                    <div class="well well-sm"><strong><%--<span class="glyphicon glyphicon-asterisk"></span>Required Field--%>
                        <asp:Label ID="lblEmployeeLeaveType" runat="server">Apply Leave Request</asp:Label></strong></div>

                    <div class="col-lg-6">
                        <div class="form-group">
                            <%--<label for="InputName">Enter Name</label>--%>
                            <div class="input-group">
                                <asp:DropDownList class="form-control" ID="ddlleavetype" runat="server">                                   
                                </asp:DropDownList>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtleavefrom" runat="server" placeholder="Leave From" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtleaveto" runat="server" placeholder="Leave To" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <asp:TextBox ID="txtleavereason" CssClass="form-control" runat="server" placeholder="Leave Reason" Columns="50" TextMode="MultiLine" Rows="5" required></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtleavejoiningdate" runat="server" placeholder="Joining Date" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtReportingManager" runat="server" placeholder="Joining Date" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                       
                         <div class="form-group">
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtFillManagerID" runat="server" placeholder=""></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                       
                        <%--<asp:Button runat="server" ID="btnsave" Text="Save" OnClick="btnsave_Click" />--%>
                        <asp:Button runat="server" ID="btnsave"  Text="Submit"  class="btn btn-primary" OnClick="btnsubmit_Click" />
                    </div>
                    
  
            </div>
        </div>
    </div>
        <div class="row">
             <div class="well well-sm"><strong><%--<span class="glyphicon glyphicon-asterisk"></span>Required Field--%>
                        <asp:Label ID="Label1" runat="server">Previous Leave</asp:Label></strong></div>

       </div>
    
     <div class="row">
                                          
    <asp:GridView ID="gvEmployeeLeave" runat="server" Border="0px" AutoGenerateColumns="False" CssClass="table table-bordered table-striped" Width="1166px" OnRowCommand="_gvEmployeeLeaveRowCommand" >
       <Columns>
           <asp:TemplateField HeaderText="LeaveId">
               <ItemTemplate>
                   <%#Eval("LeaveId") %>
               </ItemTemplate>
           </asp:TemplateField>

           <asp:TemplateField HeaderText="Leave Type">
               <ItemTemplate>
                   <%#Eval("LeaveType") %>
               </ItemTemplate>

           </asp:TemplateField>
           <asp:TemplateField HeaderText="Leave From">
               <ItemTemplate>
                    <%#Eval("LeaveFromDateTime") %>
               </ItemTemplate>
           </asp:TemplateField>

           <asp:TemplateField HeaderText="Leave TO">
               <ItemTemplate>
                   <%#Eval("LeaveTodatDateTime") %>
               </ItemTemplate>
           </asp:TemplateField>
           
                        <asp:TemplateField HeaderText="Weekends or Holiday In Leave">
                            <ItemTemplate>
                                <%#Eval("WeekendOrHolidayInLeave") %>
                            </ItemTemplate>
                        </asp:TemplateField>
           

           <asp:TemplateField HeaderText="Joining Date">
               <ItemTemplate>
                   <%#Eval("JoiningDateTime") %>
               </ItemTemplate>
           </asp:TemplateField>

          <asp:TemplateField HeaderText="Leave Approval Status">
               <ItemTemplate>
                   <%#Eval("LeaveApprovalStatus") %>
               </ItemTemplate>
           </asp:TemplateField>

             <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton  ID="Delete" CommandArgument='<%#Eval("LeaveId") %>' CommandName="CancelLeave" runat="server">Cancel</asp:LinkButton>
               </ItemTemplate>
           </asp:TemplateField>
      
       </Columns>
    </asp:GridView>           
                 </div>





      <script type="text/javascript">


          $(document).ready(function () {
              $('#<%=txtleavefrom.ClientID %>').datepicker(
             {
                 dateFormat: "dd/mm/yy",
                 duration: "",
                 showOn: "both",
                 buttonImage: "/datetimepicker/calendar.gif",
                 buttonImageOnly: true

             });
               $('#<%=txtleaveto.ClientID %>').datepicker(
             {
                 dateFormat: "dd/mm/yy",
                 duration: "",
                 showOn: "both",
                 buttonImage: "/datetimepicker/calendar.gif",
                 buttonImageOnly: true

             });
               $('#<%=txtleavejoiningdate.ClientID %>').datepicker(
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





