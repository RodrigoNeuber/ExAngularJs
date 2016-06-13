angular.module("app2")
.controller("softwareController", function ($scope, $http) {


    $http.get('http://localhost:52368/api/Software/1')
        .success(function (software1) {
            $scope.software1 = software1;
        })
    .error(function (erro) {
        console.error(erro);
    });

    $http.get('http://localhost:52368/api/Software/2')
        .success(function (software2) {
            $scope.software2 = software2;
        })
    .error(function (erro) {
        console.error(erro);
    });

    $http.get('http://localhost:52368/api/Software/3')
        .success(function (software3) {
            $scope.software3 = software3;
        })
    .error(function (erro) {
        console.error(erro);
    });

});