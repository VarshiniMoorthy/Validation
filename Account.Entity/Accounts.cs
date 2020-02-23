using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Account.Entity
{
    public class Accounts
    {
        // [Required(ErrorMessage = "Email Required")]




       // [RegularExpression(" ^[a - zA - Z0 - 9_\\.-] +@([a - zA - Z0 - 9 -] +\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not Valid EmailId")]
        //[Required]
        [Required]
        public string EmailId { get; set; }
        // [Required(ErrorMessage = "Password Required")]
        //[Required]
        [Required]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Please Provide Gender")]
        [Required]
        public string Gender { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Age")]
        [Range(25, 45, ErrorMessage = "Age Should be min 25 and max 45")]
        [Required]
        public byte Age { get; set; }
        //[Required(ErrorMessage = "City Required")]
        [Required]
        public string City { get; set; }

        //[Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = " language known required")]
       
        public string LanguageKnown { get; set; }

        public Accounts(string id, string password, string gender, byte age,string city,string phoneNo,string language)
        {
            this.EmailId = id;
            this.Password = password;
            this.Gender = gender;
            this.Age = age;
            this.City = city;
            this.PhoneNumber = phoneNo;
            this.LanguageKnown = language;

        }
        public Accounts()
        {

        }

    }
}
