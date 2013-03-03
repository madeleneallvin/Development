using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace Allvinskan.Booking
{
    public class Permissions : IPermissionProvider
    {

        public Feature Feature
        {
            get { throw new System.NotImplementedException(); }
        }

        public IEnumerable<Permission> GetPermissions()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            throw new System.NotImplementedException();
        }
    }
}