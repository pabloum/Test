const Input = (props) => {
    console.log(props.users)
    return <div className="App-input">
                <input 
                    type="text" 
                    placeholder="Type the username"
                    className="App-input"
                    list="user-specs"
                />
                    <datalist id="user-specs" className="App-input">
                        {props.users.map(
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