# DependencyInjection

Nedir bu Dependency Injection hadi bir bakalım..!
-----------------------------------------------------

Dependency Injection kaba tabir ile bir sınıfın/nesnenin bağımlılıklardan kurtulmasını amaçlayan ve o nesneyi olabildiğince bağımsızlaştıran bir programlama tekniği/prensibidir.
Dependency Injection uygulayarak; bir sınıfının bağımlı olduğu nesneden bağımsız hareket edebilmesini sağlayabilir ve kod üzerinde olası geliştirmelere karşın değişiklik yapma ihtiyacını ortadan kaldırabilirsiniz.

Peki Dependency Injection uygulamanın avantajları nelerdir ?
----------------------------------------------------------
Madde 1 - Bağımlılık oluşturacak nesneleri direkt olarak kullanmak yerine, bu nesneleri dışardan verilmesiyle sistem içerisindeki bağımlılığı minimize etmek amaçlanır.
          Böylece bağımlılık bulunan sınıf üzerindeki değişikliklerden korunmuş oluruz.

Madde 2 - Unit testlerin yazımını kolaylaştırırken doğruluğunu da artırır.

Madde 3 - Yazılım geliştirmedeki en önemli konulardan biri de yazılım içerisinde bulunan componentlerin “loosely coupled” (gevşek bağlı) olmasıdır. Dependency Injection’da bunu sağlayabilen önemli tekniklerden birisidir. 
          Böylece bağımsızlığı sağlanan sınıflar tek başına test edilebilir.
