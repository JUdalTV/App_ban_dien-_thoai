import React from "react";
import { Text, View , Button, TextInput, TouchableOpacity, StyleSheet} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { responsiveHeight } from "react-native-responsive-dimensions";
import Icons from "react-native-vector-icons/Feather";
import { useNavigation } from "@react-navigation/native";


const ProducTitle = ({title}) => {
    const navigation =useNavigation()
    return (
                <View style={styles.cata} >
                    <Text style={styles.gy}>{title}</Text>
                    <TouchableOpacity onPress={()=>navigation.navigate('Show')}>
                    <Text style={styles.all}>Tất Cả</Text>
                    </TouchableOpacity>
                </View>
           
    );
};
const styles = StyleSheet.create({
    cata:{
        flexDirection:'row',
        justifyContent:'space-between',
        alignContent:'center',
    },
    gy:{
        fontSize:20,
        fontWeight:"600",
    },
    all:{
        fontSize:16,
        color:'blue'
    },
})
export default ProducTitle;