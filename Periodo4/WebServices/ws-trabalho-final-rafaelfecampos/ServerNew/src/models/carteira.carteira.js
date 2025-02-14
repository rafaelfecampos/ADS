module.exports = (sequelize, Sequelize) =>{
    const Carteira = sequelize.define("Carteira",{
        saldo:{
            type: Sequelize.FLOAT,
            allowNull: false
        },
        userId:{
            type: Sequelize.INTEGER,
            allowNull: false,
            references: {
                model: "Users",
                key: "id"
            }
        }
    
    });

    Carteira.associate = (models) =>{
        Carteira.belongsTo(models.User, {
            foreignKey: "userId",
            as: 'user'
        })
    }

    return Carteira
};
