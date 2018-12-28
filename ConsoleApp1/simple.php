<?php


$realPass = "Paul";

if (isset($_POST['UserName'])) {
    $UserName = $_POST['UserName'];
	if($UserName == $realPass)
	{
		echo "UserName correct";
	}
	else
	{
		echo "UserName not correct";
	}
} else {
    $UserName = null;
}
  
if (isset($_POST['Password'])) {
    $Password = $_POST['Password'];
} else {
    $Password = null;
}
?>