window.onload = () => {
const form = document.getElementById('registerForm');
const userNameInput = document.getElementById('inputUserName');
const userPasswordInput = document.getElementById('inputPassword');
const userEmailInput = document.getElementById('inputEmail');
const submitButton = document.getElementById('signupButton');
const requestURL = `https://localhost:7115/api/User/sign-up`;

submitButton.addEventListener('click', (event) =>{
        event.preventDefault();
        const UserForRegistration = {
            userName: userNameInput.value,
            password: userPasswordInput.value,
            email:	userEmailInput.value
            }
        fetch(requestURL,
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(UserForRegistration)
        })
        .then(async (response) => {
            if (response.ok){
                window.location.href='../login/login.html';
            } else {
                const text = await response.text ()
                let obj = JSON.parse(text);
                if (obj === "User not found.")
                {
                    appendAlert(obj, 'danger')
                } else if (obj === "Incorrect password.") {
                    appendAlert(obj, 'danger') 
                } else if (obj === "User already exists with provided email.") {
                    appendAlert(obj, 'danger') 
                }  else if (obj === "Username is already taken.") {
                    appendAlert(obj, 'danger') 
                } else {
                    let message = obj.errors;  
                    if (typeof message.Password !== "undefined")
                    {
                        appendAlert(message.Password, 'danger')
                    }
                    if (typeof message.UserName !== "undefined")
                    {
                        if(message.UserName.includes("The UserName field is required."))
                        {
                            appendAlert("The Username field is required.", 'danger')
                        } else {
                            appendAlert(message.UserName, 'danger')
                        }
                    }
                    if (typeof message.Email !== "undefined")
                    {
                        appendAlert(message.Email, 'danger')
                    }
                }
            }
        })
        .then(result => {
        })
        .catch((error) =>{
            if(error.message.includes('Failed to fetch')){
                window.location.href='../Errorpage/error.html';
            }
            console.log(error.message);
        });
    });

    const alertPlaceholder = document.getElementById('liveAlertPlaceholder')
    const appendAlert = (message, type) => {
      const wrapper = document.createElement('div')
      wrapper.innerHTML = [
        `<div class="alert alert-${type} alert-dismissible" role="alert">
           <div>${message}</div>
           <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        </div>`    
      ].join()
    
      alertPlaceholder.append(wrapper)
      setTimeout(() => {
        wrapper.remove()
    }, 5000)
    }    
}
