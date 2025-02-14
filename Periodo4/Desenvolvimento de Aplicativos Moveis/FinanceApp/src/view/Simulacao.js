import { StyleSheet, TouchableOpacity, View , Text} from "react-native";

export default Simulacao = ({navigation}) => {
    return (
        <View style={styles.container}>
            <Text style={styles.titulo}>Simulacao</Text>

            <TouchableOpacity style={styles.btn}
            onPress={() => {navigation.navigate('resultado')}}>
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