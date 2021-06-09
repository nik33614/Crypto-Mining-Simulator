<?php

$strName = 
$_REQUEST["name"];

$pl = "75";
$b=1;

$strMoney = 
$_REQUEST["money"];

$strTutorial = 
$_REQUEST["tutorial"];

$strFile_Name = $strName.".txt";
$strPlace_Name = $strName."place".".txt";

if (file_exists($strFile_Name) && $strTutorial == 0) {
    echo "True";
} 

else
{
	if(file_exists($strPlace_Name))
	{
	 
		$check = htmlentities(file_get_contents($strFile_Name));
	 	
	}
	else{
		$fd1 = fopen($strPlace_Name, 'w');
		fwrite($fd1, $pl);
		fclose($fd1);
}
    	
	$check = htmlentities(file_get_contents($strFile_Name));

	
	$fd = fopen($strFile_Name, 'w');
	
	fwrite($fd, $strMoney);
	fclose($fd);
	$strPlace = htmlentities(file_get_contents($strPlace_Name));
	//echo $strPlace;


//
$host = 'localhost';
$user = 'n77391_dbuser'; 
$password = 'pass';
$db = 'user';
$table = 'LeaderBoard';
$con = mysqli_connect($host,$user,$password,$db);
$username = "'".$strName."'";
$varible = "'".$strMoney."'";
$place = "'".$strPlace."'";
if (!$con) {
      //die("Connection failed: " . mysqli_connect_error());
}
 
//echo "Connected successfully";

$em1 = (int)$strMoney;
$em2 = (int)$check;
if($em1 != $em2) 
{
$sql = "INSERT INTO $table (username, varible, place) VALUES ($username, $varible, $place)";
if (mysqli_query($con, $sql)) {
      //echo "New record created successfully";
} 
else {
      //echo "Error: " . $sql . "<br>" . mysqli_error($con);
}

}
$query1 = "DELETE FROM LeaderBoard
 WHERE varible NOT IN (SELECT * 
                    FROM (SELECT MAX(n.varible)
                            FROM LeaderBoard n
                        GROUP BY n.username) x)";
$result1 = mysqli_query($con,$query1);



//$usernameled="'".$strName."'";
//$query = "SELECT * FROM LeaderBoard WHERE username=".$usernameled;
//$result = mysqli_query($con,$query);
//$yourArray = array();


//while($row = mysqli_fetch_assoc($result)){
//     $array[] = $row;
//

//$plsq = $array[0]['place'];

//$fd2 = fopen($strPlace_Name, 'w');
//		fwrite($fd2, $plsq);
//		fclose($fd2);


$query3 = "SELECT username, varible, place
FROM LeaderBoard
ORDER BY varible DESC;";
$result3 = mysqli_query($con,$query3);
$YourArray = array();


while($row = mysqli_fetch_assoc($result3)){
     $array[] = $row;
}

for ($i = 0; $i < count($array); $i++)
{
	
	$strname = $array[$i]['username'];
	$strplace = $array[$i]['place'];
	$strrplace = "'".$strplace."'";
	$strrname = "'".$strname."'";
	

	$stringplace = (string)$b;
	$b= $b+1;
	$strpplace = "'".$stringplace."'";
	$query5 = "UPDATE LeaderBoard
	SET place = replace(place, ".$strrplace.", ".$strpplace.")
	WHERE username = ".$strrname;
	$result5 = mysqli_query($con,$query5);
	
	
	$strfilename = $strname."place.txt";
	$fd4 = fopen($strfilename, 'w');
		fwrite($fd4, $strplace);
		fclose($fd4);
		
	//echo $strplace;
}

$strPlaceee = htmlentities(file_get_contents($strPlace_Name));
echo $strPlaceee;

mysqli_close($con);

//
}

?>
