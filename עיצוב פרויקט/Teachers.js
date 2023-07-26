//הוספת מורה חדשה
function sendNewTeacher() {
    //שליפת השם לשליחה
    let FirstName = document.querySelector("#nm").value;
    let LastName = document.querySelector("#nmf").value;
    let Id = document.querySelector("#id").value;
    let Address = document.querySelector("#address").value;
    let Phone = document.querySelector("#phone").value;
    let Course = document.querySelector("#cours").value;
    let Password = document.querySelector("#code").value;

    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req.open('get', 'https://localhost:44312/API/Teachers/GetNewTeacher/' + FirstName + '/' + LastName + '/' + Id + '/' + Address + '/' + Phone + '/' + Course + '/' + Password, true);
    //שליחת הבקשה
    req.send();
    //req.responseText קבלת התשובה למשתנה
    req.onload = function () {
        //הדפסת התשובה על המסך
        if(req.responseText=="-2")
        alert("exist this password enter another password");
        else if(req.responseText=="-3")
        alert("מספר זהות זה רשום כבר במערכת");
        else
        alert("נרשמת בהצלחה");
    }
}
//הוספת שיעורים למורה
function addLessonToTeacher() {
    let Password = document.querySelector("#code7").value;
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Teachers/GetAddLesson/' + Password, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "-1")
            alert("this teachers isnt exist");
        else
            alert("you did " + req.responseText + " lessons");
    }
}
// //בדיקה האם זה סיסמא נכונה של מורה
// function cheak() {
//     let Password = document.querySelector("#code1").value;
//     let req = new XMLHttpRequest();
//     req.open('get', 'https://localhost:44312/API/Teachers/GetAddLesson/' + Password, true);
//     req.send();
//     req.onload = function () {
//         //הדפסת התשובה על המסך
//         document.getElementById("ans2").innerHTML = req.responseText;
//     }
// }
