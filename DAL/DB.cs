using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DB
    {

       public static string passwordmanager = "987654321";


        //רשימת לקוחות עם כל הפרטים
        public static List<Customers> Customers { get; set; } = new List<Customers>()
        {
        new Customers("214376196","הדסה","שמש","הלל","0583234052","לאומית","21352",12,new Normal_sport("pilatis"),new DateTime(01/01/2020),9,true),
        new Customers("322259623","פנינה","יצחק","שמאי","0504173228","מכבי","52412",18,new Normal_sport("feetball"),new DateTime(01/01/2020),8,false),
        new Customers("25142340","דבורה","ציוני","אביי","0583814052","כללית","78954",55,new Normal_sport("pilatis"),new DateTime(01/01/2020),7,false),
        new Customers("214526253","יפה","עסיס","חיסדא","0548414052","מאוחדת","74581",88,new Normal_sport("zumba"),new DateTime(01/01/2020),0,true)
        };
        //רשימת לקוחות שבאות ללא התחייבות
        public static List<Customers> ListCustomer { get; set; } = new List<Customers>() { };
        //רשימת מורות
        public static List<Teachers> Teachers { get; set; } = new List<Teachers>()
        {
        new Teachers("874595877","יפית","שמש","רבא","0583234052","2135212",0,new Normal_sport("zumba")),
        new Teachers("123524152","שירה","שמעונוב","שמאי","0504173228","5241212",9,new Normal_sport("zumba")),
        new Teachers("758425874","חנה","ציוני","אביי","0583814052","7895414",7,new Normal_sport("zumba")),
        new Teachers("325652421","גילה","עסיס","חיסדא","0548414052","7458187",2,new Normal_sport("zumba"))
        };

        public static List<Customers> specialCustomers { get; set; } = new List<Customers>()
        {
        new Customers("251478965","רבקה","יפת","הלל","0504173225","לאומית","98745",12,new TherapeuticSports(true,"ppp","ppp"),new DateTime(01/01/2020)),
        new Customers("325412589","שירה","שלום","שמאי","0548414745","מכבי","12365",18,new TherapeuticSports(true,"ooo","ooo"),new DateTime(01/01/2020)),
        new Customers("215487965","חיה","ציון","אביי","0527146585","כללית","45874",55,new TherapeuticSports(true,"ppp","ooo"),new DateTime(01/01/2020))
        };
    }
}
