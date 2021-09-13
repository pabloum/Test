const Button = (props) => {
    return <a 
                className='btn'
                className="App-link"
                href="https://google.com"
                target="_blank"
            >
                {props.title}
            </a>
}

Button.defaultProps = {
    title: 'Create User'
}

export default Button