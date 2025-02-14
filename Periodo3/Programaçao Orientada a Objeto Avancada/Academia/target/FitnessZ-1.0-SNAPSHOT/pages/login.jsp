<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>FitnessZ</title>
    <link rel="stylesheet" href="style/style.css">
</head>
<body>
    <h1>LOGIN</h1>
    <form action="/master" method="post">
        <input type="hidden" name="ac" value="verify">
        <label for="cpLogin">Login: </label>
        <input type="text" name="cpLogin" id="cpLogin"><br>
        <label for="cpSenha">Senha: </label>
        <input type="password" name="cpSenha" id="cpSenha">
        <br>
        <button>Ok</button><br>

        <%
            String msg = (String) request.getAttribute("msg");
        %>
        <%=(msg == null)? "":msg%>
    </form>

</body>