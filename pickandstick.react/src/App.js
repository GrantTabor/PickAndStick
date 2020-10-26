import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {

  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const register = (username, password) =>{
    console.log("registered");
  }

  


  return (
    <div className="App">
      hello world
      testing
      <input placeholder="Enter username" onChange={e => setUsername(e.target.value)} />
      <input placeholder="Enter password" onChange={e => setPassword(e.target.value)} />



      {username}
      <button onClick={() => register(username, password)} >Submit</button>
    </div>
  );
}

export default App;
