const { where } = require("sequelize");
const db = require("../models");
const Fabricante = db.fabricantes; 
const Op = db.Sequelize.Op;

exports.create = (req, res) => {
    if(!req.body.nome){
        res.status(400).send({
            message: "Nome não pode estar vazio"
        });
        return;
    }

    const fabricante = {
        nome: req.body.nome,
        endereco: req.body.endereco
    };

    Fabricante.create(fabricante)
        .then(data =>{
            res.send(data);
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao criar fabricante"
            });
        });
};

exports.findAll = (req, res) => {
    const  nome = req.query.nome;
    var condition = nome ? { nome: { [Op.like]: `%${nome}%`}}: null;

    Fabricante.findAll({ where: condition})
        .then(data =>{
            res.send(data);
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao buscar fabricantes"
            });
        });
};

exports.findOne = (req, res) => {
    const id = req.params.id;

    Fabricante.findByPk(id)
        .then(data =>{
            if(data){
                res.send(data);
            }else{
                res.status(404).send({
                    message: `Não foi possível encontrar o fabricante de id = ${id}.`
                })
            }
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao buscar fabricante"
            });
        });
};


exports.update = (req, res) => {
    const id = req.params.id;

    Fabricante.update(req.body, {
        where: { id: id}
    })
        .then(num =>{
            if(num == 1){
                res.send({
                    message: `Fabricante alterado com sucesso`
                })
            }else{
                res.status(404).send({
                    message: `Não foi possível encontrar o fabricante de id = ${id}.`
                })
            }
        })
        .catch(err =>{
            res.status(500).send({
                message:
                    err.message || "Ocorreu um erro ao alterar fabricante"
            });
        });
};


exports.delete = (req, res) => {
    const id = req.params.id;
    
    Fabricante.destroy({
        where: { id: id}
    })
    .then(num =>{
        if(num == 1){
            res.send({
                message: `Fabricante deletado com sucesso`
            })
        }else{
            res.status(404).send({
                message: `Não foi possível encontrar o fabricante de id = ${id}.`
            })
        }
    })
    .catch(err =>{
        res.status(500).send({
            message:
                err.message || "Ocorreu um erro ao deletar fabricante"
        });
    });
};


exports.deleteAll =  (req, res) => {
    Fabricante.destroy({
        where: {}
    })
    .then(nums =>{
        res.send({
            message: `Fabricantes deletados com sucesso`
        })
    })
    .catch(err =>{
        res.status(500).send({
            message:
                err.message || "Ocorreu um erro ao deletar fabricantes"
        });
    });
};
