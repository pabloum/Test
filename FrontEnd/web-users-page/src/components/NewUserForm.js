import { useState, useEffect } from 'react'


const Form = ({ onAdd }) => {
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [username, setUserName] = useState("");

    const onSubmit = (e) => {
        e.preventDefault();

        if (!firstName) {
            alert("Please add a first name");
            return;
        }

        if (!lastName) {
            alert("Please add a last name");
            return;
        }

        if (!username) {
            alert("Please add a username");
            return;
        }

        onAdd({ firstName, lastName, username });
        setFirstName("");
        setLastName("");
        setUserName("");
    }

    return <div className="App-form">
        <h1>Create new User</h1>

        <form onSubmit={onSubmit}>
            <label for="fname">First name:</label><br />
            <input type="text" id="fname" name="fname" placeholder="Enter here the Firstname"
                value={firstName}
                onChange={(e) => setFirstName(e.target.value)}
            /><br />

            <label for="lname">Last name:</label><br />
            <input type="text" id="lname" name="lname" placeholder="Enter here the Lastname"
                value={lastName}
                onChange={(e) => setLastName(e.target.value)}
            /><br />

            <label for="uname">Username:</label><br />
            <input type="text" id="uname" name="uname" placeholder="Enter here the Username"
                value={username}
                onChange={(e) => setUserName(e.target.value)}
            /><br />

            <input type="submit" value="Submit"></input>
        </form>
    </div>
}

export default Form