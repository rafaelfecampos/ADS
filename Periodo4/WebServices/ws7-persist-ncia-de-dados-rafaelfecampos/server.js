const jsonwebtoken = require("jsonwebtoken");
const { user, PRIVATE_KEY, tokenValidated } = require("./auth.js");

const express = require('express');
const cors = require('cors');

const app = express();


var corsOptions = {
    origin: "http://localhost:3001"
};

app.use(cors(corsOptions));

app.use(express.json());

app.use(express.urlencoded({extended: true}));

const db = require("./app/models");
db.sequelize.sync().then(() => {
    console.log("Banco de dados sincronizados");
})

app.get("/", (req, res) => {
    res.json({
        message: "Bem vindo a aplicação!"
    })
});

app.get("/login", (req,res)=>{
    const [, hash] = req.headers.authorization?.split(" ") || [" "," "];
    const [email,password] = Buffer.from(hash,"base64").toString().split(":");

    try{
        const correctPassword = email === "zezinho@example.com" &&
        password === "123456";

        if(!correctPassword){            
            return res.status(401).send("Senha ou e-mail inválido!");
        }

        const token = jsonwebtoken.sign(
            {user: JSON.stringify(user) },
            PRIVATE_KEY,
            {expiresIn: "60m"}
        );

        return res.status(200).json({data: {user,token}});

    }catch (error){
        console.log(error);
        res.send(error);
    }
});

// app.use("*", tokenValidated)

require("./app/routes/produto.routes.js")(app);
require("./app/routes/fabricante.routes.js")(app);

const PORT = process.env.PORT || 8080;
app.listen( PORT, () =>{
    console.log(`Server is running on ${PORT}.`);
})



