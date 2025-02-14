import { Picker } from "@react-native-picker/picker"
import { StyleSheet, Text, View } from "react-native"
import { FAB, RadioButton, TextInput } from "react-native-paper"



export default OsNewView = ()=>{

    return(
        <View style={estilo.container}>

            <Text style={estilo.titulo} >NOVA OS</Text>

            <TextInput style={estilo.campo}
                label="descrição"
                placeholder="informe os dados da OS"
                />

            <Text style={{
                paddingLeft: 15,
                paddingTop:15,
                fontSize: 18,
            }} >
                    Tipo de OS
                </Text>

            <View style={{
                // flex: 1,
                flexDirection:"row",
                width:'100%',
                // backgroundColor: '#ab0',
                padding: 10,
                
            }}>
            <RadioButton.Group >
            <View style={{
                // flex: 1,
                flexDirection:"row",
            }}>
                <Text style={{
                    paddingLeft: 15,
                    paddingTop:8,
                    fontSize: 18,
                }}>Garantia</Text>
                <RadioButton value="Garantia" />
            </View>
            <View style={{
                // flex: 1,
                flexDirection:"row",
            }}>
                <Text style={{
                    paddingLeft: 15,
                    paddingTop:8,
                    fontSize: 18,
                }}>Orçamento</Text>
                <RadioButton value="Orçamento" />
            </View>
         
            </RadioButton.Group>
            </View>

            <Text style={{
                paddingLeft: 15,
                paddingTop:15,
                fontSize: 18,
            }} >
                    Tipo de Serviço
                </Text>
            <Picker  style={estilo.campo}>
                <Picker.Item label="Troca Pneu" value="java" />
                <Picker.Item label="Alinhamento" value="js" />
                <Picker.Item label="Mecânica" value="js" />
                <Picker.Item label="Eletrica" value="js" />
                <Picker.Item label="Escapamento" value="js" />
                <Picker.Item label="Freio" value="js" />
            </Picker>


            <TextInput style={estilo.campo1}
            multiline={true}
            numberOfLines={3}
                label="problema"
                placeholder="informe o problema ocorrido"
                />

            <TextInput style={estilo.campo}
                    label="Cliente"
                    placeholder="Nome do Cliente"
                    />
                
                {/* problema relatado */}
                {/* data previsão */}
                {/* nome cliente */}


            <View style={
                {flexGrow: 1,}
            }>

                
            </View>


            <FAB
                    icon="plus"
                    label="Salvar"
                    style={estilo.fab}
                    onPress={() => console.log('Pressed')}
                />

        </View>        
    )

}

const estilo = StyleSheet.create({
    fab: {
        position: 'absolute',
        margin: 10,
        right: 0,
        bottom: 0,
      },
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'flex-start',
        justifyContent: 'flex-start',
      },
      campo:{
        width: '100%',
        height: 22,
        fontSize: 18,
      },
      campo1:{
        width: '100%',
        // height: 66,
        fontSize: 18,
      },
      titulo:{
        width: '100%',
        fontSize: 42,
        fontWeight: 'bold',
        textAlign: 'center',
      },
})