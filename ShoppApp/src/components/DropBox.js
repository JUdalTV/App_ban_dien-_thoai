import { View, Text,StyleSheet,FlatList, TouchableOpacity } from 'react-native'
import React,{useState} from 'react'
import { dropdown } from '../Units/Data'
import Icons from "react-native-vector-icons/AntDesign";
const DropBox = () => {
  const [Index,setIndex]=useState();
  const [toggle, settoggle] = useState(false);
  return (
    <View style={StyleSheet.no1}>
      <FlatList data={dropdown} renderItem={({item,index})=>(
        <View>
          <TouchableOpacity onPress={()=> {setIndex(index);settoggle(!toggle);}} style={styles.no2}>
            <Text>{item.title}</Text>
            <Icons name={Index == index && toggle?'down':'right'} size={24} color="#228B22" />
          </TouchableOpacity>
          {Index == index && toggle ? <Text>{item.content}</Text>:null}
        </View>
      )}/>
    </View>
  )
}

const styles = StyleSheet.create({
  no1: {
    marginTop: 20,
    backgroundColor:'white'
  },
  no2:{
    flexDirection:'row',
    justifyContent:'space-between',
    alignItems:'center',
    borderBottomColor:'#90EE90',
    borderBottomWidth: 2,
    marginBottom: 10,
    paddingVertical:15,
  },
})

export default DropBox