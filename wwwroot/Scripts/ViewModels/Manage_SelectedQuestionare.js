function manageSelectedQuestionare()
{
    var self = this;

    self.answerStats = ko.observableArray();

    self.load = function (id) {
        $.post("/Statistic/GetByQuestionareId", { id: id }, function (result) {
            if (result.HasSucces) {
                alert();
            }
        }).done(function (e) { }).fail(function (e) { });
    };
}