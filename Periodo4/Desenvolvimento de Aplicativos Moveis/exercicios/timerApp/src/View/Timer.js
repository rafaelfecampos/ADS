import React, { useState, useEffect } from 'react';
import { View, Text, Button, StyleSheet } from 'react-native';

const Timer = ({ route, navigation}) => {
  const {timer} = route.params;
  
  const [modo, setModo] = useState("FOCO TOTAL");  
  const [segundos, setSegundos] = useState(timer.foco*60);   
  const [ativo, setAtivo] = useState(false);     
  const [intervalId, setIntervalId] = useState(null);

  
  useEffect(() => {
    let intervalo = null;

    if (ativo && segundos>0) {
      intervalo = setInterval(() => {
        
        setSegundos((prevSegundos) => prevSegundos - 1);
        console.log(segundos);
      }, 1000);
      
      setIntervalId(intervalo);
    }else if (!ativo && intervalo ) {
      clearInterval(intervalo);
    }else if (segundos <= 0){
        clearInterval(intervalo);
        alert('O TEMPO ACABOU!' + `\nIniciando ${novoModo.toLowerCase()}.`);
        alternarModo();
    }

    
    return () => clearInterval(intervalo); 
  }, [ativo, segundos]);

  const alternarModo = () => {
    const novoModo = modo === 'FOCO TOTAL' ? 'HORA DO DESCANSO' : 'FOCO TOTAL';
    const novoTempo = novoModo === 'FOCO TOTAL' ? timer.foco * 60 : timer.descanso * 60;
    setModo(novoModo);
    setSegundos(novoTempo);
    setAtivo(false);
  };

  const resetCronometro = () => {
    setAtivo(false);
    setSegundos(modo == "FOCO TOTAL"? timer.foco*60:timer.descanso*60)
    clearInterval(intervalId);
  };

  const formatarTempo = (segundos) => {
    const minutos = Math.floor(segundos / 60);
    const segundosRestantes = Math.floor(segundos % 60);
  
    return `${minutos < 10 ? '0' + minutos : minutos}:${segundosRestantes < 10 ? '0' + segundosRestantes : segundosRestantes}`;
  };

  const chamarConfig = () =>{
      navigation.navigate("Ajustes");
  }

  return (
    <View style={styles.container}>
      

      <Text style={styles.title}>{modo}</Text>

      <Text style={styles.cronometro}>{formatarTempo(segundos)}</Text>

      <View style={styles.btn}>
        <Button title={(ativo && segundos > 0) ? "Pausar" : "Iniciar"} onPress={() => setAtivo(!ativo)} 
          color={ativo? 'red':''} />
        <Button title="Resetar" onPress={resetCronometro} color="orange"/>
      </View>
      <View style={{marginBottom: 20}} >
        <Button title='Alterar modo' onPress={alternarModo} style={styles.btn} color="#6f03fc" />
      </View>
      <View>
        <Button title="Configurações" style={styles.btn} color={"green"} onPress={chamarConfig}/>
      </View>
    </View>
  );
};




const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor:"#111"
  },
  cronometro: {
    fontSize: 48,
    fontWeight: 'bold',
    marginBottom: 20,
    color: "#f5e642"
  },
  title:{
    fontSize: 48,
    fontWeight: 'bold',
    marginBottom: 20,
    color:"#ddd",
    textAlign: "center"
  },
  btn: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    width: 200,
    marginBottom:20
  },
});

export default Timer;
