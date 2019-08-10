## Categories API DOCS

#### GET /api/categories

> Get all categories

##### Response Body Example:

    [
        {
            "id": 1,
            "name": "Fruits and Vegetables"
        },
        {
            "id": 2,
            "name": "Dairy"
        } 
    ]
#### POST /api/categories
> Add a category

##### Request Body Example:

    {
    	"name": "Former Bakery"
    }
##### Response Body Example:
###### Status: 200 OK

    {
        "id": 3,
        "name": "Bakery"
    }
###### Status: 400 BadRequest

    [
        "The Name field is required."
    ]
#### PUT /api/categories/{id}
> Update the category with id = {id}
##### Request Body Example:

    {
    	"name": "Former Bakery"
    }
##### Response Body Example:
###### Status: 200 OK

    {
        "id": 3,
        "name": "Former Bakery"
    }
###### Status: 400 BadRequest

    Category not found.
#### DELETE /api/categories/{id}
> Delete the category with id = {id}
##### Response Body Example:
###### Status: 200 OK

    {
        "id": 3,
        "name": "Former Bakery"
    }
###### Status: 400 BadRequest

    Category not found.## Categories API DOCS

#### GET /api/categories

> Get all categories

##### Response Body Example:

    [
        {
            "id": 1,
            "name": "Fruits and Vegetables"
        },
        {
            "id": 2,
            "name": "Dairy"
        } 
    ]
#### POST /api/categories
> Add a category

##### Request Body Example:

    {
    	"name": "Former Bakery"
    }
##### Response Body Example:
###### Status: 200 OK

    {
        "id": 3,
        "name": "Bakery"
    }
###### Status: 400 BadRequest

    [
        "The Name field is required."
    ]
#### PUT /api/categories/{id}
> Update the category with id = {id}
##### Request Body Example:

    {
    	"name": "Former Bakery"
    }
##### Response Body Example:
###### Status: 200 OK

    {
        "id": 3,
        "name": "Former Bakery"
    }
###### Status: 400 BadRequest

    Category not found.
#### DELETE /api/categories/{id}
> Delete the category with id = {id}
##### Response Body Example:
###### Status: 200 OK

    {
        "id": 3,
        "name": "Former Bakery"
    }
###### Status: 400 BadRequest

    Category not found.