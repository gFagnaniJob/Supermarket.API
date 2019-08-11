## Products API DOCS

  

#### GET /api/products

  

> Get all products

  

##### Response Body Example:

  

    [
    
	    {
	    
		    "id": 1,
		    
		    "name": "Apple",
		    
		    "quantityInPackage": 1,
		    
		    "unitOfMeasurement": "UN",
		    
		    "category": {
		    
			    "id": 1,
			    
			    "name": "Fruits and Vegetables"
			    
		    }
	    
	    },
	    
	    {
	    
		    "id": 2,
		    
		    "name": "Milk",
		    
		    "quantityInPackage": 2,
		    
		    "unitOfMeasurement": "L",
		    
		    "category": {
		    
			    "id": 1,
			    
			    "name": "Fruits and Vegetables"
			    
		    }
		    
	    }
    
    ]

#### POST /api/products

> Add a product

  

##### Request Body Example:

  

    {
	    "name": "Roses",
		"quantityinpackage": 2,
		"unitofmeasurement": 1,
		"categoryId": 2
    }

##### Response Body Example:

###### Status: 200 OK

  


    {
    
	    "id": 3,
	    
	    "name": "Roses",
	    
	    "quantityInPackage": 2,
	    
	    "unitOfMeasurement": "UN",
	    
	    "category": {
	    
		    "id": 2,
		    
		    "name": "Dairy"
		    
	    }
    
    }

###### Status: 400 BadRequest

  

    [
	    "The Name field is required."
    ]

#### PUT /api/products/{id}

> Update the product with id = {id}

##### Request Body Example:

  

    {
    	"name": "Potatoes",
    	"quantityinpackage": 1,
    	"unitofmeasurement": 4,
    	"categoryId": 1
    }



##### Response Body Example:

###### Status: 200 OK

    {
    
	    "id": 3,
	    
	    "name": "Potatoes",
	    
	    "quantityInPackage": 1,
	    
	    "unitOfMeasurement": "KG",
	    
	    "category": {
	    
		    "id": 1,
		    
		    "name": "Fruits and Vegetables"
		    
	    }
    
    }

###### Status: 400 BadRequest

  

    Product not found.

#### DELETE /api/products/{id}

> Delete the product with id = {id}

##### Response Body Example:

###### Status: 200 OK

  


    {
    
	    "id": 3,
	    
	    "name": "Potatoes",
	    
	    "quantityInPackage": 1,
	    
	    "unitOfMeasurement": "KG",
	    
	    "category": {
	    
		    "id": 1,
		    
		    "name": "Fruits and Vegetables"
		    
	    }
    
    }

###### Status: 400 BadRequest

  

    Product not found.
