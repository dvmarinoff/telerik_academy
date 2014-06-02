<?php 
header('Content-type: application/json');
$ret[0] = array('name'=> 'Jim', 'age' => 20);
$ret[1] = array('name'=> 'John', 'age' => 21);
$ret[2] = array('name'=> 'James', 'age' => 24);
echo json_decode($ret);