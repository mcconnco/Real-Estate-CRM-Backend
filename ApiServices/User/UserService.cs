using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class UserService
    {
        private UserDto resp;
        private UserData AccessData;

        private static UserResult CastDataUser(DataRow dr)
        {
            UserResult r = new();
            r.id_user = (int)dr["id_user"];
            r.first_name = (string)dr["first_name"];
            r.last_name = (string)dr["last_name"];
            r.sw_active = (int)dr["sw_active"];
            r.sw_admin = (int)dr["sw_admin"];
            r.sw_agent = (int)dr["sw_agent"];
            var id_user = dr["id_user_create"];
            r.id_user_create = id_user == null ? (int)id_user : 0;
            r.datetime_create = (DateTime)dr["datetime_create"];
            return r;
        }

        public UserDto GetAll()
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.getAll_Users();
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "User list retrieved successfully!";
                    resp.Users = new();

                    for (int i = 0; i < DsTable.Count; i++)
                    {
                        UserResult u = new();
                        u = CastDataUser(DsTable[i]);
                        resp.Users.Add(u);
                    }
                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
        public UserDto GetUser(int id_user)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.getUser(id_user);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "User updated successfully!";
                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }


        public UserDto Create(UserModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.register_user(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Interest created successfully!";

                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
        public UserDto Update(User model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.update_user(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "User updated successfully!";

                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
        public UserDto Deactivate(UserDelete model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.delete_user(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "User deactivated successfully!";

                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
    }
}
