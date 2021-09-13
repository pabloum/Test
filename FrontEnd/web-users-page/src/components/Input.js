var users = [
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
    }
]

const Input = (props) => {
    return <div className="App-input">
                <input 
                    type="text" 
                    placeholder="Type the username"
                    className="App-input"
                    list="user-specs"
                />
                    <datalist id="user-specs" className="App-input">
                        {users.map(
                            function(user) {                        
                                return (<>
                                    <option value={user.fullName + " (" + user.username + ")"}/>
                                </>)
                            })
                        }
                    </datalist>

            </div>
}

export default Input