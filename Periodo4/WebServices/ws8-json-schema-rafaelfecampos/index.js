import Ajv from "ajv";
import fjs from "fluent-json-schema";

const schamaProduto = fjs.object()
  .prop("nome", fjs.string().required())
  .prop("preco", fjs.number().required())
  .prop("descricao", fjs.string().minLength(15))
  .prop("quantidade", fjs.integer().minimum(0).default(0))
  .valueOf();

const produtoSchemaJSON = {
  type: "object",
  properties: {
    nome: { type: "string" },
    preco: { type: "number" },
    descricao: { type: "string", minLength: 10 },
    quantidade: { type: "integer", minimum: 0, default: 0 },
  },
  required: ["nome", "preco","descricao","quantidade"],
};


const produtoData = {
  nome: "Mesa",
  preco:1500,
  descricao: "Mesa de madeira maciça",
  quantidade: 2,
};


const ajv = new Ajv();
const isDataValidated = ajv.validate(produtoSchema, produtoData);

if (isDataValidated) {
  console.log("Dados foram validados");
} else {
  console.log("Erro ao validar:", ajv.errors);
}