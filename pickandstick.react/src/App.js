import axios from "axios";
import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
import PickPage from "./Components/PickPage"

require('dotenv').config();




function App() {

  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [loggedIn, setloggedIn] = useState("false") //switch this to redux when youre ready (put the whole user in redux store)
  const [userId, setUserId] = useState("");

  const {port} = process.env;

  const axiosConfig = {
    headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        "Access-Control-Allow-Origin": "*",
    }
  };
  const register = (Name, Password, Email) =>{

   axios.post('https://localhost:5001/Player', { // wrong format?
      Username: Name, 
      Password: Password,
      Email: 'wagh'
  }, axiosConfig)    
    .then(res => {
      console.log("registered");
      console.log(res);

    })
    .catch(err =>{
      console.log(err);
    })

  }
  const login = (Name, Password) =>{

    axios.post('https://localhost:5001/Player/login', { // wrong format?
       Username: Name, 
       Password: Password
   }, axiosConfig)    
     .then(res => {
       console.log("logged in");
       console.log(res);
 
     })
     .catch(err =>{
       alert("username or password incorrect");
     })
 
   }

  


  return (
    <div className="App">
   
      <input placeholder="Enter username" onChange={e => setUsername(e.target.value)} />
      <input placeholder="Enter password" onChange={e => setPassword(e.target.value)} />

      <button onClick={() => register(username, password, "grant")} >Register</button>
      <button onClick={() => login(username, password)} >Log in</button>

      <PickPage userId={userId} username={username} />

    </div>
  );
}

export default App;
