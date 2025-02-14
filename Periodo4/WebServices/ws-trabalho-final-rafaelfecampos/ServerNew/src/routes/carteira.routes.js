const { tokenValidated } = require("../auth/auth.js");

module.exports = api =>{
    const carteiras = require("../controllers/carteira.controller.js");

    var router = require("express").Router();

    router.get("/:userId", tokenValidated, carteiras.findCarteira);
    router.post("/:userId", tokenValidated, carteiras.update);

    api.use("/carteira", router);
}