window.onload = () => {
    const loginButton = document.getElementById('login');
    const signupButton = document.getElementById('signup');

    signupButton.addEventListener('click', (event) =>{
        event.preventDefault();
        window.location.href='Registration/register.html';
    });

    loginButton.addEventListener('click', (event) =>{
        event.preventDefault();
        window.location.href='Login/login.html';
    });
}