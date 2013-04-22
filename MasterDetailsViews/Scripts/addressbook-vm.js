/// <reference path="_references.js" />

var viewModel = function (data)
{
    this.SelectedUser = ko.observable({
        Addresses: ko.observableArray([]),
        Name: ko.observable("")
    });
    this.Users = ko.observableArray(data);
}