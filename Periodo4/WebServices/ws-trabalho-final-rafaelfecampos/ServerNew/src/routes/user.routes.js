module.exports = api =>{
    const users = require("../controllers/user.controller.js");

    var router = require("express").Router();

    router.post("/cadastro", users.create);

    // router.get("/:id", users.findOne)

    api.use("/users", router);
}