<?php

$username = "'".$_REQUEST['username']."'";  
$email = "'".$_REQUEST['email']."'"; 
$code = $_REQUEST['code']; 
$code1 = "'".$code."'";
$host = 'localhost';
$user = 'user'; 
$password = 'pass';
$db = 'n77391_db';
$table = 'users';
$con = mysqli_connect($host,$user,$password,$db);

if (!$con) {
      die("Connection failed: " . mysqli_connect_error());
}
 
echo "Connected successfully";
 
$sql = "INSERT INTO $table (username, code, email) VALUES ($username, $code1, $email)";
if (mysqli_query($con, $sql)) {
      echo "New record created successfully";
} else {
      echo "Error: " . $sql . "<br>" . mysqli_error($con);
}
mysqli_close($con);

$file = fopen($code."pos.txt", "w");
$file2 = fopen($code."em.txt", "w");
fwrite($file, "0");
fclose($file);
fclose($file2);

?>
