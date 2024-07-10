import React, { useContext, useState } from 'react';
import {Button, Text, TextInput, TouchableOpacity, View, StyleSheet} from 'react-native';
import Navigation from '../components/Navigation';
import Login from './Login';
import Home from './Home';
import { AuthContext } from '../context/AuthContext';

const Signup = ({navigation}) =>{
    const [name, setName] = useState(null);
    const [username, setUserName] = useState(null);
    const [phoneNum, setPhoneNum] = useState(null);
    const [password, setPassword] = useState(null);
    const val = useContext(AuthContext);

    return(
        <View style={styles.container}>
            <View style={styles.wrapper}>
                <Text style={styles.mp}>MeowPhone</Text>
                <Text>Họ và Tên</Text>
                <TextInput style={styles.input} value={name} placeholder='Vui lòng nhập tên' onChangeText={text => setName(text)} />
                <Text>Tên đăng nhập</Text>
                <TextInput style={styles.input} value={username} placeholder='Vui lòng nhập tên đăng nhập' onChangeText={text => setUserName(text)} />
                <Text>Số điện thoại</Text>
                <TextInput style={styles.input} value={phoneNum} placeholder='Vui lòng nhập số điện thoại' onChangeText={text => setPhoneNum(text)} />
                <Text>Mật khẩu</Text>
                <TextInput style={styles.input} value={password} placeholder='Vui lòng nhập mật khẩu' onChangeText={text => setPassword(text)} secureTextEntry/>
                <TouchableOpacity style={styles.log} onPress={()=> navigation.navigate('Home')}><Text style={styles.dn}>Đăng Kí</Text></TouchableOpacity>
                
                <View style={{flexDirection: 'row',justifyContent:'flex-end', marginTop: 20}}>
                    <Text>Đã có tải khoản? </Text>
                    <TouchableOpacity onPress={()=> navigation.navigate('Login')}>
                        <Text style={styles.link}>Đăng Nhập</Text>
                    </TouchableOpacity>
                </View>
            </View>
        </View>
    );
};

const styles = StyleSheet.create({
    container:{
        flex : 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#F5FCFF',
    },
    mp:{
        textAlign: 'center',
        fontSize: 26,
        marginVertical: 30,
        coler: 'black',
        fontFamily: 'IndieFlower-Regular',
    },
    wrapper: {
        width : '80%',
    },
    input: {
        marginBottom: 12,
        borderWidth: 1,
        borderColor: '#bbb',
        padding: 10,
        borderRadius: 5,
        paddingHorizontal: 14,
    },
    log:{
        backgroundColor:'#228B22',
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
    link: {
        color: 'blue',
    }
});

export default Signup;
