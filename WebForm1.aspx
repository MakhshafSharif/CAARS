<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script>
        function runAjax() {
            var inputVal = document.getElementById("Hello").value;
            if (inputVal == "") return;
            $.ajax({
                url: 'WebForm1.aspx/DisplayData',
                type: 'post',
                data: JSON.stringify({ "Carname": inputVal }),
                contentType: 'application/json',
                async: false,
                success: function (data) {
                    var OUTPUT = document.getElementById("OUTPUT");
                    OUTPUT.innerHTML = data.d;
                }
            })
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Enter some text here:</h1>
            <input type="text" runat="server" id="Hello"  onkeyup="runAjax()"/>
           <p runat="server" id="OUTPUT"></p>
        </div>
    </form>
</body>
</html>
