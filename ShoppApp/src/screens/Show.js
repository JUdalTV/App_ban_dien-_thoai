import React from "react";
import { Text, View, TouchableOpacity, StyleSheet, FlatList, Image,ScrollView } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { responsiveHeight, responsiveWidth } from "react-native-responsive-dimensions";
import Icons from "react-native-vector-icons/FontAwesome";
import Icons2 from "react-native-vector-icons/AntDesign";
import { phones } from "../Units/Data";
import { StatusBar } from "react-native";
import HomeText from "../components/HomeText";
import { useNavigation } from "@react-navigation/native";

const Show = () => {
    const navigation =useNavigation()
    const handleAddToCart = (item) => {
        console.log(`Added ${item.name} to cart`);
  };

  return (
    <SafeAreaView style={styles.safeArea}>
      <StatusBar backgroundColor='white' />
      <HomeText/>
      <ScrollView style={styles.scr}>
      <View style={styles.cata}>
        <FlatList 
          data={phones}
          numColumns={2} 
          keyExtractor={(item, index) => index.toString()}
          renderItem={({ item }) => (
            <TouchableOpacity onPress={() => navigation.navigate('Details')} style={styles.phone}>
              <Image style={styles.img} source={{ uri: item.image }} />
              <View style={styles.pro}>
                <Text style={styles.name}>{item.name}</Text>
                <Text style={styles.spec}>{item.specifications}</Text>
              </View>
              <View style={styles.no1}>
                <Text style={styles.pri}>{item.price} vnđ</Text>
                <TouchableOpacity onPress={() => handleAddToCart(item)}>
                  <Icons name='plus-circle' size={24} color="green" />
                </TouchableOpacity>
              </View>
            </TouchableOpacity>
          )}
        />
      </View>
      </ScrollView>
      <View style={styles.back}>
        <TouchableOpacity onPress={() =>  {navigation.goBack();}}>
          <Icons2 name='back' size={24} color="green" />
        </TouchableOpacity>
      </View>
      
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  safeArea: {
    flex: 1,
    backgroundColor: '#fff',
  },
  scr:{
    paddingHorizontal:5,
    paddingTop:10,
    flex:1,
    marginBottom:50,
},
  cata: {
    marginTop: 20,
    paddingHorizontal: 10,
    gap:10,
  },
  back: {
    flexDirection:'row',
    position:'absolute',
    width:'100%',
    paddingHorizontal:15,
  },
  phone: {
    flex: 1,
    margin: 10,
    borderWidth: 2,
    borderColor: '#778899',
    borderRadius: 10,
    shadowColor: '#000',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 0.8,
    shadowRadius: 2,
  },
  img: {
    height: responsiveHeight(20),
    width: '100%',
    resizeMode: 'contain',
    borderTopLeftRadius: 10,
    borderTopRightRadius: 10,
  },
  pro: {
    paddingHorizontal: 10,
    gap: 3,
  },
  name: {
    fontSize: 18,
    fontWeight: '600',
    color: '#333',
  },
  spec: {
    fontSize: 14,
    color: '#666',
    marginTop: 5,
  },
  no1: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    paddingHorizontal: 10,
    marginBottom: 10,
  },
  pri: {
    fontSize: 16,
    fontWeight: 'bold',
    color: '#333',
  },
});

export default Show;
