const jsonwebtoken = require("jsonwebtoken");
const dotenv = require("dotenv");
dotenv.config();

const PRIVATE_KEY = process.env.PRIVATE_KEY;

function tokenValidated(
    req,
    res,
    next
){
    const [, token] = req.headers.authorization?.split(' ') || [' ', ' '];
    if(!token)
         return res.status(401).send('Acesso negado. Nenhum token fornecido.');

    try{
        const payload = jsonwebtoken.verify(token, PRIVATE_KEY);
        const userIdFromToken = typeof payload !== 'string' && payload;       

        if(!userIdFromToken){
            return res.status(401).json({
                message: "Token inválido"
            });
        }
        req.headers['user'] = payload;//define user no cabeçalho
        console.log(req.headers['user']);
        

        return next();
    }catch( error ){
        console.log(error);
        return res.status(401).json({
            message: "Token inválido"
        });
    }
}

module.exports = { PRIVATE_KEY, tokenValidated}