const Button = (props) => {
    return <a 
                className='btn'
                className="App-link"
                target="_blank"
            >
                {props.title}
            </a>
}

Button.defaultProps = {
    title: 'Create User',
    link: '/CreateUser'
}

export default Button