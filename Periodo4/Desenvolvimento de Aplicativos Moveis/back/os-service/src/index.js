
const express = require('express');
const sequelize = require('./bd/database');
const Os = require('./models/Os');

const app = express();
app.use(express.json());

app.post('/os', async (req, res) => {
  try {
    const os = await Os.create(req.body);
    res.status(201).json(os);
  } catch (err) {
    res.status(400).json({ error: err.message });
  }
});

app.get('/os', async (req, res) => {
  try {
    const os = await Os.findAll();
    res.json(os);
  } catch (err) {
    res.status(500).json({ error: err.message });
  }
});

app.get('/os/:id', async (req, res) => {
  try {
    const os = await Os.findByPk(req.params.id);
    if (os) {
      res.json(os);
    } else {
      res.status(404).json({ error: 'OS não encontrada' });
    }
  } catch (err) {
    res.status(500).json({ error: err.message });
  }
});

app.put('/os/:id', async (req, res) => {
  try {
    const os = await Os.findByPk(req.params.id);
    if (os) {
      await os.update(req.body);
      res.json(os);
    } else {
      res.status(404).json({ error: 'OS não encontrada' });
    }
  } catch (err) {
    res.status(400).json({ error: err.message });
  }
});

app.delete('/os/:id', async (req, res) => {
  try {
    const os = await Os.findByPk(req.params.id);
    if (os) {
      await os.destroy();
      res.status(204).end();
    } else {
      res.status(404).json({ error: 'OS não encontrada' });
    }
  } catch (err) {
    res.status(500).json({ error: err.message });
  }
});


sequelize.sync()
  .then(() => {
    app.listen(3000, () => {
      console.log('Servidor rodando na porta 3000');
    });
  })
  .catch((err) => console.log(err));
