import { NavigationContainer } from "@react-navigation/native"
import { createStackNavigator } from "@react-navigation/stack"
import Splash from "../../view/Splash";
import Dados from "../../view/Dados";
import Simulacao from "../../view/Simulacao";
import Resultado from "../../view/Resultado";

const Stack = createStackNavigator();

export default MenuNavigator = () =>{
    return(
        <NavigationContainer>
            <Stack.Navigator initialRouteName="splash">
                <Stack.Screen name="splash" component={Splash}
                options={{headerShown: true}}/>
                <Stack.Screen name="dados" component={Dados}
                options={{headerTitle: ""}}/>
                <Stack.Screen name="simulacao" component={Simulacao}/>
                <Stack.Screen name="resultado" component={Resultado}/>
            </Stack.Navigator>
        </NavigationContainer>
    )
}