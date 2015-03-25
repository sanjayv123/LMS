<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeProfile.aspx.cs" Inherits="Home.EmployeeProfile1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </div>
    
    <div class="box-content">
       <table class="table table-bordered table-stripped">
         <tr>
            <td>Name
            </td>
            <td>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>

           <tr>
            <td>EmployeeId
            </td>
            <td>
                <asp:Label ID="lblEmployeeId" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Designation
            </td>
            <td>
                <asp:Label ID="lblDesignation" runat="server"></asp:Label>
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
            <td>Email-Id
            </td>
            <td>
                <asp:Label ID="lblEmailId" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Mobile Number
            </td>
            <td>
                <asp:Label ID="lblMobileNumber" runat="server"></asp:Label>
            </td>
        </tr>

           <tr>
            <td>Phone Number
            </td>
            <td>
                <asp:Label ID="lblPhoneNumber" runat="server"></asp:Label>
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
            <td>JoiningDate
            </td>
            <td>
                <asp:Label ID="lblJoiningDate" runat="server"></asp:Label>
            </td>
        </tr>


           <%--</tr>
           <tr>
               <td>
               <asp:FileUpload ID="FileUpload1" runat="server" />
              <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
               </td>
           </tr>--%>
        </table>
        
      </div>
  </div>
</asp:Content>
