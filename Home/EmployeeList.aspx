<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="Home.EmployeeList1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvEmployee" runat="server"  border="0px" AutoGenerateColumns="False" CssClass="table table-bordered table-striped" >
        <Columns>
            <asp:TemplateField HeaderText="Full Name">
                <ItemTemplate>
                    <%#Eval("FullName")%>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <%#Eval("Email")%>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Mobile No">
                <ItemTemplate>
                    <%#Eval("Mobile")%>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Code">
                <ItemTemplate>
                    <%#Eval("EmployeeCode")%>
                </ItemTemplate>
            </asp:TemplateField>

            <%--<asp:TemplateField HeaderText="DOB">
                <ItemTemplate>
                    <%#Eval("EMP_DOB")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Joining Date">
                <ItemTemplate>
                    <%#Eval("EMP_JOININGDATE")%>
                </ItemTemplate>
            </asp:TemplateField>--%>
         <%--   <asp:TemplateField HeaderText="Gender">
                <ItemTemplate>
                    <%#Eval("EMP_GENDER")%>
                </ItemTemplate>
            </asp:TemplateField>--%>

             <asp:TemplateField HeaderText="View">
                <ItemTemplate>
                    <a title="View" href='EmployeeView.aspx?EMP_ID=<%#Eval("EmployeeID")%>' > <i class="glyphicon glyphicon-eye-open"></i>        </a>
                   
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <a title="Edit" href='EmployeeForm.aspx?EMP_ID=<%#Eval("EmployeeID")%>' >   <i class=" glyphicon glyphicon-edit"></i>        </a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

    
     <script type="text/javascript">
        
     
         $(document).ready(function(){
        

             $("#Menu1").addClass("active");
         });
         </script>

</asp:Content>



