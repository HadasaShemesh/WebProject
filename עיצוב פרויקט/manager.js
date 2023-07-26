//הצגת טופס למילוי כרטיסיה חדשה
function toBuy() {
    document.getElementById('t5').style.display = "inline"
    document.getElementById('refresh').style.display = "inline"
    document.getElementById('w').style.display = "none"
    document.getElementById('w1').style.display = "none"
    document.getElementById('w2').style.display = "none"
    document.getElementById('SendID').style.display = "none"
    document.getElementById('enter').style.display = "none"
    document.getElementById('enterID').style.display = "none"
    document.getElementById('0').style.display = "none"
    document.getElementById('enterID1').style.display = "none"
    document.getElementById('SendID1').style.display = "none"
    document.getElementById('enter1').style.display = "none"
    document.getElementById('1').style.display = "none"
    document.getElementById('refresh3').style.display = "none"
    document.getElementById('refresh2').style.display = "inline"
    document.getElementById('therapistList').innerHTML = ""
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    document.getElementById('2').style.display = "none"
}
//איפוס מסך
function refresh() {
    document.getElementById('id1').style.display = "none"
    document.getElementById('pass1').style.display = "none"
    document.getElementById('send1').style.display = "none"
    document.getElementById('id2').style.display = "none"
    document.getElementById('pass2').style.display = "none"
    document.getElementById('send2').style.display = "none"
    document.getElementById('id3').style.display = "none"
    document.getElementById('pass3').style.display = "none"
    document.getElementById('send3').style.display = "none"
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    

}
//הצגת כפתורי עדכון זמני חוגים
function toShowLessons(){
    document.getElementById('addTime').style.display = "inline"
    document.getElementById('updateTime').style.display = "inline"
    document.getElementById('deleteTime').style.display = "inline"
    // document.getElementById('less').style.display = "inline"

}
//הוספת  שיעור
function addTime1(){   
    document.getElementById('putDetails1').style.display = "inline"
    document.getElementById('day1').style.display = "inline"
    document.getElementById('hour1').style.display = "inline"
    document.getElementById('nameOfCourse1').style.display = "inline"
    document.getElementById('sendToTime1').style.display = "inline"
    document.getElementById('1send').style.display = "inline"
    document.getElementById('refresh').style.display = "inline"
    document.getElementById('putDetails2').style.display = "none"
    document.getElementById('day2').style.display = "none"
    document.getElementById('hour2').style.display = "none"
    document.getElementById('nameOfCourse2').style.display = "none"
    document.getElementById('sendToTime2').style.display = "none"
    document.getElementById('2send').style.display = "none"
    document.getElementById('putDetails3').style.display = "none"
    document.getElementById('day3').style.display = "none"
    document.getElementById('hour3').style.display = "none"
    document.getElementById('nameOfCourse3').style.display = "none"
    document.getElementById('sendToTime3').style.display = "none"
    document.getElementById('3send').style.display = "none"


}
//עדכון שיעור
function updateTime1(){
    document.getElementById('putDetails3').style.display = "inline"
    document.getElementById('day3').style.display = "inline"
    document.getElementById('hour3').style.display = "inline"
    document.getElementById('nameOfCourse3').style.display = "inline"
    document.getElementById('sendToTime3').style.display = "inline"
    document.getElementById('3send').style.display = "inline"
    document.getElementById('refresh').style.display = "inline"
    document.getElementById('putDetails2').style.display = "none"
    document.getElementById('day2').style.display = "none"
    document.getElementById('hour2').style.display = "none"
    document.getElementById('nameOfCourse2').style.display = "none"
    document.getElementById('sendToTime2').style.display = "none"
    document.getElementById('2send').style.display = "none"
    document.getElementById('putDetails1').style.display = "none"
    document.getElementById('day1').style.display = "none"
    document.getElementById('hour1').style.display = "none"
    document.getElementById('nameOfCourse1').style.display = "none"
    document.getElementById('sendToTime1').style.display = "none"
    document.getElementById('1send').style.display = "none"

}
//מחיקת שיעור
function deleteTime1(){
    document.getElementById('putDetails2').style.display = "inline"
    document.getElementById('day2').style.display = "inline"
    document.getElementById('hour2').style.display = "inline"
    document.getElementById('nameOfCourse2').style.display = "inline"
    document.getElementById('sendToTime2').style.display = "inline"
    document.getElementById('2send').style.display = "inline"
    document.getElementById('refresh').style.display = "inline"
    document.getElementById('putDetails1').style.display = "none"
    document.getElementById('day1').style.display = "none"
    document.getElementById('hour1').style.display = "none"
    document.getElementById('nameOfCourse1').style.display = "none"
    document.getElementById('sendToTime1').style.display = "none"
    document.getElementById('1send').style.display = "none"
    document.getElementById('putDetails3').style.display = "none"
    document.getElementById('day3').style.display = "none"
    document.getElementById('hour3').style.display = "none"
    document.getElementById('nameOfCourse3').style.display = "none"
    document.getElementById('sendToTime3').style.display = "none"
    document.getElementById('3send').style.display = "none"

}

//הוספת שיעור לשליחה
function addTimeToSend(){
    let name = document.getElementById('day1').value
    let hour = document.getElementById('hour1').value
    let nameOfCourse = document.getElementById('nameOfCourse1').value

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetAddLesson/' +name+
    '/'+hour+'/'+nameOfCourse, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "-1")
        alert("הכניסי את כל התונים");
        else if (req.responseText =="0")
            alert("קיים שיעור בשעה זו מחקי לפני");
        else if(req.responseText=="1")
            alert("נוסף בהצלחה");
    }
}
//מחיקת שיעור לשליחה
function deleteTimeToSend(){
    let name = document.getElementById('day2').value
    let hour = document.getElementById('hour2').value
    let nameOfCourse = document.getElementById('nameOfCourse2').value

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDeleteLesson/' +name+'/'+hour+'/'+nameOfCourse, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "-1")
        alert("הכניסי את כל התונים");
        else if (req.responseText =="0")
            alert("לא קיים שיעור בשעה זו" );
        else if(req.responseText=="1")
            alert("נמחק בהצלחה");
    }
}
//עדכון שיעור לשליחה
function updateTimeToSend(){
    let name = document.getElementById('day3').value
    let hour = document.getElementById('hour3').value
    let nameOfCourse = document.getElementById('nameOfCourse3').value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetIdUpdateLesson/' +name+'/'+hour+'/'+nameOfCourse, true);
    req.send();
    // let hour1 = document.getElementById('hour3').value
    // hour1=hour1.replace('-',':')

    req.onload = function () {
        le=JSON.parse(req.response)
        console.log(le)
        //הדפסת התשובה על המסך
        if (req.responseText == "null")
        alert("לא קיים שיעור בשעה זו" )
        else{
            alert("המספר המזהה של החוג הוא: "+le.IdLesson);
            NewDetailsToUpdate(le)
            
        }
    }
}
//הצגת כפתורי עדכון שיעורים לשליחה
function NewDetailsToUpdate(le){
    less()
    document.getElementById('putDetails4').style.display = "inline"
    document.getElementById('putDetails4').value=`הכנס פרטים חדשים לחוג מס' ${le.IdLesson} לעדכון `
    document.getElementById('id4').value=le.IdLesson
    document.getElementById('day4').style.display = "inline"
    document.getElementById('hour4').style.display = "inline"
    document.getElementById('nameOfCourse4').style.display = "inline"
    document.getElementById('sendToTime4').style.display = "inline"
    document.getElementById('4send').style.display = "inline"
    document.getElementById('refresh').style.display = "inline"
    document.querySelector('#day4').value = le.Day
    document.querySelector('#hour4').value = le.Hour
    document.querySelector('#nameOfCourse4').value = le.NameOfCourse
    
}
//שליחה לעדכון שיעור
function toUpdateLesson(){
    let id = document.getElementById('id4').value
    let name = document.getElementById('day4').value
    let hour = document.getElementById('hour4').value
    let nameOfCourse = document.getElementById('nameOfCourse4').value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetUpdateLesson/'+id+'/' +name+'/'+hour+'/'+nameOfCourse, true);
    req.send();
   
    req.onload = function () {
        //הדפסת התשובה על המסך
         if (req.responseText =="-1")
        alert("לא קיים שיעור בשעה זו" );
        else
        alert("השיעור התעדכן בהצלחה")
    }
}
//הצגת כפתורי שליחה לאיפוס שיעורים למורה
function toResetLessonsToTeacher() {
    document.getElementById('enterID2').style.display = "inline"
    document.getElementById('enter2').style.display = "inline"
    document.getElementById('SendID2').style.display = "inline"
    document.getElementById('2').style.display = "inline"
    document.getElementById('refresh').style.display = "inline"
    document.getElementById('t5').style.display = "none"
    document.getElementById('w').style.display = "none"
    document.getElementById('w1').style.display = "none"
    document.getElementById('w2').style.display = "none"
    document.getElementById('SendID').style.display = "none"
    document.getElementById('enter').style.display = "none"
    document.getElementById('enterID').style.display = "none"
    document.getElementById('0').style.display = "none"
    document.getElementById('enterID1').style.display = "none"
    document.getElementById('SendID1').style.display = "none"
    document.getElementById('enter1').style.display = "none"
    document.getElementById('1').style.display = "none"
    document.getElementById('refresh3').style.display = "none"
    document.getElementById('refresh2').style.display = "inline"
    document.getElementById('therapistList').innerHTML = ""
    
}
//איפוס שיעורים למורה ע"י ת.ז
function toResetLessonsToSend() {
    let id = document.querySelector("#enter2").value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetToResetLessonsToSend/' + id, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "1")
            alert("השיעורים של המורה התאפסו בהצלחה");
        else if (req.responseText == "-1")
            alert("מספר זהות זה לא קיים במערכת");
        else
            alert("לא התאפס");
    }
}
//מלוי כרטיסיה חדשה ללקוחה שמביאה התחיבות
function buyNewCard() {

    let id = document.querySelector("#code9").value;
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/BuyNewCard/' + id, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "-1")
        alert("מספר זהות זה לא קיים במערכת או שלקוחה זו שייכת לספורט הטיפולי");
        else if (req.responseText != "10")
            alert("you still have lessons, you cant buy card, you rest " + req.responseText + " lessons ");
        // else if(req.responseText=="0")
        // alert("you dont give Prescription");
        else
            alert("you bought new card you rest " + req.responseText + " lessons");
    }
}
//כניסה למנהלת ע"י סיסמא 
function cheakPassword() {
    let Password = document.querySelector("#psw").value;
    // localStorage.setItem("password", "" + Password);
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetManager/' + Password, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        // document.getElementById("ans5").innerHTML = req.responseText;
        if (req.responseText == "true")
            window.location.href = "manager.html"
        else
            window.location.href = "index.html"
        // document.getElementById("ans5").innerHTML = "wrong password enter again";
    }

}
//שנוי סיסמא למנהלת הצגת הכפתור ושליחה לפונקצייה של שנוי
function changeM() {
    document.getElementById('id1').style.display = "inline"
    document.getElementById('pass1').style.display = "inline"
    document.getElementById('send1').style.display = "inline"
    document.getElementById('send1').onclick = function () { sendToChangeM() }

}
//שנוי סיסמא למורה הצגת הכפתור ושליחה לפונקצייה של שנוי
function changeT() {
    document.getElementById('id2').style.display = "inline"
    document.getElementById('pass2').style.display = "inline"
    document.getElementById('send2').style.display = "inline"
    document.getElementById('send2').onclick = function () { sendToChangeT() }
}
//שנוי סיסמא ללקוחה הצגת הכפתור ושליחה לפונקצייה של שנוי
function changeC() {
    document.getElementById('id3').style.display = "inline"
    document.getElementById('pass3').style.display = "inline"
    document.getElementById('send3').style.display = "inline"
    document.getElementById('send3').onclick = function () { sendToChangeC() }
}
//שליחה שנוי סיסמא ללקוחה
function sendToChangeC() {
    let x1 = document.querySelector("#id3").value
    let x2 = document.querySelector("#pass3").value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetChangePasswordCustomer/' + x1 + '/' + x2, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
            alert("הסיסמא של הלקוחה התעדכנה בהצלחה");
        else if (req.responseText == "0")
            alert("מספר זהות זה לא קיים במערכת");
        else if (req.responseText == "-1")
            alert("זה הסיסמא הקודמת שלך הקש שוב סיסמא אחרת");
        else if (req.response == "-2")
            alert("קיים כזאת סיסמא במערכת, הכניסי אחרת");
    }
}
//שליחה שנוי סיסמא למנהלת
function sendToChangeM() {
    let x1 = document.getElementById('id1').value
    let x2 = document.getElementById('pass1').value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetChangePasswordManager/' + x1 + '/' + x2, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
            alert("הסיסמא של המנהלת התעדכנה בהצלחה");
        else if (req.responseText == "0")
            alert("מספר זהות זה לא קיים במערכת");
        else if (req.responseText == "-1")
            alert("זה הסיסמא הקודמת שלך הכניסי סיסמא חדשה שוב");

    }
}
//שליחה שנוי סיסמא למורה
function sendToChangeT() {
    let x1 = document.getElementById('id2').value
    let x2 = document.getElementById('pass2').value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetChangePasswordTeacher/' + x1 + '/' + x2, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
            alert("הסיסמא של המורה התעדכנה בהצלחה");
        else if (req.responseText == "0")
            alert("מספר זהות זה לא קיים במערכת");
        else if (req.responseText == "-1")
            alert("זה הסיסמא הקודמת שלך הכניסי סיסמא אחרת");
        else if (req.response == "-2")
            alert("קיים כזאת סיסמא במערכת, הכנס אחרת");
    }
}
//בדיקה ע"י סיסמא מיזה ושליחה לפונקצייה מתאימה לעדכון
function IdForUpdate() {
    let id = document.querySelector("#enter").value;
    localStorage.setItem("id", "" + id);

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetSearchByIdForUpdate/' + localStorage.getItem("id"), true);
    req.send();
    req.onload = function () {
        if (req.responseText == "1")
            updateCustomerSpecial();
        else if (req.responseText == "2")
            updateCustomer()
        else if (req.responseText == "3")
            updateTeacher()
        else
            alert("לא קיים מספר זהות זה");
    }
}
//איפוס מסך
function refreshPageUpdate() {
    document.getElementById('enterID').style.display = "none"
    document.getElementById('SendID').style.display = "none"
    document.getElementById('enter').style.display = "none"
    document.getElementById('0').style.display = "none"
    document.getElementById('refresh2').style.display = "none"
    document.getElementById('w1').style.display = "none"
    document.getElementById('w2').style.display = "none"
    document.getElementById('w').style.display = "none"
    document.getElementById('t5').style.display = "none"
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('1').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    document.getElementById('2').style.display = "none"

}
//הצגת כפתורים של עדכון על המסך
function Update() {
    document.getElementById('enterID').style.display = "inline"
    document.getElementById('enter').style.display = "inline"
    document.getElementById('SendID').style.display = "inline"
    document.getElementById('0').style.display = "inline"
    document.getElementById('enterID1').style.display = "none"
    document.getElementById('enter1').style.display = "none"
    document.getElementById('SendID1').style.display = "none"
    document.getElementById('1').style.display = "none"
    document.getElementById('t5').style.display = "none"
    document.getElementById('w1').style.display = "none"
    document.getElementById('w2').style.display = "none"
    document.getElementById('refresh').style.display = "none"
    document.getElementById('refresh2').style.display = "inline"
    document.getElementById('refresh3').style.display = "none"
    document.getElementById('therapistList').innerHTML = ""
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    document.getElementById('2').style.display = "none"
}
//הצגת הנתונים של מורה לעדכון
function updateTeacher() {
    document.getElementById('therapistList').innerHTML = ""

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDataTeacher/' + localStorage.getItem("id"), true);
    req.send();
    req.onload = function () {
        cus = JSON.parse(req.response);
        console.log(cus);
        // document.getElementById('refresh').style.display="block"
        document.getElementById('w1').style.display = "block"
        document.getElementById('w1').style.marginRight = "40%"

        document.querySelector('#nmf2').value = cus.LastName
        document.querySelector('#address2').value = cus.Address
        document.querySelector('#phone2').value = cus.Phone
    }

}
//הצגת הנתונים של לקוחה לעדכון
function updateCustomer() {
    // let id = document.querySelector("#enter").value;
    // localStorage.setItem("id", "" + id);
    document.getElementById('therapistList').innerHTML = ""
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDataCustomer/' + localStorage.getItem("id"), true);
    req.send();
    req.onload = function () {
        cus = JSON.parse(req.response);
        console.log(cus);
        // document.getElementById('refresh').style.display="block"
        document.getElementById('w').style.display = "block"
        document.getElementById('w').style.marginRight = "40%"

        document.querySelector('#nmf1').value = cus.LastName
        document.querySelector('#address1').value = cus.Address
        document.querySelector('#phone1').value = cus.Phone
        document.querySelector('#pharm1').value = cus.Pharm

    }

}
//הצגת הנתונים של לקוחה טיפולית לעדכון
function updateCustomerSpecial() {
    document.getElementById('therapistList').innerHTML = ""
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDataCustomerSpecial/' + localStorage.getItem("id"), true);
    req.send();
    req.onload = function () {
        cus = JSON.parse(req.response);
        console.log(cus);
        // document.getElementById('refresh').style.display="block"
        document.getElementById('w2').style.display = "block"
        document.getElementById('w2').style.marginRight = "40%"

        document.querySelector('#nmf3').value = cus.LastName
        document.querySelector('#address3').value = cus.Address
        document.querySelector('#phone3').value = cus.Phone
        document.querySelector('#pharm3').value = cus.Pharm
        document.querySelector('#Disability3').value = cus.SpecialSport.AreaOfDisability
        document.querySelector('#type3').value = cus.SpecialSport.TypeOfDisability
        document.querySelector('#lp3').value = cus.SpecialSport.ThereIsReference
    }

}
//עדכון הנתונים ללקוחה טיפולית לשליחה
function updateCustomerSpecial1() {
    let LastName = document.querySelector("#nmf3").value;
    let Address = document.querySelector("#address3").value;
    let Phone = document.querySelector("#phone3").value;
    let Pharm = document.querySelector("#pharm3").value;
    let Reference = document.querySelector("#lp3").value;
    let type = document.querySelector("#type3").value;
    let Disability = document.querySelector("#Disability3").value;

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/Api/Manager/GetUpdateCustomerSpecial/' + localStorage.getItem("id") + '/' + LastName + '/' + Address +
        '/' + Phone + '/' + Pharm + '/' + type + '/' + Disability + '/' + Reference, true);
    req.send();

    req.onload = function () {
        if (req.responseText == "1")
            alert("לקוחה טיפולית התעדכנה בהצלחה");
        else if (req.responseText == "-1")
            alert("לא קיים כזאת לקוחה");
        else
            alert("לא עדכן");
    }
}
//עדכון הנתונים ללקוחה לשליחה
function updateCustomer1() {
    let LastName = document.querySelector("#nmf1").value;
    let Address = document.querySelector("#address1").value;
    let Phone = document.querySelector("#phone1").value;
    let Pharm = document.querySelector("#pharm1").value;

    // localStorage.setItem("password", "" + Password);
    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req.open('get', 'https://localhost:44312/Api/Manager/GetUpdateCustomer/' + localStorage.getItem("id") + '/' + LastName + '/' + Address +
        '/' + Phone + '/' + Pharm , true);
    //שליחת הבקשה
    req.send();
    //req.responseText קבלת התשובה למשתנה
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
        alert("הלקוחה התעדכנה בהצלחה");
       else if (req.responseText == "-1")
            alert("לא קיימת לקוחה זו");
        else
            alert("לא התעדכן");
        }

}
//עדכון הנתונים למורה לשליחה
function updateTeacher1() {
    let LastName = document.querySelector("#nmf2").value;
    let Address = document.querySelector("#address2").value;
    let Phone = document.querySelector("#phone2").value;

    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req.open('get', 'https://localhost:44312/API/Manager/GetUpdateTeacher/' + localStorage.getItem("id") + '/' + LastName + '/' + Address + '/' + Phone , true);
    //שליחת הבקשה
    req.send();
    //req.responseText קבלת התשובה למשתנה
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
            alert("מורה התעדכנה בהצלחה");
        else if (req.responseText == "-1")
            alert("no exists teacher");
        else
            alert("dont update");
    }
}
//איפוס מסך
function refreshPageDelete() {
    document.getElementById('enterID1').style.display = "none"
    document.getElementById('SendID1').style.display = "none"
    document.getElementById('enter1').style.display = "none"
    document.getElementById('1').style.display = "none"
    document.getElementById('refresh3').style.display = "none"
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    document.getElementById('2').style.display = "none"
}
//הצגת כפתורי המחיקה
function Delete() {
    document.getElementById('SendID1').style.display = "inline"
    document.getElementById('enter1').style.display = "inline"
    document.getElementById('enterID1').style.display = "inline"
    document.getElementById('1').style.display = "inline"
    document.getElementById('SendID').style.display = "none"
    document.getElementById('enter').style.display = "none"
    document.getElementById('enterID').style.display = "none"
    document.getElementById('0').style.display = "none"
    document.getElementById('t5').style.display = "none"
    document.getElementById('w').style.display = "none"
    document.getElementById('w1').style.display = "none"
    document.getElementById('w2').style.display = "none"
    document.getElementById('refresh').style.display = "none"
    document.getElementById('refresh3').style.display = "inline"
    document.getElementById('refresh2').style.display = "none"
    document.getElementById('therapistList').innerHTML = ""
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    document.getElementById('2').style.display = "none"


}
//בדיקה מיזה למחיקה ושליחה לפונקצייה המתאימה
function IdForDelete() {
    let id = document.querySelector("#enter1").value;
    localStorage.setItem("id", "" + id);

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetSearchByIdForDelete/' + localStorage.getItem("id"), true);
    req.send();
    req.onload = function () {
        if (req.responseText == "1")
            sendToDeleteCT();
        else if (req.responseText == "2")
            sendToDeleteCR();
        else if (req.responseText == "3")
            sendToDeleteT()
        else
            alert("לא קיים מספר זהות זה");
    }
}
//מחיקת מורה
function sendToDeleteT() {
    let id = document.querySelector("#enter1").value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDeleteTeacher/' + id, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "1")
            alert("teacher deleted succesfully");
        else if (req.responseText == "-1")
            alert("there isnot teacher enter id again");
        else
            alert("dont deleted");
        //הדפסת התשובה על המסך
        // document.getElementById("req").innerHTML = req.responseText;
    }
}
//מחיקת לקוחה
function sendToDeleteCR() {

    let id = document.querySelector("#enter1").value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDeleteCustomersR/' + id, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
            alert("customer deleted succesfully");
        else if (req.responseText == "-1")
            alert("there isnot customer enter id again");
        else
            alert("dont deleted");
    }
}
//מחיקת לקוחה טיפולית
function sendToDeleteCT() {

    let id = document.querySelector("#enter1").value
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetDeleteCustomersT/' + id, true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if (req.responseText == "1")
            alert("special customer deleted succesfully");
        else if (req.responseText == "-1")
            alert("there isnot customer enter id again");
        else
            alert("dont deleted");
    }
}
//איפוס מסך
function less() {
    document.getElementById('enterID').style.display = "none"
    document.getElementById('enter').style.display = "none"
    document.getElementById('SendID').style.display = "none"
    document.getElementById('0').style.display = "none"
    document.getElementById('enterID1').style.display = "none"
    document.getElementById('enter1').style.display = "none"
    document.getElementById('SendID1').style.display = "none"
    document.getElementById('1').style.display = "none"
    document.getElementById('t5').style.display = "none"
    document.getElementById('w').style.display = "none"
    document.getElementById('w1').style.display = "none"
    document.getElementById('w2').style.display = "none"
    document.getElementById('refresh').style.display = "none"
    // document.getElementById('refresh2').style.display = "none"
    // document.getElementById('refresh3').style.display = "none"
    document.getElementById('therapistList').innerHTML = ""
    document.getElementById('enterID2').style.display = "none"
    document.getElementById('enter2').style.display = "none"
    document.getElementById('SendID2').style.display = "none"
    document.getElementById('2').style.display = "none"
    document.getElementById('putDetails1').style.display = "none"
    document.getElementById('day1').style.display = "none"
    document.getElementById('hour1').style.display = "none"
    document.getElementById('nameOfCourse1').style.display = "none"
    document.getElementById('sendToTime1').style.display = "none"
    document.getElementById('1send').style.display = "none"
    document.getElementById('putDetails2').style.display = "none"
    document.getElementById('day2').style.display = "none"
    document.getElementById('hour2').style.display = "none"
    document.getElementById('nameOfCourse2').style.display = "none"
    document.getElementById('sendToTime2').style.display = "none"
    document.getElementById('2send').style.display = "none"
    document.getElementById('putDetails3').style.display = "none"
    document.getElementById('day3').style.display = "none"
    document.getElementById('hour3').style.display = "none"
    document.getElementById('nameOfCourse3').style.display = "none"
    document.getElementById('sendToTime3').style.display = "none"
    document.getElementById('3send').style.display = "none"
    document.getElementById('addTime').style.display = "none"
    document.getElementById('updateTime').style.display = "none"
    document.getElementById('deleteTime').style.display = "none"
    document.getElementById('id4').style.display = "none"
    document.getElementById('day4').style.display = "none"
    document.getElementById('hour4').style.display = "none"
    document.getElementById('nameOfCourse4').style.display = "none"
    document.getElementById('sendToTime4').style.display = "none"
    document.getElementById('4send').style.display = "none"
    document.getElementById('putDetails4').style.display = "none"
    // document.getElementById('less').style.display = "none"


}
//הצגת כל הלקוחות הרגילות
function GetShowAllCustomersR() {
    less()

    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetShowAllCustomersR', true);
    req.send();
    req.onload = function () {
        users = JSON.parse(req.response);
        console.log(users);

        let table = document.createElement('table')
        table.setAttribute('class', 'table table-primary table-bordered table-hover')

        //שורת כותרת
        let r = document.createElement('tr');
        //עמודות כותרת
        let d1 = document.createElement('th');
        d1.innerHTML = "תעודת זהות"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם פרטי"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם משפחה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = " כתובת"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "טלפון"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "סיסמא"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "גיל"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "קופת חולים"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "הביאה התחיבות"
        r.appendChild(d1)

        // d1 = document.createElement('th');
        // d1.innerHTML = "שם חוג"
        // r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "תאריך הרשמה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "כמות שיעורים"
        r.appendChild(d1)
        // הוספת שורת כותרת
        table.appendChild(r)

        //שורות תוכן
        for (let i = 0; i < users.length; i++) {
            let r = document.createElement('tr');
            //עמודות תוכן
            //תעודת זהות
            let d1 = document.createElement('td');
            d1.innerHTML = users[i].Id
            r.appendChild(d1)
            //שם פרטי
            d1 = document.createElement('td');
            d1.innerHTML = users[i].FirstName
            r.appendChild(d1)
            //שם משפחה
            d1 = document.createElement('td');
            d1.innerHTML = users[i].LastName
            r.appendChild(d1)
            //כתובת 
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Address
            r.appendChild(d1)
            //טלפון
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Phone
            r.appendChild(d1)
            //סיסמא
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Password
            r.appendChild(d1)
            //גיל
            d1 = document.createElement('td');
            let d = new Date().getFullYear();
            d1.innerHTML = d - users[i].Age;
            r.appendChild(d1)

            //קופת חולים
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Pharm;
            r.appendChild(d1)
            //הביאה התחיבות
            d1 = document.createElement('td');
            d1.innerHTML = (users[i].GivePrescription == true ? 'כן' : 'לא');
            r.appendChild(d1)
            //שם חוג 
            //  d1 = document.createElement('td');
            //  d1.innerHTML = users[i].NormalSport
            //  r.appendChild(d1)
            // תאריך
            d1 = document.createElement('td');
            d1.innerHTML = String(users[i].Date).substring(0, 10)
            r.appendChild(d1)
            // כמה שיעורים
            d1 = document.createElement('td');
            d1.innerHTML = users[i].AmountOfLesson
            r.appendChild(d1)

            // הוספת שורות תוכן
            table.appendChild(r)
        }

        document.getElementById('therapistList').appendChild(table)
    }

}
//הצגת כל הלקוחות הטיפוליות
function GetShowAllCustomersT() {
    less()
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetShowAllCustomersT', true);
    req.send();
    req.onload = function () {
        users = JSON.parse(req.response);
        console.log(users);

        let table = document.createElement('table')
        table.setAttribute('class', 'table table-primary table-bordered table-hover')

        //שורת כותרת
        let r = document.createElement('tr');
        //עמודות כותרת
        let d1 = document.createElement('th');
        d1.innerHTML = "תעודת זהות"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם פרטי"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם משפחה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = " כתובת"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "טלפון"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "סיסמא"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "גיל"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "קופת חולים"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "תאריך הרשמה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "סוג המגבלה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "אזור המגבלה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "ישנה הפנייה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "כמות התחיבויות"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "האם יש שיפור - דוח שיעור קודם" 
        r.appendChild(d1)
        // הוספת שורת כותרת
        table.appendChild(r)

        //שורות תוכן
        for (let i = 0; i < users.length; i++) {
            let r = document.createElement('tr');
            //עמודות תוכן
            //תעודת זהות
            let d1 = document.createElement('td');
            d1.innerHTML = users[i].Id
            r.appendChild(d1)
            //שם פרטי
            d1 = document.createElement('td');
            d1.innerHTML = users[i].FirstName
            r.appendChild(d1)
            //שם משפחה
            d1 = document.createElement('td');
            d1.innerHTML = users[i].LastName
            r.appendChild(d1)
            //כתובת 
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Address
            r.appendChild(d1)
            //טלפון
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Phone
            r.appendChild(d1)
            //סיסמא
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Password
            r.appendChild(d1)
            //גיל
            d1 = document.createElement('td');
            let d = new Date().getFullYear();
            d1.innerHTML = d - users[i].Age;
            r.appendChild(d1)

            //קופת חולים
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Pharm;
            r.appendChild(d1)

            //תאריך
            d1 = document.createElement('td');
            d1.innerHTML = String(users[i].Date).substring(0, 10)
            r.appendChild(d1)

            //סוג
            d1 = document.createElement('td');
            d1.innerHTML = users[i].SpecialSport.TypeOfDisability
            r.appendChild(d1)
            // //אזור
            d1 = document.createElement('td');
            d1.innerHTML = users[i].SpecialSport.AreaOfDisability
            r.appendChild(d1)
            //ישנה הפנייה
            d1 = document.createElement('td');
            d1.innerHTML = (users[i].SpecialSport.ThereIsReference == true ? 'כן' : 'לא')
            r.appendChild(d1)
            // כמות התחיבויות
            d1 = document.createElement('td');
            d1.innerHTML = users[i].SpecialSport.HowPrescription
                r.appendChild(d1)
            //האם יש שיפור 
            d1 = document.createElement('td');
            d1.innerHTML = users[i].SpecialSport.DoThereIsImprovement
                r.appendChild(d1)
            // הוספת שורות תוכן
            table.appendChild(r)

        }

        document.getElementById('therapistList').appendChild(table)
        console.log(req.responseText)
    }

}
//הצגת כל המורות
function GetShowAllTeachers() {
    less()
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/API/Manager/GetShowAllTeachers', true);
    req.send();
    req.onload = function () {
        users = JSON.parse(req.response);
        console.log(users);

        let table = document.createElement('table')
        table.setAttribute('class', 'table table-primary table-bordered table-hover')

        //שורת כותרת
        let r = document.createElement('tr');
        //עמודות כותרת
        let d1 = document.createElement('th');
        d1.innerHTML = "תעודת זהות"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם פרטי"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם משפחה"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = " כתובת"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "טלפון"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "סיסמא"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "שם חוג"
        r.appendChild(d1)

        d1 = document.createElement('th');
        d1.innerHTML = "כמות שיעורים"
        r.appendChild(d1)
        // הוספת שורת כותרת
        table.appendChild(r)

        //שורות תוכן
        for (let i = 0; i < users.length; i++) {
            let r = document.createElement('tr');
            //עמודות תוכן
            //תעודת זהות
            let d1 = document.createElement('td');
            d1.innerHTML = users[i].Id
            r.appendChild(d1)
            //שם פרטי
            d1 = document.createElement('td');
            d1.innerHTML = users[i].FirstName
            r.appendChild(d1)
            //שם משפחה
            d1 = document.createElement('td');
            d1.innerHTML = users[i].LastName
            r.appendChild(d1)
            //כתובת 
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Address
            r.appendChild(d1)
            //טלפון
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Phone
            r.appendChild(d1)
            //סיסמא
            d1 = document.createElement('td');
            d1.innerHTML = users[i].Password
            r.appendChild(d1)

            //שם חוג 
             d1 = document.createElement('td');
             d1.innerHTML = users[i].Course.NameOfCourse
             r.appendChild(d1)

            // כמה שיעורים
            d1 = document.createElement('td');
            d1.innerHTML = users[i].AmountOfLessonTeacher
            r.appendChild(d1)

            // הוספת שורות תוכן
            table.appendChild(r)
        }

        document.getElementById('therapistList').appendChild(table)
    }
}







