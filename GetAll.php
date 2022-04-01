<?php

mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

$strCode = 
$_REQUEST["code"];

$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = 'pass';
$db = 'n77391_db';
$table = 'information';
$con = mysqli_connect($host,$user,$password,$db);

$str_ans = '';

$query = "SELECT * FROM information WHERE code= '".$strCode."'";
$result = mysqli_query($con,$query);
while($row = mysqli_fetch_assoc($result)){
    $array[] = $row;
}




$str_ans = $array[0]['pc']."_".$array[0]['pc']."_".$array[0]['graphic_up']."_".$array[0]['cpu_up']."_".$array[0]['mother_board_up']."_".$array[0]['power_up']."_";
$str_ans = $str_ans.$array[0]['bitcoin']."_".$array[0]['balance']."_".$array[0]['fan_timer']."_".$array[0]['fanupgrade']."_".$array[0]['house']."_";
$str_ans = $str_ans.$array[0]['profitold']."_".$array[0]['profit']."_".$array[0]['house_debit']."_".$array[0]['house_debit_int']."_".$array[0]['house_debit_time']."_";
$str_ans = $str_ans.$array[0]['pc_debit']."_".$array[0]['pc_debit_int']."_".$array[0]['pc_debit_time']."_".$array[0]['score']."_".$array[0]['salary']."_".$array[0]['salary_money']."_".$array[0]['salary_cost']."_";
$str_ans = $str_ans.$array[0]['time_work']."_".$array[0]['profit_inf'];
echo $str_ans;

mysqli_close($con);
?>