//הצגת כל השיעורים
function sendListTherapist() {
    let req = new XMLHttpRequest()
    req.open('get', 'https://localhost:44312/API/Manager/GetShowAllLesson', true)
    req.send()
    req.onload = function () {

        lessons = JSON.parse(req.response);
        console.log(lessons);

        let table = document.createElement('table')
        table.setAttribute('class', 'table table-primary table-bordered table-hover')

//שורת כותרת
let r = document.createElement('tr');
//עמודות כותרת
// let d1 = document.createElement('th');
// d1.innerHTML = "מספר חוג"
// r.appendChild(d1)


d1 = document.createElement('th');
d1.innerHTML ="שעה" 
r.appendChild(d1)

d1 = document.createElement('th');
d1.innerHTML = "שם חוג"
r.appendChild(d1)


d1 = document.createElement('th');
d1.innerHTML = "יום"
r.appendChild(d1)



// הוספת שורת כותרת
table.appendChild(r)


//שורות תוכן
for (let i = 0; i < lessons.length; i++) {
    let r = document.createElement('tr');
    //עמודות תוכן
    // let d1 = document.createElement('td');
    // d1.innerHTML = lessons[i].IdLesson
    // r.appendChild(d1)
    

    d1 = document.createElement('td');
    d1.innerHTML = lessons[i].Hour
    r.appendChild(d1)

    d1 = document.createElement('td');
    d1.innerHTML = lessons[i].NameOfCourse
    r.appendChild(d1)
    
    d1 = document.createElement('td');
    d1.innerHTML = lessons[i].Day
    r.appendChild(d1)

    

    // הוספת שורות תוכן
    table.appendChild(r)

}

document.getElementById('lessons').appendChild(table)
}

}



//  //שורת כותרת
//  let r = document.createElement('tr');
//  //עמודות כותרת

 
//  let d1 = document.createElement('th');
//  d1.innerHTML = "יום שישי"
//  r.appendChild(d1)

//  d1 = document.createElement('th');
//  d1.innerHTML ="יום חמישי" 
//  r.appendChild(d1)

//  d1 = document.createElement('th');
//  d1.innerHTML = "יום רביעי"
//  r.appendChild(d1)


//  d1 = document.createElement('th');
//  d1.innerHTML ="יום שלישי" 
//  r.appendChild(d1)
 
//  d1 = document.createElement('th');
//  d1.innerHTML = "יום שני"
//  r.appendChild(d1)


//   d1 = document.createElement('th');
//  d1.innerHTML = "יום ראשון"
//  r.appendChild(d1)

//  d1 = document.createElement('th');
//  d1.innerHTML = "שעה"
//  r.appendChild(d1)


//  // d2 = document.createElement('tr');
//  // d2.innerHTML = "9:00"
//  // r.appendChild(d2)

//  // הוספת שורת כותרת
//  table.appendChild(r)


//  //שורות תוכן
//  for (let i = 0; i < lessons.length; i++) {
//      let r = document.createElement('tr');
//      //עמודות תוכן
//      let d1 = document.createElement('td');
//      d1.innerHTML = lessons[i].IdLesson
//      r.appendChild(d1)

//      d1 = document.createElement('td');
//      d1.innerHTML = lessons[i].Day
//      r.appendChild(d1)

//      d1 = document.createElement('td');
//      d1.innerHTML = lessons[i].Hour
//      r.appendChild(d1)

//      d1 = document.createElement('td');
//      d1.innerHTML = lessons[i].NameOfCourse
//      r.appendChild(d1)

//      // הוספת שורות תוכן
//      table.appendChild(r)

//  }

//  document.getElementById('lessons').appendChild(table)
// }
// // document.getElementById("message").innerHTML = req.responseText



