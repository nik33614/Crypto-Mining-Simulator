<?php
//скрипт получения изменившегося дома и баланса доллара. работает в сценах покупки дома

$strCode = 
$_REQUEST["code"];

$code = "'".$strCode."'";

$strBalance = 
$_REQUEST["balance"];

$balance = "'".$strBalance."'";

$strHouse = 
$_REQUEST["house"];

$house = "'".$strHouse."'";


$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = '3*FP#t&=<SCQi9jw';
$db = 'n77391_db';
$table = 'information';
$con = mysqli_connect($host,$user,$password,$db);


$query = "UPDATE information SET house =".$house." WHERE code = ".$code;
$result = mysqli_query($con,$query);
$query1 = "UPDATE information SET balance =".$balance." WHERE code = ".$code;
$result1 = mysqli_query($con,$query1);

mysqli_close($con);
?>