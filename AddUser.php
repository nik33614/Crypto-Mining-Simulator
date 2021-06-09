<?php
$code = $_REQUEST['code'];  
$PC = $_REQUEST['pc'];  
$upgrades = $_REQUEST['upgrades'];  
$money = $_REQUEST['money'];  
$bitcoin = $_REQUEST['bitcoin']; 
$profit = $_REQUEST['profit'];   
$file = fopen($code."inf.txt", "w");
fwrite($file, $PC);
fwrite($file, $upgrades);
fwrite($file, $money);
fwrite($file, $bitcoin);
fwrite($file, $profit);
fclose($file);
echo "OK";
?>
