const inpCol= document.querySelector(".col");
const section =document.querySelector(".section");
section.style.backgroundColor=localStorage.getItem("color");
function display(value){
section.style.backgroundColor=value;
localStorage.setItem("color",value)
}
