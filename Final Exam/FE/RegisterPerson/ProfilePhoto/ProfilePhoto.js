window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const getPersonInfoUrl = `https://localhost:7115/api/PersonInformation/UploadImage`;
    const buttonSavePhoto = document.getElementById('saveButtonPersonInfo');
    const inputPhoto = document.getElementById('PhotoFile');
    const getPersonImageUrl = `https://localhost:7115/api/PersonInformation/DownloadImage`;
    const currentImage = document.getElementById('personImage');

    //turn back User if it has Logged Out
    hasUserToken();

    const decodedToken = JSON.parse(atob(userToken.split(".")[1]));
    addUserName(decodedToken);

    getImage(getPersonImageUrl, userToken).then(result => {
        if(result[0].status === 200)
        {
            const imageUrl = URL.createObjectURL(result[1]);
            currentImage.src = imageUrl;
        } else {
            currentImage.src = "/Images/defaultprofile.png";
        }
    });

    buttonSavePhoto.addEventListener('click', (event) =>{
        event.preventDefault();

        var formData = new FormData();
        formData.append("Image", inputPhoto.files[0])
        fetch(getPersonInfoUrl,
            {
                method: 'POST',
                headers: {
                    'Authorization': 'Bearer ' + userToken
                },
                body: formData
            })                    
            .then(async (response) => {
                if (response.ok){
                    appendAlert("Success, Image was added!", 'success');
                    getImage(getPersonImageUrl, userToken).then(result => {
                        if(result[0].status === 200){
                            const imageUrl = URL.createObjectURL(result[1]);
                            currentImage.src = imageUrl;
                        }
                    });
                } else {
                    const text = await response.text ()
                    let obj = JSON.parse(text);
                    console.log(obj);
                    if (typeof obj.errors.Image !== "undefined")
                    {
                        if(obj.errors.Image.length > 1)
                        {
                            appendAlert(obj.errors.Image[0], 'danger')
                            appendAlert(obj.errors.Image[1], 'danger')
                        }else{
                            appendAlert(obj.errors.Image, 'danger')
                        }
                    }                    
                }                    
            })
        .catch(error => console.log(error.message));
    });

    //GET method to return Image file
    async function getImage(getPersonImageUrl, userToken) {
        try{
            const response = await fetch(getPersonImageUrl, {
                method: 'GET',
                headers: {
                    'Authorization': 'Bearer ' + userToken,
                },
                redirect: 'follow'
            });
            const getImage = await response.blob();
            const responseArray = [response, getImage];
            return responseArray;
        } catch (error) {
            console.log(error);
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
        window.location.href='../../mainIndex.html';
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
    };

    //tool tips over the input fields
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

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

    function hasUserToken() {
        var tokenValue = sessionStorage.getItem('User');
        if(!tokenValue){
            window.location.href='../../mainIndex.html';
        }
    };
}