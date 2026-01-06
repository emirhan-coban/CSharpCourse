# 📚 C# Eğitim Kampı

Sıfırdan ileri seviyeye C# programlama dili eğitim projesi. Temel konulardan veritabanı işlemlerine kadar kapsamlı içerik.

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Modüller](#-modüller)
- [Teknolojiler](#-teknolojiler)
- [Kurulum](#-kurulum)
- [Kullanım](#-kullanım)
- [Öğrenilenler](#-öğrenilenler)

## 🎯 Proje Hakkında

Bu proje, C# programlama dilini temellerinden başlayarak adım adım öğreten kapsamlı bir eğitim setidir. Her modül, farklı bir konuya odaklanarak pratik örnekler içerir.

## 📚 Modüller

### 01 - Ana Konular (MainSubjects)
Temel C# konseptleri ve syntax yapısı
```csharp
Console.WriteLine("Merhaba Dünya!");
int number = 5;
string text = "C# Eğitimi";
```

### 02 - Değişkenler (Variables)
Veri tipleri ve değişken kullanımı
```csharp
int age = 25;
double price = 99.99;
string name = "Emirhan";
bool isActive = true;
```

### 03 - Karar Yapıları (Making Decision)
If-else, switch-case yapıları
```csharp
if (age >= 18)
{
    Console.WriteLine("Yetişkin");
}
else
{
    Console.WriteLine("Çocuk");
}
```

### 04 - Döngüler (Loops)
For, while, do-while döngüleri
```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

while (condition)
{
    // kod
}
```

### 06 - Diziler (Arrays)
Array tanımlama ve kullanımı
```csharp
string[] cities = { "İstanbul", "Ankara", "İzmir" };
int[] numbers = new int[5];
numbers[0] = 10;
```

### 07 - Foreach Döngüsü
Koleksiyonlar üzerinde iterasyon
```csharp
foreach (string city in cities)
{
    Console.WriteLine(city);
}
```

### 08 - Metotlar (Methods)
Fonksiyon tanımlama ve kullanımı
```csharp
public int Sum(int a, int b)
{
    return a + b;
}

public void Greet(string name)
{
    Console.WriteLine($"Merhaba {name}!");
}
```

### 09 - Veritabanı Projesi (Database Project)
ADO.NET ile veritabanı bağlantısı
```csharp
SqlConnection connection = new SqlConnection(connectionString);
SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
connection.Open();
SqlDataReader reader = command.ExecuteReader();
```

### 10 - Veritabanı CRUD
Create, Read, Update, Delete işlemleri
```csharp
// Ekleme
SqlCommand insertCmd = new SqlCommand(
    "INSERT INTO Products (Name, Price) VALUES (@name, @price)", 
    connection
);
insertCmd.Parameters.AddWithValue("@name", productName);
insertCmd.ExecuteNonQuery();

// Listeleme
SqlDataAdapter adapter = new SqlDataAdapter(command);
DataTable table = new DataTable();
adapter.Fill(table);

// Güncelleme
SqlCommand updateCmd = new SqlCommand(
    "UPDATE Products SET Price = @price WHERE Id = @id", 
    connection
);

// Silme
SqlCommand deleteCmd = new SqlCommand(
    "DELETE FROM Products WHERE Id = @id", 
    connection
);
```

## 🛠 Teknolojiler

- C# .NET
- ADO.NET
- SQL Server
- Windows Forms

## 📦 Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/emirhan-coban/CSharpCourse.git
```

2. Visual Studio ile solution'ı açın

3. SQL Server bağlantısını yapılandırın (09 ve 10 numaralı modüller için)

4. İstediğiniz modülü başlangıç projesi yapın ve çalıştırın

## 💡 Kullanım

Her modül bağımsız bir console/windows forms uygulamasıdır. İlgilendiğiniz modülü açıp çalıştırabilirsiniz.

```bash
# Belirli bir modülü çalıştırma
cd 01_MainSubjects
dotnet run
```

## 📚 Öğrenilenler

- C# temel syntax ve yapısı
- Veri tipleri ve değişkenler
- Kontrol yapıları (if-else, switch)
- Döngüler (for, while, foreach)
- Diziler ve koleksiyonlar
- Metot tanımlama ve kullanımı
- ADO.NET ile veritabanı işlemleri
- CRUD operasyonları
- SQL komutları ve parametreli sorgular

## 🔗 Kaynaklar

- [Microsoft C# Docs](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)
- [ADO.NET Overview](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/)

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/new-module`)
3. Commit edin (`git commit -m 'feat: Add new module'`)
4. Push edin (`git push origin feature/new-module`)
5. Pull Request açın

## 📄 Lisans

Bu proje eğitim amaçlıdır.

## 👨‍💻 Geliştirici

**Emirhan ÇOBAN**
- GitHub: [@emirhan-coban](https://github.com/emirhan-coban)

---

⭐ Faydalı bulduysanız yıldız vermeyi unutmayın!

**Happy Coding! 🚀**
