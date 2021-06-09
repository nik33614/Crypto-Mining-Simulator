<?php

$code = $_REQUEST["code"];
$em = $_REQUEST["em"]."";
$file = $code."em.txt";
$str2 = htmlentities(file_get_contents($file));
$em1 = (int)$em;
$str3 = (int)$str2;
if($em1 == $str3)
{
	echo "ok";
	
	$file = fopen($code."pos.txt", "w");
	fwrite($file, "1");
	fclose($file);
}
else
{

	echo"no";
}
?>
