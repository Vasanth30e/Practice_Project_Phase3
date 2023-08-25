<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Phase3Section3._6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:HiddenField ID="validation_id" value="14635" runat="server" />

    <div class="row">
        <div class="col-12 text-center"><asp:Label runat="server" Text="PASSPORT APPLICATION FORM" Font-Bold="true"></asp:Label></div>
    </div>
    <div class="row">
                <div class="col-6">
                      <div class="row mt-5">
                        <div class="col-4">First Name*</div>
                        <div class="col-7"><asp:TextBox ID="fname" cssClass="form-control" runat="server" MaxLength="100"></asp:TextBox></div>
                    </div>

                      <div class="row mt-5">
                        <div class="col-4">Last Name*</div>
                        <div class="col-8"><asp:TextBox ID="lname" cssClass="form-control" runat="server" MaxLength="100"></asp:TextBox></div>
                    </div>

                      <div class="row mt-5">
                        <div class="col-4">Date of Birth*
                          </div>
                        <div class="col-8"><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></div>
                    </div>
    
                     <div class="row mt-5">
                        <div class="col-4">Current Address*
                          </div>
                        <div class="col-8">
                            <asp:ImageButton ID="ImageButton1" runat="server"  Height="40"
                                ImageUrl="https://img.etimg.com/thumb/msid-69170499,width-643,imgsize-50756,resizemode-4/googlemaps1.jpg" ImageAlign="Left" OnClick="ImageButton1_Click" />
                            &nbsp;Click on icon to the left to launch Google Maps
                        </div>
                    </div>

                </div>

        <div class="col-6">
                 <div class="row mt-5">
                        <div class="col-4">Upload Photo*</div>
                        <div class="col-7">
                            <asp:FileUpload ID="FileUpload1" runat="server"  />
                            <hr />
                            Sample image below:<br />
                            <asp:Image runat="server" Height="300" Width="300" id="imgUpload" ImageUrl="https://visafoto.com/img/source355x388.jpg"/>
                        </div>
                        
                 </div>

         
                <asp:Panel runat="server" CssClass="bg-info row mt-5">
                        <div class="col-4">Employment Status</div>
                    <div class="col-7">
                        <asp:RadioButton ID="RadioButton1" value="0" runat="server" Text="&nbsp;Unemployed" GroupName="rbGroup"/><br />
                            <asp:RadioButton ID="RadioButton2" value="1"  runat="server" Text="&nbsp;Private Company" GroupName="rbGroup"/><br />
                            <asp:RadioButton ID="RadioButton3" value="2" runat="server" Text="&nbsp;Public Company" GroupName="rbGroup"/><br />
                        <asp:RadioButton ID="RadioButton4" value="3" runat="server" Text="&nbsp;Self Employed" GroupName="rbGroup"/><br />
                        <asp:RadioButton ID="RadioButton5" value="4" runat="server" Text="&nbsp;Business" GroupName="rbGroup"/><br />
                    </div>
                 </asp:Panel>

            
                <asp:Panel runat="server" CssClass="bg-info row mt-5">
                        <div class="col-4">Special Status</div>
                    <div class="col-7">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="&nbsp;Senior Citizen"/><br />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="&nbsp;Minor"/><br />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="&nbsp;Armed Forces"/><br />
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="&nbsp;Foreign Diplomat"/><br />
                        </div>
                 </asp:Panel>
                 
        </div>
    </div>
  
      <div class="row mt-5 border-top">
        <div class="col-12 text-center">
            <asp:Button runat="server" ID="btnSubmit" cssClass="btn btn-secondary" Text="Submit" />
        </div>
    </div>
</asp:Content>
