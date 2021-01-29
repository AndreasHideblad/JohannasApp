const getData = () => {
    fetch('https://jsonplaceholder.typicode.com/todos/1')
        .then(response => response.json())
        .then(json => console.log(json))
    console.log('hej')
}


const timeout = () => {
    setTimeout(() => console.log('hej'), 3000)
}

const getData = () => {
    timeout();
    console.log('då')
}



let para = document.createElement('p');
let node = document.createTextNode('Lite text...');
para.appendChild(node);

let element = document.getElementById('div1');
element.appendChild(p);


const data = { username: 'example' };

fetch('https://example.com/profile', {
  method: 'POST', // or 'PUT'
  headers: {
    'Content-Type': 'application/json',
  },
  body: JSON.stringify(data),
})
.then(response => response.json())
.then(data => {
  console.log('Success:', data);
})
.catch((error) => {
  console.error('Error:', error);
});