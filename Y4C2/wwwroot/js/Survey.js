




function load() {
    document.getElementById("SurveyQuestions").innerHTML = surv;
}
function one() {
    var inner = 'Question: <input type="text" name="QuestionOne" id="QuestionOne" required/><br/ > <br />\
    Answer Type: <select name="typeOne" id="typeOne">\
<option disabled selected>Select Option</option >\
<option value="Text">Text Response</option>\
<option value="Rating">Rating Response</option>\
</select > <br /> <br />'

    document.getElementById("SurveyQuestions").innerHTML = inner;
}
function two() {
    var inner = 'Question: <input type="text" name="QuestionOne" id="QuestionOne" required/><br/ > <br />\
    Answer Type: <select name="type" id="typeOne">\
<option disabled selected>Select Option</option >\
<option value="Text">Text Response</option>\
<option value="Rating">Rating Response</option>\
</select > <br /><br />\
Question: <input type="text" name="QuestionTwo" id="QuestionTwo" required/><br/ > <br />\
    Answer Type: <select name="typeTwo" id="typeTwo">\
<option  selected disabled >Select Option</option >\
<option value="Text">Text Response</option>\
<option value="Rating">Rating Response</option>\
</select > <br /><br />'
    document.getElementById("SurveyQuestions").innerHTML = inner;
}
function three() {
    var inner = 'Question: <input type="text" name="QuestionOne" id="QuestionOne" required/><br/ > <br />\
    Answer Type: <select name="typeOne" id="typeOne">\
<option  selected disabled >Select Option</option >\
<option value="Text">Text Response</option>\
<option value="Rating">Rating Response</option>\
</select > <br /><br />\
Question: <input type="text" name="QuestionTwo" id="QuestionTwo" required/><br/ > <br />\
    Answer Type: <select name="typeTwo" id="typeTwo">\
<option selected disabled >Select Option</option >\
<option value="Text">Text Response</option>\
<option value="Rating">Rating Response</option>\
</select > <br /><br />\
Question: <input type="text" name="QuestionThree" id="QuestionThree" required/><br/ > <br />\
    Answer Type: <select name="typeThree" id="typeThree">\
<option disabled selected>Select Option</option >\
<option value="Text">Text Response</option>\
<option value="Rating">Rating Response</option>\
</select > <br /><br />'
    document.getElementById("SurveyQuestions").innerHTML = inner;
}
function updateForm(option) {
    //document.getElementById("SurveyQuestions").innerHTML = "hellooooooo";
    
    if (option.id == "oneQ") {
        document.getElementById("SurveyQuestions").innerHTML = "hellooooooo11111";
        one();
    }
    else if (option.id == "twoQ") {
        two();
    }
    else if (option.id == "threeQ") {
        three();
    }
    
}
function update(option) {
   // var val = document.getElementById("Num").value;

    if (option.value == "one") {
        document.getElementById("SurveyQuestions").innerHTML = "hellooooooo11111";
        one();
    }
    else if (option.value == "two") {
        two();
    }
    else if (option.value == "three") {
        three();
    }
}
