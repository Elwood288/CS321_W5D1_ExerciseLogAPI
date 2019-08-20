
using Microsoft.AspNetCore.Identity;

namespace CS321_W5D1_ExerciseLogAPI.Core.Models
{
    // TODO: inherit from IdentityUser
    public class User : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
