var ViewModel = function () {
    var self = this;
    self.cars = ko.observableArray();
    self.error = ko.observable();
    self.detail = ko.observable();
    self.owners = ko.observableArray();

    var carsUri = '/api/cars/';

    self.getCarDetail = function (item) {
        ajaxHelper(carsUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllCars() {
        ajaxHelper(carsUri, 'GET').done(function (data) {
            self.cars(data);
        });
    }




    self.newCar = {
        Owner: ko.observable(),
        Price: ko.observable(),
        Model: ko.observable(),
        Year: ko.observable()
    }

    var ownersUri = '/api/owners/';

    function getOwners() {
        ajaxHelper(ownersUri, 'GET').done(function (data) {
            self.owners(data);
        });
    }

    self.addCar = function (formElement) {
        var car = {
            OwnerId: self.newCar.Owner().Id, // huom
            Price: self.newCar.Price(),
            Model: self.newCar.Model(),
            Year: self.newCar.Year()
        };

        ajaxHelper(carsUri, 'POST', car).done(function (item) {
            self.cars.push(item);
        });
    }
    getOwners();




    // Fetch the initial data.
    getAllCars();
};

ko.applyBindings(new ViewModel());