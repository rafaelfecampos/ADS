<%@ page import="br.edu.vianna.gym.model.User" %>
<%
    User u = (User) request.getSession().getAttribute("user");
%>
<h1>Bem vindo <%= u.getLogin()%></h1>

