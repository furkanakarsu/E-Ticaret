# ECommerce Ntier Project
.Net Framework ile geliþtirilen bir E-Ticaret uygulamasý

### CORE - Class Library
Bu katman içeerisinde diðer katmanlara öncülük edecek olan sýnýflar yer almaktadýr. 

### MODEL - Class Library
Bu katman içerisinde veritabanýnda tablo haline gelmesini istediðimiz nesneler(entity) yer almaktadýr.

### MAP - Class Library
Bu katman içerisinde entity(varlýklar) veritabanýnda tablo haline gelirken hangi koþullar dahilinde oluþturulacaðýnýn kurallarý belirlendi.

### DATAACESS - Class Library
Data access katmanýnýn amacýÝ veritabanýna ulaþýmýný saðlamaktýr. Yukarýda uygulanan bütün iþlemler Data access katmaný içerisinde veritabanýna iletilir.

### SERVICE- Class Library
Data access katmaný içerisinde bulunan Context ile dorðudan iletiþime geçerek verilerde ne gibi iþlemlerin uygulancaðýnýn stadartýný belirleyen katman olarak oluþturuldu.

### UI - Asp.Net MVC
  User Interface (UI) bütün projede yeralan iþlemleri kullanýcýya sunan katman olarak oluþturuldu. 
