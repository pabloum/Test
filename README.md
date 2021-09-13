# Test

Test project. 

## Back end

This was built using Database first approach. Three endpoints were exposed to interact with the Database:

1. To list all users:
    ```
    GET api/user/
    ```

2. To filter users with a keyword
    ```
    GET api/user/{filter}
    ```

3. To create a new user. (You must send the created user in the body of the request)
    ```
    POST api/user/
    ```

### Run 

1. Make sure you have installed .Net Core, SQL Server Express and SQL Server Management Studio
2. Deploy the Database from the data base project to a local server.
3. Edit the connection string to match your local server
3. Compile and run the application

## Front end

This was built with React. 

However, the app is not entirely functional. The Form that creates user is not hitting the endpoint. And the Details route is not hitting any endpoint either, thus the data displayed is hardcoded.

