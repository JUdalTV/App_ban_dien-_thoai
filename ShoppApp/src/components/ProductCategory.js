import React from "react";
import { Text, View , Button, TextInput, TouchableOpacity, StyleSheet,FlatList, Image} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { responsiveHeight, responsiveWidth } from "react-native-responsive-dimensions";
import Icons from "react-native-vector-icons/FontAwesome";
import {phones} from "../Units/Data";

import { useNavigation } from "@react-navigation/native";
import { useDispatch } from "react-redux";
import { addToCart } from "../../redux/CartSlice";


const ProducCategory = (route) => {
    
    const navigation = useNavigation();
    const dispatch = useDispatch();
    return (
                <View style={styles.cata} >
                    <FlatList 
                    horizontal
                    showsHorizontalScrollIndicator={false}
                    data ={phones}
                    renderItem={({item,index})=>(
                        <TouchableOpacity onPress={() => navigation.navigate('Details',{main:item})} style={styles.phone}>
                            <Image style={styles.img} source={{uri:item.image}} />
                            <View style={styles.pro}>
                                <Text style={styles.name}>{item.name}</Text>
                                <Text style={styles.spec}>{item.specifications}</Text>
                            </View>
                            <View style={styles.no1}>
                                <Text style={styles.pri}>{item.price} vnđ</Text>
                                
                                    <Icons name='plus-circle' size={24} color="green" />
                                
                            </View>
                        </TouchableOpacity>
                        
                    )} 
                    />
                </View>
           
    );
};
const styles = StyleSheet.create({
    phone:{
        height: responsiveHeight(37),
        borderWidth: 2,
        borderColor: '#778899',
        width:responsiveWidth(45),
        marginRight: 16,
        borderRadius: 10,
        shadowColor: '#000',
        shadowOffset: { width: 0, height: 2 },
        shadowOpacity: 0.8,
        shadowRadius: 2,
        flex:1,
    },
    img:{
        height:170,
        width:170,
        resizeMode: 'contain',
    },
    pro:{
        paddingHorizontal: 10,
        gap:3,
        position:'relative',
    },
    name:{
        fontSize: 18,
        fontWeight: '600',
        color: '#333',
        position:'static',
        
    },
    spec:{
        fontSize: 14,
        color: '#666',
        marginTop: 5,
    },
    no1:{
        flexDirection: 'row',
        alignItems: 'center',
        justifyContent: 'space-between',
        paddingHorizontal: 10,
        position:'relative',
    },
    pri:{
        fontSize: 16,
        fontWeight: 'bold',
        color: '#333',
        position:'static',
        bottom:0
    },
})
export default ProducCategory;