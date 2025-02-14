const { tokenValidated } = require("../auth/auth");
const { route } = require("./auth.routes");

module.exports = api =>{
    const transacoes = require("../controllers/trasacao.controller");

    var router = require("express").Router();

    router.post("/comprar", tokenValidated, transacoes.create);

    router.post("/vender", tokenValidated, transacoes.create)

    router.get("/:codigoAcao", tokenValidated, transacoes.findAll);

    api.use("/transacao", router)
}