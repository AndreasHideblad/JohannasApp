loginForm.onsubmit = (e) =>{
    e.preventDefault()
    console.log(e)

    
}

registerForm.onsubmit = (e) =>{
    e.preventDefault()
    console.log(e)

    let regObject ={
        UserName: (e).target[0].value,
        Password: (e).target[1].value
    }

    fetch('http://localhost:44399/api/Register', {
      method: 'POST',
      headers: {
        //'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(
        regObject
    )})
}

var x = document.getElementById("loginForm");
var y = document.getElementById("registerForm");
var z = document.getElementById("btn");

function register(){
x.style.left = "-400px";
y.style.left = "50px";
z.style.left = "110px";
        }
function login(){
x.style.left = "50px";
y.style.left = "450px";
z.style.left = "0px";}