// function change(){
//    var x = document.getElementById("boxLogin");
//    if(x.style.display===block){
//        x.style.display= none;
//    }else{
//        x.style.display = block;
//    }
// }

// const change = ()=>{
//     console.log("byter fönster")
//     const form = document.getElementById("boxLogin");

//     if (form.getElementById("boxLogin").contains("boxLogin")){
//         form.getElementById("boxLogin").remove("boxLogin")
//         form.getElementById("boxSignup").add("boxSignup")
//     }else {
//         form.getElementById("boxSignup").remove("boxSignup")
//         form.getElementById("boxLogin").add("boxLogin")
//     }
// }
//     function change(){
//         var modal = document.getElementById("boxLogin")
//         window.onclick = function(event){
//         if(event.target == modal){
//         modal.style.display="none"
//         }
//     }
// }

Login.onsubmit = (e) => {
    e.preventDefault()
    let user = {UserName, Password}
}


var password = document.getElementById("password")
  , confirm_password = document.getElementById("confirm_password");

function validatePassword(){
  if(password.value != confirm_password.value) {
    confirm_password.setCustomValidity("Passwords Don't Match");
  } else {
    confirm_password.setCustomValidity('');
  }
}

password.onchange = validatePassword;
confirm_password.onkeyup = validatePassword;

