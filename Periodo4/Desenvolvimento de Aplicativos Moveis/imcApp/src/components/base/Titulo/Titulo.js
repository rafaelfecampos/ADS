import {Text, StyleSheet } from 'react-native';


const Titulo = ({children, tamanho, corFundo}) => { //children é palavra padrão para atribuir elemento que a tag engloba como filho
    // console.log(p);'
    console.log({children, tamanho, corFundo});
    // switch (p.tamanho) {'
    //     case "grande":
    //         return(<Text style={styles.t1}>{p.titulo}</Text>)
    //     case "medio":
    //         return(<Text style={styles.t2}>{p.titulo}</Text>)
    //     case "pequeno":
    //         return(<Text style={styles.t3}>{p.titulo}</Text>)
    //     default:
    //         break;
    // }
    //funcionou mas não é muito limpo

    st = styles.t1;
    if (tamanho == "medio"){
        st = styles.t2;
    }else if (tamanho == "pequeno"){
        st = styles.t3;
    }
    
    const cor = {
        backgroundColor: corFundo
    }
    console.log(corFundo, styles.cor, cor);

    return(<Text style={[st,styles.cor, cor]}>
            {children}
        </Text>)
    //também não é muito limpo, mas é mais direto
    

}

const styles = StyleSheet.create({
    t1:{
        fontSize: 40,
        padding: 15
    },
    t2: {
        fontSize: 20,
        padding: 15
    },
    t3: {
        fontSize: 14,
        padding: 48,
    },
    cor:{
        width: "99%",
        textAlign: "center",
    }
})

export default Titulo;