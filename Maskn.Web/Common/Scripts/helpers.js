var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('Maskn');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);