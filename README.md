# Yapılacaklar Listesi Uygulaması

## Proje Tanımı
Yapılacaklar Listesi Uygulaması, kullanıcıların günlük işlerini planlayıp düzenli bir şekilde yapmalarını sağlamak ve aynı zamanda güncel finansal piyasa değerlerinden haberdar olmalarını amaçlamaktadır. Uygulama; iş yönetimi, döviz kurları takibi ve kripto para değerlerini izleme gibi fonksiyonları bir arada sunar. Proje, JIRA kullanılarak iş bölümü yapılıp ve GitHub üzerinden değişiklikler sürekli olarak güncellenerek geliştirilmiştir.

## İçindekiler
- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Teknolojik Altyapı](#teknolojik-altyapı)
- [Proje Yönetimi](#proje-yönetimi)
- [Sonuç ve Değerlendirme](#sonuç-ve-değerlendirme)
- [Katkıda Bulunanlar](#katkıda-bulunanlar)
- [Lisans](#lisans)

## Özellikler
### 1. frmLogin (Giriş Ekranı)
- **Fonksiyon:** Kullanıcıların uygulamaya giriş yapmasını sağlar.
- **Özellikler:** Kullanıcı adı ve şifre doğrulama sistemi.
- **Kullanıcı Deneyimi:** Başarılı girişlerde ilişkili pencereye yönlendirme ve başarısız girişlerde uyarı mesajı sağlanmıştır.

### 2. frmRegister (Üyelik Ekranı)
- **Fonksiyon:** Yeni kullanıcıların üyelik oluşturmasını sağlar.
- **Özellikler:** Kullanıcı bilgilerini veri tabanına kaydetme.
- **Kullanıcı Deneyimi:** Başarılı kayıt işlemi sonrasında giriş ekranına yönlendirir. Kayıt işleminde tekrarlanan şifre eşleşmezse uyarı verir.

### 3. frmDoviz (Döviz Kurlarını Görüntüleme)
- **Fonksiyon:** Güncel döviz kurlarını görüntüleme.
- **Özellikler:** Döviz kurları API üzerinden güncel olarak alınır ve gösterilir.
- **Kullanıcı Deneyimi:** Kullanıcılar güncel döviz kurlarından haberdar olur ve takibini sağlar.

### 4. frmCoin (Coin Değerlerini Görüntüleme)
- **Fonksiyon:** Kripto para değerlerini görüntüler.
- **Özellikler:** Kripto para değerleri API üzerinden alınır ve güncel olarak kullanıcıya sunulur.

### 5. CoinForm (Coin Değerleri Seçimi ve Bildirim)
- **Fonksiyon:** Kullanıcıların belirledikleri coin değerlerine ulaşıldığında e-posta ile bildirim gönderir.
- **Özellikler:** Kullanıcının istediği değere ait değerleri kontrol etmesi ve seçtiği hedef değer sonrasında bildirim alınmasının sağlanması.
- **Kullanıcı Deneyimi:** Kullanıcının belirlediği değer hakkında geri dönüş alabilmesi.

### 6. frmFinance (Döviz Kurlarının Seçimi ve Bildirim)
- **Fonksiyon:** Kullanıcıların belirledikleri döviz kurlarına ulaşıldığında e-posta ile bildirim gönderir.
- **Özellikler:** Kullanıcıların seçtiği döviz birimi ve hedeflediği değerler sonrasında seçilen kur istenilen değere ulaşınca bildirim gönderimi.
- **Kullanıcı Deneyimi:** Kullanıcılara belirledikleri kur belirledikleri değerlere ulaşınca geri dönüş sağlanması.

### 7. BigNoteForm (Günlük İşleri Not Alma ve Bildirim)
- **Fonksiyon:** Kullanıcıların günlük işlerini not almalarını ve bu işler hakkında bildirim almalarını sağlar.
- **Özellikler:** Notların kaydedilmesi ve belirlenen zamanlarda hatırlatıcı bildirimlerin gönderilmesi.
- **Kullanıcı Deneyimi:** Kullanıcıların günlük işlerini organize edebilmesi ve gün içinde halletmesi gereken işleri belli bir plan dahilinde düzene sokabilmesi.

## Kurulum
1. Bu projeyi klonlayın:
   ```sh
   git clone https://github.com/mertomer/YazilimMuhendisligiProje-ToDoList.git
Kullanım
Projeyi çalıştırmak için uygun komutları kullanarak uygulamayı başlatın.
Giriş ekranından uygulamaya giriş yapın veya yeni bir kullanıcı olarak kayıt olun.
Günlük işlerinizi ekleyin, döviz ve coin değerlerini izleyin ve bildirimleri ayarlayın.
Teknolojik Altyapı
CI/CD Süreçleri
Continuous Integration: Geliştiriciler tarafından yapılan kod değişikliklerinin sürekli olarak GitHub’a push edilmesi ve bu değişikliklerin otomatik olarak test edilmesi sağlandı.
Continuous Deployment: Başarılı testlerin ardından uygulamanın otomatik olarak dağıtım ortamına gönderilmesi sağlandı.
Veritabanı
Veritabanı Yönetim Sistemi: SQL Server
Kullanım: Kullanıcıya ait mail adresi, kullanıcı adı, şifre, belirlediği tarih, döviz ve coin değerleri gibi verilerin saklanması ve yönetimi.
Veri Yapısı: Kullanıcıların verilerinin saklandığı tablo, döviz kurlarının saklandığı tablo gibi ayrı ayrı düzenli olarak tutulan tablolarda uygulamanın düzenli şekilde çalışması ve istenilen işlemlere cevap vermesi sağlandı.
Proje Yönetimi
JIRA
Proje yönetimi ve iş bölümü için JIRA kullanıldı. Görevler, sprintler ve backloglar oluşturularak proje yönetildi. Epic, Story ve Task gibi başlıklar altında yapılan görevler düzenlendi.
GitHub
Kodların senkronize edilmesi ve sürüm kontrolü için GitHub kullanıldı. Pull request’ler ve code review süreçleri ile kalite kontrol sağlandı.
Sonuç ve Değerlendirme
Yapılacaklar Listesi Uygulaması, kullanıcıların günlük işlerini organize etmelerine ve finansal piyasalar hakkında güncel bilgi almalarına yardımcı 
olan kapsamlı bir çözüm sunar. Uygulama sayesinde kullanıcı günlük hayatta yapması gereken işleri planlayıp düzene sokarken, aynı zamanda güncel döviz 
kurlarına ve güncel coin piyasalarına hakim olur. Proje, CI/CD süreçlerinin başarılı bir şekilde uygulanması ve sağlam bir veri tabanı altyapısı ile desteklenmiştir. 
JIRA ve GitHub entegrasyonu ile ekip içi koordinasyon ve iş takibi etkili bir şekilde sağlanmıştır. JIRA üzerinde yapılan görev dağılımı ve yapılması gereken süreçler tarihleriyle beraber sisteme işlenmiştir. 
Ekip üyeleri üzerine düşen görevleri JIRA sisteminden takip ederek belirlenen süre içerisinde tamamlamıştır.


