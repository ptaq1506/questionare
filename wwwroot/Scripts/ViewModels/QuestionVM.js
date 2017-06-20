function questionVM(lp, type)
{
    var self = this;

    self.lp = ko.observable(lp);
    self.question = ko.observable();
    self.answers = ko.observableArray([new questionOptionVM(lp)]);
    self.singleAnswer = ko.observable(false);
    self.manyAnswer = ko.observable(false);
    self.answerVisible = ko.observable(true);
    self.type = type;

    switch (type) {
        case 1:
            self.singleAnswer(true);
            self.manyAnswer(false);
            self.answerVisible(true);
            break;
        case 2:
            self.singleAnswer(false);
            self.manyAnswer(true);
            self.answerVisible(true);
            break;
        case 3:
            self.singleAnswer(false);
            self.manyAnswer(false);
            self.answerVisible(false);
            break;
    };      

    self.addAnswer = function () {
        self.answers.push(new questionOptionVM());
    };

    self.save = function () {

    };

    self.remove = function () {
        NewQuestionareFormVM.removeQuestion(self);
    };
}