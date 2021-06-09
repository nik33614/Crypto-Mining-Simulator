<?php
$str =
$_REQUEST["Profit"];
$fd = fopen("Profit.txt", 'a');
fwrite($fd, $str." ");
fclose($fd);
$str3 = "Information.txt";
$str2 = htmlentities(file_get_contents($str3));
echo $str2;
?>
