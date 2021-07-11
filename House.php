<?php

$strCode = 
$_REQUEST["code"];
$strcheck = 
$_REQUEST["check"];


$code = "'".$strCode."'";

$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = '3*FP#t&=<SCQi9jw';
$db = 'n77391_db';
$table = 'information';
$con = mysqli_connect($host,$user,$password,$db);


$query = "SELECT * FROM information WHERE code=".$code;

$result = mysqli_query($con,$query);

$yourArray = array();


while($row = mysqli_fetch_assoc($result)){
    $array[] = $row;
    
    echo $array[0]['house'];
    
}

mysqli_close($con);

?>
