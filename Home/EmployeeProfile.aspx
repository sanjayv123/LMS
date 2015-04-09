<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeProfile.aspx.cs" Inherits="Home.EmployeeProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="box-content">
        <%-- <table class="table table-bordered table-stripped">

           <tr>
            <td class="auto-style1">Casual Leaves Applied
            </td>
            <td>
                <asp:Label ID="lblLeavesApplied" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style1">Casual Leaves Available
            </td>
            <td>
                <asp:Label ID="lblLeavesAvailable" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style1">Leaves Availed
            </td>
            <td>
                <asp:Label ID="lblLeavesAvailed" runat="server"></asp:Label>
            </td>
        </tr>

           <tr>
            <td class="auto-style1">Leaves Carried Over
            </td>
            <td>
                <asp:Label ID="lblLeavesCarriedOver" runat="server"></asp:Label>
            </td>
        </tr>

           <%--</tr>
           <tr>
               <td>
               <asp:FileUpload ID="FileUpload1" runat="server" />
              <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
               </td>
           </tr>--%>
        <%--  </table>--%>

        <table class="table table-striped">
           <%-- <caption>Striped Table Layout</caption>--%>
            <thead>
                <tr>
                    <th>&nbsp;</th>
                    <th>casual leave</th>
                    <th>planned leave</th>
                    <th>Sick leave</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th>Total Leaves</th>
                    <td>
                        <asp:Label ID="lbltotalcasualleaves" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblTotalPlannedLeaves" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTotalSickLeaves" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Leave Taken </th>
                    <td><asp:Label ID="lbltotalcasualleavesTaken" runat="server" Text="Label"></asp:Label></td>
                    <td><asp:Label ID="lblTotalPlannedLeavesTaken" runat="server" Text="Label"></asp:Label></td>
                    <td><asp:Label ID="lblTotalSickLeavesTaken" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Leave Available</th>
                    <td><asp:Label ID="lbltotalcasualleavesAvailable" runat="server" Text="Label"></asp:Label></td>
                    <td><asp:Label ID="lblTotalPlannedLeavesAvailable" runat="server" Text="Label"></asp:Label></td>
                    <td><asp:Label ID="lblTotalSickLeavesAvailable" runat="server" Text="Label"></asp:Label></td>
                </tr>
            </tbody>
        </table>

    </div>

</asp:Content>
