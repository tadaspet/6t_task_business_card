window.onload = () => {
    const form = document.getElementById('loginForm');
    const userNameInput = document.getElementById('inputUserName');
    const userPasswordInput = document.getElementById('inputPassword');
    const submitButton = document.getElementById('login');

    submitButton.addEventListener('click', (event) =>{
        event.preventDefault();
        const postLoginItem = {
            username: userNameInput.value,
            password: userPasswordInput.value
        }
        const requestURL = `https://localhost:7115/api/User/login`;        
        fetch(requestURL,
            {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(postLoginItem),
            })
        .then(async (response) => {
            if (response.ok){
                const data = await response.json();
                sessionStorage.setItem('User', data);
                window.location.href='../RegisterPerson/ProfilePhoto/ProfilePhoto.html';
            } else {
                // deleteError();
                const text = await response.text ()
                let obj = JSON.parse(text);
                if (obj === "User not found.")
                {
                    appendAlert(obj, 'danger')
                }  else if (obj === "Incorrect password.") {
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
                }

            }
        })
        .catch(error => console.log(error.message));
    })

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

    