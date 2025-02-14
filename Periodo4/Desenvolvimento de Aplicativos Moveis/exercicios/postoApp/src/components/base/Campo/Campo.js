import { useState } from "react"
import { StyleSheet, TextInput, View, Text } from "react-native"

export default Campo = ({children, onChange}) =>{

    const mudarValor = (value) => {
        onChange(value);
    }


    return(<View style={styles.container}>
        <Text style={styles.texto}>{children}</Text>
        <TextInput style={styles.campo}
            placeholder="Insira o preço"
            keyboardType="numeric"
            onChangeText={mudarValor}
        />
    </View>)
}

const styles = StyleSheet.create({
    container: {
        alignItems: 'flex-start',
        justifyContent: "flex-start",
        padding: 15,
        width: "98%"
    },
    campo:{
        fontSize: 30,
        padding: 5,
        backgroundColor: '#fff',
        width:"98%",
        borderWidth: 1,
        borderColor: "#000"
    },
    texto:{
        color:"#fff",
        fontSize:20
    }
})