function questionOptionVM(lp, questionId, questionType, optionText, optionId) {
    var self = this;

    self.lp = ko.observable(lp);
    self.id = optionId;
    self.optionText = ko.observable(optionText);
    self.questionId = ko.observable(questionId);
    self.isSelected = ko.observable(false);

    self.mouseupEvent = function (data, ev) {
        if (questionType == 1) {
            PublishedQuestionareVM.uncheckAllOptionsByQuestionId(self.questionId);
            self.isSelected(true);
        }
        else {
            var selected = !ev.currentTarget.checked;
            self.isSelected(selected);
        }
    };
}