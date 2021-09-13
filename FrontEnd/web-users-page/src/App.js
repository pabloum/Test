import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>THE USERS APP</h1>
        <img src={logo} className="App-logo" alt="logo" />
        <a
          className="App-link"
          href="https://google.com"
          target="_blank"
        >Create new user</a>
        <div className="App-input">
          <input 
              type="text" 
              placeholder="Type the username"
              className="App-input"
          >            
          </input>
        </div>
      </header>
    </div>
  );
}

export default App;
