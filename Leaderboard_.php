<?php



$strName = 
$_REQUEST["name"];

$pl = "2890";

$strMoney1 = 
$_REQUEST["money"];
$strMoney2 = implode(".",explode(",",$strMoney1));
$strMoney = implode(".",explode("/",$strMoney2));

$strTutorial = 
$_REQUEST["tutorial"];

$strFile_Name = $strName.".txt";
$strPlace_Name = $strName."place".".txt";

$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = 'pass';
$db = 'n77391_db';
$table = 'LeaderBoard';
$con = mysqli_connect($host,$user,$password,$db);
$username = "'".$strName."'";



$query365 = "SELECT * FROM LeaderBoard WHERE username=".$username;
$result365 = mysqli_query($con,$query365);
$YourArray32 = array();


while($row = mysqli_fetch_assoc($result365))
{
    	
   $array32[] = $row;
    
}
if($array32[0]['username'] !="" && $strTutorial == 0)
{
     echo "True";
}

else
{
	
	$fd1 = fopen($strPlace_Name, 'w');
	fwrite($fd1, $pl);
	fclose($fd1);
    
    $fd = fopen($strFile_Name, 'w');
	fwrite($fd, $strMoney);
	fclose($fd);
	
	$strPlace = $pl;
	
    $username = "'".$strName."'";
    $varible = "'".$strMoney."'";
    $place = "'".$strPlace."'";

	

    $query36 = "SELECT * FROM LeaderBoard WHERE username=".$username;
    $result36 = mysqli_query($con,$query36);
    $YourArray = array();


    while($row = mysqli_fetch_assoc($result36))
    {
    	
        $array[] = $row;
    
    }
    if($array[0]['username'] !="")
    {
    	if((float)$array[0]['varible'] < (float)$strMoney)
        {
            
	            $query5 = "UPDATE LeaderBoard
	            SET varible = replace(varible, ".$array[0]['varible'] .", ".$strMoney.")
	            WHERE username = ".$username;
	            $result5 = mysqli_query($con,$query5);
        }
    
    }
    
    else
    {
        $sqlop = "INSERT INTO LeaderBoard (username, varible, place) VALUES ($username, $varible, $place);";
        $result57 = mysqli_query($con,$sqlop);
    }


}
$query1 = "DELETE FROM LeaderBoard
 WHERE varible NOT IN (SELECT * 
                    FROM (SELECT MAX(n.varible)
                            FROM LeaderBoard n
                        GROUP BY n.username) x)";
$result1 = mysqli_query($con,$query1);

$query3 = "SELECT username, varible, place
FROM LeaderBoard
ORDER BY varible DESC;";
$result3 = mysqli_query($con,$query3);
$YourArray1 = array();


while($row = mysqli_fetch_assoc($result3))
{
     $array1[] = $row;
}

for ($i = 0; $i < count($array1); $i++)
{
	
	$strname = $array1[$i]['username'];
	$strplace = $array1[$i]['place'];
	$strrplace = "'".$strplace."'";
	$strrname = "'".$strname."'";
	$b++;

	$stringplace = (string)$b;
	
	$strpplace = "'".$stringplace."'";
	$query5 = "UPDATE LeaderBoard
	SET place = replace(place, ".$strrplace.", ".$strpplace.")
	WHERE username = ".$strrname;
	$result5 = mysqli_query($con,$query5);
	
	
	$strfilename = $strname."place.txt";
	$fd4 = fopen($strfilename, 'w');
	fwrite($fd4, $strplace);
	fclose($fd4);
		

}

$query362 = "SELECT * FROM LeaderBoard WHERE username=".$username;
$result362 = mysqli_query($con,$query362);
$YourArray = array();
while($row = mysqli_fetch_assoc($result362))
{
    	
    $array4[] = $row;
    
}
    

echo $array4[0]['place'];

mysqli_close($con);
//include('date.php');


?>
