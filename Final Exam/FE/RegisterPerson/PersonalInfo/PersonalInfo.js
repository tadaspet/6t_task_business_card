window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const saveButton = document.getElementById('saveButtonPersonInfo');
    const inputName = document.getElementById('name');
    const inputSurName = document.getElementById('surname');
    const inputIdentCode = document.getElementById('identityCode');
    const inputPhone = document.getElementById('phoneNo');
    const inputEmail = document.getElementById('email');
    const getPersonInfoUrl = `https://localhost:7115/api/PersonInformation`;
    let userHasInfo = false;
    
    getPersonInfo(getPersonInfoUrl, userToken).then(result => {
        if(result !== "Person Information was not found.")
        {
            updateFormFields(result);
            userHasInfo = true;
        }
    });
    
    saveButton.addEventListener('click', (event) =>{
        event.preventDefault();
        
        const inputBody = {
            name : inputName.value,
            surname : inputSurName.value,
            identityCode : inputIdentCode.value,
            phoneNo : inputPhone.value,
            email : inputEmail.value
        }
        if(userHasInfo === true)
        {
            //PUT method
                fetch(getPersonInfoUrl,
                {
                    method: 'PUT',
                    headers: {
                        'Authorization': 'Bearer ' + userToken,
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(inputBody)
                })
                .then(async (response) => {
                    if (response.ok){
                        window.location.href='../MainHome/mainHome.html';
                    } else {
                        const text = await response.text ()
                        let obj = JSON.parse(text);
                        console.log(obj);
                        if (typeof obj.errors.Name !== "undefined")
                        {
                            if(obj.errors.Name.includes("The Name field is required."))
                            {
                                appendAlert("The Name field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.Name, 'danger')
                            }
                        }
                        if (typeof obj.errors.Surname !== "undefined")
                        {
                            if(obj.errors.Surname.includes("The Surname field is required."))
                            {
                                appendAlert("The Surname field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.Surname, 'danger')
                            }
                        }
                        if (typeof obj.errors.IdentityCode !== "undefined")
                        {
                            if(obj.errors.IdentityCode.includes("The IdentityCode field is required."))
                            {
                                appendAlert("The Identity code field is required.", 'danger')
                            } else {
                                appendAlert("Identity code can't be longer than 20 characters and shorter than 10 characters.", 'danger')
                            }
                        }
                        if (typeof obj.errors.PhoneNo !== "undefined")
                        {
                            if(obj.errors.PhoneNo.includes("The PhoneNo field is required."))
                            {
                                appendAlert("The Phone number field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.PhoneNo, 'danger')
                            }
                        }
                        if (typeof obj.errors.Email !== "undefined")
                        {
                            if(obj.errors.Email.includes("The Email field is required."))
                            {
                                appendAlert("The Email field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.Email, 'danger')
                            }
                        }
                    }
                        
                })
                .catch(error => console.log(error.message));
            } else {
                fetch(getPersonInfoUrl,
                    {
                        method: 'POST',
                        headers: {
                            'Authorization': 'Bearer ' + userToken,
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(inputBody)
                    })                    
                    .then(async (response) => {
                        if (response.ok){
                            window.location.href='../MainHome/mainHome.html';
                        } else {
                            const text = await response.text ()
                            let obj = JSON.parse(text);
                            console.log(obj);
                            if (typeof obj.errors.Name !== "undefined")
                            {
                                if(obj.errors.Name.includes("The Name field is required."))
                                {
                                    appendAlert("The Name field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.Name, 'danger')
                                }
                            }
                            if (typeof obj.errors.Surname !== "undefined")
                            {
                                if(obj.errors.Surname.includes("The Surname field is required."))
                                {
                                    appendAlert("The Surname field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.Surname, 'danger')
                                }
                            }
                            if (typeof obj.errors.IdentityCode !== "undefined")
                            {
                                if(obj.errors.IdentityCode.includes("The IdentityCode field is required."))
                                {
                                    appendAlert("The Identity code field is required.", 'danger')
                                } else {
                                    appendAlert("Identity code can't be longer than 20 characters and shorter than 10 characters.", 'danger')
                                }
                            }
                            if (typeof obj.errors.PhoneNo !== "undefined")
                            {
                                if(obj.errors.PhoneNo.includes("The PhoneNo field is required."))
                                {
                                    appendAlert("The Phone number field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.PhoneNo, 'danger')
                                }
                            }
                            if (typeof obj.errors.Email !== "undefined")
                            {
                                if(obj.errors.Email.includes("The Email field is required."))
                                {
                                    appendAlert("The Email field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.Email, 'danger')
                                }
                            }
                        }
                            
                    })
                .catch(error => console.log(error.message));
            }
        })
    
    //GET method to return values
    async function getPersonInfo(getPersonInfoUrl, userToken) {
        
        try{
            const response = await fetch(getPersonInfoUrl, {
                method: 'GET',
                headers: {
                    'Authorization': 'Bearer ' + userToken,
                    'Content-Type': 'application/json'
                },
            });
            const getData = await response.json();
            return getData;

        } catch (error) {
            console.log(error);
        }
    };


    //fill in the form fields from GET 
    function updateFormFields(personInfo) {
        const personInfoProp = ["name","surname", "identityCode", "phoneNo", "email"];
        for (var i = 0; i < personInfoProp.length; i++) {
            var id = personInfoProp[i];
            var inputElement = document.getElementById(id);
            if (inputElement) {
                inputElement.value = personInfo[id];
            }
        }
    };

    //alert message box
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
    };

    //tool tips over the input fields
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

}