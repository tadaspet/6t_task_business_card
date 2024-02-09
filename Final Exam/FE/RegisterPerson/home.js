window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const saveButton = document.getElementById('saveButtonPersonInfo');
    const inputName = document.getElementById('name');
    const inputSurName = document.getElementById('surname');
    const inputIdentCode = document.getElementById('identityCode');
    const inputPhone = document.getElementById('phoneNo');
    const inputEmail = document.getElementById('email');
    const inputPhotoFile = document.getElementById('PhotoFile');
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
                    window.location.href='../login/login.html';
                } else {
                    const text = await response.text ()
                    let obj = JSON.parse(text);
                    console.log(obj);
                    //debugger;
                    if (obj.errors)
                    {
                        console.log(obj)
                    //} else if (obj === "Incorrect password.") {
                    //     console.log(obj)
                    //     appendAlert(obj, 'danger') 
                    // } else if (obj === "User already exists with provided email.") {
                    //     appendAlert(obj, 'danger') 
                    // }  else if (obj === "Username is already taken.") {
                    //    appendAlert(obj, 'danger') 
                    } else {
                        let message = obj.errors;  
                        if (typeof message.Name !== "undefined")
                        {
                            console.log(message.Name)
                            appendAlert(message.Password, 'danger')
                        }
                        if (typeof message.Surname !== "undefined")
                        {
                            console.log(message.Surname)
                            if(message.Surname.includes("The UserName field is required."))
                            {
                                appendAlert("The Username field is required.", 'danger')
                            } else {
                                appendAlert(message.Surname, 'danger')
                            }
                        }
                        if (typeof message.Email !== "undefined")
                        {
                            console.log(message.Email)
                            appendAlert(message.Email, 'danger')
                        }
                    }
                }
            })
            .then(result => {
            })
            .catch(error => console.log(error.errors));
        }
    })
    

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
    function updateFormFields(personInfo) {
        const personInfoProp = ["name","surname", "identityCode", "phoneNo", "email"];
        for (var i = 0; i < personInfoProp.length; i++) {
            var id = personInfoProp[i];
            var inputElement = document.getElementById(id);
            if (inputElement) {
                inputElement.value = personInfo[id];
            }
        }
    } 

    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

}