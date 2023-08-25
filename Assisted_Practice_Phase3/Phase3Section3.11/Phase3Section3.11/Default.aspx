<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Phase3Section3._11._Default" %>
<%@ Import NameSpace="System.Data" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <br />
        <h4>List Of Students</h4>
        <%
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Class", typeof(string));

            table.Rows.Add("Walter", "6B");
            table.Rows.Add("Edith", "6B");
            table.Rows.Add("William", "6B");
            table.Rows.Add("June", "6B");

            foreach(DataRow dr in table.Rows)
            {
                Response.Write(dr["Name"] + " is in class " + dr["Class"] + "<Br>");
            }
            %>
    </div>

</asp:Content>
