﻿var app = angular.module('ThanhHuongSolution', ['toastr', 'ui.mask', 'ui.bootstrap']);

app.controller('BillingController', function ($scope, toastr, $http) {

    $scope.init = function () {
        $scope.pageIndex = 1;
        $scope.recordPerPage = 5;
        $scope.maxSize = 5;
        $scope.bills = [];
        $scope.sortBy = 'CreatedAt';
        $scope.sortDirection = false;
        $scope.isSearchName = false;
        $scope.query = '';
        //$scope.currentIndex = 1;

        $http.post("/Billing/Search", { customerId: '', query: '', pagination: { PageIndex: $scope.pageIndex, PageSize: $scope.recordPerPage, SortBy: $scope.sortBy, SortDirection: $scope.sortDirection } }, {
        }).success(function (response) {
            $scope.bills = response.data.LstBilling;
            $scope.totalBillings = response.data.TotalItem;
        });

        $('#search_date').trigger('input');
    }

    $scope.search = function () {
        $http.post("/Billing/Search", { customerId: '', query: $scope.query, pagination: { PageIndex: $scope.pageIndex, PageSize: $scope.recordPerPage, SortBy: $scope.sortBy, SortDirection: $scope.sortDirection } }, {
        }).success(function (response) {
            if (response.isSuccess) {
                var data = response.data.LstBilling;

                $scope.bills = data;
                $scope.totalBillings = response.data.TotalItem;
            }
            else {
                toastr.error('error at: ' + response.message);
            }
        });
    }
    $scope.searchKeyDown = function (event) {
        if (event.keyCode == 13) {
            $scope.search();
        }
    }

    $scope.viewBill = function (billId)
    {
        $scope.billId = billId;
        if (billId != '')
        {
            for (var i = 0; i < $scope.bills.length; i++)
            {
                if ($scope.bills[i].Id == billId)
                {
                    $scope.trackingNumber = $scope.bills[i].TrackingNumber;
                    $scope.customerId = $scope.bills[i].Customer.Id;
                    $scope.customerTrackingNumber = $scope.bills[i].Customer.CustomerTrackingNumber;
                    $scope.customerName = $scope.bills[i].Customer.CustomerName;
                    $scope.totalAmount = $scope.bills[i].TotalAmount;
                    $scope.billCreatedDate = $scope.bills[i].BillCreatedDate;
                    $scope.createdAt = $scope.bills[i].CreatedAt;
                    $scope.cart = $scope.bills[i].Cart;                    
                    return;
                }
            }
        }
    }

    $scope.changeSearchMode = function()
    {
        $scope.isSearchName = !$scope.isSearchName;
        $scope.query = '';
    }

    $scope.onChangePageIndex = function ()
    {
        $scope.search();
    }
});