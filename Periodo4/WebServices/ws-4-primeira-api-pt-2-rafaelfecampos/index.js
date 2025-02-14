const express = require("express")
const app = express();
app.use(express.json());

var DB = {
    produtos:[
        {
            id:1,
            fabricante:{
                nome: "Jose Factory",
                endereco:"Juiz de Fora - MG"
            },
            nomeProduto:"Cadeira",
            precoUnitario:125.99,
            quantidade:6,
            categoria:"A"            
        },
        {
            id:2,
            fabricante:{
                nome: "Jose Factory",
                endereco:"Juiz de Fora - MG"
            },
            nomeProduto:"Mesa",
            precoUnitario:350.99,
            quantidade:1,
            categoria:"B"            
        },
        {
            id:100,
            fabricante:{
                nome: "Carlinhos Tapecaria",
                endereco:"Xique-xique - BA"
            },
            nomeProduto:"Tapete persa",
            precoUnitario:1598000.99,
            quantidade:1,
            categoria:"ZZ"            
        }
    ]
}

app.listen(3001, () => {
    console.log("Application is running");
})
app.get("/", (req, res) => {
    res.statusCode = 200;
    res.json(DB.produtos)
})
app.get("/produtos", (req, res) => {
    res.statusCode = 200;
    res.json(DB.produtos)
})

app.post("/produto", (req, res) => {
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

app.put("/produto/:id",(req, res) => {

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