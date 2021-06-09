<?php
$code = $_REQUEST["code"];
$file = $code."pos.txt";
$str2 = htmlentities(file_get_contents($file));
echo $str2; 
?>
