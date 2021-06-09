<?php
$strName = 
$_REQUEST["code"];

$host = 'localhost';
$user = 'user'; 
$password = 'pass';
$db = 'n77391_db';
$table = 'users';
$con = mysqli_connect($host,$user,$password,$db);

$usernameled="'".$strName."'";
$query = "SELECT * FROM users WHERE code=".$usernameled;
$result = mysqli_query($con,$query);
$yourArray = array();

if(mysqli_num_rows($result) > 0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        $array[] = $row;

    }
    $plsq = $array[0]['code'];
}
else
{
    echo "1";
}
mysqli_close($con);
?>
