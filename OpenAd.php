<?php
$str = 
$_REQUEST["Ad"];
$str3 = $str.".txt";
$str2 = htmlentities(file_get_contents("Ad.txt"));
echo $str2; 
?>
