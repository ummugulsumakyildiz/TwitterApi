# Twitter Api(Windows Form)

Proje tweetinvi api kullanılarak visual studio 2019 windows form application ortamında geliştirilmiştir. Twitter apisini kullanarak, 
tweet paylaşma ve tweet okuma işlemleri yapılmaktadır. Paylaşılan ve okunan tweetler SqlServer veri tabanında saklanmaktadır. Database işlemleri
için Entitiy Framework 6 kullanıldı.

##  Tweetinvi

Tweetinvi, Twitter REST API'sine erişmek için hazırlanmış bir .NET C # kütüphanesidir. Tweetinvi ile twitter apilerini hızlı ve kolay bir şekilde kullabiliriz.
Tweetinvi kütüphanesini Nuget ile projemize dahil edebiliriz.

[Tweetinvi](https://github.com/linvi/tweetinvi) - Tweetinvi kütüphanesini inceleyebilirsiniz.

### Genel Bakış

Genel olarak projede 4 tab bulunuyor.Bunlar;
* Tweet Paylaş
* Tweet Al
* Tweet Oku
* Konfigürasyon'dur.

Başlangıçta apiyi kullanbilmek için Konfigürasyon sekmesinde gerekli 4 değer girilmelidir.Bunlar;
* OAuthConsumerKeyString
* OAuthConsumerSecretString
* AccessToken
* TokenSecret değerleridir.

Aynı zamanda bu bölümde GetTweetNumber değeri le Tweet al sekmesinde ve Tweet oku sekmesinde ekrana getirilecek olan
tweet sayısı belirlenmektedir. Eğer veri tabanında bu değer null ise default olarak 20 adet veri getiriilmektedir.

- Tweet Oku tabına basılınca yazılan kullanıcı ismine göre ilgili kişinin tweetleri ekrana gelmektedir.

- Tweet Al tabına basılınca Tweetter üzerindeki akış burada yer almaktadır.

- Tweet Paylaş tabında ise kullanıcı tweet Paaylaşımı yapar. Burada paylaşılan tweet 280 karakterle sınırlıdır.

### Projeyi Çalıştırma
Projeyi çalıştırmak için *databasefile* klasoründe bulunan mdf dosyasını SqlServer ortamına attach etmeniz gerekmektedir. 
 
```
TwitterApi\TwitterApi\bin\Debug\TwitterApi.exe
```
dosyasını çalıştırarak projeyi başlatabilirsiniz.

