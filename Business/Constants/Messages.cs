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

        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarRented = "Araba kiralandı";
        public static string CarIsAlreadyRented = "Araba çoktan kiralandığı için kiralanamaz";
    }
}
