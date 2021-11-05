This program has its own repository, and can be run from VS Code by hitting F5. 

The API can be tested using Postman or Swagger using the URI https://localhost:5001

POST and GET operations can be sent to https://localhost:5001/items. Using GET like this will return all items in the database

PUT and DELETE operations, as well as GET operations for a specific database item, will require an id template, such as https://localhost:5001/items/503-12eedea-10