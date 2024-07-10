import {View, Text, StyleSheet} from 'react-native';
import React, { useEffect } from 'react';
import Icons from 'react-native-vector-icons/Ionicons';
import {useNavigation} from '@react-navigation/native';
import { StatusBar } from 'react-native';

const OrderPlace = () => {
    const navigation = useNavigation();
    useEffect(() => {
        setTimeout(()=>{navigation.navigate("Home");}, 2000);
    }, []);
  return (
    <View style={styles.a1}>
      <Icons name="bag-check" size={80} color="green" />
      <Text style={styles.ss}>Giàu đấy!</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  a1: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'white',
  },
  ss:{
    fontSize: 26,
    color: 'green',
    marginTop: 10,
  },
});
export default OrderPlace;
