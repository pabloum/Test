import './App.css';
import Header from './components/Header'
import Button from './components/Button'
import Input from './components/Input'
import Form from './components/NewUserForm'
import UserDetails from './components/UserDetails'
import usersQuemados from './Util/usersMock'

import {BrowserRouter, Switch, Route, Link} from 'react-router-dom'

import {useState, useEffect} from 'react'


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
        <BrowserRouter>
          <Switch>

            <Route path="/CreateUser">
              <Form/>
            </Route>
            
            <Route path="/User/ID">
              <UserDetails/>
            </Route>

            <Route path="/">
              <Link to="/CreateUser"><Button /></Link>
              <Input users={users}/>
            </Route>

          </Switch>
        </BrowserRouter>
      </header>
    </div>
  );
}

export default App;
