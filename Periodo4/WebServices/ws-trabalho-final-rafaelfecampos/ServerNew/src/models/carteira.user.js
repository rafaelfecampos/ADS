const { DataTypes } = require("sequelize");

module.exports = (sequelize, Sequelize) =>{
    const User = sequelize.define('User', {
        email:{
            type: Sequelize.STRING,
            allowNull: false,
            unique: true,
        },
        login:{
            type: Sequelize.STRING,
            allowNull: false,
            unique: true,
        },
        senha:{
            type: Sequelize.STRING,
            allowNull: false
        },
        nome:{
            type: Sequelize.STRING,
            allowNull: false
        },
        sobrenome:{
            type: Sequelize.STRING,
            allowNull: false
        },
        idade:{
            type: Sequelize.INTEGER,
            allowNull: false
        },
        cpf:{
            type: Sequelize.STRING,
            allowNull: false,
            unique: true
        },
        githubId: {
            type: Sequelize.STRING,
            allowNull: false,
            unique: true
        }
    }, {
        tableName: 'Users'
    });

    return User;
}