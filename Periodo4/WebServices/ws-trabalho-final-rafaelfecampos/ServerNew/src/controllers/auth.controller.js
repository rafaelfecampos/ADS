const db = require("../models/index.js");
const User = db.User;
const bcrypt = require('bcrypt');
const jsonwebtoken = require("jsonwebtoken");
const { PRIVATE_KEY } = require("../auth/auth.js");


exports.login = async(req, res) =>{
    const {login, senha} = req.body;

    try{
        let user = await User.findOne({ where: {login}});

        if(!user)
            return res.status(404).json({message: `Usuário ${login} não encontrado`});

        const isPasswrdValid = await bcrypt.compare(senha, user.senha);
        if(!isPasswrdValid)
            return res.status(401).json({ message: "Senha incorreta"});

        const token = jsonwebtoken.sign(
            {
                id: user.id,
                login: user.login,
                cpf: user.cpf
            },
            PRIVATE_KEY,
            {expiresIn: "60m"}
        );

        return res.status(200).json({ data: {user, token}});
    }catch(error){
        res.status(500).json({
            error: error.message
        });
    }
};