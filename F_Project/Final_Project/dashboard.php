<?php
include 'config.php';

$sql = "SELECT * FROM messages";
$result = mysqli_query($conn,$sql);
?>

<!DOCTYPE html>
<html>
<head>
<title>Dashboard</title>
<style>
table{
width:80%;
margin:30px auto;
border-collapse:collapse;
}
th,td{
border:1px solid #ddd;
padding:12px;
text-align:center;
}
th{
background:#222;
color:white;
}
</style>
</head>
<body>

<h2 align="center">Contact Messages</h2>

<table>
<tr>
<th>ID</th>
<th>Name</th>
<th>Email</th>
<th>Subject</th>
<th>Message</th>
</tr>

<?php
while($row=mysqli_fetch_assoc($result)){
?>
<tr>
<td><?php echo $row['id']; ?></td>
<td><?php echo $row['name']; ?></td>
<td><?php echo $row['email']; ?></td>
<td><?php echo $row['subject']; ?></td>
<td><?php echo $row['message']; ?></td>
</tr>

<?php } ?>

</table>

</body>
</html>