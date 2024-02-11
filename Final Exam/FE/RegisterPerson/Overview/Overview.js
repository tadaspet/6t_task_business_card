window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const currentImage = document.getElementById('personImage');
    const getPersonInfoUrl = `https://localhost:7115/api/PersonInformation`;
    const getPersonImageUrl = `https://localhost:7115/api/PersonInformation/DownloadImage`;
    const getPersonSettlementUrl = `https://localhost:7115/api/Settlement`;
    
    const decodedToken = JSON.parse(atob(userToken.split(".")[1]));
    addUserName(decodedToken);
    
    getPersonInfo(getPersonInfoUrl, userToken).then(result => {
        if(result[0].status === 200)
        {
            //const data = result.json();
            updatePersonInfoFields(result[1]);
        } else {
            document.getElementById('editSettlementInfoLink').classList.add('disabled');
            document.getElementById('editPhotoLink').classList.add('disabled');
        }
    });
    
    
    getSettlement(getPersonSettlementUrl, userToken).then(result => {
        if(result[0].status === 200)
        {
            updateSettlementFields(result[1]);
        }
    });
    
    getImage(getPersonImageUrl, userToken).then(result => {
        if(result[0].status === 200)
        {
            const imageUrl = URL.createObjectURL(result[1]);
            currentImage.src = imageUrl;
        } else {
            currentImage.src = "/Images/defaultprofile.jpg";
        }
    });

    //GET method to return Person Info
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
            const responseArray = [response, getData];
            return responseArray;
        } catch (error) {
            console.log(error);
        }
    };

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

    //fill in the form fields from GET PersonInfo
    function updatePersonInfoFields(personInfo) {
        const personInfoProp = ["name","surname", "identityCode", "phoneNo", "email"];
        for (var i = 0; i < personInfoProp.length; i++) {
            var id = personInfoProp[i];
            var inputElement = document.getElementById(id);
            if (inputElement) {
                inputElement.textContent = personInfo[id];
            }
        }
    };

    //fill in the form fields from GET Settlement
    function updateSettlementFields(settlementInfo) {
        const settlemenInfoProp = ["city","street", "buildingNo", "flatNo"];
        for (var i = 0; i < settlemenInfoProp.length; i++) {
            var id = settlemenInfoProp[i];
            var inputElement = document.getElementById(id);
            if (inputElement) {
                inputElement.textContent = settlementInfo[id];
            }
        }
    };

    //delete Session storage
    const logoutLink = document.getElementById('editLogOutLink');
    logoutLink.addEventListener('click', (event) =>{
        event.preventDefault();
        sessionStorage.removeItem('User');
        window.location.href='../../Login/login.html';
    });

    //enable the delete button for user.
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
            `<a class="dropdown-item" href="#" id="editDeletePersonLink">Delete Person</a>`
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