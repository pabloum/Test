

const Form = (props) => {
    return <div className="App-form">
                <h1>Create new User</h1>

                <form>
                    <label for="fname">First name:</label><br/>
                    <input type="text" id="fname" name="fname"/><br/>

                    <label for="lname">Last name:</label><br/>
                    <input type="text" id="lname" name="lname"/><br/>

                    <label for="uname">Username:</label><br/>
                    <input type="text" id="uname" name="uname"/><br/>

                    <input type="submit" value="Submit"></input>
                </form>
            </div>
}

export default Form