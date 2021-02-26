using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string NoCarAdded = "Araba ekleme işlemi başarısız. Açıklama en az 2 karakter ve günlük fiyat 0 dan büyük olmalı.";
        public static string CarAUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";

        public static string RentalAdded = "Kiralama başarılı.";
        public static string RentalFailed = "Kiralama başarısız.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalDeleted = "Kiralama silindi.";
    }
}
