<?php
include 'config.php';

$name=$_POST['name'];
$email=$_POST['email'];
$subject=$_POST['subject'];
$message=$_POST['message'];

$sql="INSERT INTO messages VALUES
(NULL,'$name','$email','$subject','$message')";

$result=mysqli_query($conn,$sql);

if($result){
header("Location: contact.php?success=1");
exit();
}else{
die(mysqli_error($conn));
}
?>