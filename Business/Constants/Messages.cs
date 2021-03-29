﻿using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
