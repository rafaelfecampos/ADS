import { StyleSheet, TouchableOpacity, View , Text} from "react-native";

export default Resultado = () => {
    return (
        <View style={styles.container}>
            <Text style={styles.titulo}>Resultado</Text>

            <TouchableOpacity style={styles.btn}>
                <Text style={styles.titulo}>Próximo</Text>
            </TouchableOpacity>

        </View>

    )
};

const styles = StyleSheet.create({
    container:{
        flex: 1,
        alignItems: 'flex-start',
        justifyContent:'flex-start',
        backgroundColor: "#fff"
    },
    titulo:{
        fontSize:28,
        padding:15,
        fontWeight: 'bold',
        textAlign: 'center',
        width: '99%'
    },
    btn:{
        padding:15,
        backgroundColor: '#0bb',
        width: '100%'
    }
})