
using System.ComponentModel.DataAnnotations;
using ShopMarket.DataLayer.Entities.Common;

namespace ShopMarket.DataLayer.Entities.Account
{
    public class User : BaseEntity
    {


        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100,ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        public string LastName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        public string FirstName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمیباشد")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "کد فعالسازی ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string EmailActiveCode { get; set; }


        [Display(Name = "ایمیل فعال / غیر فعال")]
        public bool EmailIsActive { get; set; }



        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        [RegularExpression("(0|\\+98)?([ ]|-|[()]){0,2}9[1|2|3|4]([ ]|-|[()]){0,2}(?:[0-9]([ ]|-|[()]){0,2}){8}\r\n",ErrorMessage = "تلفن وارد شده معتبر نیست")]
        public string Mobile { get; set; }

        [Display(Name = "کد قعالسازی موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        public string MobileActiveCode { get; set; }

        [Display(Name = "اکانت موبایل فعال /غیر فعال")]
        public bool MobileIsActive { get; set; }


        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        public string Password { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        [Compare("Password",ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "آواتار")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند از {1} کاراکتر بیشتر باشد.")]
        public string Avatar { get; set; }


        [Display(Name = "کاربر فعال / غیر فعال")]
        public bool IsBlocked { get; set; }

    }
}
