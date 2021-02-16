incomeForm.onsubmit = (e) => {
    e.preventDefault()
    console.log(e)
  
    let incomeObj = {
      name: e.target[0].value,
      price: e.target[1].value,
    }
  
    fetch('https://localhost:44399/Income', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(incomeObj)
    })
  }
