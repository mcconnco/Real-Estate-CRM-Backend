
# Real Estate CRM Backend API

This project contains the backend code for the Real Estate CRM project.

Target Framework: net5.0 required to run.




## API Reference
All of our documentation and API description/usage is documented through Swagger. This can be accessed while running the project. This contains all the API REST calls, its parameters, required fields, schemas, and expected return values.

![Capture](https://github.com/mcconnco/Real-Estate-CRM-Backend/assets/45697531/ab0204b5-a4df-474e-9572-8f74e6120ec7)
![Capture2](https://github.com/mcconnco/Real-Estate-CRM-Backend/assets/45697531/c1b34974-01f0-4e52-b35b-22b8b03ec785)


#### Authenticate user
This validates the user and password, returns its credentials including menus allowed to access.
```http
  POST /api/Auth/authenticate
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `user` | `string` | **Required**. Your username |
| `pwd` | `string` | **Required**. Your password |
| `id_user` | `int` |  Possible User id |
| `id_role` | `int` |  Possible Role id |



