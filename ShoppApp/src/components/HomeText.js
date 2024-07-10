import React from "react";
import { Text, View , Button, TextInput, TouchableOpacity, StyleSheet} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";

const HomeText = () => {
    return (
                <View style={styles.md}>
                    <Text style={styles.mp}>MeowPhone</Text>
                </View>
           
    );
};
const styles = StyleSheet.create({
    md:{
        justifyContent: 'center',
        alignItems: 'center',
    },
    mp:{
        textAlign: 'center',
        fontSize: 26,
        marginVertical: 30,
        coler: 'black',
        fontFamily: 'IndieFlower-Regular',
        
    },
})
export default HomeText;