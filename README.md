# Tasarım Desenleri Dökümantasyonu

Bu dökümantasyonda, yazılım geliştirme sürecinde sıkça kullanılan bazı tasarım desenleri ve amaçları hakkında bilgi bulabilirsiniz. Tasarım desenleri, belirli problemleri çözmek için geliştirilmiş genel çözüm yöntemleridir ve yazılımın daha modüler, esnek ve bakımı kolay olmasını sağlar.

## Creational Design Patterns (Yaratımsal Tasarım Desenleri)

1. **Singleton**:
   - **Amaç**: Sınıfın yalnızca bir örneğini oluşturmasını sağlar ve bu örneğe global erişim sağlar.
   - **Örnek**: Bir uygulamada yalnızca bir veritabanı bağlantısı oluşturmak için kullanılabilir.

2. **Factory Method**:
   - **Amaç**: Bir süper sınıfın alt sınıflarının hangi nesneleri oluşturacağını belirleyen bir yöntem tanımlar.
   - **Örnek**: Bir mobil oyunun farklı seviyelerindeki düşmanları oluşturmak için kullanılabilir.

3. **Abstract Factory**:
   - **Amaç**: İlgili nesne gruplarının oluşturulmasını destekler ve nesnelerin birbirleriyle uyumlu olmasını sağlar.
   - **Örnek**: Bir araba üretim fabrikasında, bir aracın motorunu, şasesini ve diğer parçalarını oluşturan bir Abstract Factory deseni kullanılabilir.

4. **Builder**:
   - **Amaç**: Karmaşık bir nesnenin oluşturulmasını adım adım sağlar ve farklı tiplerde nesneler oluşturmayı destekler.
   - **Örnek**: Bir restoran uygulamasında, müşterilerin isteklerine göre özelleştirilmiş yemek siparişlerini oluşturmak için kullanılabilir.

5. **Prototype**:
   - **Amaç**: Mevcut bir nesnenin kopyasını oluşturarak yeni nesneler oluşturmayı sağlar.
   - **Örnek**: Bir oyun motorunda, benzer nesnelerin çoğaltılması için kullanılabilir.


## Structural Design Patterns (Yapısal Tasarım Desenleri)

1. **Adapter**:
   - **Amaç**: İki farklı arayüzü birbirine bağlar ve uyumlu hale getirir.
   - **Örnek**: Bir projede kullanılan eski bir kütüphaneyi, yeni bir projeye entegre etmek için kullanılabilir.

2. **Decorator**:
   - **Amaç**: Bir nesneye dinamik olarak yeni özellikler ekler.
   - **Örnek**: Bir metin editöründe yazılan metni renklendirmek için kullanılabilir.

3. **Composite**:
   - **Amaç**: Nesneleri ağaç benzeri bir yapıda birleştirir ve bu nesneleri tek bir nesne gibi yönetmeyi sağlar.
   - **Örnek**: Bir menü sistemi oluştururken, menülerin alt menülerini içeren bir Composite deseni kullanılabilir.

4. **Facade**:
   - **Amaç**: Karmaşık bir alt sistemi basitleştirmek için tek bir arayüz sağlar.
   - **Örnek**: Bir bilgisayarın donanımını kontrol etmek için kullanılan bir kütüphanenin karmaşıklığını gizlemek için kullanılabilir.

5. **Proxy**:
   - **Amaç**: Bir nesnenin yerine geçerek, o nesneye erişimi kontrol eder veya ek işlevsellik ekler.
   - **Örnek**: Bir dosya yükleme işleminde, dosyanın yüklenmeden önce boyutunu kontrol etmek için kullanılabilir.

## Behavioral Design Patterns (Davranışsal Tasarım Desenleri)

1. **Observer**:
   - **Amaç**: Bir nesne değiştiğinde, bu değişiklikten etkilenen diğer nesneleri otomatik olarak günceller.
   - **Örnek**: Bir haber sitesinde, yeni bir haber yayınlandığında abonelere otomatik olarak bildirim göndermek için kullanılabilir.

2. **Strategy**:
   - **Amaç**: Bir algoritmayı tanımlar, kapsüller ve değiştirilebilir hale getirir.
   - **Örnek**: Bir oyunun yapay zekasını yönetmek için farklı stratejileri kullanarak kullanılabilir.

3. **Command**:
   - **Amaç**: Bir eylemi bir nesne olarak temsil eder, böylece bu eylemi gerçekleştirmek için gerekli olan bilgiler saklanabilir ve bu eylem geri alınabilir.
   - **Örnek**: Bir metin editöründe geri alma (undo) işlemi için kullanılabilir.

4. **State**:
   - **Amaç**: Bir nesnenin davranışını duruma bağlı olarak değiştirmesine olanak tanır.
   - **Örnek**: Bir sipariş yönetim sisteminde, siparişin durumuna göre farklı işlemler yapmak için kullanılabilir.

5. **Visitor**:
   - **Amaç**: Bir nesne üzerinde belirli işlemleri yapmak için ayrı bir sınıf tanımlar, böylece nesne yapısını değiştirmeden yeni işlemler eklenmesini sağlar.
   - **Örnek**: Bir belge ağacında dolaşarak farklı işlemler yapmak için kullanılabilir.

6. **Iterator**:
   - **Amaç**: Bir nesne koleksiyonunun elemanlarına sırayla erişimi sağlar ve bu erişimi standart bir arabirim üzerinden yapar.
   - **Örnek**: Bir liste veya dizi üzerinde dolaşmak için kullanılabilir.

7. **Chain of Responsibility**:
   - **Amaç**: Bir isteği işleyebilecek bir dizi nesne oluşturur ve isteği gönderen nesne bu nesneler arasında dolaşarak isteğin hangi nesne tarafından işleneceğine karar verir.
   - **Örnek**: Bir hata günlüğü sisteminde, bir hata mesajının hangi seviyede kaydedileceğine karar vermek için kullanılabilir.

## Additional Design Patterns (Ek Tasarım Desenleri)

1. **Object Pool**:
   - **Amaç**: Önceden oluşturulmuş nesnelerin bir havuzunu tutar ve ihtiyaç duyulduğunda bu havuzdan nesne alır veya havuza geri koyar.
   - **Örnek**: Bir web sunucusunda, çok sayıda kullanıcı isteğini işlemek için havuzlanmış bağlantıları kullanmak için kullanılabilir.

2. **Flyweight**:
   - **Amaç**: Nesne oluşturulma maliyetini azaltmak için paylaşılan nesneleri kullanır.
   - **Örnek**: Bir metin düzenleyicide, benzer karakterlerin ayrı ayrı saklanması yerine tek bir nesne olarak saklanması için kullanılabilir.

3. **Bridge**:
   - **Amaç**: Soyutlanmış bir yapının gerçek uygulamasını ayrı sınıflara böler ve böylece değişikliklerin bir kısmının diğerlerinden bağımsız olmasını sağlar.
   - **Örnek**: Bir çizim uygulamasında, çizim araçlarının farklı platformlarda (Windows, macOS) farklı şekillerde uygulanmasını sağlamak için kullanılabilir.
