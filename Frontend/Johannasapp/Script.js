loginForm.onsubmit = (e) => {
  e.preventDefault()
  console.log(e)

  let logObject = {
    username: e.target[0].value,
    password: e.target[1].value
  }
  console.log(logObject)

  fetch('https://localhost:44399/user/login', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(logObject)
  })
  .then(response => 
  // .then(window.location = "Homepage.html")
  {if(response === Response.ok)
  {
    window.location = "Homepage.html"
  }
  else 
  {
    console.log(response.json())
  }})
}

registerForm.onsubmit = (e) => {
  e.preventDefault()
  console.log(e)

  let regObject = {
    username: e.target[0].value,
    password: e.target[1].value
  }

  fetch('https://localhost:44399/user/register', {
    method: 'POST',
    headers: {
      //'Accept': 'application/json',
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(regObject)
  })
}

var x = document.getElementById("loginForm");
var y = document.getElementById("registerForm");
var z = document.getElementById("btn");

function register() {
  x.style.left = "-400px";
  y.style.left = "50px";
  z.style.left = "110px";
}
function login() {
  x.style.left = "50px";
  y.style.left = "450px";
  z.style.left = "0px";
}