window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const getPersonSettlementUrl = `https://localhost:7115/api/Settlement`;
    let userHasInfo = false;
    const saveButton = document.getElementById('saveButtonSttlement');
    const flatNo = "N/A";
    
    const decodedToken = JSON.parse(atob(userToken.split(".")[1]));
    addUserName(decodedToken);

    
    getSettlement(getPersonSettlementUrl, userToken).then(result => {
        if(result[0].status === 200)
        {
            updateSettlementFields(result[1]);
            userHasInfo = true;
        }
    });


    saveButton.addEventListener('click', (event) =>{
        event.preventDefault();
        if(document.getElementById('flatNo').value.length < 1){
            const flatNo = "N/A";
        } else {
            const flatNo = document.getElementById('flatNo').value;
        }
        const inputBody = {
            city : document.getElementById('city').value,
            street : document.getElementById('street').value,
            buildingNo : document.getElementById('buildingNo').value,
            flatNo : flatNo
        }
        if(userHasInfo === true)
        {
            //PUT method
                fetch(getPersonSettlementUrl,
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
                        appendAlert("Success, information was updated!", 'success');
                    } else {
                        const text = await response.text ()
                        let obj = JSON.parse(text);
                        if (typeof obj.errors.City !== "undefined")
                        {
                            if(obj.errors.City.includes("The City field is required."))
                            {
                                appendAlert("The City field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.City, 'danger')
                            }
                        }
                        if (typeof obj.errors.Street !== "undefined")
                        {
                            if(obj.errors.Street.includes("The Street field is required."))
                            {
                                appendAlert("The Street field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.Street, 'danger')
                            }
                        }
                        if (typeof obj.errors.BuildingNo !== "undefined")
                        {
                            if(obj.errors.BuildingNo.includes("The BuildingNo field is required."))
                            {
                                appendAlert("The Building Number field is required.", 'danger')
                            } else {
                                appendAlert(obj.errors.BuildingNo, 'danger')
                            }
                        }
                        if (typeof obj.errors.FlatNo !== "undefined")
                        {
                                appendAlert(obj.errors.FlatNo, 'danger')
                        } 
                    }   
                })
                .catch(error => console.log(error.message));
            } else {
                fetch(getPersonSettlementUrl,
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
                            appendAlert("Success, information was added!", 'success');
                        } else {
                            const text = await response.text ()
                            let obj = JSON.parse(text);
                            if (typeof obj.errors.City !== "undefined")
                            {
                                if(obj.errors.City.includes("The City field is required."))
                                {
                                    appendAlert("The City field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.City, 'danger')
                                }
                            }
                            if (typeof obj.errors.Street !== "undefined")
                            {
                                if(obj.errors.Street.includes("The Street field is required."))
                                {
                                    appendAlert("The Street field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.Street, 'danger')
                                }
                            }
                            if (typeof obj.errors.BuildingNo !== "undefined")
                            {
                                if(obj.errors.BuildingNo.includes("The BuildingNo field is required."))
                                {
                                    appendAlert("The Building Number field is required.", 'danger')
                                } else {
                                    appendAlert(obj.errors.BuildingNo, 'danger')
                                }
                            }
                            if (typeof obj.errors.FlatNo !== "undefined")
                            {
                                    appendAlert(obj.errors.FlatNo, 'danger')
                            }                            
                        }                            
                    })
                .catch(error => console.log(error.message));
            }
        })

    //GET method to return Settlement Info
    async function getSettlement(getPersonSettlementUrl, userToken) {
        try{
            const response = await fetch(getPersonSettlementUrl, {
                method: 'GET',
                headers: {
                    'Authorization': 'Bearer ' + userToken,
                    'Content-Type': 'application/json'
                },
            });
            const getData = await response.json();
            const responseArray = [response, getData];
            return responseArray;
        } catch (error) {
            console.log(error);
        }
    };

    //fill in the form fields from GET Settlement
    function updateSettlementFields(settlementInfo) {
        const settlemenInfoProp = ["city","street", "buildingNo", "flatNo"];
        for (var i = 0; i < settlemenInfoProp.length; i++) {
            var id = settlemenInfoProp[i];
            var inputElement = document.getElementById(id);
            if (inputElement && settlementInfo[id].length > 0) {
                inputElement.value = settlementInfo[id];
            } else if (inputElement) {
                inputElement.value = 'N/A';
            }
        }
    };

    //alert message box
    const alertPlaceholder = document.getElementById('liveAlertPlaceholder')
    const appendAlert = (message, type) => {
        const wrapper = document.createElement('div')
        if(type === 'danger'){
            wrapper.innerHTML = [
            `<div class="alert alert-${type} alert-dismissible" role="alert">
                <div>${message}</div>
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>`    
            ].join()
            alertPlaceholder.append(wrapper)
            setTimeout(() => {
            wrapper.remove()
        }, 5000);
        } else {
        wrapper.innerHTML = [
            `<div class="alert alert-${type} alert-dismissible" role="alert">
                <div>${message}</div>
            </div>`    
            ].join()

            alertPlaceholder.append(wrapper)
            setTimeout(() => {
            wrapper.remove()
            window.location.href='../../RegisterPerson/Overview/Overview.html';   
        }, 3500);
        }
    };

    //delete Session storage
    const logoutLink = document.getElementById('editLogOutLink');
    logoutLink.addEventListener('click', (event) =>{
        event.preventDefault();
        sessionStorage.removeItem('User');
        window.location.href='../../Login/login.html';
    });

    //enable the delete navigation for user.
    const isUserAdmin = () => {
    const role = decodedToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
    return role === "Admin";
    };

    if (isUserAdmin()) {        
        const innerDropDownNav = document.getElementById('innerDropDown');
        const deleteDivider = document.createElement('li');
        const deleteUseroption = document.createElement('li');
        deleteDivider.innerHTML = [
            `<hr class="dropdown-divider">`
        ]
        deleteUseroption.innerHTML = [
            `<a class="dropdown-item" href="../../RegisterPerson/DeleteUser/DeleteUser.html" id="editDeletePersonLink">Delete Person</a>`
        ]
        innerDropDownNav.append(deleteDivider);
        innerDropDownNav.append(deleteUseroption);
    } 

    function addUserName(decodedToken) {
        const userName = decodedToken["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];
        const homepageString = `${userName} overview`;

        const homePageObject = document.getElementById('overview1');
        const homePageObject2 = document.getElementById('overview2');
        if (userName.length > 0){
            homePageObject.textContent = homepageString;
            homePageObject2.textContent = homepageString;
        }
    };
}