<?php
// implementação da classe UserController herda de BaseController
class UserController extends BaseController
{
    // Função que lista as informações de resposta da API
    public function listAction()
    {
        $errorDescription = '';
        $requestMethod = $_SERVER["REQUEST_METHOD"];
        $stringParamsArray = $this->getStringParams();

        // caso seja uma requisição GET
        if (strtoupper($requestMethod) == 'GET'){
            try {
                // instancia um objeto UserModel
                $userModel = new UserModel();

                $intLimit = 10;
                if (isset($stringParamsArray['limit']) && $stringParamsArray['limit']){
                    $intLimit = $stringParamsArray['limit'];
                }

                // gera o array de usuarios para resposta final
                $usersArray = $userModel->getUsers($intLimit);
                // configura os dados de resposta com json_encode
                $responseData = json_encode($userArray);
            
                //tratamento de excessao
            } catch (Error $e) {
                $errorDescription = $e->getMessage().'Something went wrong! Please contact support.';
                $erroHeader = 'HTTP/1.1 500 Internal Server Error';
            }
        // se nao for GET nossa API rejeita
        } else {
            $errorDescription = 'Method not support';
            $erroHeader = 'HTTP/1.1 422 Unprocessable Entity';
        }

        // tratamento de erros
        if (!$errorDescription) {
            $this->sendOutput(
                $responseData,
                array('Content-Type: application/json', 'HTTP/1.1 200 OK')
            );
        } else {
            $this->sendOutput(json_encode(array('array' => $errorDescription)),
                array('Content-Type: application/json', $erroHeader)
            );
        }
    }
}
?>