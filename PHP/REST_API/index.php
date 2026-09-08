<?php
// importa o arquivo de configuração
require __DIR__ . "/Config/config.php";

// declara o uri da requisição - uri é um array separado pelos '/'
$uri = parse_uri($_SERVER['REQUEST_URI'], PHP_URL_PATH);
$uri = explode( '/', $uri );

// guard rails para os uris que não correspondem ao acesso da API
if((isset($uri[1]) && $uri[1] != 'api') || (isset($uri[2]) && $uri[2] != 'v1')){
    header("HTTP/1.1 404 Not Found");
    exit();
} else if ((isset($uri[3]) && $uri[3] != 'user') || !isset($uri[4])){
    header("HTTP/1.1 404 Not Found");
    exit();
}

// importa o UserController
require ROOT_PATH . "/Controller/Api/UserController.php";

// instancia UserController
$user = new UserController();

// utiliza os metodos do controller previamente instanciado
$methodName = $uri[4] . 'Action';
$user->{$methodName}();
?>