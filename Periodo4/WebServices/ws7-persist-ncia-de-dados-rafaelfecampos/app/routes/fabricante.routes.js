module.exports = app => {
    const fabricante = require("../controller/fabricante.controller");
    
    const { tokenValidated } = require("../../auth.js");

    var router = require("express").Router();
    
    router.get("/", fabricante.findAll);
    
    app.use("*", tokenValidated);

    router.post("/", fabricante.create);

    router.get("/:id", fabricante.findOne);

    router.put("/:id", fabricante.update);

    router.delete("/:id", fabricante.delete);

    router.delete("/", fabricante.deleteAll);

    app.use('/api/fabricantes', router);

}