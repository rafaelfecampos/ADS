import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';


export default function App() {
  // let v1 = 0;
  // let v2 = 5;
  const [v1 , setV1] = useState(0);
  const [v2, setV2]  =useState(5);

  const calcular = ()=>{
    // v1 = v1 + 1;
    // v2= v2 + 1;
    setV1(v1+1) //setXX é uma função assíncrona, o que permite o programa em continuar sendo executado, por isso  console.log vai imprimir o valor "antigo"
    setV2(v2+1)
    console.log("ok", v1, v2);
  }
  
  return (
    <View style={styles.container}>
      <Text style={styles.titulo}>Calculadora</Text>

      <View style={styles.body}>
        <Text style = {styles.texto}>Valor 1</Text>
        <TextInput style={styles.campo} value={v1}/>
        <Text style = {styles.texto}>Valor 2</Text>
        <TextInput style={styles.campo} value={v2}/>
      </View>

      <TouchableOpacity onPress={calcular} style={styles.btn}>Calcular</TouchableOpacity>
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  btn:{
    padding: 25,
    fontSize: 32,
    backgroundColor:"#0d6007",
    borderRadius:15,
    marginBottom:10,
    width: '98%',
    textAlign: 'center'
  },
  body:{
    flexGrow:1,
    // backgroundColor: '#ff0'
  },
  container: {
    flex: 1,
    backgroundColor: '#AA9',
    alignItems: 'center',
    justifyContent: 'center',
  },
  texto:{
    fontSize:20,
    paddingBottom:10,
    paddingTop: 10
  },
  campo:{
    backgroundColor: "#fff",
    fontSize: 22,
    padding:5,
    borderWidth: 1, // Alterado para borderWidth, borderStyle e borderColor
    borderColor: "black",
    borderStyle: 'solid'
  },
  titulo:{
    fontSize: 48,
    fontWeight: 'bold',
    paddding:25,

  }
});
