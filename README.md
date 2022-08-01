# Toughbuilt
Prueba Tecnica - Jeisson Juanias

Consumo de API

[GET] 
  https://localhost:7265/api/Product
  
[GET] 
  https://localhost:7265/api/Product/{id}
  
[GET] 
  https://localhost:7265/api/Product/{text}
  
[POST]
 https://localhost:7265/api/Product/Product
  
  Request body
    
  {
    "product_id": 0,
    "product": "string",
    "description": "string",
    "stock": 0,
    "price": 0,
    "type": "string",
    "active": 0
  }
  
[PUT]
 https://localhost:7265/api/Product
  
  Request body
    
  {
    "id": 0,
    "product_id": 0,
    "product": "string",
    "description": "string",
    "stock": 0,
    "price": 0,
    "type": "string",
    "active": 0
  }
  
[DELETE] 
  https://localhost:7265/api/Product/{id}
  
  
  
  
