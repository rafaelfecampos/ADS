const axios = require("axios");
const qs = require("query-string");
const db = require("../models");
const { PASSWORD } = require("../config/db.config");
const User = db.User;

const trocarTokenPorAccessToken = async (code) => {
  const GITHUB_ACCESS_TOKEN_URL = "https://github.com/login/oauth/access_token";
  const { REDIRECT_URL, CLIENT_ID, CLIENT_SECRET } = process.env;
  console.log("redirect: " + REDIRECT_URL);
  
  if (!REDIRECT_URL || !CLIENT_ID || !CLIENT_SECRET) {
    throw new Error("REDIRECT_URL, CLIENT_ID e CLIENT_SECRET precisam estar definidos nas variáveis de ambiente.");
  }

  const params = qs.stringify({
    code,
    grant_type: "authorization_code",
    redirect_uri: REDIRECT_URL,
    client_id: CLIENT_ID,
    client_secret: CLIENT_SECRET,
  });

  try {
    const { data } = await axios.post(GITHUB_ACCESS_TOKEN_URL, params, {
      headers: {
        "Content-Type": "application/x-www-form-urlencoded",
      },
    });

    const parsedData = qs.parse(data);
    if (!parsedData.access_token) {
      throw new Error("Access token não retornado pela API do GitHub.");
    }

    return parsedData.access_token;
  } catch (error) {
    if (error.response) {
      console.error("Erro na resposta da API:", {
        status: error.response.status,
        data: error.response.data,
      });
    } else if (error.request) {
      console.error("Erro na requisição:", error.request);
    } else {
      console.error("Erro inesperado:", error.message);
    }
    throw error;
  }
};

async function fetchUser(token) {

  const response = await axios.get("https://api.github.com/user", {
    headers: {
      Authorization: `Bearer ${token}`,
    },
  });


  const { id, name, login, email } = response.data;
  try {

    const user = await User.findOrCreate({
      where: { githubId: id },
      defaults: {
        githubId: id,
        nome: name,
        sobrenome: "n/a",
        senha:"n/a",
        login,
        email: email || "n/a",
        idade: 0,
        cpf: "n/a"
      }
    });

    return user;

  } catch (error) {
    console.error("Unable to create user:", error);
  }

}

module.exports = { trocarTokenPorAccessToken, fetchUser };
