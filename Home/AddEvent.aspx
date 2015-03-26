<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="Home.AddEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
    <div class="row vertical-center-row">
        <div class="col-lg-12">Add Event
            <div class="row ">
                <div class="col-xs-4 col-xs-offset-4"color:white">
                     <asp:TextBox Width="500px" Height="200px" ID="txtboxeventadd" TextMode="MultiLine" runat="server"></asp:TextBox> 
                   
                </div>
            </div>
        </div>

    </div>
         <br/>
         <br/>
           <div class="row vertical-center-row">
        <div class="col-lg-12">
            <div class="row ">
                <div class="col-xs-4 col-xs-offset-4"color:white">
                    <asp:Button ID="Button1"  class="btn btn-primary" OnClick="btnSaveEvents" runat="server" Text="Button" />
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
