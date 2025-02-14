module.exports = app => {
    const produtos = require("../controller/produto.controller.js");

    const { tokenValidated } = require("../../auth.js");

    var router = require("express").Router();

    router.get("/", produtos.findAll);

    app.use("*", tokenValidated);
    
    router.post("/", produtos.create);

    router.get("/:id", produtos.findOne);

    router.put("/:id", produtos.update);

    router.delete("/:id", produtos.delete);

    router.delete("/", produtos.deleteAll);

    app.use('/api/produtos', router);
    
    
}