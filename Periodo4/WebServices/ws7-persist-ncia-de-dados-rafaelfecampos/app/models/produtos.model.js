module.exports = (sequelize, Sequelize) => {
    const Produto = sequelize.define("produto", {
        nomeProduto: {
            type: Sequelize.STRING,
            allowNull: false
        },
        precoUnitario: {
            type: Sequelize.FLOAT,
            allowNull: false
        },
        quantidade: {
            type: Sequelize.INTEGER,
            allowNull: false
        },
        categoria: {
            type: Sequelize.STRING,
            allowNull: false
        }
    });

    return Produto;
};
