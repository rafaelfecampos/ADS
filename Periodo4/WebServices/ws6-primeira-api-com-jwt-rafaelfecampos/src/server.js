import express from "express";
import jsonwebtoken from "jsonwebtoken";
import { user, PRIVATE_KEY, tokenValidated } from "./auth.js"

const api = express();
api.use(express.json());

var DB = {
    produtos:[
        {
            id: 1,
            fabricante:{
                nome: "Jose Factory",
                endereco: "Juiz de Fora - mg"
            },
            nomeProduto: "Cadeira",
            precoUnitario: 125.99,
            quantidade: 6,
            categoria: "A",
        },
        {
            id: 2,
            fabricante:{
                nome: "Jose Factory",
                endereco: "Juiz de Fora - mg"
            },
            nomeProduto: "Mesa",
            precoUnitario: 350.99,
            quantidade: 1,
            categoria: "B",
        },
        {
            id: 100,
            fabricante:{
                nome: "Carlinhos Tapecaria",
                endereco:"Xique-xique - BA"
            },
            nomeProduto:"Tapete persa",
            precoUnitario:1598000.99,
            quantidade:1,
            categoria:"ZZ",
        },
    ]
}

api.get("/produtos", (req, res) =>{
    res.statusCode = 200;
    var nomes = DB.produtos.map(x=>x.nomeProduto)

    if(nomes.length > 0){
        res.statusCode = 200;
        res.json(nomes);
    }else{
        res.sendStatus(404);
    }

})

api.get("/login", (req,res)=>{
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


api.use("*", tokenValidated);

api.get("/private", (req, res) => {
    const { user } = req.headers;
    const currentUser = JSON.parse(user);
    return res.status(200).json({
        message: "This is a private route",
        data: {
            userLogged: currentUser,
        },
    });
});

api.get("/produtos/:id", (req, res) =>{
    if(isNaN(req.params.id)){
        res.sendStatus(400)
    }else{
        var id = parseInt(req.params.id);

        var produto = DB.produtos.find(p => p.id == id);

        if( produto != undefined){
            res.statusCode = 200;
            res.json(produto);
        }else{
            res.sendStatus(404);
        }
    }
});

api.post("/produto", (req, res) => {
    var {
        id,
        fabricante:{
            nome,
            endereco
        },
        nomeProduto,
        precoUnitario,
        quantidade,
        categoria
    } = req.body;
    DB.produtos.push({
        id,
        fabricante:{
            nome,
            endereco
        },
        nomeProduto,
        precoUnitario,
        quantidade,
        categoria
    });
    res.sendStatus(200);
});


api.put("/produto/:id",(req, res) => {

    if(isNaN(req.params.id)){
        res.sendStatus(400);
    }else{

        var id = parseInt(req.params.id);

        var produto = DB.produtos.find(prod => prod.id == id)

        if(produto != undefined){

            var {
                fabricante:{
                    nome,
                    endereco
                },
                nomeProduto,
                precoUnitario,
                quantidade,
                categoria
            } = req.body;

            if (nome != undefined) {
                produto.fabricante.nome = nome;
            }
            if (endereco != undefined) {
                produto.fabricante.endereco = endereco;
            }
            if (nomeProduto != undefined) {
                produto.nomeProduto = nomeProduto;
            }
            if (precoUnitario != undefined) {
                produto.precoUnitario = precoUnitario;
            }
            if (quantidade != undefined) {
                produto.quantidade = quantidade;
            }
            if (categoria != undefined) {
                produto.categoria = categoria;
            }
            res.sendStatus(200);

        }else{
            res.sendStatus(404);
        }
    }

});


api.listen(3001, () =>{
    console.log(`Aplicação rodando na porta 3001`);
})