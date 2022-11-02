import React ,{ useState}from 'react';
import './App.css';
import {useTransition,animated} from "react-spring"


import {PasswordResetCode} from './components/Password_reset_code.js'

function PasswordReset()
{   
    const [IsVisible,setIsVisible]=useState();
    const transition=useTransition(IsVisible,{
      config:{duration: 500},
  
      from:{ opacity:0 },
      enter:{opacity:1},
      leave:{opacity:0}
    })

function add_component()

{

setIsVisible(v=>v=true);
}

    return(
     <div>
    <div className="login-div">
        <h1 >Reset Password</h1>
        <div className="user-div">
       
        <input className=""type="text"  placeholder="E-mail adress"></input>

        </div>
        <button className="" onClick={add_component}>Send Code to E-mail</button>
      
        <div>{transition((style,item)=>
         item ?<animated.div style={style} >
     <PasswordResetCode/>
     
         </animated.div>:" ")}
         </div>
    </div>
    </div> 
    )
}

export default PasswordReset;