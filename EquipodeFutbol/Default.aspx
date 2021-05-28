<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EquipodeFutbol._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Equipos de Futbol</h1>
        <p class="lead">Equipos existentes</p>
        <p class="lead">Nombre del Equipo:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Ciudad:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Jugadores</p>
        <p class="lead">Nombre del jugador
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Jugadores" />
        </p>
        <p class="lead">Año de fundacion:</p>
        <p class="lead">
            <asp:Calendar ID="Calendar1" runat="server" Height="63px" Width="199px"></asp:Calendar>
        </p>
        <p class="lead">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar Equipo" />
        </p>
        <p class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <asp:GridView ID="GridView1" runat="server" Height="218px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="320px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:GridView ID="GridView2" runat="server" Height="170px" Width="329px">
        </asp:GridView>
        <asp:Button ID="Button3" runat="server" Height="38px" Text="Mostrar" Width="97px" />
        <br />
        Nombre jugador para eliminar o editar:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Height="45px" OnClick="Button4_Click" Text="Eliminar" Width="106px" />
&nbsp;
        <br />
        <br />
        ingrese el nuevo nombre:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <p>&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Editar" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
