<?php
// importa o Database Model
require_once ROOT_PATH . "/Model/Database.php";

// declaramento da classe de UserModel que herda de Database
class UserModel extends Database
{
    // função para acessar os usuários
    public function GetUsers(int $limit) : array
    {
        // chama a função implementada na superclasse
        return $this->select($limit);
    }
}
?>