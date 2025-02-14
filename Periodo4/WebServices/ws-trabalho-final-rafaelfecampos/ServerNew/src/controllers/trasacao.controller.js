const db = require("../models");
const Transacao = db.Transacao;
const Op = db.Sequelize.Op;

exports.create = async (req, res) => {
    try {
        console.log(req.body);
        
        const { carteiraId, acao, quantidade, valorTotal } = req.body;

        if (!carteiraId) {
            return res.status(400).send({ message: "Carteira não informada" });
        }

        if (!acao) {
            return res.status(400).send({ message: "Ação não informada" });
        }

        if (!quantidade) {
            return res.status(400).send({ message: "Quantidade não informada" });
        }

        if (!valorTotal) {
            return res.status(400).send({ message: "Valor total não informado" });
        }

        console.log("Carteira: " + carteiraId);
        console.log(acao);

        const transacao = {
            codigoAcao: acao,
            quantidade: quantidade,
            valorTotal: valorTotal,
            carteiraId: carteiraId,
        };

        const transacaoCriada = await Transacao.create(transacao);
        res.status(201).send(transacaoCriada);
    } catch (error) {
        res.status(500).send({ message: "Erro ao criar transação" });
    }
};

exports.findAll = async (req, res) => {
    const { carteiraId } = req.params;

    const condition = carteiraId ? { carteiraId: { [Op.like]: `${carteiraId}` } } : null;

    try {
        const data = await Transacao.findAll({ where: condition });
        res.status(200).send(data);
    } catch (error) {
        res.status(500).send({
            message: error.message || "Não foi possível buscar informações"
        });
    }
};
