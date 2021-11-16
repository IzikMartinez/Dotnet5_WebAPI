This program reads and writes to a MongoDB instance running on port 27017 with host name "localhost"

The API can be tested with Postman or Swagger using the URI https://localhost:5001

POST and GET operations can be sent to https://localhost:5001/items. Using GET like this will return all items in the database

The expected payload for a POST operation is  
{  
    "name": "Name of item",  
    "price": 10  
}

PUT and DELETE operations, as well as GET operations for a specific database item, will require an id template, such as https://localhost:5001/items/503-12eedea-10