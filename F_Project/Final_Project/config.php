<?php

$conn = mysqli_connect(
"127.0.0.1",
"root",
"",
"metro_db",
3306
);

if(!$conn){
die("Connection failed");
}

?>