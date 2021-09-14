import './App.css';
import Header from './components/Header'
import Button from './components/Button'
import Input from './components/Input'
import Form from './components/NewUserForm'
import UserDetails from './components/UserDetails'
import usersQuemados from './Util/usersMock'
import { BrowserRouter, Switch, Route, Link } from 'react-router-dom'

import { useState, useEffect } from 'react'

const axios = require('axios');
const baseUrl = 'https://localhost:44373/';

function App() {
  const [users, setUsers] = useState([])

  useEffect(async () => {
    const fetchTask = async () => {
      const res = await fetch(baseUrl + 'api/user');
      const data = await res.json();
      return data;
    }
    var cosa = await fetchTask()
    setUsers(cosa)
  }, [])

  // Create user
  const createUser = (user) => {
    console.log(user);

    axios.post(baseUrl + 'api/user', user)
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
  }

  return (
    <div className="App">
      <header className="App-header">
        <Header />
        <BrowserRouter>
          <Switch>

            <Route path="/CreateUser">
              <Form onAdd={createUser} />
            </Route>

            <Route path="/User/ID">
              <UserDetails />
            </Route>

            <Route path="/">
              <Link to="/CreateUser"><Button /></Link>
              <Input users={users} />
            </Route>

          </Switch>
        </BrowserRouter>
      </header>
    </div>
  );
}

export default App;
