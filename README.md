# WebAPI
.net core api practice project

- CRUD operations
- connection to sql express database
- Entity framework
- Asynchronous programming

## Overview

GET method returns json format of items from sql database

<img src="/assets/GET.png" alt="GET request" width="650"/>

POST method takes in DTO of Item class, allowing the user to send in only name and price of an item, while ID gets generated automatically

<img src="/assets/POST.png" alt="POST request" width="650"/>

<img src="/assets/GET2.png" alt="GET request updated" width="650"/>

PUT method takes in DTO of Item class, only allowing to change the name and price. ID has to be provided in the route

<img src="/assets/PUT.png" alt="PUT request" width="650"/>

Item can be received based on ID.

<img src="/assets/GET3.png" alt="GET request by id" width="650"/>

DELETE method removes the item based on provided ID

<img src="/assets/DELETE.png" alt="DELETE request" width="650"/>

<img src="/assets/GET4.png" alt="GET request not found" width="650"/>

All methods are async.

Tested using Postman.
