<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Votacion.aspx.cs" Inherits="Votacion" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Votación</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h2>Votar por un Candidato</h2>
    <form id="form1" runat="server">
        <label>Seleccione un Candidato:</label>
        <asp:DropDownList ID="ddlCandidatos" runat="server"></asp:DropDownList><br />
        <asp:Button ID="btnVotar" Text="Votar" OnClick="btnVotar_Click" runat="server" />
    </form>
</body>
</html>
