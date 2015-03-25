<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="Home.EmployeeView1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box col-md-12" >
<div class="box-inner" style="margin-left: auto;margin-right: auto;"">
<div class="box-header well" >
<h2 style="font-weight:300; line-height:none; margin-top: 0px;margin-bottom: 0px;font-size:25px"><i class="glyphicon glyphicon-eye-open"></i> View Employee</h2>

</div>
<div class="box-content">
    <table  class="table table-bordered table-striped">

        <tr>
            <td>Name
            </td>
            <td>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Full Name
            </td>
            <td c>
                <asp:Label ID="lblFullName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Address
            </td>
            <td>
                <asp:Label ID="lblAddress" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Email
            </td>
            <td>
                <asp:Label ID="lblEmail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Personal Email
            </td>
            <td>
                <asp:Label ID="lblPersonalEmail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Mobile No.
            </td>
            <td>
                <asp:Label ID="lblMobileNumber" runat="server"></asp:Label>
            </td>

        </tr>
        <tr>
            <td>Code
            </td>
            <td>
                <asp:Label ID="lblCode" runat="server"></asp:Label>
            </td>

        </tr>
        <tr>
            <td>DOB
            </td>
            <td>
                <asp:Label ID="lblDOB" runat="server"></asp:Label>
            </td>

        </tr>


        <tr>
            <td>Joining Date
            </td>
            <td>
                <asp:Label ID="lblJoiningDate" runat="server"></asp:Label>
            </td>

        </tr>



        <tr>
            <td>Gender
            </td>
            <td>
                <asp:Label ID="lblGender" runat="server"></asp:Label>
            </td>

        </tr>
    </table>.
    </div>
</div>
</div>
</asp:Content>
