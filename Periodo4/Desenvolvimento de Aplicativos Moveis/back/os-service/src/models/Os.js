const { DataTypes } = require('sequelize');
const sequelize = require('../bd/database');

const Os = sequelize.define('Os', {
  descricao: {
    type: DataTypes.STRING,
    allowNull: false,
  },
  tipoOs: {
    type: DataTypes.STRING,
    allowNull: false,
  },
  tipoServico: {
    type: DataTypes.STRING,
    allowNull: false,
  },
  detalhes: {
    type: DataTypes.TEXT,
    allowNull: true,
  },
  status: {
    type: DataTypes.STRING,
    allowNull: false,
  },
  cliente: {
    type: DataTypes.STRING,
    allowNull: false,
  },
  dataAbertura: {
    type: DataTypes.DATE,
    allowNull: false,
  },
  dataEncerramento: {
    type: DataTypes.DATE,
    allowNull: true,
  },
  atendente: {
    type: DataTypes.STRING,
    allowNull: false,
  },
});

module.exports = Os;
