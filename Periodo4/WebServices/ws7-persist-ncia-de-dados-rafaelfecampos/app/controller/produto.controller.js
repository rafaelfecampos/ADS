const db = require("../models");
const Produto = db.produtos; 
const Op = db.Sequelize.Op;

exports.create = (req, res) => {
    if(!req.body.nomeProduto){
        res.status(400).send({
            message: "Nome não pode estar vazio"
        });
        return;
    }

    const produto = {
        nomeProduto: req.body.nomeProduto,
        precoUnitario: req.body.precoUnitario,
        quantidade: req.body.quantidade,
        categoria: req.body.categoria,
        fabricanteId: req.body.fabricanteId
    };

    Produto.create(produto)
        .then(data =>{
            res.send(data);
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao criar produto"
            });
        });
};

exports.findAll = (req, res) => {
    const  nomeProduto = req.query.nomeProduto;
    var condition = nomeProduto ? { nomeProduto: { [Op.like]: `%${nomeProduto}%`}}: null;

    Produto.findAll({ where: condition})
        .then(data =>{
            res.send(data);
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao buscar produtos"
            });
        });
};

exports.findOne = (req, res) => {
    const id = req.params.id;

    Produto.findByPk(id)
        .then(data =>{
            if(data){
                res.send(data);
            }else{
                res.status(404).send({
                    message: `Não foi possível encontrar o produto de id = ${id}.`
                })
            }
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao buscar produto"
            });
        });
};

exports.update = (req, res) => {
    const id = req.params.id;

    Produto.update(req.body, {
        where: { id: id}
    })
        .then(num =>{
            if(num == 1){
                res.send({
                    message: `Produto alterado com sucesso`
                })
            }else{
                res.status(404).send({
                    message: `Não foi possível encontrar o produto de id = ${id}.`
                })
            }
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao alterar produto"
            });
        });
};

exports.delete = (req, res) => {
    const id = req.params.id;
    
    Produto.destroy({
        where: { id: id}
    })
    .then(num =>{
        if(num == 1){
            res.send({
                message: `Produto deletado com sucesso`
            })
        }else{
            res.status(404).send({
                message: `Não foi possível encontrar o produto de id = ${id}.`
            })
        }
    })
    .catch(err =>{
        res.status(500).send({
            message:
                err.message || "Ocorreu um erro ao deletar produto"
        });
    });
};

exports.deleteAll =  (req, res) => {
    Produto.destroy({
        where: {}
    })
    .then(nums =>{
        res.send({
            message: `Produtos deletados com sucesso`
        })
    })
    .catch(err =>{
        res.status(500).send({
            message:
                err.message || "Ocorreu um erro ao deletar produtos"
        });
    });
};

