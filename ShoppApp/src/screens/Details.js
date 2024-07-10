import React from "react";
import { Text, View, Button, TextInput, TouchableOpacity, StyleSheet, Image, FlatList } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { responsiveHeight } from "react-native-responsive-dimensions";
import Icons from "react-native-vector-icons/AntDesign";
import { StatusBar } from "react-native";
import DropBox from "../components/DropBox";
import { useNavigation } from '@react-navigation/native';
import { useDispatch } from "react-redux";
import { addToCart } from "../../redux/CartSlice";

const Details = ({ route }) => {
    const ProductData = route.params.main;
    const { name, specifications, price, image } = ProductData;
    
    const navigation = useNavigation();
    const dispatch = useDispatch();

    const renderDetails = () => (
        <View>
            <View style={styles.top}>
                <Image style={styles.pic} source={{ uri: image }} />
                <View style={styles.back}>
                    <TouchableOpacity onPress={() => { navigation.goBack(); }}>
                        <Icons name='back' size={24} color="green" />
                    </TouchableOpacity>
                </View>
            </View>
            <View style={styles.det}>
                <View>
                    <Text style={styles.itro}>{name}</Text>
                </View>
                <View>
                    <Text style={styles.aa}>{specifications}</Text>
                    <Text style={styles.ab}>{price} vnđ</Text>
                    <DropBox />
                    <TouchableOpacity onPress={() => { dispatch(addToCart(ProductData)); navigation.navigate('Cart') }} style={styles.btn}>
                        <Text style={styles.dn}>Thêm vào giỏ hàng</Text>
                    </TouchableOpacity>
                </View>
            </View>
        </View>
    );

    return (
        <SafeAreaView style={{ flex: 1 }}>
            <StatusBar backgroundColor="white" />
            <FlatList
                data={[{ key: 'details' }]}
                renderItem={renderDetails}
                keyExtractor={item => item.key}
                contentContainerStyle={styles.scr}
            />
        </SafeAreaView>
    );
};

const styles = StyleSheet.create({
    top: {
        alignItems: "center",
        gap: 20,
    },
    scr: {
        paddingHorizontal: 20,
        paddingTop: 10,
        marginBottom: 50,
    },
    pic: {
        resizeMode: "contain",
        height: 340,
        width: 250,
        borderBottomLeftRadius: 15,
        borderBottomRightRadius: 15,
    },
    back: {
        flexDirection: 'row',
        position: 'absolute',
        width: '100%',
        paddingHorizontal: 15,
    },
    det: {
        paddingHorizontal: 15,
    },
    itro: {
        fontSize: 20,
        fontWeight: '600',
        color: 'black',
    },
    aa: {
        fontSize: 16,
        fontWeight: '500',
        color: '#666',
        marginTop: 5,
    },
    ab: {
        fontSize: 20,
        fontWeight: 'bold',
        color: 'black',
        marginTop: 10,
    },
    btn: {
        backgroundColor: '#228B22',
        marginTop: 10,
        height: 50,
        borderRadius: 10,
        justifyContent: 'center',
        alignItems: 'center',
        shadowColor: '#000',
        shadowOffset: { width: 0, height: 2 },
    },
    dn: {
        color: 'white',
        fontSize: 18,
    },
});

export default Details;
