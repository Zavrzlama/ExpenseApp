using System.Collections.Generic;
using ExpensesApp.API.Models;

namespace ExpensesApp.API
{
    public class ClientRolesService
    {
        public static ClientRolesService Current = new ClientRolesService();
        public  List<ClientRoleDTO> Roles = new List<ClientRoleDTO>();

        public ClientRolesService()
        {
            Roles.Add(new ClientRoleDTO() {ID = 1, RoleName = "Father", Description = "Description 1"});
            Roles.Add(new ClientRoleDTO() {ID = 2, RoleName = "Mother", Description = "Description 2"});
            Roles.Add(new ClientRoleDTO() {ID = 3, RoleName = "Son", Description = "Description 3"});
            Roles.Add(new ClientRoleDTO() {ID = 4, RoleName = "Daughter", Description = "Description 4"});
        }
    }
}