const db = require("../models");
const User = db.User;
const Carteira = db.Carteira;
const bcrypt = require('bcrypt');

exports.create = async (req, res) => {
    if (!req.body.email || !req.body.usuario || !req.body.senha 
        || !req.body.nome || !req.body.sobrenome || !req.body.idade || !req.body.cpf) {
            return res.status(400).send({
                message: "Campos vazios",
            });
    }

    try {
        const hashedPassword = await bcrypt.hash(req.body.senha, 10);

        const user = {
            email: req.body.email,
            usuario: req.body.usuario,
            senha: hashedPassword, 
            nome: req.body.nome,
            sobrenome: req.body.sobrenome,
            idade: req.body.idade,
            cpf: req.body.cpf
        };

        const usuarioCriado = await User.create(user);

        const carteira = {
            saldo: 0,
            userId: usuarioCriado.id
        };

        const carteiraCriada = await Carteira.create(carteira);

        res.status(201).send({ user: usuarioCriado, carteira: carteiraCriada });

    } catch (error) {
        res.status(500).send({
            message: error.message || "Algum erro ocorreu ao criar usuário ou carteira!",
        });
    }
};
