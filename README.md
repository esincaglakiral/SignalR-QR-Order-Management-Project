# SignalR ile Restoran Yönetim Projesi

![slider](https://github.com/user-attachments/assets/91923854-68cb-435d-ac1a-fff0394635b0)

## 🟢 Projenin Temel Amacı

Geliştirdiğim SignalR projesi, restoran rezervasyonları ve online sipariş işlemlerini kapsamlı bir şekilde yönetir. Kullanıcılar, restorana online olarak sipariş verebilir veya rezervasyon oluşturabilirler. Sipariş vermek için kullanıcıların önce giriş yapmaları gerekmektedir. Giriş yaptıktan sonra, menüdeki yiyecek ve içecekleri seçip sepetlerine ekleyebilirler.

Siparişler ve rezervasyonlar, admin panelinde SignalR teknolojisi kullanılarak gerçek zamanlı olarak görüntülenir. Bu sayede adminler, siparişler ve rezervasyonlar üzerinde anlık olarak işlem yapabilir, onaylayabilir veya iptal edebilirler. Kullanıcılar ve adminler, herhangi bir durum değişikliğinde, ilgili e-posta adreslerine otomatik olarak bilgilendirme alırlar. Bu özellik, tüm işlemlerin hızlı ve etkili bir şekilde takip edilmesini sağlar.
## 🟢 Teknik Detaylar

Bu projeyi ASP.NET Core 6.0 ve SignalR teknolojileri kullanarak geliştirdim. Tüm CRUD işlemlerini API üzerinden gerçekleştirdim ve bu işlemleri MVC tarafında tüketerek dinamik bir yapı oluşturduk. Dinamik veritabanı yönetimi için Entity Framework Code First kullandım. Projeyi daha modüler ve sürdürülebilir kılmak için N Katmanlı mimari yapısına yer verdim. DTO katmanıyla, verileri daha güvenli bir şekilde işledim.

### 📌 Kullanılan Teknolojiler

- ASP.NET Core 6.0
- ASP.NET Core Web API
- SignalR
- PagedList
- MSSQL
- Identity
- AutoMapper
- MailKit
- AutoMapper
- Entity Framework Code First
- HTML, CSS, JavaScript
- Ajax
- Bootstrap

### 📌 Katmanlar

- UI Layer
- Entity Layer
- DataAccess Layer
- Business Layer
- Dto Layer
- Web Api Layer

### 📌 Öne Çıkan Özellikler


- Restorana rezervasyon yapma özelliği
- Rezervsyonları detaylı bir şekilde admin panelinde yönetebilme özelliği
- MSSQL ile ilişkili tablolar
- Online sipariş verme seçeneği
- Identity kütüphanesi kullanarak giriş yapma
- Admin paneli
- Adminlere mesaj ile bilgilendirme
- SignalR ile canlı mesajlaşma (chatbox benzeri)
- SignalR ile masa durumlarını gerçek zamanlı görüntüleme
- Anlık istatistiklerin görüntülenmesi
- E-posta gönderme özellikleri
- Ürünlerde indirim uygulama


###  📌 Admin Panel Özellikler

- Ürünler CRUD işlemler
- Kategoriler CRUD işlemler
- Site üzerinden diğer veriler için CRUD işlemler
- Rezervasyonları sayfa yenilemeden görüntüleme
- Bildirim oluşturma
- Masa durumlarını sayfa yenilemeden görüntüleme
- İndirim oluştruma
- İstatistik görüntüleme


### 📌 Teknik Özellikler

- Asp.net core 6.0
- MSSQL Veritabanı
- N Katmanlı Mimari Yapı
- Web API
- Identity
- AutoMapper
- MailKit
- PagedList
- SignalR ile canlı veri takibi
- Entity Framework Code First LINQ


---------------------------------------------------------------------------------------------------
## Projeye Ait Görseller

### UI tarafı / Müşteri Tarafı

#### ☞ Anasayfa görünüm : Slider

![slider](https://github.com/user-attachments/assets/365ce89c-9df6-4082-a906-0f2f156e6017)

#### ☞ Anasayfa görünüm : İndirimler

![discount](https://github.com/user-attachments/assets/3b374f0e-c127-4b63-b3b3-1cc8cc389d8f)


#### ☞ Anasayfa görünüm : Öne Çıkan 9 ürün


![anasayfa 9 ürün](https://github.com/user-attachments/assets/e15d7d24-836d-4c19-a815-18b9f90896cb)

#### ☞ Anasayfa görünüm : Bizleri Tanıyın

![hakkımızda anasayfa](https://github.com/user-attachments/assets/d7f36e49-b211-439b-819c-3232cfb7c02d)

#### ☞ Anasayfa görünüm : İletişim Bölümü / Admine buradan mesaj gönderebilirler müşteriler. Mesela Merve Adlı müşteri admine mesaj yolluyor.

![contact](https://github.com/user-attachments/assets/e314894b-65d7-4915-bdcf-782ffe32b84a)

![merve adlı müşteir mesaj gönderiyor](https://github.com/user-attachments/assets/d414d2bc-f6c1-49a8-bd1a-e040a2af47a9)


#### ☞ Anasayfa görünüm : Referanslar ve Footer


![referanslar](https://github.com/user-attachments/assets/594ba907-1100-4705-a740-1faf3a70c226)

![footer](https://github.com/user-attachments/assets/a36161e7-4d5d-4737-9ced-5480bb933caf)





#### ☞ Register - Kullanıcı Yeni Kayıt Yapma Sayfası

![yeni kullanıcı kaydı](https://github.com/user-attachments/assets/d7252f9d-dd6e-4149-aec4-6eabbe8f404d)

![yeni kullanıcı kaydoluyor](https://github.com/user-attachments/assets/cef36332-4263-4b86-84f5-23b345ef2161)



#### ☞ Login - Giriş Yapma Sayfası

![login](https://github.com/user-attachments/assets/309af6eb-8e88-4154-a1cd-f868fb9d0915)

![kullanıcı giriş yapıyor](https://github.com/user-attachments/assets/4de5d5a6-f1b1-4462-b48b-537b467ca122)


#### ☞ Menü Sayfası görünüm : Menüdeki tüm ürünlerin listelendiği ve sepete eklenebildiği alan

![menüden sepete ürün ekleme](https://github.com/user-attachments/assets/1420967b-9be0-48e4-81e7-f614aa41ab54)

![men](https://github.com/user-attachments/assets/68e9ae09-e58a-4b30-be41-0ff8d3ccc6ef)


#### ☞ Sepet Sayfası görünüm : Ürünleri ekledikten sonra sepetin görünümü böyledir. Burada ürünlerin adetine göre toplam tutar hesaplanır ve kdv oranıyla beraber Ödeme tutarı gösterilmektedir.


![ürünler eklendikten sonra basket](https://github.com/user-attachments/assets/c3925c0f-3b85-4cbf-9735-08ea9331955c)


#### ☞ Rezervasyon Sayfası görünüm : Burada Müşteriler restoran için rezervasyon yapabilirler. Yapılan her yeni rezervasyon admin paneline SignalR ile anlık oarak düşektedir.  Çünkü admin panelinde rezervasyonları SignalR ile çektiğimiz için Sayfayı yenilemeden anlık olarak gelen tüm rezervasyonlar görüntülenebilir. Her yeni rezervsyon "Onay Bekliyor" durumu olarak admin paneline düşer. Admin buradan Rezervasyon durumunu yönetebilir.

![rezervasyon](https://github.com/user-attachments/assets/b40a3c75-a9c6-435e-8a81-669e5ec58f5f)


![ayşe yılmaz rezervasyon yapıyo](https://github.com/user-attachments/assets/eca10d1f-967a-4961-af02-bafd37d80fb2)



#### ☞ Anlık Mesajlaşma (ChatBox) görünüm : Bu yapı SignalR ile Anlık olarak Müşteri ve admin arasında iletişim kurulmasını sağlar. Gerçek e-ticaret sitelerindeki ChatBox'lar gibi düşünebiliriz.

- signalr anlık mesajlaşma ayşe (Müşteri)
![signalr anlık mesajlaşma ayşe](https://github.com/user-attachments/assets/5801cdea-fcc2-4484-815e-24e209daeae6)

- signalr anlık mesajlaşma admin
![signalr anlık mesajlaşma admin](https://github.com/user-attachments/assets/064f3ceb-be29-4739-a9c7-47fa3ddf787c)

- Bir başka Anlık mesajlaşma örneği
![anlık mesajlaşma2](https://github.com/user-attachments/assets/6922bcaa-c549-4fa6-926e-b1810ee034ab)

---------------------------------------------------------------------------------------------------
## Projeye Ait Görseller

### Admin Paneli / Admin Yönetim Tarafı

#### ☞ Admin Kategori Sayfası görünüm : Admin Buradan kategorilerle alakalı CRUD işlemleri yapabilir, kategori durumlarını Aktif Pasif olarak güncelleyebilir.

![kategoriler](https://github.com/user-attachments/assets/b2435b4f-3297-446f-8534-9f6c04f37517)

#### ☞ Admin Ürün Sayfası görünüm : Admin Buradan ürünlerle alakalı CRUD işlemleri yapabilir. Bu sayfada PagedList yapısı ile sayfalama sistemi kullanılmıştır. Yine Ürünlerin durumlarını da Üretimde - Üretimde değil olarak yönetebilir.


![ürünler](https://github.com/user-attachments/assets/f38cbed6-2a8b-4fe2-839f-9fbdf458ed35)

#### ☞ Admin Rezervasyon Sayfası görünüm : Burada Rezervasyon yaptıran ayşenin admin apneline rezervasyonunun nasıl ulaştığını görüyoruz. Admin ayşenin rezervasyonunu onaylıyor, ve spesifik olarak onaylı, iptal edilen ve bekletilen rezervasyonları ayrı ayrı listeleyebiliyor. Bu sayfada SignalR ile anlık rezervasyon verilerini getirme ve Pagedlist ile sayfalama sistemi kullanıldı.

![rezervasyonlar son rezerve yaptıran ayşe](https://github.com/user-attachments/assets/cd0f55dd-7b79-494b-a7a5-ed0cf991e76e)

![ayşenin rezervasyonu onaylandı](https://github.com/user-attachments/assets/352661b4-4ee5-425a-8635-666a86d964e6)

![onaylı rezervasyonlar](https://github.com/user-attachments/assets/7b2774f0-971a-4bd6-8829-57f0f7a884cc)

![iptal edilen rezervasyonlar](https://github.com/user-attachments/assets/7e52525a-4da4-4896-b635-92b1aefd7bb5)

![bekletilen rezervasyonlar](https://github.com/user-attachments/assets/14810ecc-88b0-4be2-af7d-d45ca73e07be)

#### ☞ Admin İndirimler Sayfası görünüm : Buradan da yine crud işlemleri ve indirim etkin mi değilmi bunları yönetebilir. tabiki bunların hepsi UI tarafına yansımaktadır.

![indirimler](https://github.com/user-attachments/assets/6aee21b8-4989-4fdc-9273-030ea06c9459)


#### ☞ Admin Referanslar Sayfası görünüm :

![referreanslar](https://github.com/user-attachments/assets/02c854f7-8d51-4637-9d9f-56b3d5eb702b)


#### ☞ Admin SignalR ile İstatistikler Sayfası görünüm : Bu sayfada SignalR yapısı kullanıldı ve Tüm İstatistik bilgileri güncel olarak sayfa yenilemye gerek duyulmadan güncellenmektedir. Mesela Boş olan Salon 07 adlı Masayı dolu yapıyorum ve ardından görünüm aşağıdaki gibi oluyor.

![signalr istatistikler](https://github.com/user-attachments/assets/878c619c-080a-482d-ab84-dda189270204)

#### ☞ Admin SignalR ile Masalar Sayfası görünüm : Burada Masalarla alakalı Crud işlemleri ve Dolu-Boş durumlarını yönetebilriiz. Ardından da SignalR ile anlık olarak masalar görüntülenebilmektedir.

![signalr masaları yönet](https://github.com/user-attachments/assets/5524d340-70d2-4b50-b364-b033a94d61b1)

![signalr masa durumları](https://github.com/user-attachments/assets/140ef21d-151d-4046-8875-4e95fc4c8171)

![boş olan masayı dolu yapcam](https://github.com/user-attachments/assets/c65db236-0419-482d-a426-c4ce27633768)


![salon 7 numaralı masa doldu](https://github.com/user-attachments/assets/830e1a97-9748-4511-ac60-8fe6ee89040d)



#### ☞ Admin SignalR ile Anlık Durum Çubuğu / ProgressBar Sayfası görünüm : Bu sayfada SignalR yapısı kullanıldı ve Tüm İstatistik bilgileri güncel olarak sayfa yenilemye gerek duyulmadan güncellenmektedir.

![signalr anlık durum çubuğu](https://github.com/user-attachments/assets/6db7035c-2fc2-44dc-8890-21ef06efa18c)


#### ☞ Admin Tarfında SignalR ile Sipariş Yönetimi ve İstatistiklere anlık olarak yansıması:  

- burdaki siparişlere göre signalr istatistik verileri güncellenebilmektedir
![burdaki siparişlere göre signalr istatistik vberileri güncellenebilmektedir](https://github.com/user-attachments/assets/d039ada9-7ac7-407b-bbdd-43727068b6a2)


- burdaki sipariş detaylarına göre
![burdaki detaylara göre](https://github.com/user-attachments/assets/d243372a-039d-4051-9eb4-52571625cb88)



- yeni bi sipariş girdim şimdi bunun detaylarını gircem ve total price güncellencek
![yeni bi sipariş girdim şimdi bunun detaylarını gircem ve total price güncellencek](https://github.com/user-attachments/assets/487810d0-2e9a-4844-83c8-72dfd0220227)



- yeni girdiğim sipariş de 3 adet ürün ekledim 17 idli siparişe dikkat
![yeni girdiğim sipariş de 3 adet ürün ekledim 17 idli siparişe dikkat](https://github.com/user-attachments/assets/f3ff99da-9ecd-4e52-8436-72a3fe833433)


- para kasası güncellenmedi çünküğ henüz müşteri hesabı ödemedi müşteri masada durumunda
![para kasası güncellenmedi çünküğ henüz müşteri hesabı ödemedi müşteri masada durumunda](https://github.com/user-attachments/assets/9c9264bd-eee3-444a-876e-783cd03eced4)

- son sipariş 650 tl olarak güncellendi şimdi istatistiklere bakalım
![son sipariş 650 tl olarak güncellendi şimdi istatistiklere bakaşlım](https://github.com/user-attachments/assets/fd5c0a40-d461-4417-9095-5fad34b1217a)

- burada da gözükmekte
![burada da gözükmekte](https://github.com/user-attachments/assets/7fb2154b-b70f-45c7-b666-603cac975f9f)

- peki müşteri hesabı kapatırsa nolur?
![peki müşteri hesabı kapatırsa nolur](https://github.com/user-attachments/assets/a7bc2d26-d1ba-4422-b8a3-a2e71b4cce0f)

- kasadaki tutar arttı, bugunki kazanç güncellendi ve aktif sipariş sayısı azaldı (masadan kalkan müşteri)
![kasadaki tutar arttı, bugunki kazanç güncellendi ve aktif sipariş sayısı azaldı (masdan kalkan müşteri)](https://github.com/user-attachments/assets/1915ef2a-ead8-4de1-9304-e9ed565a5d0c)

- anlık durum çubuğu da güncellendi tabiki bu sistemi gerçek zamanlı bir projede qr üzerinden veya sepete ürün ekleyip onaylayarak otomatik olarak yönetilebilir hale getirilebilir
![anlık durum çubuğu da güncellendi tabiki bu sistemi gerçek zamanlı bir projede qr üzerinden veya sepete ürün ekleyip onaylayarak otomatik olarak yönetilebilir hale getirilebilir](https://github.com/user-attachments/assets/e2d3077b-d8d9-4344-acf9-b31d3b22199e)


#### ☞ Admin Bildirim Sayfası görünüm : Bildirimler de signalR ile güncelenmektedir. Görüldüğü gibi okunmayan bildirimler burada gözükmektedir

![bldirimler de signalR ile güncelenmektedir](https://github.com/user-attachments/assets/a2db4b4c-8944-420e-82ae-b1987aaf3086)

![görüldüğü gibi okunmayan bildirimler burada gözükmektedir](https://github.com/user-attachments/assets/f6180efe-6685-408a-b9ff-584c731d13c6)


#### ☞ Admin Mail Gönderme Sayfası görünüm : Burada Mailkit teknolojisiyle Admin Gerçek Maillere e-posta gönderebilmektedir. Bu yapı mesela rezervasyon ya da ekip içi çalışmalar için kullanılabilen bir yapı olabilir.

![sinalr mail gönderme](https://github.com/user-attachments/assets/6a272e98-1cd9-4760-b23b-4804621cf014)

![signalr restoran gerçek mail gönderme](https://github.com/user-attachments/assets/36720082-a3f4-4f7d-a7ab-459775f1bcde)


#### ☞ Admin QR Kod Oluşturma Sayfası görünüm : Aşağıda QR Code oluşturma örneklerini görüyorsunuz. QR kodlardan birini çözümledim


![salon05](https://github.com/user-attachments/assets/5560bb62-a012-43d1-981b-3b23b18f8a5d)

![bahçe05](https://github.com/user-attachments/assets/7b23cc9e-652b-40fd-b25a-00fe3c24d84f)

![image](https://github.com/user-attachments/assets/ede6573b-39c4-45be-b4b4-3ff262641a93)

![qr kode çözümleme](https://github.com/user-attachments/assets/7a66128f-33e2-4952-be53-a902537066ff)

------------------------------------------------------------------------------------------------------------------------------------------------------------
#### ☞ Swagger Tüm API istekleri görünüm :

![apiler](https://github.com/user-attachments/assets/45fab8f5-f506-4c5b-a50f-8f209789e23f)

![apiler2](https://github.com/user-attachments/assets/d7c405a9-e414-40eb-9410-cf16235cfd35)

![apiler3](https://github.com/user-attachments/assets/42dd0789-2687-4d4b-b056-2eaf27a20277)

![product apiler](https://github.com/user-attachments/assets/d1f30aeb-95bd-4994-813f-4fbb1b51d9f5)


------------------------------------------------------------------------------------------------------------------------------------------------------------
#### ☞ Tablolar Arası İlişkiler :


![tablolar arası ilişkiler](https://github.com/user-attachments/assets/f6efad67-acef-49f4-b7d5-ff5e981e2c9f)

------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------


# Teşekkür

Bu proje, restoran rezervasyonları ve online sipariş işlemlerini kapsamlı bir şekilde yönetme amacını taşıyor ve ASP.NET Core teknolojilerinde yetkinliğimi artıran önemli projelerimden biridir. Bir restoran yöneticisi olarak, yönetim panelinde ve ziyaretçi panelinde bulunması gereken temel özellikleri düşünerek bu projeyi geliştirdim. Projem, hem admin hem de ziyaretçiler için dinamik ve kullanıcı dostu bir deneyim sunmayı hedefliyor.
Projede en önemli bulduğum özellikler:  Kesinlekle SiganlR yapısının mantığı ve kullandığım tüm alanları sayabilirim. Adminin personeller ve ziyaretçilerle Mail üzerinden iletişim kurabilmesi ve rezervasyonların detaylı yönetilebilirliği de en önemli bulduğum özelliklerdir.
QR Code nasıl oluşturulur bunu öğrendim. Anlık Mesajlaşma da bana göre hem kullanıcı hem de admin açısından büyük avantajlı bir sistem olabilmektedir. 
Tabiki gelişime açık bir proje olmakla beraber birçok teknolojiyi bir arada kullandığım bir proje oldu.
Buraya kadar incelediğiniz için teşekkür ederim. 
Geri dönüşleriniz için Bana Linkedin Hesabımdan Ulaşabilirsiniz : https://www.linkedin.com/in/esincaglakiral/

