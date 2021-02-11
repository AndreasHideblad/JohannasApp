createExpCategoryForm.onsubmit = (e) => {
    e.preventDefault()
    console.log(e)
  
    let createExpCategoryObject = {
      id: e.target[0].value,
      name: e.target[1].value
    }
  
    fetch('https://localhost:44399/expensesCategories/create', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(createExpCategoryObject)
    })
  }

  getExpCategoryForm.onsubmit = (e) => {
    e.preventDefault()
    console.log(e)
  
    let getExpCategoryObject = {
      id: e.target[0].value,
      name: e.target[1].value
    }
  
    fetch('https://localhost:44399/expensesCategories/get', {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(getExpCategoryObject)
    })
  }