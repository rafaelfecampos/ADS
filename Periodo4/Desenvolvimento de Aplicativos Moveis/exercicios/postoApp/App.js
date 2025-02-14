import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, Touchable, TouchableOpacity, View } from 'react-native';
import Titulo from './src/components/base/Titulo/Titulo';
import Campo from './src/components/base/Campo/Campo';
import { useState } from 'react';
import Combustivel from './src/model/Combustivel';

export default function App() {
  const [alcool, setAlcool] = useState(0.0);
  const [gasolina, setGasolina] = useState(0.0);

  const calcular = () =>{
    console.log("alcool: " + alcool);
    console.log("gasolina: " + gasolina);

    let combustivel = new Combustivel(gasolina, alcool);

    alert(`O resultado foi ${combustivel.resultado().toFixed(3)}!\n` + combustivel.maisVantajoso());
  }

  return (
    <View style={styles.container}>
      <View style={styles.titulo}>
        <Titulo tamanho="grande">CALCULADORA</Titulo>
        <Titulo tamanho="grande">DE</Titulo>
        <Titulo tamanho="grande">ABASTECIMENTO</Titulo>
      </View>
       <View style={styles.body}>
        <Titulo tamanho="pequeno">Preço Álcool x Preço Gasolina</Titulo>
        <Campo  onChange={setAlcool}>Álcool</Campo>
        <Campo  onChange={setGasolina}>Gasolina</Campo>
      </View>
      <TouchableOpacity style={styles.btn} onPress={calcular}>
        <Text style={styles.btnTexto}>CALCULAR</Text>
      </TouchableOpacity>
      
    </View>
  );
}
const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#f5d442',
    alignItems: 'center', 
    justifyContent: 'center',
    padding:10,
    
  },
  body: {
    backgroundColor: "#000",
    // flex: 1, 
    width: "98%",
    alignItems: "center",
    justifyContent: "center", 
    padding:0,
    margin: 15,
    
  },
  btn:{
    padding:15,
    backgroundColor:"#AAA",
    alignItems:"center",
    width:"50%"
  },
  btnTexto:{
    color: "#fff",
    fontWeight: "bold",
    fontSize: 20
  },
  titulo:{
    width: '100%',
    marginBottom: 20,
    alignItems:"center"
  }
});
