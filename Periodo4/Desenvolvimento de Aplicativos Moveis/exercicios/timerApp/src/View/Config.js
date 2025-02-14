import { useState } from "react";
import { StyleSheet, View, Text, Button } from "react-native";
import { TextInput } from "react-native-paper";


const Config = ({navigation}) => {
    const [tempo, setTempo] = useState({
        foco: 25,
        descanso: 5
    })

    const chamarTimer = () =>{
        if(tempo.foco <= 0 || tempo.descanso <= 0){
            alert("Tempo inserido inválido!")
        }else{
            console.log(tempo);
            navigation.navigate("Timer", {timer:tempo});
        }
    }

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Configure seu cronômetro</Text>
            <View style={styles.body}>
                <TextInput 
                    style={styles.campo}
                    label="Tempo de foco (min)"
                    keyboardType="numeric"
                    mode="outlined"
                    value={tempo.foco.toString()}
                    onChangeText={text => setTempo({...tempo, foco:text})}
                />
                <TextInput 
                    style={styles.campo}
                    label="Tempo de descanso (min)"
                    keyboardType="numeric"
                    mode="outlined"
                    value={tempo.descanso.toString()}
                    onChangeText={text => setTempo({...tempo, descanso:text})}


                />
                <Button title="Salvar" style={styles.btn} color={"green"} onPress={chamarTimer}/>
            </View>

        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#111',
        justifyContent: 'center',
        alignItems: 'center',
    },
    body: {
        backgroundColor: '#111',
        width: '100%',
        flex: 1,
        padding: 20, 
    },
    campo: {
        maxHeight: 70,
        padding: 10,
        width: '100%',
        marginBottom: 10,
        backgroundColor: "#ddd"
    },
    title:{
        fontSize: 48,
        fontWeight: 'bold',
        marginBottom: 20,
        color:"#ddd",
        textAlign:"center"
    },
    btn: {
        width: 200,
        marginBottom:20
    }
});

export default Config;
