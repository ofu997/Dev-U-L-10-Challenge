﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevUL10ChallengeWebForm.aspx.cs" Inherits="DevUL10Challenge.DevUL10ChallengeWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="ok" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
