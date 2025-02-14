const dbConfig = require("../config/db.config.js");
const Sequelize = require("sequelize");

const sequelize = new Sequelize(dbConfig.DB, dbConfig.USER, dbConfig.PASSWORD, {
    host: dbConfig.HOST,
    dialect: dbConfig.dialect,
    pool: {
        max: dbConfig.pool.max,
        min: dbConfig.pool.min,
        acquire: dbConfig.pool.acquire,
        idle: dbConfig.pool.idle
    }
});

const db = {};

db.Sequelize = Sequelize;
db.sequelize = sequelize;

db.fabricantes = require("./fabricante.model.js")(sequelize, Sequelize);
db.produtos = require("./produtos.model.js")(sequelize, Sequelize);

db.produtos.belongsTo(db.fabricantes, { foreignKey: 'fabricanteId', as: 'fabricante' });

module.exports = db;
