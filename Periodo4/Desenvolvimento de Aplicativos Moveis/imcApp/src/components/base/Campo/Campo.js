import { StyleSheet, TextInput, View, Text} from "react-native"
import Titulo from "../Titulo/Titulo"
import { useState } from "react"

export default Campo = ({children, keyboard, mensagem, valor='', onChange}) =>{

    const [value, setValue] = useState(valor);

    const mudaValue = (f) =>{
        setValue(f);
        onChange(f)
    }

    return(
        <View style={styles.container}>
            <Text>{children}</Text>
            {/* <Titulo tamanho="medio">{children}</Titulo> */}
            <TextInput style={styles.campo} 
                value={value}
                onChangeText={mudaValue}
                keyboardType={keyboard}
                placeholder={mensagem}
            />
        </View>
    )
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        alignItems: 'flex-start',
        justifyContent: "flex-start",
        padding: 15,
        width: "98%"
    },
    campo:{
        fontSize: 22,
        padding: 5,
        backgroundColor: '#fff',
        width:"98%",
        borderWidth: 1,
        borderColor: "#000"
    }
})