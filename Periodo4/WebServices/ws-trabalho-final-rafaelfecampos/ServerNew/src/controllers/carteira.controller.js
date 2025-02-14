const db = require("../models");
const Carteira = db.Carteira;

exports.findCarteira = async (req, res) => {
    const userId = req.params.userId;

    if (!userId) {
        console.log("Nenhum userId fornecido na URL.");
        return res.status(400).send({
            message: "Sem usuário cadastrado"
        });
    }

    try {
        let carteira = await Carteira.findOne({ where: { userId } });

        if (!carteira) {
            console.log("Saldo não encontrado para o userId:", userId);
            return res.status(404).send({
                message: "Não foi possível encontrar a carteira"
            });
        }

        console.log("Saldo encontrado:", carteira);
        return res.status(200).json(carteira); 
    } catch (error) {
        console.error("Erro ao buscar carteira:", error);
        return res.status(500).send({
            message: "Erro ao buscar a carteira"
        });
    }
};

exports.update = async (req, res) => {
    const userId = req.params.userId;

    if (!userId) {
        console.log("Nenhum userId fornecido na URL.");
        return res.status(400).send({
            message: "Sem usuário cadastrado"
        });
    }

    try {
        const [updatedRows] = await Carteira.update(req.body, { where: { userId }, returning: true });

        if (updatedRows === 0) {
            console.log("Carteira não encontrada ou não foi atualizada para o userId:", userId);
            return res.status(404).send({
                message: "Não foi possível encontrar ou atualizar a carteira"
            });
        }

        let carteiraAtualizada = await Carteira.findOne({ where: { userId } });

        console.log("Carteira atualizada:", carteiraAtualizada);
        return res.status(200).json(carteiraAtualizada);  
    } catch (error) {
        console.error("Erro ao atualizar a carteira:", error);
        return res.status(500).send({
            message: "Erro ao atualizar a carteira"
        });
    }
};


// exports.deposito = async (req, res) =>{
//     const userId = req.params.id;
//     const valorDeposito = req.body.deposito;

//     if (!userId) {
//         console.log("Nenhum userId fornecido na URL.");
//         return res.status(400).send({
//             message: "Sem usuário cadastrado"
//         });
//     }

//     if(!valorDeposito || valorDeposito == ""){
//         console.log("Nenhum valor para deposito fornecido!");
//         return res.status(400).send({
//             message: "Sem valor para depósito"
//         });
//     }

//     try {
//         let carteira = await Carteira.findOne({ where: { userId } });
        

//         if (!carteira) {
//             console.log("Saldo não encontrado para o userId:", userId);
//             return res.status(404).send({
//                 message: "Não foi possível encontrar o carteira"
//             });
//         }

//         console.log("Saldo encontrado:", carteira);

//         carteira.saldo += valorDeposito;
        
//         Carteira.update()
        
//     } catch (error) {
//         console.error("Erro ao buscar saldo:", error);
//         return res.status(500).send({
//             message: "Erro ao buscar o saldo"
//         });
//     }
