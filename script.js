function validateForm() {
    document.getElementById("myForm").submit();
}

function validateForm() {
    var x = document.forms["myForm"]["fname"].value;
    var y = document.script["myForm"]["email"].value;
 var xLen = x.length;
 var yLen = y.length; 
    if (xLen>20) {
        alert("Enter a valid name");
        return false;
    }
    else if(yLen>20)
    	alert("Enter a valid email address")
        return false;
}


function myFunction() {
    var x = document.createElement("SCRIPT");
    var t = document.createTextNode("alert('josediaz.arrechea@gmail.com')");
    x.appendChild(t);
    document.body.appendChild(x);
}