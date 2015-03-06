<%@ Page Language="C#" AutoEventWireUp="true" Inherits="CurrencyConverter" Codebehind="CurrencyConverter.aspx.cs" %>
<!DOCTYPE html>

<html>
<head>
    <title>Currency Converter</title>
</head>
<body>
    <form runat="server">
        <div>
            Convert: &nbsp;
            <input type="text" id="US" runat="server"/>
            &nbsp; U.S. dollars to Euros.
            <br /><br />
            <input type="submit" value="OK" id="Convert" runat="server" OnServerClick= "Convert_ServerClick" />
            <br /><br />
            <p style="font-weight:bold" id="Result" runat="server"></p>
        </div>
    </form>
</body>
</html>