# Estudos de APIs REST com ASP.NET Core
---
Este projeto foi criado para organizar e registrar um plano de estudos prático sobre o desenvolvimento de APIs REST utilizando C# e ASP.NET Core. Serão estudados desde os fundamentos de comunicação entre sistemas até a criação, documentação, versionamento e integração de uma API com serviços externos. Este projeto de estudo tem como objetivo, consolidar os principais conceitos envolvidos no desenvolvimento de uma API REST.  O foco será desenvolver uma API completa, executada localmente, documentada por meio do Swagger/OpenAPI, organizada com versionamento e capaz de consumir dados com origem de outras APIs.

Durante o aprendizado, o foco será compreender os fundamentos de uma API REST, o funcionamento do protocolo HTTP, os principais métodos de requisição e os códigos de status. Como atividade prática, será desenvolvida uma Web API com Controllers e operações de CRUD para cadastrar, consultar, atualizar e excluir informações. O projeto será aprimorado com a implementação da documentação utilizando Swagger e OpenAPI. Também será estudado o versionamento de APIs, permitindo organizar diferentes versões dos endpoints sem comprometer aplicações que utilizam versões anteriores. Também, será realizado o consumo de uma API externa utilizando o HttpClient. Os dados obtidos serão integrados à API principal, com tratamento de erros, conversão de respostas JSON e organização das classes responsáveis pela comunicação com o serviço externo.

Ao final dos estudos, o repositório deverá conter uma API REST funcional, executada localmente, documentada com Swagger, organizada por versões e integrada com pelo menos uma API externa. Também será produzido um relatório apresentando o processo de desenvolvimento, os recursos utilizados, os testes realizados e os resultados da integração.
---
## Conceitos Iniciais
### Fundamentos REST e CRUD

Começando o estudo pela compreensão do que é uma API e qual é sua função na comunicação entre sistemas. É importante entender a diferença entre cliente e servidor, como uma requisição HTTP é enviada e como o servidor devolve uma resposta. Deverá estudar os métodos `GET`, `POST`, `PUT`, `PATCH` e `DELETE`. O `GET` será utilizado para consultar dados, o `POST` para cadastrar, o `PUT` para atualizar completamente um recurso, o PATCH para realizar uma atualização parcial e o `DELETE` para excluir.

Também deverão ser estudados os códigos de status HTTP, como `200 OK`, `201 Created`, `204 No Content`, `400 Bad Request`, `404 Not Found` e `500 Internal Server Error`.
---
### Swagger, OpenAPI e versionamento

O objetivo será melhorar a documentação e a organização da API.

O Swagger deverá ser utilizado para visualizar e testar os endpoints diretamente pelo navegador. Cada endpoint deverá apresentar informações claras sobre os dados recebidos e retornados.

Também deverão ser utilizados tipos de retorno mais específicos, como `ActionResult<T>`, permitindo indicar quais respostas podem ser produzidas por cada endpoint.
---
### Consumo de API externa e integração

Com estudo sendo bem consolidado a aplicação deverá consumir uma API externa. A API deverá estar integrada com um serviço externo, possuir tratamento de erros e apresentar os dados recebidos por meio de um endpoint próprio.
