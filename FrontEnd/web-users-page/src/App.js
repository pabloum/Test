import './App.css';
import Header from './components/Header'
import Button from './components/Button'
import Input from './components/Input'

function App() {
  return (
    <div className="App">
      <header className="App-header">        
        <Header />
        <Button />
        <Input />
      </header>
    </div>
  );
}

export default App;
