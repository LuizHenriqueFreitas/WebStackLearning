<?php
// declaração da classe BaseController
class BaseController
{
    // função padrão __call para resposta de requisição
    public function __call($name, $arguments)
    {
        // chama a função interna implementada mais abaixo nesta mesma classe
        $this->sendOutput('', array('HTTP/1.1 404 Not Found'));
    }

    // função que retorna um array de strings usando o 'QUERY_STRING' de $_SERVER
    protected function getStringParams() : array
    {
        parse_str($_SERVER['QUERY_STRING'], $query);
        return $query;
    }

    // função de formatação de resposta a requisição
    protected function sendOutput($data, $httpHeaders=array())
    {
        header_remove('Set-Cookie');

        if(is_array($httpHeaders) && count($httpHeaders)){
            foreach ($httpHeaders as $httpHeaders){
                header($httpHeaders);
            }
        }

        echo $data;
        exit;
    }
}
?>