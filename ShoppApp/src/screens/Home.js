import React from "react";
import { Text, View , Button, TextInput, TouchableOpacity, StyleSheet,ScrollView} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import HomeText from "../components/HomeText";
import HomeSearch from "../components/HomeSearch";
import ProducTitle from "../components/ProductTitle";
import ProducCategory from "../components/ProductCategory";

const Home = () => {
    return (
        <SafeAreaView style={styles.home}>
            <ScrollView style={styles.scr}>
                <View style={styles.we}>
                    <HomeText/>
                    <HomeSearch/>
                    <ProducTitle title='Dành Cho Bạn'/>
                    <ProducCategory/>
                    <ProducTitle title='Bán Chạy Nhất'/>
                    <ProducCategory/>
                </View>
            </ScrollView>
            
        </SafeAreaView>
    );
};
const styles = StyleSheet.create({
    home: {
        
        flex:1,
        backgroundColor: '#F5FCFF',
        
    },
    scr:{
        paddingHorizontal:20,
        paddingTop:10,
        flex:1,
        marginBottom:50,
    },
    we:{
        gap:20,
        paddingBottom:20,
    },
    mp:{
        textAlign: 'center',
        fontSize: 26,
        marginVertical: 30,
        coler: 'black',
        fontFamily: 'IndieFlower-Regular',
    },
})
export default Home;