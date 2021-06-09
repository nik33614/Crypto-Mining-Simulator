<?php
$str = 
$_REQUEST["Place"];

if($str == "First")
{
	$place = "1";
	$intplace = "1. ";
	$place1="'1'";
}

if($str =="Second")
{
	$place = "2";
	$place1="'2'";
	$intplace = "2. ";
}

if($str =="Third")
{
	$place = "3";
	$place1="'3'";
	$intplace = "3. ";
}

if($str =="Forth")
{
	$place = "4";
	$place1="'4'";
	$intplace = "4. ";
}

if($str =="Fifth")
{
	$place = "5";
	$place1="'5'";
	$intplace = "5. ";
}

$host = 'localhost';
$user = 'user'; 
$password = 'pass';
$db = 'n77391_db';
$table = 'LeaderBoard';
$con = mysqli_connect($host,$user,$password,$db);

//$place="'".$str."'";
$query = "SELECT * FROM LeaderBoard WHERE place= ".$place1;
$result = mysqli_query($con,$query);
$yourArray = array();


while($row = mysqli_fetch_assoc($result)){
     $array[] = $row;
}

$plsq = $array[0]['username'];


//$place = $place.". ".
$str3 = $str.".txt";

$fd2 = fopen($str3, 'w');
	fwrite($fd2, $intplace.$plsq);
	fclose($fd2);



$str2 = htmlentities(file_get_contents($str3));
echo $str2; 

mysqli_close($con);
?>
