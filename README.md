# Labb3Api

Get All Users
Requests
curl -X 'GET' \
  'https://localhost:7233/api/Labb3' \
  -H 'accept: */*'
  Response
  [
  {
    "userID": 1,
    "firstName": "Anas",
    "lastName": "Qlok",
    "phone": "023329248"
  },
  {
    "userID": 2,
    "firstName": "Maureen",
    "lastName": "Larsson",
    "phone": "072362462"
  },
  {
    "userID": 3,
    "firstName": "Sara",
    "lastName": "Sarasson",
    "phone": "2099425498"
  }
]

Get Interests by user ID
Request
curl -X 'GET' \
  'https://localhost:7233/api/Labb3/Interests/3' \
  -H 'accept: */*''
  Reponse
[
  {
    "interestsID": 3,
    "interestsName": "Football",
    "interestsDescription": "Kick a ball around and try to score"
  },
  {
    "interestsID": 4,
    "interestsName": "Skateboarding",
    "interestsDescription": "Wooden board with wheels"
  },
  {
    "interestsID": 5,
    "interestsName": "Coffee",
    "interestsDescription": "Coffee is made out of roasted beans, fun to make and drink"
  }
]

Get links to interests by user ID
Request 
[
  {
    "linkID": 3,
    "link": "https://sv.wikipedia.org/wiki/Football"
  },
  {
    "linkID": 4,
    "link": "https://en.wikipedia.org/wiki/Skateboarding"
  },
  {
    "linkID": 5,
    "link": "https://en.wikipedia.org/wiki/Coffee"
  },
  {
    "linkID": 6,
    "link": "https://www.britannica.com/topic/coffee"
  }
]

Connect user to another interest
Request 
curl -X 'POST' \
  'https://localhost:7233/api/Labb3/Uinterests' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "userID": 3,
  "interestsID": 1
}'

Respone
{
  "id": 15,
  "userID": 3,
  "user": null,
  "interestsID": 1,
  "interests": null,
  "linksID": null,
  "links": null
}

Add new link to specific interest and user
Request
curl -X 'POST' \
  'https://localhost:7233/api/Labb3/AddLinks?newLink=https%3A%2F%2Flearn.microsoft.com%2Fen-us%2Fdotnet%2Fcsharp%2F&Id=3&InterestID=1&LinkID=11' \
  -H 'accept: */*' \
  -d ''
  Response
  {
  "linkID": 11,
  "link": "https://learn.microsoft.com/en-us/dotnet/csharp/"
}






















