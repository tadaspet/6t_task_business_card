window.onload = () => {

    //START Filtering All TODO list for active user
    const userName = sessionStorage.getItem('userName');
    const userIdSession = sessionStorage.getItem('userId');
    const userHeader = document.getElementById('currentUser');
    const userText = document.createElement('p');
    userText.innerHTML = `<p class="name">User: <b>${userName}</b></p>`;
    userHeader.append(userText);

    getAll().then(result => {
        showAllTodos(result,userIdSession);
    });
    //END of filtering All TODO list for active user

    //START of EDIT button
    const editcurrentButton = document.getElementById('editcurrent');

    editcurrentButton.addEventListener('click', () => {
        document.getElementById('delete').disabled = true;
        document.getElementById('addNew').disabled = true;
        editFormCreation(); //creating input form for edit options
        getAll().then(result => {
            let userIdToDoArray = createDropDownTypes(result,userIdSession); //sorted array by the unique value types property and
            const userIdToDoArrayPass = userIdToDoArray;
            const selectionLists = document.getElementById('selectionList');
            selectionLists.addEventListener('change', () =>{  //set when the types list is change and arranging children todo items CONTENT 
                createDropDownContents(selectionLists,userIdToDoArrayPass);
            });
        //saving selected value from the drop down each time it is changed.
        let optionItemValue;
        const activeItemSelection = document.getElementById('selectionItem');
        activeItemSelection.addEventListener('change', () => {
            let selectedIndex = selectionItem.selectedIndex;
            let optionItem = selectionItem.options[selectedIndex].value;
            optionItemValue = optionItem;
        });

        //Saving form after edit is finished by user
        const editSaveButton = document.getElementById('saveEdit');
        editSaveButton.addEventListener('click', (event)=>{
            event.preventDefault();
            //choice is compared the array and object ID is filtered
            let arrayId;
            for(let i = 0; i< userIdToDoArrayPass.length; i++){
                let trimedContent =userIdToDoArrayPass[i].content.trim();
                if(optionItemValue === trimedContent){
                    arrayId = i;
                }
            }
            const putItemBody = craetePutBody(arrayId, userIdToDoArrayPass);
            const URL = `https://localhost:7171/api/ToDo/${userIdToDoArrayPass[arrayId].id}`; //find item id to add to the end of url
            putOneID(URL,putItemBody);
            // getAll().then(result => {
            //     showAllTodos(result,userIdSession);
            // }); 
            location.reload(); 
            });

        });
    });
    //END of EDIT button

    //START of NEW button
    const addNewButton = document.getElementById('addNew');
    addNewButton.addEventListener('click',() => {
        document.getElementById('delete').disabled = true;
        document.getElementById('editcurrent').disabled = true;
        addNewFormCreation();
        getAll().then(result => {
            let userIdToDoArray = createDropDownTypes(result,userIdSession); //sorted array by the unique value types property and
            const userIdToDoArrayPass = userIdToDoArray;
            const selectionLists = document.getElementById('selectionList');
            let optionItemValue = null;
            selectionLists.addEventListener('change', () =>{  //set when the types list is change and arranging children todo items CONTENT 
                let selectedIndex = selectionList.selectedIndex;
                let optionItem = selectionList.options[selectedIndex].value;
                optionItemValue = optionItem;
                if(selectedIndex === 0){
                    document.getElementById('newType').disabled = false;
                } else{
                    document.getElementById('newType').disabled = true;
                };
            });
            const newSaveButton = document.getElementById('saveNew');
            newSaveButton.addEventListener('click', (event) =>{
                event.preventDefault();
                //choice is compared the array and object ID is filtered
                let arrayId = null;
                for(let i = 0; i< userIdToDoArrayPass.length; i++){
                    let trimedContent =userIdToDoArrayPass[i].type.trim();
                    if(optionItemValue === trimedContent){
                        arrayId = i;
                    }
                };
                const putItemBody = createPostBody(arrayId, userIdToDoArrayPass);
                const URL = `https://localhost:7171/api/ToDo`;
                postNewItem(URL, putItemBody);
                location.reload(); 
            });
        });
    });


    //END of NEW button

    //START of DELETE button
    const deleteButton = document.getElementById('delete');
    deleteButton.addEventListener('click', () =>{
        document.getElementById('editcurrent').disabled = true;
        document.getElementById('addNew').disabled = true;
        deleteFormCreation();
        getAll().then(result => {
            let userIdToDoArray = createDropDownTypes(result,userIdSession); //sorted array by the unique value types property and
            const userIdToDoArrayPass = userIdToDoArray;
            const selectionLists = document.getElementById('selectionList');
            selectionLists.addEventListener('change', () =>{  //set when the types list is change and arranging children todo items CONTENT 
                createDropDownContents(selectionLists,userIdToDoArrayPass);
            });
            //saving selected value from the drop down each time it is changed.
            let optionItemValue;
            const activeItemSelection = document.getElementById('selectionItem');
            activeItemSelection.addEventListener('change', () => {
                let selectedIndex = selectionItem.selectedIndex;
                let optionItem = selectionItem.options[selectedIndex].value;
                optionItemValue = optionItem;

            });

            const deleteButton = document.getElementById('saveDelete');
            deleteButton.addEventListener('click', (event)=>{
                event.preventDefault();
                //choice is compared the array and object ID is filtered
                let arrayId;
                for(let i = 0; i< userIdToDoArrayPass.length; i++){
                    let trimedContent =userIdToDoArrayPass[i].content.trim();
                    if(optionItemValue === trimedContent){
                        arrayId = i;
                    }
                }
                const URL = `https://localhost:7171/api/ToDo/${userIdToDoArrayPass[arrayId].id}`; //find item id to add to the end of url
                deleteOneID(URL);
                // getAll().then(result => {
                //     showAllTodos(result,userIdSession);
                // }); 
                location.reload(); 
            });

        });

    });
    //END of DELETE button

    //function to GET One ID
    async function getAll() {
        const getAllURL = `https://localhost:7171/api/ToDo`;
        try{
            const response = await fetch(getAllURL, {
                method: 'GET',
                headers: {
                    'Content-Type': 'application/json'
                }
            });
            const getData = await response.json();
            return getData;

        } catch (error) {
            console.log(error);
        }
    };
    //function to PUT only by ID
    async function putOneID(URL,putItemBody){
        try{
            fetch(URL,
                {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(putItemBody),
                })
                .then(async (response) => {
                    if (response.ok){
                        //const data = await response.json();
                    } else {
                        const text = await response.text ()
                        let obj = JSON.parse(text);
                        let message = obj.error;
                        const errorMessage = document.createElement('p');
                        errorMessage.innerHTML = `<p class="error">${message}</p>`;
                        form.prepend(errorMessage);
                    }
                })
                .then(result => {
                })
        } catch(error) {console.log(error.message)};
    };
    //function to POST One ID
    async function postNewItem(URL,postItemBody){
        try{
            fetch(URL,
                {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(postItemBody),
                })
                .then(async (response) => {
                    if (response.ok){
                        //const data = await response.json();
                    } else {
                        const text = await response.text ()
                        let obj = JSON.parse(text);
                        let message = obj.error;
                        const errorMessage = document.createElement('p');
                        errorMessage.innerHTML = `<p class="error">${message}</p>`;
                        form.prepend(errorMessage);
                    }
                })
                .then(result => {
                })
        } catch(error) {console.log(error.message)};
    };
    //function to DELETE One by ID
    async function deleteOneID(URL){
        try{
            fetch(URL,
                {
                    method: 'DELETE',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                })
                .then(async (response) => {
                    if (response.ok){
                        //const data = await response.json();
                    } else {
                        const text = await response.text ()
                        let obj = JSON.parse(text);
                        let message = obj.error;
                        const errorMessage = document.createElement('p');
                        errorMessage.innerHTML = `<p class="error">${message}</p>`;
                        form.prepend(errorMessage);
                    }
                })
                .then(result => {
                })
        } catch(error) {console.log(error.message)};
    };

    // create ToDo list drop down selections
    function createDropDownTypes(result,userId){
        const selectionLists = document.getElementById('selectionList');
        let userIdToDoArray= [];
        result.forEach(element => {
            if(element.userId === userId){
                userIdToDoArray.push(element);
            }
        });
        const typesList = [];
        for(let i =0; i<userIdToDoArray.length; i++){
            if(!typesList.includes(userIdToDoArray[i].type)){
                const typeListItem = document.createElement('option');
                typeListItem.innerHTML = `<option id="${userIdToDoArray[i].type}">${userIdToDoArray[i].type}</option>`;
                selectionLists.appendChild(typeListItem);
                typesList.push(userIdToDoArray[i].type);
            };
        };
        return userIdToDoArray;
    };
    // creates each to do list single items for drop down selection
    function createDropDownContents(selectionObject,userArray){
        const selectedType = selectionObject.value;
        const selectionItems = document.getElementById('selectionItem');
        selectionItems.innerHTML='';
        const contentListItem = document.createElement('option');
        contentListItem.innerHTML='<option value="">(select)</option>';
        selectionItems.append(contentListItem);
        for(let i = 0; i< userArray.length; i++){
            if(selectedType=== userArray[i].type){
                const contentListItem = document.createElement('option');
                contentListItem.innerHTML = `<option value="${userArray[i].id}">${userArray[i].content}</option>`;
                selectionItems.appendChild(contentListItem);
            }
        }
    };

    // function returns Body object for PUT method
    function craetePutBody(arrayId, userIdToDoArrayPass){
        const updatedContent = document.getElementById('editNewContent').value;
        const userEndDate = document.getElementById('editendDate').value;
        let updatedEndDate;
        if(userEndDate === ''){
            updatedEndDate = new Date();
        }else{
            updatedEndDate = new Date(userEndDate);
        }
        updatedEndDate.setHours(updatedEndDate.getHours() + 2);
        const updatedEndDateIso = updatedEndDate.toISOString();
        putItem = {
            userId: userIdSession,
            type: userIdToDoArrayPass[arrayId].type,
            content: updatedContent,
            endDate: updatedEndDateIso,
            id: userIdToDoArrayPass[arrayId].id,
        };
        return putItem;
    };

    // function returns Body object for POST method
    function createPostBody(arrayId,userIdToDoArrayPass){
        let typeInput;
        if(arrayId === null){
            typeInput = document.getElementById('newType').value;
        } else {
            typeInput = userIdToDoArrayPass[arrayId].type;
        };
        const newContent = document.getElementById('newContent').value;
        const userNewEndDate = document.getElementById('newendDate').value;
        let updatedNewEndDate;
        if(userNewEndDate === ''){
            updatedNewEndDate = new Date();
        }else{
            updatedNewEndDate = new Date(userNewEndDate);
        }
        updatedNewEndDate.setHours(updatedNewEndDate.getHours() + 2);
        const updatedNewEndDateIso = updatedNewEndDate.toISOString();
        postItem = {
            userId: userIdSession,
            type: typeInput,
            content: newContent,
            endDate: updatedNewEndDateIso,
        };
        return postItem;
    };

    // function to Print All ToDo lists
    function showAllTodos(result,userId){
        const mainLists = document.getElementById('lists');
        const todoDiv = document.getElementById('todoLists');
        todoDiv.innerHTML='';
        mainLists.append(todoDiv);
        let userIdToDoArray= [];
        result.forEach(element => {
            if(element.userId === userId){
                userIdToDoArray.push(element);
            }
        });

        const newList = document.createElement('ul');
        newList.innerHTML= `<ul id="mainList"></ul>`;
        todoDiv.append(newList);
        const typesList = [];
        for(let i =0; i<userIdToDoArray.length; i++){
            if(!typesList.includes(userIdToDoArray[i].type)){
                const liItem = document.createElement('li');
                liItem.innerHTML = `<li id="${userIdToDoArray[i].type}"><b>${userIdToDoArray[i].type}</b></li>
                <ul id="items${userIdToDoArray[i].type}"></ul>`;
                newList.appendChild(liItem);
                typesList.push(userIdToDoArray[i].type);
            };
        };
        for(let i =0; i<userIdToDoArray.length; i++){
                const liItem = document.createElement('li');
                const innerUl = document.getElementById(`items${userIdToDoArray[i].type}`);
                let dateStr;
                if(userIdToDoArray[i].endDate.length > 19){
                    dateStr = userIdToDoArray[i].endDate.slice(0,-7).replace('T', ' ');
                }else{
                    dateStr = userIdToDoArray[i].endDate.slice(0,-3).replace('T', ' ');
                }
                liItem.innerHTML = `<li id="${userIdToDoArray[i].id}">${dateStr} - ${userIdToDoArray[i].content}</li>`;
                innerUl.appendChild(liItem);
        };
    };

    //Create EDIT button Form
    function editFormCreation() {
        const aside = document.getElementById('topside');
        const subForm = document.getElementById('editNav');
        if(!subForm){
        const editForm = document.createElement('form');
        editForm.innerHTML = 
        `<form>
            <fieldset id="editNav" class="editsidetopBar">
                <label class="selectLabel" for="selectionList">ToDo Lists:</label>
                <select id="selectionList" name="selectionList" required>
                <option value="">(select)</option>
                </select>
                <br>
                <label class="selectLabel" for="selectionItem">ToDo Item:</label>
                <select id="selectionItem" name="selectionItem" required>
                <option value="">(select)</option>
                </select>
                <br>
                <label for="editNewContent">Edit Item:</label>
                <input type="text" id="editNewContent" name="editNewContent" required>
                <br>
                <label for="editendDate">End Date:</label>
                <input type="datetime-local" id="editendDate" name="editendDate" required>
                <br>
                <button type="submit" id="saveEdit">Save</button>
                <br>
            </fieldset>
        </form>
        <br><br>`;
        aside.append(editForm);
        }

    };
    //Create DELETE button Form
    function deleteFormCreation() {
        const navigationBar = document.getElementById('topside');
        const subForm = document.getElementById('deleteNav');
        if(!subForm){
        const editForm = document.createElement('form');
        editForm.innerHTML = 
        `<form>
            <fieldset id="deleteNav" class="deletesidetopBar">
                <label class="selectLabel" for="selectionList">ToDo Lists:</label>
                <select id="selectionList" name="selectionList" required>
                <option value="">(select)</option>
                </select>
                <br>
                <label class="selectLabel" for="selectionItem">ToDo Item:</label>
                <select id="selectionItem" name="selectionItem" required>
                <option value="">(select)</option>
                </select>
                <br>
                <button type="submit" id="saveDelete">Delete</button>
                <br>
            </fieldset>
        </form>
        <br><br>`;
        navigationBar.append(editForm);
        }
    };

    //Create ADD_NEW button Form
    function addNewFormCreation() {
        const navigationBar = document.getElementById('topside');
        const subForm = document.getElementById('newNav');
        if(!subForm){
        const editForm = document.createElement('form');
        editForm.innerHTML = 
        `<form>
            <fieldset id="newNav" class="deletesidetopBar">
                <label class="selectLabel" for="selectionList">Todo Lists:</label>
                <select id="selectionList" name="selectionList">
                <option value="">(create new)</option>
                </select>
                <br>
                <label for="newType">List Name:</label>
                <input type="text" id="newType" name="newType" required>
                <br>
                <label for="newContent">New ToDo:</label>
                <input type="text" id="newContent" name="newContent" required>
                <br>
                <label for="newendDate">End Date:</label>
                <input type="datetime-local" id="newendDate" name="newendDate" required>
                <br>
                <button type="submit" id="saveNew">Save</button>
                <br>
            </fieldset>
        </form>
        <br><br>`;
        navigationBar.append(editForm);
        }
    };
    
}