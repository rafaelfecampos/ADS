module.exports = (sequelize, Sequelize) =>{
    const Transacao = sequelize.define("Transacao", {
        codigoAcao:{
            type: Sequelize.STRING,
            allowNull: false,
        },
        quantidade:{
            type: Sequelize.INTEGER,
            allowNull: false
        },
        valorTotal:{
            type: Sequelize.FLOAT,
            allowNull: false
        },
        carteiraId:{
            type: Sequelize.INTEGER,
            allowNull: false,
            references: {
                model: "Carteiras",
                key: "id"
            }
        }
    });

    Transacao.associate = (models) =>{
        Transacao.belongsTo(models.Carteira,{
            foreingKey: "carteiraId",
            as: "carteira"
        })
    }

    return Transacao;
}