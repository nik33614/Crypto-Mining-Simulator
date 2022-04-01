<?php


$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = 'pass';
$db = 'n77391_db';

$date = date('d');
$sec = substr($date , 0,2);
$day = (int)$sec;

$check = (int)file_get_contents( 'day_check.txt');


if($day == 1 && $check == 0)
{
    
    $place = 0;
    mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
    $con = mysqli_connect($host,$user,$password,$db);
    $query = "SELECT username, varible, place
    FROM LeaderBoard
    ORDER BY varible DESC;";
    $result = mysqli_query($con,$query);
    $lead = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $lead[] = $row;

        $name = $lead[$place]["username"];
        $place += 1;

        $query1 = "SELECT * FROM users WHERE username= '".$name."'";
        $result1 = mysqli_query($con,$query1);
        $code = array();
        while($row = mysqli_fetch_assoc($result1))
        {
            $code[] = $row;

        }
        $code_us = $code[0]["code"];

        $query2 = "SELECT * FROM information WHERE code= '".$code_us."'";
        $result2 = mysqli_query($con,$query2);
        $balance_ar = array();
        while($row = mysqli_fetch_assoc($result2))
        {
            $balance_ar[] = $row;
        }

        $balance = $balance_ar[0]["balance"];
        if($place <= 10)
        {
            $y = (int)$balance + 500000;
            $query3 = "UPDATE information SET balance =".(string)$y." WHERE code = '".$code_us."'";
            $result3 = mysqli_query($con,$query3);
            $query4 = "UPDATE information SET profit_inf = 0 WHERE code = '".$code_us."'";
            $result4 = mysqli_query($con,$query4);
        }
        if($place <= 39 && $place > 10)
        {
            $y = (int)$balance + 300000;
            $query5 = "UPDATE information SET balance =".(string)$y." WHERE code = '".$code_us."'";
            $result5 = mysqli_query($con,$query5);
            $query6 = "UPDATE information SET profit_inf = 0 WHERE code = '".$code_us."'";
            $result6 = mysqli_query($con,$query6);
        }
        if($place <= 69 && $place > 39)
        {
            $y = (int)$balance + 100000;
            $query7 = "UPDATE information SET balance =".(string)$y." WHERE code = '".$code_us."'";
            $result7 = mysqli_query($con,$query7);
            $query8 = "UPDATE information SET profit_inf = 0 WHERE code = '".$code_us."'";
            $result8 = mysqli_query($con,$query8);
        }
        if($place <= 100 && $place > 69)
        {
            $y = (int)$balance + 50000;
            $query9 = "UPDATE information SET balance =".(string)$y." WHERE code = '".$code_us."'";
            $result9 = mysqli_query($con,$query9);
            $query10 = "UPDATE information SET profit_inf = 0 WHERE code = '".$code_us."'";
            $result10 = mysqli_query($con,$query10);
        }
        if($place > 100)
        {
            $y = (int)$balance + 5000;
            $query11 = "UPDATE information SET balance =".(string)$y." WHERE code = '".$code_us."'";
            $result11 = mysqli_query($con,$query11);
            $query12 = "UPDATE information SET profit_inf = 0 WHERE code = '".$code_us."'";
            $result12 = mysqli_query($con,$query12);

            $fd2 = fopen("day_check.txt", 'w');
	        fwrite($fd2, '1');
	        fclose($fd2);
          
        }
        
    }
    $query13 = "delete from LeaderBoard";
    $result13 = mysqli_query($con,$query13);
    $query15 = "UPDATE information SET profit_inf = NULL";
    $result15 = mysqli_query($con,$query15);

    mysqli_close($con);

}
if($day != 1)
{
    $fd2 = fopen("day_check.txt", 'w');
	fwrite($fd2, '0');
	fclose($fd2);
    
}


?>