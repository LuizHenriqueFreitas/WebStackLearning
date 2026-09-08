<?php

// importa o caminho da raiz do projeto
define("ROOT_PATH", __DIR__ . "/../");

// importa o caminho do arquivo de database do projeto
define("DATABASE_FILE", ROOT_PATH . 'database.json');

// importa unica vez o BaseController e o UserModel
require_once ROOT_PATH . "/Controller/Api/BaseController.php";
require_once ROOT_PATH . "/Model/UserModel.php";
?>