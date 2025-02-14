module.exports = (sequelize, Sequelize) => {
    const Fabricante = sequelize.define("fabricante", {
        nome: {
            type: Sequelize.STRING,
            allowNull: false
        },
        endereco: {
            type: Sequelize.STRING,
            allowNull: false
        }
    });

    return Fabricante;
};
