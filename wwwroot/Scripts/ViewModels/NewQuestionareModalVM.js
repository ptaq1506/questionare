function newQuestionareModalVM() {
    var self = this;

    self.name = ko.observable();

    self.save = function () {
        window.location.href = "/Questionare/Add?name=" + self.name();
    }
}