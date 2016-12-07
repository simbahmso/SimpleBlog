using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        public string Test { get; set; }
        
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }  
    }
}