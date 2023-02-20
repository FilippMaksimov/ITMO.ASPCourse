<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SummaryBD.aspx.cs" Inherits="SummaryBD" MasterPageFile="~/Site.master"%>
<asp:Content ID="SummaryBDContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Список участников</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="ФИО" ReadOnly="True" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Электронный адрес" ReadOnly="True" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Телефон" ReadOnly="True" SortExpression="Phone" />
                <asp:BoundField DataField="Rdata" DataFormatString="{0:d}" HeaderText="Дата регистрации" ReadOnly="True" SortExpression="Rdata" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="EntityWeb.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)" TableName="GuestResponses">
        </asp:LinqDataSource>
    </div>
</asp:Content>