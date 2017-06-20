function manageVM() {
    var self = this;

    self.questionares = ko.observableArray();

    getQuestionares();

    function getQuestionares() {
        $.post("/Questionare/GetList", { id: self.id }, function (result) {
                $.each(result, function (key, value) {
                    self.questionares.push(new questionareManageListItem(value));
                });
        }).done(function (e) { }).fail(function (e) { });
    };
};

function questionareManageListItem(source) {
    var self = this;

    self.id = source.id;
    self.name = ko.observable(source.name);

    self.selected = function () {
        location.href = '/Statistic/Index?id=' + self.id;
    };
}