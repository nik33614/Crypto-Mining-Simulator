<?php
//скрипт получения изменившегося дома и баланса доллара. работает в сценах покупки дома

$strCode = 
$_REQUEST["code"];

$code = "'".$strCode."'";

$strBit = 
$_REQUEST["bitcoin"];

$bit = "'".$strBit."'";


$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = '3*FP#t&=<SCQi9jw';
$db = 'n77391_db';
$table = 'information';
$con = mysqli_connect($host,$user,$password,$db);

$query1 = "SELECT * FROM `information` WHERE code = ".$code;
$result1 = mysqli_query($con,$query1);
if(mysqli_num_rows($result1) > 0)
{
    
}
else
{
    $query2 = "UPDATE information SET code =".$code." WHERE code = '0'";
    $result2 = mysqli_query($con,$query2);
}

$query = "UPDATE information SET bitcoin =".$bit." WHERE code = ".$code;
$result = mysqli_query($con,$query);


mysqli_close($con);
?>