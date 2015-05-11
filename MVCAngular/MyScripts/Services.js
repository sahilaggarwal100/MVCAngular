﻿app.service("SinglePageCRUDService", function ($http) {

    //Function to Read All Employees
    this.getEmployees = function () {
        return $http.get("/api/Test_Vishnu_Table1Controller");
    };

    //Fundction to Read Employee based upon id
    this.getEmployee = function (id) {
        return $http.get("/api/Test_Vishnu_Table1Controller/" + id);
    };

    //Function to create new Employee
    this.post = function (Employee) {
        var request = $http({
            method: "post",
            url: "/api/Test_Vishnu_Table1Controller",
            data: Employee
        });
        return request;
    };

    //Function  to Edit Employee based upon id 
    this.put = function (id, Employee) {
        var request = $http({
            method: "put",
            url: "/api/Test_Vishnu_Table1Controller/" + id,
            data: Employee
        });
        return request;
    };

    //Function to Delete Employee based upon id
    this.delete = function (id) {
        var request = $http({
            method: "delete",
            url: "/api/Test_Vishnu_Table1Controller/" + id
        });
        return request;
    };
});