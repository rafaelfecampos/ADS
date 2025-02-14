const express = require("express");
const cors = require("cors");
const db = require("./models/index.js");
const authRoute = require("./routes/auth.routes.js");
const { trocarTokenPorAccessToken, fetchUser } = require("./oauth/oauth.js");

const api = express();

// Configurações de CORS
const corsOptions = {
  origin: "http://localhost:1234",
};
api.use(cors(corsOptions));

// Configurações para parsing de JSON e form-urlencoded
api.use(express.json());
api.use(express.urlencoded({ extended: true }));

// Sincronizar banco de dados
(async () => {
  try {
    await db.sequelize.authenticate();
    console.log("Conexão com o banco de dados estabelecida com sucesso.");

    // `force: true` apenas em desenvolvimento; `false` mantém os dados existentes.
    await db.sequelize.sync({ force: false });
    console.log("Sincronização concluída.");
  } catch (error) {
    console.error("Erro ao conectar ao banco de dados:", error);
    process.exit(1); // Finaliza o processo em caso de erro crítico
  }
})();

// Rota pública
api.get("/", (_, res) => {
  res.status(200).json({
    message: "Rota pública",
  });
});

// Rota para login OAuth
api.post("/oauth/login", async (req, res) => {
  const { code } = req.body;

  if (!code) {
    return res.status(400).json({ error: "O campo 'code' é obrigatório." });
  }

  try {
    const token = await trocarTokenPorAccessToken(code);
    console.log("Token recebido:", token);

    const user = await fetchUser(token);
    res.status(200).json(user);
  } catch (erro) {
    console.error("Erro ao processar login OAuth:", erro.response?.data || erro.message || erro);
    res.sendStatus(500);
  }
});

// Rotas adicionais
api.use("/auth", authRoute);
require("./routes/user.routes.js")(api);
require("./routes/carteira.routes.js")(api);
require("./routes/transacao.routes.js")(api);

// Inicialização do servidor
const PORT = 3000;
const HOST = "192.168.2.229";

api.listen(PORT, HOST, () => {
  console.log(`Aplicação rodando na porta ${PORT} no host ${HOST}`);
});
