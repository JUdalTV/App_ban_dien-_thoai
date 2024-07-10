import React from "react";
import { Text, View , Button, TextInput, TouchableOpacity, StyleSheet} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { responsiveHeight } from "react-native-responsive-dimensions";
import Icons from "react-native-vector-icons/Feather";


const HomeSearch = () => {
    return (
                <View style={styles.search}>
                    <Icons name="search" size={24} color="black"/>
                    <TextInput placeholder="Tìm kiếm....." style={styles.input}/>
                </View>
           
    );
};
const styles = StyleSheet.create({
    search:{
        backgroundColor: '#e3e3e3',
        height: responsiveHeight(6.5),
        borderRadius:15,
        flexDirection: 'row',
        alignItems:'center',
        paddingHorizontal : 20,
        gap:10,
    },
    input:{
        flex:1
    },
})
export default HomeSearch;