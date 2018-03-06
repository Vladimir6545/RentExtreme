using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System;
using System.Security.Cryptography;
using System.Data.Entity.Validation;

namespace RentExtreme2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class MustBeTrueAttribute : ValidationAttribute
    {
        // Если метод возвращает true - значение свойства допустимо.
        // При значении false - возникнет ошибка на уровне свойства.
        // Таким же способом можно создавать атрибуты для всей модели. В случае атрибута для всей модели,
        // значения параметра value метода IsValid будет экземпляром модели, а не значением свойства, как в данном случае.
        public override bool IsValid(object value)
        {
            // если тип проверяемого значения bool, а значение true - возвращаем true
            return value is bool && (bool)value;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        // Required - поле обязательное для заполнения
        // StringLength - допустимая длина слова для поля ввода
        // RegularExpression - регулярное выражение для проверки введенных данных
        // Range - диапазон допустимых значений для поля ввода
        // Compare - значения свойств должны иметь одинаковые значения

        [Required(ErrorMessage = "Вы не ввели логин")]
        [StringLength(10, ErrorMessage = "Логин не может привышать 10 символов")]
        public string Login { get; set; }//обязательное поле

        [Required(ErrorMessage = "Поле пароль обязательно для заполнения")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Следует указать пароль от 5 до 20 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }//пароли должны совпадать

        [Required(ErrorMessage = "Поле Email обязательно для заполнения")]
        [EmailAddress]
        [RegularExpression(@"^(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b$", ErrorMessage = "Email адрес указан не правильно")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Номер телефона обязательно для заполнения")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Номер должен содержать десять цифр")]
     //   [RegularExpression(@"^\d{10}$", ErrorMessage = "Введите 10 цифр")]
        public long Telephone { get; set; }


        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Range(100, 260, ErrorMessage = "Значение поля Рост должно быть указано в сантиметрах")]
        public int Growth { get; set; }//рост в см

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Range(20,99, ErrorMessage = "Занесите свой размер обуви")]
        public byte FootSize { get; set; }//размер ноги

        [Required(ErrorMessage = "Вы не согласились с условиями использования")]
        [MustBeTrue(ErrorMessage = "Вы не согласились с условиями использования")]
        public bool TermsAccepted { get; set; }
    }

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public DbSet<Person> Persons { get; set; }
    //    public DbSet<Firm> Firms { get; set; }
    //    public DbSet<Address> Addresses { get; set; }
    //    public ApplicationDbContext()
    //        : base("DefaultConnection", throwIfV1Schema: false)
    //    {
    //    }

    //    //public override int SaveChanges()
    //    //{
    //    //    try
    //    //    {
    //    //        return base.SaveChanges();
    //    //    }
    //    //    catch (DbEntityValidationException e)
    //    //    {
    //    //        var newException = new FormattedDbEntityValidationException(e);
    //    //        throw newException;
    //    //    }
    //    //}

    //    public static ApplicationDbContext Create()
    //    {
    //        return new ApplicationDbContext();
    //    }
    //}
}