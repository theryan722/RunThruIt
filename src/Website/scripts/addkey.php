<?php
/* 
Add string to workout list
*/

$msg = $_GET['w'];
$ukeyfile= '../data/workouts.txt';
$fp = fopen($ukeyfile, "a");
$newl = "\n" . $msg;
fwrite($fp, $newl);
fclose($fp);

?>