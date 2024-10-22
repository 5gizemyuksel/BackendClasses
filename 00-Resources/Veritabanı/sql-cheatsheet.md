# SQL CheatSheet: Temel Komutlar, Açıklamalar ve Örnekler

## Veri Sorgulama (DQL - Data Query Language)

### SELECT
Veritabanından veri çekmek için kullanılır.
```sql
SELECT sütun1, sütun2 FROM tablo_adı;
SELECT * FROM tablo_adı;

-- Örnek:
SELECT ad, soyad FROM öğrenciler;
SELECT * FROM dersler;
```

### WHERE
Sorgu sonuçlarını filtrelemek için kullanılır.
```sql
SELECT * FROM tablo_adı WHERE koşul;

-- Örnek:
SELECT * FROM öğrenciler WHERE yaş > 20;
SELECT ad, soyad FROM çalışanlar WHERE departman = 'IT';
```

### ORDER BY
Sorgu sonuçlarını belirli bir sütuna göre sıralamak için kullanılır.
```sql
SELECT * FROM tablo_adı ORDER BY sütun ASC|DESC;

-- Örnek:
SELECT ad, soyad FROM öğrenciler ORDER BY soyad ASC;
SELECT ürün_adı, fiyat FROM ürünler ORDER BY fiyat DESC;
```

### LIMIT
Sorgu sonuçlarının sayısını sınırlamak için kullanılır.
```sql
SELECT * FROM tablo_adı LIMIT sayı;

-- Örnek:
SELECT * FROM siparişler LIMIT 10;
SELECT ad, puan FROM öğrenciler ORDER BY puan DESC LIMIT 5;
```

### JOIN
İki veya daha fazla tabloyu birleştirmek için kullanılır.
```sql
SELECT * FROM tablo1
INNER JOIN tablo2 ON tablo1.sütun = tablo2.sütun;

-- Örnek:
SELECT öğrenciler.ad, dersler.ders_adı
FROM öğrenciler
INNER JOIN kayıtlar ON öğrenciler.öğrenci_id = kayıtlar.öğrenci_id
INNER JOIN dersler ON kayıtlar.ders_id = dersler.ders_id;
```

## Veri Manipülasyonu (DML - Data Manipulation Language)

### INSERT
Tabloya yeni veri eklemek için kullanılır.
```sql
INSERT INTO tablo_adı (sütun1, sütun2) VALUES (değer1, değer2);

-- Örnek:
INSERT INTO öğrenciler (ad, soyad, yaş) VALUES ('Ahmet', 'Yılmaz', 22);
```

### UPDATE
Mevcut verileri güncellemek için kullanılır.
```sql
UPDATE tablo_adı SET sütun1 = değer1 WHERE koşul;

-- Örnek:
UPDATE çalışanlar SET maaş = maaş * 1.10 WHERE departman = 'Satış';
```

### DELETE
Tablodan veri silmek için kullanılır.
```sql
DELETE FROM tablo_adı WHERE koşul;

-- Örnek:
DELETE FROM siparişler WHERE sipariş_tarihi < '2023-01-01';
```

## Veri Tanımlama (DDL - Data Definition Language)

### CREATE DATABASE
Yeni bir veri tabanı yaratmak için kullanılır.
```sql
CREATE DATABASE veritabanı_adı

-- Örnek:
CREATE DATABASE University
```

### CREATE TABLE
Yeni bir tablo oluşturmak için kullanılır.
```sql
CREATE TABLE tablo_adı (
    sütun1 veri_tipi,
    sütun2 veri_tipi
);

-- Örnek:
CREATE TABLE müşteriler (
    müşteri_id INT PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    email VARCHAR(100) UNIQUE,
    kayıt_tarihi DATE
);
```

### ALTER TABLE
Mevcut bir tablonun yapısını değiştirmek için kullanılır.
```sql
ALTER TABLE tablo_adı ADD sütun veri_tipi;

-- Örnek:
ALTER TABLE öğrenciler ADD sınıf VARCHAR(10);
```

### DROP TABLE
Bir tabloyu tamamen silmek için kullanılır.
```sql
DROP TABLE tablo_adı;

-- Örnek:
DROP TABLE eski_kayıtlar;
```

## Diğer Önemli Kavramlar

- Anahtar Kelimeler: 
  - AND, OR, NOT: Koşulları birleştirmek veya olumsuzlamak için kullanılır.
  - IN: Bir değerin belirli bir liste içinde olup olmadığını kontrol eder.
  - BETWEEN: Bir değerin belirli bir aralıkta olup olmadığını kontrol eder.
  - LIKE: Metin eşleştirme için kullanılır.
  - IS NULL: Null değerleri kontrol etmek için kullanılır.

```sql
-- Örnekler:
SELECT * FROM ürünler WHERE fiyat BETWEEN 100 AND 500;
SELECT * FROM çalışanlar WHERE departman IN ('IT', 'Satış', 'Pazarlama');
SELECT * FROM müşteriler WHERE email LIKE '%@gmail.com';
SELECT * FROM siparişler WHERE kargo_takip_no IS NULL;
```

- Fonksiyonlar: 
  - COUNT(): Satır sayısını hesaplar.
  - AVG(): Ortalama değeri hesaplar.
  - SUM(): Toplam değeri hesaplar.
  - MAX(): En yüksek değeri bulur.
  - MIN(): En düşük değeri bulur.

```sql
-- Örnekler:
SELECT COUNT(*) FROM öğrenciler;
SELECT AVG(maaş) FROM çalışanlar;
SELECT SUM(miktar) FROM satışlar;
SELECT MAX(puan) FROM sınavlar;
SELECT MIN(stok_miktarı) FROM ürünler;
```

- Gruplandırma: 
  - GROUP BY: Verileri belirli bir sütuna göre gruplar.
  - HAVING: Gruplandırılmış veriler üzerinde filtreleme yapar.

```sql
-- Örnek:
SELECT departman, AVG(maaş) as ortalama_maaş
FROM çalışanlar
GROUP BY departman
HAVING AVG(maaş) > 5000;
```
