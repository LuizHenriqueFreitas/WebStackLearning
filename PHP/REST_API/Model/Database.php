<?php
// declaração da classe Database
class Database
{
    // função de selecionar infomações do BDD
    public function select(int $limit) : array
    {
        try {
            // usa o metodo json_decode pra splitar o arquivo json num array de informações (users)
            $users = json_decode(file_get_contents(DATABASE_FILE), true);
            $users = array_slice($users, 0, $limit);
            return $users;

        } catch(Exception $e) { // tratamento de excessões
            throw New Exception($e->getMessage());
        }
        return false;
    }
}