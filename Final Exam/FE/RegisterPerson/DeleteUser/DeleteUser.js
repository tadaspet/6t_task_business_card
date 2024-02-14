window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const deleteButton = document.getElementById('deleteUser');
    
    //turn back User if it has Logged Out
    hasUserToken();

    const decodedToken = JSON.parse(atob(userToken.split(".")[1]));
    addUserName(decodedToken);
    
    deleteButton.addEventListener('click', (event) =>{
        event.preventDefault();
        const inputGUID = document.getElementById('guid').value;
        if (isValidGUID(inputGUID)){
        const deleteUserUrl = `https://localhost:7115/api/User/${inputGUID}`;
        fetch(deleteUserUrl,
            {
                method: 'DELETE',
                headers: {
                    'Authorization': 'Bearer ' + userToken,
                },
            })
            .then(async (response) => {
                if (response.ok){
                    appendAlert("Success, User was deleted!", 'success');
                } else {
                    const text = await response.text ()
                    if (response.status === 204)
                    {
                        appendAlert("User was deleted", 'success')
                    }
                    if (response.status === 400)
                    {
                        appendAlert("User GUID number does not exist.", 'danger')
                    }
                    if (response.status === 404)
                    {
                        appendAlert("User was not found.", 'danger')
                    }
                }   
            })
            .catch(error => console.log(error.message));
        }else {
            appendAlert("Invalid GUID format!", 'danger');
            document.getElementById('DeleteUser').reset();
        }

    });

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
                `<a class="dropdown-item active" href="../../RegisterPerson/DeleteUser/DeleteUser.html" id="editDeletePersonLink">Delete Person</a>`
            ]
            innerDropDownNav.append(deleteDivider);
            innerDropDownNav.append(deleteUseroption);
        } 

    //delete Session storage
    const logoutLink = document.getElementById('editLogOutLink');
    logoutLink.addEventListener('click', (event) =>{
        event.preventDefault();
        sessionStorage.removeItem('User');
        window.location.href='../../mainIndex.html';
    });

    //add userName to the navigaiton bar
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

    //GUID  number validation
    function isValidGUID(guid) {
        const regex = /^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$/;
        return regex.test(guid);
    };

    function hasUserToken() {
        var tokenValue = sessionStorage.getItem('User');
        if(!tokenValue){
            window.location.href='../../mainIndex.html';
        }
    };
}