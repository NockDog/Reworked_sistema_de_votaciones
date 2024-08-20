<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrarCandidato.aspx.cs" Inherits="RegistrarCandidato" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Registrar Candidato</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h2>Registrar Nuevo Candidato</h2>
    <form id="form1" runat="server">
        <label>Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
        <label>Partido Político:</label>
        <asp:TextBox ID="txtPartido" runat="server"></asp:TextBox><br />
        <label>Plataforma:</label>
        <asp:TextBox ID="txtPlataforma" TextMode="MultiLine" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnRegistrar" Text="Registrar" OnClick="btnRegistrar_Click" runat="server" />
    </form>
</body>
</html>
