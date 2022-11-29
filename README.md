
# Real Estate CRM Backend API

This project contains the backend code for the Real Estate CRM project.

Target Framework: net5.0 required to run.




## API Reference
The authentication method is the only one implemented by now. This validates the user and password, returns its credentials including menus allowed to access.

#### Authenticate user

```http
  POST /api/Auth/authenticate
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `user` | `string` | **Required**. Your username |
| `pwd` | `string` | **Required**. Your password |
| `id_user` | `int` |  Possible User id |
| `id_role` | `int` |  Possible Role id |



