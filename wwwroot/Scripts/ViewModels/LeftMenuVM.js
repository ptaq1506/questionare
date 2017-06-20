function leftMenuVM() {
    var self = this;

    self.singleQuestion = function() {
        NewQuestionareFormVM.addSingleAnswerQuestion();
    }

    self.manyAnswerQuestion = function () {
        NewQuestionareFormVM.addManyAnswerQuestion();
    }

    self.openQuestion = function() {
        NewQuestionareFormVM.addOpenQuestion();
    }
}