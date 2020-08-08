# Otopark Otomasyonu C#
Otopark Otomasyonu C# Form - Stored procedure

**Bu proje `Stored procedure` kullanılarak yazılmıştır. Açık kaynak geliştirebilir, kullanabilirsiniz.**
**Tükçe Eğitim Videosu - Link **

### 1. Veritabanı Bağlantısını Yapınız
```
SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=Sizin veri kaynağınız");

Örneğin : Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True
```
 - Tüm form.cs'lerde veritabanı bağlantınızı güncelleyin.
 
 ### 2. Sql server'a otoparkc#.sql veritabanını import edin.


## Projemizde kullandığımız Saklı Yordamlar neler?
![saklıyordam](https://user-images.githubusercontent.com/41057642/89715487-8c52e080-d9ae-11ea-8789-b384cee0d123.png)

## Programın Arayüzü - INTERFACE
![anasayfa1](https://user-images.githubusercontent.com/41057642/89715539-e5227900-d9ae-11ea-8e2a-016c626904fd.png)

### Otopark kayıt
![otoparkkayit](https://user-images.githubusercontent.com/41057642/89715558-084d2880-d9af-11ea-8533-6aa3cf64487a.png)

### Otopark Çıkış
![otoparkgiriscıkıs](https://user-images.githubusercontent.com/41057642/89715572-1e5ae900-d9af-11ea-96f6-f64671fc2763.png)

### Otopark Durum (Araçların Konumu)
![otoparkyerleri](https://user-images.githubusercontent.com/41057642/89715584-329ee600-d9af-11ea-8c69-7f62331621e8.png)
