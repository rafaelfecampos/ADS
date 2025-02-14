import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "@react-navigation/stack";
import Timer from "../../View/Timer.js";
import Config from "../../View/Config.js";

const Stack = createStackNavigator();

export default MenuNavigator = () =>{
    return(
        <NavigationContainer>
            <Stack.Navigator initialRouteName="Ajustes">
                <Stack.Screen name="Timer" component={Timer} 
                    options={{headerTitleAlign:"center", headerStyle:{backgroundColor:"#111"}, headerTintColor:"#ddd"}}/>
                <Stack.Screen name="Ajustes" component={Config}
                    options={{headerTitleAlign:"center", headerStyle:{backgroundColor:"#111"}, headerTintColor:"#ddd"}} />
            </Stack.Navigator>
        </NavigationContainer>
    )
}