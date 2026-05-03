<?php
session_start();
include 'config.php';

$email = $_POST['email'];
$password = $_POST['password'];

$sql = "SELECT * FROM users WHERE email='$email'";
$result = mysqli_query($conn,$sql);

if(mysqli_num_rows($result) == 1){

    $user = mysqli_fetch_assoc($result);

    // مقارنة الباسورد المدخل بالمشفر في الداتابيز
    if(password_verify($password,$user['password'])){

        $_SESSION['user']=$user['name'];

        header("Location: index.html");
        exit();

    }else{
        echo "Invalid Email Or Password";
    }

}else{
    echo "Invalid Email Or Password";
}
?>