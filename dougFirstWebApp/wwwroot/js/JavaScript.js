$("#calcbutton").click(function calculateGrade() {

    let assignments = $("#assignments").val() * .5;
    let project = $("#project").val() * .1;
    let quizzes = $("#quizzes").val() * .1;
    let midterm = $("#midterm").val() * .1;
    let final = $("#final").val() * .1;
    let intex = $("#intex").val() * .1;

    let weighted = assignments + project + quizzes + midterm + final + intex;
    let grade;

    if (weighted >= 94) {
        grade = "A";
    } else if (weighted < 94  && weighted >= 90) {
        grade = "A-";
    } else if (weighted < 90 && weighted >= 87) {
        grade = "B+";
    } else if (weighted < 87 && weighted >= 84) {
        grade = "B";
    } else if (weighted < 84 && weighted >= 80) {
        grade = "B-";
    } else if (weighted < 80 && weighted >= 77) {
        grade = "C+";
    } else if (weighted < 77 && weighted >= 74) {
        grade = "C";
    } else if (weighted < 74 && weighted >= 70) {
        grade = "C-";
    } else if (weighted < 70 && weighted >= 67) {
        grade = "D+";
    } else if (weighted <= 67 && weighted >= 64) {
        grade = "D";
    } else if (weighted < 64 && weighted >= 60) {
        grade = "D-";
    } else {
        grade = "E";
    }

    $("#result").text(weighted + " " + grade)

})