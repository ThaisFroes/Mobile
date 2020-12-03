import { StackScreenProps } from '@react-navigation/stack';
import as React from 'react';
import { StyleSheet, Text, View, TextInput, TouchableOpacity } from 'react-native';
import Img from 'react-image'

export default function Home(){
  return (
    <View style={styles.container}>
    
    
    <View Style={styles.texto}>
    <Text style={styles.text}>Em busca do seu primeito emprego na área de tecnologia, junte-se a nós e encontre as melhores vagas.</Text>
    </View>
   
    <View style={styles.quadrado}>
    <img src="./img/imgEmpresa.png"></img>
    </View>

    </View> 
  );
}
 
const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  quadrado:{
    display: 'flex',
    alignItems: 'center'
    flexDirection: 'column',
    width: '10vw',
    height: '10vw',
    marginBottom: '3vh',
  },

  texto:{
    backgroundColor: 'black',
    color: 'black',
    textAlign: 'center',
    padding: '0.6vw'
    fontWeight:'bold',
  }

});