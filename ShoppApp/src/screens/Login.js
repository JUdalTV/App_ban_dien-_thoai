import React, { useContext, useState } from 'react';
import {Button, Text, TextInput, TouchableOpacity, View, StyleSheet,SafeAreaView, Image} from 'react-native';
import Navigation from '../components/Navigation';
import Signup from './Signup';
import { AuthContext } from '../context/AuthContext';


const Login = ({navigation}) =>{
    const [username, setUserName] = useState(null);
    const [password, setPassword] = useState(null);
    const val = useContext(AuthContext);

    return(
        <SafeAreaView style={{flex: 1, backgroundColor : '#eBcf4'}}>
            <View style={styles.container}>
                <View style ={styles.header}>
                    <Text style={styles.mp}>MeowPhone</Text>
                    <Text style={styles.wc}>Chào mừng đến với </Text>
                    <Text style={styles.wc}>của hàng điện thoại số 1 Việt Nam</Text>
                </View>
                <View style={styles.wrapper}>
                    <Text>Tài Khoản</Text>
                    <TextInput style={styles.input} value={username} placeholder='Vui lòng nhập tên đăng nhập' onChangeText={text => setUserName(text)} />
                    <Text>Mật khẩu</Text>
                    <TextInput style={styles.input} value={password} placeholder='Vui lòng nhập mật khẩu' onChangeText={text => setPassword(text)} secureTextEntry/>
                    <Button title='Đăng nhập' />
                    <View style={{flexDirection: 'row', justifyContent: "flex-end", marginVertical: 22}}>
                        <Text>Chưa có tải khoản? </Text>
                        <TouchableOpacity onPress={()=> navigation.navigate('Signup')}>
                            <Text style={styles.link}>Đăng kí</Text>
                        </TouchableOpacity>
                    </View>
                </View>
            </View>
        </SafeAreaView>
    );
};

const styles = StyleSheet.create({
    container:{
        flex : 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#F5FCFF',
    },
    header:{
        marginVertical:30,
    },
    mp:{
        textAlign: 'center',
        fontSize: 26,
        marginVertical: 30,
        coler: 'black',
        fontFamily: 'IndieFlower-Regular',
    },
    wc:{
        fontSize: 16,
        coler: 'black',
    },
    wrapper: {
        
        marginBottom: 52,
        
        width : '80%',
    },
    input: {
        marginBottom: 32,
        borderWidth: 1,
        borderColor: '#bbb',
        padding: 10,
        borderRadius: 5,
        paddingHorizontal: 14,
    },
    link: {
        color: 'blue',
    }
});

export default Login;