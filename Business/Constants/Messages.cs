using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static olduğu için new'leme gerekmez.
    //Products bu projeye özgü olduğu için Core'a değil Business'a yazılır.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductNotFound = "Ürün bulunamadı";
        public static string CategoryListed = "Kategoriler listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerNotFound = "Müşteri bulunamadı";
        public static string ProductCountOfCategoryError = "Kategoriye daha fazla urun eklenemez";
        public static string ProductNameAlreadyExists = "Bu urun ismi onceden kullanilmistir";
        public static string CategoryLimitExceeded = "Urun siniri asildi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
