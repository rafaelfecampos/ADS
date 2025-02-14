// async function getData(){
//     const movie_datasetResponse = await fetch("./movie_dataset.json");
//     const movie_dataset = await movie_datasetResponse.json();
    
//     const cleaned = movie_dataset.map(movie => ({
//         va: movie.vote_average,
//         vc: movie.vote_count
//     })).filter(movie => (movie.va != null && movie.vc != null));

//     return cleaned;
// }//obtem os dados de media dos votos e numeto de votos dos filmes avaliados no site do IMDb

// async function run() {
//     // Carrega os dados de entrada a serem treinados
//     const data = await getData();
//     const values = data.map(d => ({
//         x: d.vc,
//         y: d.va
//     }));
    
//     tfvis.render.scatterplot(
//         { name: 'Número de votos x media dos votos' },
//         { values },
//         {
//             xLabel: 'Número de votos',
//             yLabel: 'media dos votos',
//             height: 300
//         }
//     );
    
//     const tensorData = convertToTensor(data);
//     const { inputs, labels } = tensorData;

//     const model = createModel(); // Cria um modelo
//     tfvis.show.modelSummary({ name: "Modelo" }, model);

//     await trainModel(model, inputs, labels);
//     console.log("Treinamento completo");

//     testModel(model, data, tensorData);
// }

// function createModel() {
//     const model = tf.sequential(); // Cria um modelo sequencial

//     model.add(tf.layers.dense({ inputShape: [1], units: 1, useBias: true })); // Adiciona uma única camada de entrada

//     model.add(tf.layers.dense({ units: 1, useBias: true })); // Adiciona uma camada de saída

//     return model;
// }

// document.addEventListener("DOMContentLoaded", run);

// function convertToTensor(data) {
//     return tf.tidy(() => {
//         // Embaralha os dados
//         tf.util.shuffle(data);

//         // Converte os dados em tensor
//         const inputs = data.map((d) => d.vc);
//         const labels = data.map((d) => d.va);

//         const inputTensor = tf.tensor2d(inputs, [inputs.length, 1]);
//         const labelTensor = tf.tensor2d(labels, [labels.length, 1]);

//         // Retorna os limites máximo e mínimo
//         const inputMax = inputTensor.max();
//         const inputMin = inputTensor.min();
//         const labelMax = labelTensor.max();
//         const labelMin = labelTensor.min();

//         // Realiza a normalização
//         const normalizedInputs = inputTensor.sub(inputMin).div(inputMax.sub(inputMin));
//         const normalizedLabels = labelTensor.sub(labelMin).div(labelMax.sub(labelMin));

//         return {
//             inputs: normalizedInputs,
//             labels: normalizedLabels,
//             inputMax: inputMax,
//             inputMin: inputMin,
//             labelMax: labelMax,
//             labelMin: labelMin
//         };
//     });
// }

// // Correção: nome da chave 'metrics' ao compilar o modelo
// async function trainModel(model, inputs, labels) {
//     // Compila o modelo especificando o otimizador, a função de perda e as métricas
//     model.compile({
//         optimizer: tf.train.adam(),
//         loss: tf.losses.meanSquaredError,
//         metrics: ['mse']
//     });

//     const batchSize = 32; // Tamanho do lote para cada iteração de treinamento
//     const epochs = 50; // Número de épocas para treinar

//     // Treina o modelo usando os inputs e labels fornecidos
//     return await model.fit(inputs, labels, {
//         batchSize,
//         epochs,
//         shuffle: true, // Embaralha os dados antes de cada época
//         callbacks: tfvis.show.fitCallbacks(
//             { name: "Performance do treinamento" },
//             ['loss', 'mse'], // Monitora a perda e o erro quadrático médio (mse)
//             {
//                 height: 200,
//                 callbacks: ["onEpochEnd"]
//             }
//         ),
//     });
// }

// function testModel(model, inputData, normalizationData) {
//     const { inputMax, inputMin, labelMax, labelMin } = normalizationData;

//     const [xs, preds] = tf.tidy(() => {
//         // Gera 100 pontos de dados normalizados de 0 a 1
//         const xs = tf.linspace(0, 1, 100);
//         // Faz previsões usando o modelo
//         const preds = model.predict(xs.reshape([100, 1]));

//         // Desnormaliza os dados de entrada
//         const unNormXs = xs.mul(inputMax.sub(inputMin)).add(inputMin);
//         // Desnormaliza as previsões
//         const unNormPreds = preds.mul(labelMax.sub(labelMin)).add(labelMin);

//         // Converte os tensores para arrays
//         return [unNormXs.dataSync(), unNormPreds.dataSync()];
//     });

//     // Prepara os dados para visualização
//     const predictedPoints = Array.from(xs).map((val, i) => {
//         return { x: val, y: preds[i] }; // Correção: usa xs e preds corretamente
//     });

//     // Os dados originais devem corresponder às propriedades corretas
//     const originalPoints = inputData.map(d => ({
//         x: d.vc,
//         y: d.va,
//     }));

//     // Renderiza o gráfico de dispersão usando tfvis
//     tfvis.render.scatterplot(
//         { name: "Previsões do modelo x dados originais" },
//         {
//             values: [originalPoints, predictedPoints],
//             series: ["original", "predicted"],
//         },
//         {
//             xLabel: "Número de votos",
//             yLabel: "media dos votos",
//             height: 300
//         }
//     );
// }
async function getData() {
    const movie_datasetResponse = await fetch("./movie_dataset.json");
    const movie_dataset = await movie_datasetResponse.json();
    
    const cleaned = movie_dataset.map(movie => ({
        va: movie.vote_average,
        vc: movie.vote_count
    })).filter(movie => (movie.va != null && movie.vc != null));

    return cleaned;
}

async function run() {
    // Carrega os dados de entrada a serem treinados
    const data = await getData();
    const values = data.map(d => ({
        x: d.vc,
        y: d.va
    }));
    
    tfvis.render.scatterplot(
        { name: 'Número de votos x Média de votos' },
        { values },
        {
            xLabel: 'Número de votos',
            yLabel: 'Média de votos',
            height: 300
        }
    );
    
    const tensorData = convertToTensor(data);
    const { inputs, labels } = tensorData;

    const model = createModel(); // Cria um modelo
    tfvis.show.modelSummary({ name: "Modelo" }, model);

    await trainModel(model, inputs, labels);
    console.log("Treinamento completo");

    testModel(model, data, tensorData);
}

function createModel() {
    const model = tf.sequential(); // Cria um modelo sequencial

    // Adiciona uma camada densa com 10 unidades e função de ativação ReLU
    model.add(tf.layers.dense({ inputShape: [1], units: 10, activation: 'relu', useBias: true }));
    // Adiciona uma segunda camada densa com 10 unidades e função de ativação ReLU
    model.add(tf.layers.dense({ units: 10, activation: 'relu', useBias: true }));
    // Adiciona a camada de saída com uma unidade (para previsão de um valor contínuo)
    model.add(tf.layers.dense({ units: 1, useBias: true }));

    return model;
}

document.addEventListener("DOMContentLoaded", run);

function convertToTensor(data) {
    return tf.tidy(() => {
        // Embaralha os dados
        tf.util.shuffle(data);

        // Converte os dados em tensor
        const inputs = data.map((d) => d.vc);
        const labels = data.map((d) => d.va);

        const inputTensor = tf.tensor2d(inputs, [inputs.length, 1]);
        const labelTensor = tf.tensor2d(labels, [labels.length, 1]);

        // Retorna os limites máximo e mínimo
        const inputMax = inputTensor.max();
        const inputMin = inputTensor.min();
        const labelMax = labelTensor.max();
        const labelMin = labelTensor.min();

        // Realiza a normalização
        const normalizedInputs = inputTensor.sub(inputMin).div(inputMax.sub(inputMin));
        const normalizedLabels = labelTensor.sub(labelMin).div(labelMax.sub(labelMin));

        return {
            inputs: normalizedInputs,
            labels: normalizedLabels,
            inputMax: inputMax,
            inputMin: inputMin,
            labelMax: labelMax,
            labelMin: labelMin
        };
    });
}

// Treinamento do modelo
async function trainModel(model, inputs, labels) {
    // Compila o modelo especificando o otimizador, a função de perda e as métricas
    model.compile({
        optimizer: tf.train.adam(),
        loss: tf.losses.meanSquaredError,
        metrics: ['mse']
    });

    const batchSize = 32; // Tamanho do lote para cada iteração de treinamento
    const epochs = 50; // Número de épocas para treinar

    // Treina o modelo usando os inputs e labels fornecidos
    return await model.fit(inputs, labels, {
        batchSize,
        epochs,
        shuffle: true, // Embaralha os dados antes de cada época
        callbacks: tfvis.show.fitCallbacks(
            { name: "Performance do treinamento" },
            ['loss', 'mse'], // Monitora a perda e o erro quadrático médio (mse)
            {
                height: 200,
                callbacks: ["onEpochEnd"]
            }
        ),
    });
}

function testModel(model, inputData, normalizationData) {
    const { inputMax, inputMin, labelMax, labelMin } = normalizationData;

    const [xs, preds] = tf.tidy(() => {
        // Gera 100 pontos de dados normalizados de 0 a 1
        const xs = tf.linspace(0, 1, 100);
        // Faz previsões usando o modelo
        const preds = model.predict(xs.reshape([100, 1]));

        // Desnormaliza os dados de entrada
        const unNormXs = xs.mul(inputMax.sub(inputMin)).add(inputMin);
        // Desnormaliza as previsões
        const unNormPreds = preds.mul(labelMax.sub(labelMin)).add(labelMin);

        // Converte os tensores para arrays
        return [unNormXs.dataSync(), unNormPreds.dataSync()];
    });

    // Prepara os dados para visualização
    const predictedPoints = Array.from(xs).map((val, i) => {
        return { x: val, y: preds[i] }; // Correção: usa xs e preds corretamente
    });

    // Os dados originais devem corresponder às propriedades corretas
    const originalPoints = inputData.map(d => ({
        x: d.vc,
        y: d.va,
    }));

    // Renderiza o gráfico de dispersão usando tfvis
    tfvis.render.scatterplot(
        { name: "Previsões do modelo x dados originais" },
        {
            values: [originalPoints, predictedPoints],
            series: ["original", "predicted"],
        },
        {
            xLabel: "Número de votos",
            yLabel: "Média de votos",
            height: 300
        }
    );
}
