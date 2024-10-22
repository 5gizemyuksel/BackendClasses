# Windows için Docker, SQL Server 2019 ve Azure Data Studio Kurulum Rehberi

Arkadaşlar bu rehber, Windows 10/11 işletim sisteminde Docker kurulumu, Docker üzerinde SQL Server 2019 container'ı oluşturma ve Azure Data Studio ile bu container'a bağlanma süreçlerini adım adım anlatmaktadır.

## 1. Docker Kurulumu

### Adım 1: Sistem Gereksinimlerini Kontrol Etme

- Windows 10 64-bit: Pro, Enterprise veya Education (Build 15063 veya daha yeni)
- Windows 11 64-bit: Pro, Enterprise veya Education
- WSL 2 özelliği etkinleştirilmiş olmalı
- BIOS'ta donanım sanallaştırma desteği açık olmalı

### Adım 2: Docker Desktop'u İndirme

1. Resmi Docker web sitesine gidin: https://www.docker.com/products/docker-desktop
2. "Download for Windows" butonuna tıklayın.
3. İndirilen "Docker Desktop Installer.exe" dosyasını çalıştırın.

### Adım 3: Docker Desktop'u Yükleme

1. Yükleyiciyi çalıştırdığınızda, varsayılan ayarları kabul edin.
2. "Use WSL 2 instead of Hyper-V" seçeneğinin işaretli olduğundan emin olun.
3. Yükleme tamamlandığında bilgisayarınızı yeniden başlatın.

### Adım 4: Docker Desktop'u Başlatma ve Doğrulama

1. Bilgisayarınız yeniden başladıktan sonra Docker Desktop'u başlatın.
2. Başlangıç tamamlandığında, sistem tepsisinde Docker ikonunun görünür olduğundan emin olun.
3. PowerShell veya Command Prompt açın ve aşağıdaki komutu çalıştırarak Docker'ın düzgün çalıştığını doğrulayın:

   ```
   docker --version
   ```

   Bu komut, yüklü Docker sürümünü göstermelidir.

## 2. Docker Üzerinde SQL Server 2019 Container'ı Oluşturma

### Adım 1: SQL Server 2019 İmajını İndirme

1. PowerShell veya Command Prompt'u yönetici olarak açın.
2. Aşağıdaki komutu çalıştırarak SQL Server 2019 imajını indirin:

   ```
   docker pull mcr.microsoft.com/mssql/server:2019-latest
   ```

   Not: Bu komut, Microsoft Container Registry'den en son SQL Server 2019 imajını indirir.

### Adım 2: SQL Server 2019 Container'ını Oluşturma ve Çalıştırma

1. Aşağıdaki komutu çalıştırarak SQL Server 2019 container'ını oluşturun ve başlatın:

   ```
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" -p 1440:1433 --name sql_server_2019_container -d mcr.microsoft.com/mssql/server:2019-latest
   ```

   Bu komutun açıklaması:
   - `-e "ACCEPT_EULA=Y"`: SQL Server lisans anlaşmasını kabul eder.
   - `-e "SA_PASSWORD=YourStrong@Passw0rd"`: SA kullanıcısı için güçlü bir şifre belirler.
   - `-p 1440:1433`: Host makinenin 1433 portunu container'ın 1440 portuna yönlendirir.
   - `--name sql_server_2019_container`: Container'a bir isim atar.
   - `-d`: Container'ı arka planda (detached mode) çalıştırır.

2. Container'ın çalışıp çalışmadığını kontrol etmek için aşağıdaki komutu kullanın:

   ```
   docker ps
   ```

   Bu komut, çalışan container'ların listesini gösterecektir.

### Adım 3: SQL Server 2019 Container'ının Durumunu Kontrol Etme

1. Container'ın loglarını görüntülemek için aşağıdaki komutu kullanın:

   ```
   docker logs sql_server_2019_container
   ```

   Loglar arasında "SQL Server is now ready for client connections" mesajını görürseniz, SQL Server başarıyla başlatılmış demektir.

## 3. Azure Data Studio ile SQL Server 2019 Container'ına Bağlanma

### Adım 1: Azure Data Studio'yu İndirme ve Kurma

1. Microsoft'un resmi web sitesinden Azure Data Studio'yu indirin: https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio
2. İndirilen yükleyiciyi çalıştırın ve kurulum adımlarını takip edin.

### Adım 2: Azure Data Studio'yu Başlatma ve SQL Server 2019'a Bağlanma

1. Azure Data Studio'yu başlatın.
2. Sol üst köşedeki "New Connection" (Yeni Bağlantı) butonuna tıklayın.
3. Bağlantı detaylarını girin:
   - Server: `localhost,1433`
   - Authentication Type: SQL Login
   - User name: `sa`
   - Password: `YourStrong@Passw0rd` (Docker container'ını oluştururken belirlediğiniz şifre)
   - Database: Boş bırakın veya `master` yazın
4. "Connect" (Bağlan) butonuna tıklayın.

### Adım 3: Bağlantıyı Doğrulama

1. Bağlantı başarılı olduysa, sol tarafta sunucu ve veritabanları görünecektir.
2. Yeni bir sorgu penceresi açmak için "New Query" (Yeni Sorgu) butonuna tıklayın.
3. Aşağıdaki SQL sorgusunu yazın ve çalıştırın:

   ```sql
   SELECT @@VERSION;
   ```

   Bu sorgu, SQL Server 2019 sürümünü gösterecektir.

Artık Docker üzerinde çalışan bir SQL Server 2019 instance'ına Azure Data Studio ile başarıyla bağlanabiliyoruz.

