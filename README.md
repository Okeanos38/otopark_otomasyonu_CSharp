# Otopark Otomasyonu C#
Otopark Otomasyonu C# Form - Stored procedure

**Bu proje `Stored procedure` kullanılarak yazılmıştır. Açık kaynak geliştirebilir, kullanabilirsiniz.**

### 1. Veritabanı Bağlantısını Yapınız
```
SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=Sizin veri kaynağınız");

Örneğin : Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True
```
 - Tüm form.cs'lerde veritabanı bağlantınızı güncelleyin.
 
 ### 2. Sql server'a otoparkc#.sql veritabanını import edin.
