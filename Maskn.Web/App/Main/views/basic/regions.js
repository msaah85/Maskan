(function () {
    var controllerId = 'app.views.regions';
    angular.module('app').controller(controllerId, [
        '$scope', '$rootScope', function ($scope, $rootScope) {
            var vm = this;
            //Regions logic...

            vm.Title = 'Countries & Cities';

            showRegions = function () {
                var rgn = $('#regions');                
                
                if (rgn)
                rgn.DataTable();
            }


            $rootScope.$on('$viewContentLoaded', function () {
                showRegions();
            });
            
        }
    ]);
})();