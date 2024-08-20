<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Resultados.aspx.cs" Inherits="Resultados" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Resultados</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h2>Resultados de la Elección</h2>
    <table>
        <thead>
            <tr>
                <th>Candidato</th>
                <th>Total Votos</th>
                <th>Porcentaje</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rptResultados" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Nombre") %></td>
                        <td><%# Eval("Total_Votos") %></td>
                        <td><%# Eval("Porcentaje_Votos") %>%</td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</body>
</html>
