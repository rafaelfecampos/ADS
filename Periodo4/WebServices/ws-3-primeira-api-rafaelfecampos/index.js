const express = require("express")
const app = express();

var DB = {
    produtos:[
        {
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

app.get("/produtos", (req, res) => {
    res.statusCode = 200;
    res.json(DB.produtos)
})