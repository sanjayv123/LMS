<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Home.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-2">
            <div class="table">
                <table class="table">
                    <caption>Employee</caption>
                    <thead>
                    </thead>
                    <tbody>
                        <tr class="danger">
                            <th>Name</th>
                            <td>
                                <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                        <tr class="danger">
                            <th>DOB</th>
                            <td>
                                <asp:Label ID="lblDOB" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                        <tr class="danger">
                            <th>ADDRESS</th>
                            <td>
                                <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>

                        <tr class="danger">
                            <th>EMPLOYEE CODE</th>
                            <td>
                                <asp:Label ID="lblEmployeecode" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                        <tr class="danger">
                            <th>EMAIL ID</th>
                            <td>
                                <asp:Label ID="lblemailId" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                        <tr class="danger">
                            <th>MOBILE NO</th>
                            <td>
                                <asp:Label ID="lblMobileNo" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                    </tbody>
                </table>
            </div>
            <br />
            <br />
            <br />
            <br />

        </div>
        <div class="col-lg-1">
        </div>
        <div class="col-lg-2">
            <div class="table">
                <table class="table">
                    <caption>Thaught for the Day</caption>
                    <thead>
                    </thead>
                    <tbody>
                        <tr class="success">
                            <th>
                                <asp:Label ID="lblthaughts" runat="server" Text="Label"></asp:Label>

                            </th>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
        
         <div class="col-lg-5">
            <div class="table">
                <table class="table">
                    <caption>Event of this Month</caption>
                    <thead>
                    </thead>
                    <tbody>
                        <tr class="warning">
                            <th>
                                <asp:Label ID="lblevents" runat="server" Text="Label"></asp:Label>
                            </th>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>

    </div>


</asp:Content>
