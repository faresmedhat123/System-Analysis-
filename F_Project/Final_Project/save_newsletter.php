<?php
include 'config.php';

if(isset($_POST['email'])){

$email = $_POST['email'];

$sql = "INSERT INTO newsletter(email)
VALUES('$email')";

if(mysqli_query($conn,$sql)){
 echo "Subscribed Successfully";
}else{
 echo "Error";
}

}else{
 echo "Access Denied";
}
?>