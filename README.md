# Harmoni Backend Admin 
Är backend-delen av en projektuppgift som är skapad för ett fiktivt företag vid namn Harmoni spa & relax. 

Skapad av Erika Vestin, 2024.

erbj1201@student.miun.se 


## Om applikationen
Gränssnittet är skapat med ASP.NET MVC Core och är databasdriven med hjälp av Entity Framework och SQLite. Det är skapat enligt model first och contollers och views har scaffoldats fram. Det finns inloggningsfunktionalitet och möjlighet att registera användare med hjälp av NuGet-paktet Identity. Vyer kopplade till inloggning och registrering har scaffoldats fram.


Hela gränssnittet är på svenska.

### Web api
Web apit tillåter metoderna get för booking, treatment, staff och product. Metoden post fungerar endast till booking.

#### Endpoints och användning
Denna URL användes av mig lokalt på datorn: http://localhost:5108/api


Treatment


Metod Ändpunkt Beskrivning


GET /treatment Hämtar alla behandlingar




Product


Metod Ändpunkt Beskrivning



GET /product Hämtar alla produkter




Staff


Metod Ändpunkt Beskrivning


GET /staff Hämtar all personal




Booking


Metod Ändpunkt Beskrivning


GET /bookig Hämtar alla bokningar


POST /booking Lägger till ny bokning


Format på objekt


Treatment 



{


"_id": "65900ddf931ba946be6a2744",

"name": "Kanelbulle",

"description": "Vetebulle med kanel, socker, kardemumma, pärlsocker",

"category": "Frukost",

"price": "25kr",

"__v": 0


}

Booking


{


    "id": 62,


    "bookingName": "Erika Vestin",


    "bookingEmail": "erikabjorklund13@hotmail.com",


    "bookingPhone": "0701231422",


    "bookingDate": "2024-03-23T19:35:00",


    "treatmentId": 26,


    "treatments": null


  }

  Staff


    {


    "id": 2,


    "staffName": "Martin Vestin"


  }


  Product 


  {


    "id": 13,


    "productName": "Schampo normalt hår",


    "productPrice": "99 kr",


    "productCategory": "Schampo & balsam"


  }