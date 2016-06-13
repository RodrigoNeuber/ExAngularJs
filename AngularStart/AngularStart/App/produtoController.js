angular.module("app")
.controller("produtoController", function ($scope, $http) {

    // Busca  em um serviço Rest
    //simulação de um produto já buscado

    //$scope.produto = {
    //    Id: 1,
    //    Name: "iPhone 6s Plus",
    //    Category: "Hardware",
    //    Price: 4999,
    //    Url: "http://assets-jpcust.jwpsrv.com/thumbs/Fxp5myJq.jpg"
    //};

    $http.get('http://localhost:52368/api/Produto/1')
        .success(function (produtos1){
            $scope.produto1 = produtos1;
        })
    .error(function (erro){
        console.error(erro);
    });

    $http.get('http://localhost:52368/api/Produto/2')
        .success(function (produtos2) {
            $scope.produto2 = produtos2;
        })
    .error(function (erro) {
        console.error(erro);
    });

    $http.get('http://localhost:52368/api/Produto/3')
        .success(function (produtos3) {
            $scope.produto3 = produtos3;
        })
    .error(function (erro) {
        console.error(erro);
    });

});