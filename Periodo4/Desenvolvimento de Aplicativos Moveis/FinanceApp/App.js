import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import Splash from './src/view/Splash';
import MenuNavigator from './src/components/navigator/MenuNavigator';

export default function App() {
  return (
    // <Splash/>
    <MenuNavigator/>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
