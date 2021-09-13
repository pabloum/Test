import './App.css';
import Header from './components/Header'
import Button from './components/Button'
import Input from './components/Input'

import {useState, useEffect} from 'react'

var usersQuemados = [
  {
      "firstName": "Pablo",
      "lastName": "Uribe",
      "fullName": "Pablo Uribe",
      "username": "puribe"
  },
  {
      "firstName": "James",
      "lastName": "Rodriguez",
      "fullName": "James Rodriguez",
      "username": "jrodriguez"
  },
  {
      "firstName": "Vero",
      "lastName": "Sharapova",
      "fullName": "Vero Sharapova",
      "username": "vsharapova"
  },
  {
    "firstName": "Perro",
    "lastName": "Feo",
    "fullName": "Perro Feo",
    "username": "vsharapova"
  }
]

function App() {
  const [users, setUsers] = useState([])

  useEffect( async () => {
    const fetchTask = async () => {
      const res = await fetch('https://localhost:44373/api/user');
      const data = await res.json();
      return data;
    }
    var cosa = await fetchTask()
    setUsers(cosa)
  }, [])


  return (
    <div className="App">
      <header className="App-header">        
        <Header />
        <Button />
        <Input users={users}/>
      </header>
    </div>
  );
}

export default App;
