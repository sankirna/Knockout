

ko.bindingHandlers.fadeInOut = {

    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var shouldDisplay = valueAccessor();
        $(element).toggle(shouldDisplay);
    },
    update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {

        var shouldDisplay = valueAccessor();
        shouldDisplay ? $(element).fadeIn() : $(element).fadeOut();
    }
};


var customBindingModel = function () {
    var self = this;

    self.firstName = ko.observable();

    self.items = ko.observableArray([{ mealName: "Standard (sandwich)", price: 0, TimeStamp: GuidClass.NewGuid() },
        { mealName: "Premium (lobster)", price: 34.95, TimeStamp: GuidClass.NewGuid() },
        { mealName: "Ultimate (whole zebra)", price: 290, TimeStamp: GuidClass.NewGuid() }]);

    self.add = function () {
        self.items.push({ mealName: self.firstName(), price: 0, TimeStamp: GuidClass.NewGuid() });
    };





    self.removeItem = function (item) {
        var i = self.items().filter(function (elem) {
            return elem.TimeStamp === item.TimeStamp;
        })[0];
        self.items.remove(i);
    };

    // Animation callbacks for the planets list
    self.showPlanetElement = function (elem) {
        if (elem.nodeType === 1) $(elem).hide().slideDown();
    };
    self.hidePlanetElement = function (elem) {
        if (elem.nodeType === 1)
            $(elem).slideUp(
                function() { $(elem).remove(); });
    };
};


var customeBindingViewModel;

$(function () {
    customeBindingViewModel = new customBindingModel();

    ko.applyBindings(customeBindingViewModel);
});


var GuidClass = (function () {
    function S4() {
        return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
    }

    return {
        NewGuid: function () {
            return (S4() + S4() + "-" + S4() + "-" + S4() + "-" + S4() + "-" + S4() + S4() + S4());
        }
    };

})();