import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import Titulo from './src/components/base/Titulo/Titulo';
import Campo from './src/components/base/Campo/Campo';
import { useState } from 'react';
import Pessoa from './src/model/Pessoa';


export default function App() {
  
  const [nome, setNome] = useState('');
  const [peso, setPeso] = useState(0);
  const [altura, setAltura] = useState(0);



  const calcula = () =>{
    // let imc = parseFloat(peso)/(parseFloat(altura)*parseFloat(altura));
    // console.log("ok", nome, peso, altura);
    // alert(`${nome},` + ` seu imc é ` + imc.toFixed(2) + `!`);
    let pessoa = new Pessoa(nome, peso, altura);
    alert(`Nome: ${pessoa.nome} \nPeso: ${pessoa.peso} kg \nAltura: ${pessoa.altura} m `
      +`\nIMC: ${pessoa.imc().toFixed(2)}`
      + `\nFaixa: ${pessoa.faixa()}`)
    
  }

  return (
    <View style={styles.container}>
      
      <Titulo tamanho="grande" corFundo="#bbb">
        IMC
      </Titulo>
      <Titulo tamanho="medio" corFundo="#0dd">
        O seu app!
      </Titulo>
      {/* <Titulo tamanho="pequeno" >
        Blá
      </Titulo>
      <Titulo tamanho="50">
        Blá blá
      </Titulo> */}
      <View style={styles.body}>
        <Campo mensagem="Informe seu nome!"  onChange={setNome}>
          <Titulo tamanho="medio">Nome:</Titulo>
        </Campo>
        <Campo keyboard='numeric' valor="0" onChange={setPeso}>
          <Titulo tamanho="medio">Peso: (em kg)</Titulo>
        </Campo>
        <Campo keyboard='numeric' valor="0"  onChange={setAltura}> 
          <Titulo tamanho="medio">Altura: (em metros)</Titulo>
        </Campo>
      </View>
      <TouchableOpacity style={styles.btn} onPress={calcula}>
        <Text style={styles.btnText}>Calcular </Text>
      </TouchableOpacity>
      {/* <StatusBar style="auto" /> */}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'flex-start',
  },
  btn:{
    padding: 15,
    backgroundColor: "#AAA",
    width: "100%"
  },btnText:{
    textAlign: "center",
    fontSize: 22,
    fontWeight:"bold"
  },
  body:{
    backgroundColor: '#ff3',
    flexGrow: 1,
    width: "99%",
    alignItems: "center",
    justifyContent: 'flex-start'
  }
});
