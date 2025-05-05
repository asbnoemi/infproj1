<html>
	<title> Tanfolyamszervezés </title>
	<head>
		<meta charset="UTF-8">
		<style>
			form {text-align: center;}
		</style>
	</head>
	<body>
		<form action="" method="POST">
			<h1> Rendezvény jelentkezés </h1>
			<br>
			<label for="name"> Kérlek add meg a nevedet: </label>
			<input type="text" name="name"> <br><br>
			<label for="birthdate"> Kérlek add meg a születési dátumod: </label>
			<input type="date" name="birthdate"> <br><br>
			<label for="idnumber"> Kérlek add meg a személyi igazolvány számodat: </label>
			<input type="text" name="idnumber"> <br><br>
			<label for="phonenumber"> Kérlek add meg a telefonszámodat: </label>
			<input type="text" name="phonenumber"> <br><br>
			<label for="courses"> Kérlek válaszd ki a kurzust, amire jelentkezni szeretnél: </label>
			<select name="courses" id="courses">
				<option value="1">Dunaújváros 2025/06/01 12:00</option>
				<option value="2">Budapest 2025/06/05 8:00</option>
				<option value="3">Budapest 2025/06/07 11:00</option>
				<option value="4">Debrecen 2025/06/05 15:00</option>
				<option value="5">Pécs 2025/06/11 9:00</option>
			</select> <br><br>
			<input type="submit" value="Jelentkezés">
		</form>
	</body>
</html>
<?php
	include("login.php");
	$ssl_option=array(
		"ssl"=>array(
			"key"=>"path/to/client-key.pem",
			"cert"=>"path/to/client-cert.pem",
			"ca"=>"path/to/ca-cert.pem",
			"capath"=>"etc/ssl/certs",
			"cipher"=>"AES256-SHA"
		)
	);
	$conn=mysqli_init();
	/*if(!$conn)
	{
		die("MySQL inicializáció sikertelen");
	}*/
	mysqli_ssl_set($conn,NULL,NULL,NULL,NULL,NULL);
	/*if(!mysqli_real_connect($conn,$host,$username,$password,$database,$port,NULL,MYSQLI_CLIENT_SSL))
	{
		die("Kapcsolódás sikertelen: ".mysqli_connect_error());
	}
	echo "A kapcsolódás sikeres";*/
	/*$sql="INSERT INTO tanfolyam (tanfolyam_helyszine,tanfolyam_datuma,tanfolyam_kezdete) VALUE ('Pécs','2025-06-11','09:00:00')";
	if(mysqli_query($conn,$sql))
	{
		echo "<br>Beszúrtunk egy új sort <br>";
	}
	else
	{
		echo "<br>Hiba a sor beszúrásánál <br>";
	}*/
	$cookie_name=name;
	$cookie_value=birthdate." ".idnumber." ".phonenumber." ".courses;
	setcookie($cookie_name, $cookie_value,time()+60*60*24*30);
	if(isset($_COOKIE[cookie_name]))
	{
		echo "A süti neve: ".$cookie_name;
		echo "A süti értéke: ".$cookie_value;
	}
	else
		echo "valami nem jó";
	
?>
