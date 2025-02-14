import { Text, StyleSheet } from "react-native";

const Titulo = ({children, tamanho}) => {

    st = styles.grande
    if(tamanho === "pequeno"){
        st=styles.pequeno
    }

    return (
        <Text style={st}>
            {children}
        </Text>
    );
}

const styles = StyleSheet.create({
  grande:{
    fontSize: 30,
    fontWeight: 'bold',
    color: '#000',
  },
  pequeno:{
    fontSize: 20,
    color: '#fff',
  }
});

export default Titulo;
