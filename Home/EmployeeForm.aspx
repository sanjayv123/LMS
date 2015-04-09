<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="Home.EmployeeForm1" %>

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
                    <div class="well well-sm">
                        <strong><%--<span class="glyphicon glyphicon-asterisk"></span>Required Field--%>
                            <asp:Label ID="lblEmployeeFormType" runat="server"></asp:Label></strong>
                    </div>

                    <div class="col-lg-6">
                        <div class="form-group">
                            <%--<label for="InputName">Enter Name</label>--%>
                            <div class="input-group">
                                <%--   <input type="text" class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required>--%>
                                <asp:TextBox class="form-control" ID="txtname" runat="server" placeholder="Name" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <%-- <label for="InputName">Full Name</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtSurname" runat="server" placeholder="Last Name" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <%-- <label for="InputName">Address</label>--%>
                            <div class="input-group">
                                <asp:TextBox ID="txtaddress" CssClass="form-control" runat="server" placeholder="Address" Columns="50" TextMode="MultiLine" Rows="5" required></asp:TextBox>

                            </div>
                        </div>
                        <div class="form-group">
                            <%-- <label for="InputEmail">Email</label>--%>
                            <div class="input-group">


                                <asp:TextBox class="form-control" ID="txtemail" runat="server" placeholder="Email" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <%--  <label for="InputEmail">Personal Email</label>--%>
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtpersonalemail" runat="server" placeholder="Personal Email" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <%--   <label for="InputName">Employee DOB</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtDOB" runat="server" placeholder="Employee DOB" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <%-- <label for="InputName">Employee Joining Date</label>--%>
                            <div class="input-group">

                                <asp:DropDownList class="form-control" ID="ddlGender" runat="server"
                                    AppendDataBoundItems="true">
                                    <asp:ListItem Value="-1">Select Gender</asp:ListItem>
                                    <asp:ListItem Value="Male">Male</asp:ListItem>
                                    <asp:ListItem Value="Female">Female</asp:ListItem>
                                </asp:DropDownList>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                    </div>



                    <div class="col-lg-6">
                        <div class="form-group">
                            <%-- <label for="InputName">Mobile Number</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtmobile" runat="server" placeholder="MobileNumber" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <%-- <label for="InputName">Phone Number</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtphone" runat="server" placeholder="Phone Number" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <%--   <label for="InputName">Employee Code</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtempcode" runat="server" placeholder="Employee Code" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        
                            <div class="form-group">
                            <%--   <label for="InputName">Employee Code</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtusername" runat="server" placeholder="User Name" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Select Department</label>
                            <div class="input-group">
                                <asp:DropDownList class="form-control" ID="ddlDepartmentList" runat="server"></asp:DropDownList>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                         <div class="form-group">
                            <label>Select Role</label>
                            <div class="input-group">
                                <asp:DropDownList class="form-control" ID="ddlRoleList" runat="server"></asp:DropDownList>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>


                        <div class="form-group">
                            <label>Select Job Role</label>
                            <div class="input-group">
                                <asp:DropDownList class="form-control" ID="ddlJobRole" runat="server"></asp:DropDownList>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <label>Select Reporting Manager</label>
                            <div class="input-group">
                                <asp:DropDownList class="form-control" ID="ddlReportingManager" runat="server"></asp:DropDownList>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>


                        <div class="form-group">
                            <%--     <label for="InputName">Employee Joining Date</label>--%>
                            <div class="input-group">

                                <asp:TextBox class="form-control" ID="txtJoiningDate" runat="server" placeholder="Employee Joining Date" required></asp:TextBox>
                                <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                            </div>
                        </div>



                        <asp:Button runat="server" ID="btnsave" Text="Save" class="btn btn-primary" OnClick="btnsave_Click" />
                    </div>
                    <%-- <input type="submit" name="submit" id="submit" value="Submit" class="btn btn-info pull-right">--%>
                </div>
            </div>
            <%--<div class="col-lg-5 col-md-push-1">
            <div class="col-md-12">
                <div class="alert alert-success">
                    <strong><span class="glyphicon glyphicon-ok"></span> Success! Message sent.</strong>
                </div>
                <div class="alert alert-danger">
                    <span class="glyphicon glyphicon-remove"></span><strong> Error! Please check all page inputs.</strong>
                </div>
            </div>
        </div>--%>
        </div>
    </div>




    <script type="text/javascript">

      

        $(document).ready(function () {
            $('#<%=txtDOB.ClientID %>').datepicker(
         {
             dateFormat: "dd/mm/yy",
             duration: "",
             showOn: "both",
             buttonImage: "/datetimepicker/calendar.gif",
             buttonImageOnly: true

         });


            $('#<%=txtJoiningDate.ClientID %>').datepicker(
      {
          dateFormat: "dd/mm/yy",
          duration: "",
          showOn: "both",
          buttonImage: "datetimepicker/calendar.gif",
          buttonImageOnly: true

      });

            var btntext = $('#<%=btnsave.ClientID %>').val();            if (btntext != "Update") {
                $("#Menu2").addClass("active");
            }

        });
    </script>

</asp:Content>

