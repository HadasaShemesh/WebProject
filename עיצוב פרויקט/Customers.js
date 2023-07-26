//הכנסת לקוחה חדשה
function sendRequest() {
    //שליפת השם לשליחה
    let FirstName = document.querySelector("#FirstName").value;
    let LastName = document.querySelector("#nmf").value;
    let Id = document.querySelector("#id").value;
    let Address = document.querySelector("#address").value;
    let Phone = document.querySelector("#phone").value;
    let Pharm = document.querySelector("#pharm").value;
    let Password = document.querySelector("#code").value;
    let Age = document.querySelector("#age").value;
    let Date1 = document.querySelector("#date").value;

    let d = new Date().getFullYear();
    d= d -Age;

   if(d<16)
   alert("לקוחה בגיל זה לא יכולה להרשם")
   else{
    // localStorage.setItem("password", "" + Password);
    //יצירת קריאה חדשה
    let req = new XMLHttpRequest();
    //פתיחת קריאה חדשה - סוג וכתובת
    req.open('get', 'https://localhost:44312/Api/Customers/GetNewCustomer/' + FirstName + '/' + LastName + '/' + Id + '/' + Address +
        '/' + Phone + '/' + Pharm + '/' + Password + '/' + Age + '/' + Date1 , true);
    //שליחת הבקשה
    req.send();
    //req.responseText קבלת התשובה למשתנה
    req.onload = function () {
        //הדפסת התשובה על המסך
        if(req.responseText=="-1")
        alert(" you dont give prescription");
        else if(req.responseText=="-2")
        alert("exist this password enter another password");
        else if(req.responseText=="-3")
        alert("מספר זהות זה רשום כבר במערכת");
        else
        alert("נרשמת בהצלחה");
 
        // alert("you are " + req.responseText + " customer");
    }
}
}
//הפחתת שיעורים ללקוחה
function sendToLess() {
    let Password = document.querySelector("#code1").value;
    localStorage.setItem("password", "" + Password);
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/Api/Customers/GetEnterByPassword/' + localStorage.getItem("password"), true);
    req.send();
    req.onload = function () {
        //הדפסת התשובה על המסך
        if(req.responseText=="0")
        alert("this customer isnt exist");
        else if(req.responseText=="-1")
        alert("your lessons are finished, buy lesson again");
        else
        alert("yoe rest " + req.responseText + " lessons");
    }

}


//function EnterPrivateCustomers() {
//     let FirstName = document.querySelector("#nm").value;
//     let LastName = document.querySelector("#lnf").value;
//     let GivePrescription = document.querySelector("#lpp").value;
//     let req = new XMLHttpRequest();
//     req.open('get', 'https://localhost:44312/Api/Customers/GetCustomer/' + FirstName + '/' + LastName + '/' + GivePrescription, true);
//     req.send();
//     req.onload = function () {
//         //הדפסת התשובה על המסך
//         document.getElementById("res3").innerHTML = req.responseText;
//     }
// }

//כניסה לדף של הספורט הטיפולי לפי סיסמא
function sendToPay() {
    let Password = document.querySelector("#code3").value;
    localStorage.setItem("password", "" + Password);
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/Api/Customers/GetSpecialCPassword/' + localStorage.getItem("password"), true);
    req.send();
    req.onload = function () {
        if (req.responseText == "true")
            window.location.href = "PAY.html"
        else
            alert("wrong password enter again");
    }
}
//הוספת לקוחה טיפולית
function sendSpecialCustomer() {
    let FirstName = document.querySelector("#FirstName").value;
    let LastName = document.querySelector("#nmf").value;
    let Id = document.querySelector("#id").value;
    let Address = document.querySelector("#address").value;
    let Phone = document.querySelector("#phone").value;
    let Pharm = document.querySelector("#pharm").value;
    let Password = document.querySelector("#code").value;
    let Age = document.querySelector("#age").value;
    let Date1 = document.querySelector("#date").value;
    let Reference = document.querySelector("#lp").value;
    let type = document.querySelector("#type").value;
    let Disability = document.querySelector("#Disability").value;

    let d = new Date().getFullYear();
    d= d -Age;
    if(d<16)
    alert("לקוחה בגיל זה לא יכולה להרשם")

    else{
       let req = new XMLHttpRequest();
       req.open('get', 'https://localhost:44312/Api/Customers/GetNewSpecialCustomer/' + FirstName + '/' + LastName + '/' + Id + '/' + Address +
           '/' + Phone + '/' + Pharm + '/' + Password + '/' + Age + '/' + Date1 + '/' + type + '/' + Disability + '/' + Reference, true);
       req.send();
       req.onload = function () {
          
           if(req.responseText=="-2")
           alert("exist this password enter another password");
           else if(req.responseText=="-3")
           alert("מספר זהות זה רשום כבר במערכת");
           else
           alert("נרשמת בהצלחה");
           // alert("you are " + req.responseText + " customer");
       }
    } 
}
//שליחה האם יש שיפור
function sendTextImrove() {
    let improve = document.querySelector("#improve").value;
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/Api/Customers/GetThereIsImprove/' + localStorage.getItem("password")+'/'+improve, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "1")
        alert("השיפור עודכן בהצלחה");   
             else
            alert("לא קיים במערכת , לא עודכן שיפור");
    }
}
//כמות מרשמים-התחיבויות
function amountOFprescription() {
    let amount = document.querySelector("#amount").value;
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/Api/Customers/GetGivePresCripTion/' + localStorage.getItem("password")+'/'+amount, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "-1")
        alert("לא עודכן");   
             else
            alert("yoe have " + req.responseText + " lessons");
    }
}
//הורדת שיעורים
function lessPrescription() {
    let less = document.querySelector("#less").value;
    let req = new XMLHttpRequest();
    req.open('get', 'https://localhost:44312/Api/Customers/GetToLessLesson/' + localStorage.getItem("password")+'/'+less, true);
    req.send();
    req.onload = function () {
        if (req.responseText == "-1")
        alert("לא עודכן");   
       else if (req.responseText == "0")
        alert("אין מספיק התחיבויות"); 
             else
            alert("yoe rest " + req.responseText + " lessons");
    }
}
