﻿var app = angular.module('ThanhHuongSolution', ['toastr', 'ui.mask', 'ui.bootstrap']);

app.controller('BillingController', function ($scope, toastr, $location, $http) {

    $scope.init = function (data) {
        $scope.pageIndex = 1;
        $scope.recordPerPage = 10;
        $scope.maxSize = 5;
        $scope.bills = [];
        $scope.sortBy = 'CreatedAt';
        $scope.sortDirection = false;
        $scope.isSearchName = false;
        $scope.searchCustomerId = data.CustomerId;
        $scope.query = '';
        //$scope.currentIndex = 1;


        // true : BILL, false : RECEIVING_BILL
        $scope.BillChoosen = true;

        $http.post("/Billing/Search", { customerId: $scope.searchCustomerId, query: '', pagination: { PageIndex: $scope.pageIndex, PageSize: $scope.recordPerPage, SortBy: $scope.sortBy, SortDirection: $scope.sortDirection }, billType: 'BILL' }, {
        }).success(function (response) {
            $scope.bills = response.data.LstBilling;
            $scope.totalBillings = response.data.TotalItem;
        });

        $('#search_date').trigger('input');
    }

    $scope.search = function () {

        if ($scope.BillChoosen) {
            $scope.billType = 'BILL';
        }
        else
        {
            $scope.billType = 'RECEIVING_BILL';
        }
        
        $http.post("/Billing/Search", { customerId: $scope.searchCustomerId, query: $scope.query, pagination: { PageIndex: $scope.pageIndex, PageSize: $scope.recordPerPage, SortBy: $scope.sortBy, SortDirection: $scope.sortDirection }, billType: $scope.billType }, {
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
            $scope.pageIndex = 1;
            $scope.search();
        }
    }

    $scope.viewBill = function (billId) {
        $scope.billId = billId;
        if (billId != '') {
            for (var i = 0; i < $scope.bills.length; i++) {
                if ($scope.bills[i].Id == billId) {
                    $scope.trackingNumber = $scope.bills[i].TrackingNumber;
                    $scope.customerTrackingNumber = $scope.bills[i].Customer.CustomerTrackingNumber;
                    $scope.customerName = $scope.bills[i].Customer.CustomerName;
                    $scope.totalAmount = $scope.bills[i].TotalAmount;
                    $scope.billCreatedDate = $scope.bills[i].BillCreatedDate;
                    $scope.createdAt = $scope.bills[i].CreatedAt;
                    $scope.cart = $scope.bills[i].Cart;

                    if ($scope.billType == 'RECEIVING_BILL')
                        $scope.customerId = $scope.bills[i].Customer.Id;
                    return;
                }
            }
        }
    }

    $scope.changeSearchMode = function () {
        $scope.isSearchName = !$scope.isSearchName;
        $scope.query = '';
    }

    $scope.onChangePageIndex = function () {
        $scope.search();
    }

    $scope.switchSellingBill = function () {
        $scope.BillChoosen = true;
        $scope.search();
    }

    $scope.switchReceivingBill = function () {
        $scope.BillChoosen = false;
        $scope.search();
    }
});