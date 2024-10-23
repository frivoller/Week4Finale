# Türkçe README
# Teknoloji Mağazası Ürün Yönetimi
Bu proje, bir teknoloji mağazasında telefon ve bilgisayar kayıtlarını yönetmek için C# dilinde nesne yönelimli programlama (OOP) prensipleri kullanılarak hazırlanmıştır.

## Proje Özellikleri:
Telefon ve Bilgisayar sınıfları, BaseMakine isimli bir temel sınıftan türemektedir.
Telefonlar ve bilgisayarlar için farklı özellikler (TR lisanslı olup olmama, USB giriş sayısı, Bluetooth gibi) desteklenmektedir.
USB giriş sayısı yalnızca 2 veya 4 olabilir. Aksi durumda bir uyarı mesajı verilir ve -1 atanır.
Üretim tarihi, nesne oluşturulduğunda otomatik olarak atanır.
Her ürün tipi için farklı bir isim gösterim şekli (UrunAdiGetir) tanımlanmıştır.
Ürün bilgileri ekrana yazdırılabilir ve her sınıf kendi özel bilgilerini gösterebilir.

## Program Akışı:
- Kullanıcıya telefon üretmek için 1, bilgisayar üretmek için 2 seçeneği sunulur.
- Kullanıcıdan alınan bilgilere göre ilgili ürün sınıfından bir nesne oluşturulur.
- Ürün başarıyla oluşturulduktan sonra, kullanıcıya başka bir ürün üretip üretmek istemediği sorulur.
- Kullanıcı başka bir ürün üretmek istemediğinde program sonlandırılır.

## Nasıl Kullanılır?
- Projeyi indirin ve Visual Studio veya herhangi bir C# IDE'si ile açın.
- Projeyi çalıştırın.
- Konsol ekranındaki talimatları izleyerek telefon veya bilgisayar üretin.


# English README
# Tech Store Product Management
This project is designed using object-oriented programming (OOP) principles in C# to manage phone and computer records for a tech store.

## Project Features:
Phone and Computer classes inherit from a base class called BaseMachine.
Supports different features for phones and computers (e.g., TR license status, number of USB ports, Bluetooth capability).
The number of USB ports can only be 2 or 4. Otherwise, a warning message is displayed and -1 is assigned.
The production date is automatically assigned when an object is created.
A different method (UrunAdiGetir) is defined for displaying the name of each product type.
Product information can be displayed on the screen, and each class shows its own specific details.

## Program Flow:
- The user is prompted to press 1 to create a phone or 2 to create a computer.
- Based on the user's input, an object is created from the corresponding class.
- After the product is successfully created, the user is asked if they want to create another product.
- If the user doesn't want to create another product, the program ends.

## How to Use?
- Download the project and open it with Visual Studio or any C# IDE.
- Run the project.
- Follow the console instructions to create a phone or a computer.
