function check() {
    var email = document.getElementById("inputEmail3").value;
    var password = document.getElementById("inputPassword3").value;


    if (email === "" || email === null) { alert("Email is not entered"); return false };
    if (password === "" || password === null) { alert("Password is not entered"); return false };
    if (email != "admin@123.com") { alert("Email or Password is Incorrect!"); return false };
    if (password != "123") { alert("Email or Password is Incorrect!"); return false };


    return true;
}