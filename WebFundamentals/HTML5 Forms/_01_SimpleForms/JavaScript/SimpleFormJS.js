function checkPasswordMatch() {
    var password = $("#pass").val();
    var confirmPassword = $("#confPass").val();

    if (password != confirmPassword) {
        alert("Passwords do not match!");
    }
 $(document).ready(function () {
   $("#confirmPass").keypress(checkPasswordMatch);
});
}