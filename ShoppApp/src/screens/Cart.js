import {
  View,
  Text,
  StyleSheet,
  Image,
  TouchableOpacity,
  FlatList,
} from 'react-native';
import React from 'react';
import {SafeAreaView} from 'react-native-safe-area-context';
import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
} from 'react-native-responsive-dimensions';
import Icons from 'react-native-vector-icons/AntDesign';
import {useNavigation} from '@react-navigation/native';
import {useDispatch, useSelector} from 'react-redux';
import {removeFromCart} from '../../redux/CartSlice';
import {decrementQuantity} from '../../redux/CartSlice';
import {incrementQuantity} from '../../redux/CartSlice';

const Cart = () => {
  const dispatch = useDispatch();
  const storeData = useSelector(state => state.CartSlice);
  //   console.log(storeData);
  const navigation = useNavigation();
  let amount = 0;
  storeData.forEach(element => {
    amount += element.price * element.quantity;
  });

  return (
    <SafeAreaView style={styles.view}>
      <TouchableOpacity
        onPress={() => {
          navigation.goBack();
        }}>
        <Icons name="back" size={24} color="green" />
      </TouchableOpacity>
      <Text style={styles.in1}>Giỏ Hàng</Text>

      <FlatList
        data={storeData}
        renderItem={({item, index}) => (
          <View style={styles.in2}>
            <View style={styles.in3}>
              <Image
                style={styles.in5}
                source={{
                  uri: item.image,
                }}
              />
            </View>
            <View style={styles.in4}>
              <View style={styles.in6}>
                <Text style={styles.in7}>{item.name}</Text>

                <Icons
                  onPress={() => {
                    dispatch(removeFromCart(item));
                  }}
                  name="closecircle"
                  size={24}
                  color="green"
                />
              </View>
              <Text style={styles.in8}>{item.specifications}</Text>
              <View style={styles.in9}>
                <View style={styles.in10}>
                  <Icons
                    onPress={() => dispatch(decrementQuantity(item))}
                    name="minus"
                    size={26}
                    color="green"
                  />
                  <Text style={styles.in7}>{item.quantity}</Text>
                  <Icons
                    onPress={() => dispatch(incrementQuantity(item))}
                    name="plus"
                    size={26}
                    color="green"
                  />
                </View>
                <Text style={styles.in7}>{item.quantity * item.price} vnđ</Text>
              </View>
            </View>
          </View>
        )}
      />
      <TouchableOpacity
        onPress={() => {
          navigation.navigate('OrderPlace');
        }}
        style={styles.btn}>
        <View style={styles.cc}>
          <Text style={styles.dn}>Thanh Toán Ngay</Text>
          <Text style={styles.dn}>{amount}vnđ</Text>
        </View>
      </TouchableOpacity>
    </SafeAreaView>
  );
};
const styles = StyleSheet.create({
  view: {
    flex: 1,
    paddingHorizontal: 15,
    backgroundColor: 'white',
    gap: 15,
  },

  in1: {
    fontSize: 22,
    fontWeight: '600',
    marginBottom: 5,
    marginTop: 3,
    color: 'black',
    textAlign: 'center',
  },
  in2: {
    height: responsiveHeight(20),
    borderBottomColor: '#90EE90',
    borderBottomWidth: 2,
    flexDirection: 'row',
  },
  in3: {
    flex: 0.3,
    alignItems: 'center',
    justifyContent: 'center',
    // backgroundColor:'red',
  },
  in4: {
    flex: 0.7,
    // backgroundColor: 'cyan',
    paddingHorizontal: 10,
    justifyContent: 'space-evenly',
  },
  in5: {
    height: 110,
    width: 110,
    resizeMode: 'contain',
  },
  in6: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
  },
  in7: {
    fontSize: 20,
    fontWeight: '700',
    color: 'black',
  },
  in8: {
    fontSize: 17,
    color: 'grey',
  },
  in9: {
    // backgroundColor: 'red',
    alignItems: 'center',
    justifyContent: 'space-between',
    flexDirection: 'row',
  },
  in10: {
    flexDirection: 'row',
    alignItems: 'center',
    gap: 10,
    marginTop: 10,
  },
  in11: {},
  btn: {
    backgroundColor: '#228B22',
    marginBottom: 10,
    height: 50,
    borderRadius: 10,
    justifyContent: 'center',
    alignItems: 'center',
    shadowColor: '#000',
    shadowOffset: {width: 0, height: 2},
  },
  dn: {
    color: 'white',
    fontSize: 18,
  },
  cc: {
    flexDirection: 'row',
    alignItems: 'center',
    gap: 40,
  },
});

export default Cart;
