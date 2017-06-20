function newQuestionareFormVM(id) {
    var self = this;

    self.id = id;
    self.name = ko.observable();
    self.questions = ko.observableArray();

    self.setName = function (name) {
        self.name(name);
    };

    self.addSingleAnswerQuestion = function () {
        self.questions.push(new questionVM(self.questions().length + 1, 1));
    };

    self.addManyAnswerQuestion = function () {
        self.questions.push(new questionVM(self.questions().length + 1, 2));
    };

    self.addOpenQuestion = function () {
        self.questions.push(new questionVM(self.questions().length + 1, 3));
    };

    self.removeQuestion = function (question) {
        self.questions.remove(question);
    };

    self.save = function () {
        var savedQuestions = 0;

        ko.utils.arrayForEach(self.questions(), function (question) {
            var answers = new Array();

            ko.utils.arrayForEach(question.answers(), function (answer) {
                answers.push(answer.optionText());
            });

            $.post("/Questionare/Save", {
                questionareId: self.id, questionType: question.type, question: question.question(), options: answers
            }, function (result) {
                savedQuestions++;

                if(savedQuestions == self.questions().length)
                {
                    $("#saved_result_modal").modal('show');
                    $("#questionare_link").text("http://localhost:63277/Questionare/Read?id=" + self.id);
                }
            })
            .done(function (e) { })
            .fail(function (e) { });
        });
    };


}