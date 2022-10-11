using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi ";
        public static string CarDescriptionInvalid = "Araba ismi geçersiz";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarListed = "Araba listelendi";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarRented = "Araba kiralandı";
        public static string CarIsAlreadyRented = "Araba çoktan kiralandığı için kiralanamaz";

        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserListed = "Kullanıcı listelendi";


        public static string CustomerListed = "Müşteri listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerDeleted = "Müşteri silindi ";
        public static string CustomerAdded = "Müşteri eklendi ";

        public static string CommonError = " İşlem başarısız";
        public static string BrandNameExist = "Marka ismi zaten var";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorNameExist = "Renk zaten var";
        public static string EmailExist = "Email hesabı daha önce kullanılmış";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageAdded = " Araba resmi eklendi ";
        public static string CarImageLimitExceeded = "Araba resmi limitine ulaşıldı";
        public static string CarImageIsNotExist = "Araba resmi yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccesfulLogin = "Giriş başarılı";
        public static string UserAlreadyExist = "Kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı kaydı başarılı";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string CarImageUpdated = "Araba resmi güncellendi";
    }
}
