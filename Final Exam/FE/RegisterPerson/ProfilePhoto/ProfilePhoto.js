window.onload = () => {
    const userToken = sessionStorage.getItem('User');
    const getPersonInfoUrl = `https://localhost:7115/api/PersonInformation/UploadImage`;
    const buttonSavePhoto = document.getElementById('saveButtonPersonInfo');
    const inputPhoto = document.getElementById('PhotoFile');
    let userHasInfo = false;

    // getPersonPhoto(getPersonInfoUrl, userToken).then(result => {
    //     if(result !== "Image File not found.")
    //     {
    //         updateFormFields(result);
    //         userHasInfo = true;
    //     }
    // });


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
                    window.location.href='../MainHome/mainHome.html';
                } else {
                    const text = await response.text ()
                    let obj = JSON.parse(text);
                    console.log(obj);
                    if (typeof obj.errors.Image !== "undefined")
                    {
                            appendAlert(obj.errors.Image, 'danger')

                        
                    }
                    // if (obj.errors.Image.includes("The Image field is required.")) 
                    // {
                    //     appendAlert(obj.errors.Image, 'danger')
                    // }
                    // } else {
                    //     appendAlert("The max photo size is 5MB bytes.", 'danger')
                    // }
                    
                }
                    
            })
        .catch(error => console.log(error.message));


    });



    //GET method to return values
    async function getPersonPhoto(getPersonInfoUrl, userToken) {
    
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
        var inputElement = document.getElementById(id);
        if (inputElement) {
            inputElement.value = personInfo[id];
        }
    };


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