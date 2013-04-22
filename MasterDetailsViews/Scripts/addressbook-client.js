/// <reference path="addressbook-vm.js" />
$(document).ready(function ()
{
    $.ajax({
        url: "/AddressBook/Index/",
        type: "POST",
        data: {},
        success: function (data)
        {
            var userslist = ko.mapping.fromJS(data.Users);
            vm = new viewModel(userslist);
            ko.applyBindings(vm);
        }
    });
    $(".right-aligned-section").hide();
});

$(document).delegate(".show-details", "click", function ()
{
    $(".right-aligned-section").fadeIn();
    var user = ko.dataFor(this);
    vm.SelectedUser(user);
});
