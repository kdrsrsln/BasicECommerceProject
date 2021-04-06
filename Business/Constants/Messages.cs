using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategori limiti aşıldı";
        public static string ProductNameExists = "Aynı isimde ürün mevcut";
        public static string ReachedMaxCategoryLimit = " Kategori limiti aşıldı";
        public static string AuthorizationDenied = "Yetkisiz Erişim";
        public static string UserRegistered = "Kullanıcı kayıtlı değil";
        public static string UserNotFound = "Kullanıcı adı hatası";
        public static string PasswordError = "Şifre hatası";
        public static string SuccessfulLogin = "Baraşıyla giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
    }
}
