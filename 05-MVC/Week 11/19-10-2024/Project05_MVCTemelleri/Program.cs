//Buradaki tüm kodlar aslında main metodunun içindeler
var builder = WebApplication.CreateBuilder(args); //bir web application oluşturucu

// Add services to the container.
//Bu satırla bu uygulamanın bir MVC uygulaması olacağı bildiriliyor
builder.Services.AddControllersWithViews();

var app = builder.Build(); //bir web application(mvc) oluşturuluyor

// Configure the HTTP request pipeline.
//Bu aşamadan run yapılana kadar olan kısımda gelen istekler yapılandırılıyor.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //http üzerinden gelen istekleri https'e yönlendirir.
app.UseStaticFiles(); // wwwroot klasörünün kullanılabilir olmasını sağlar.

app.UseRouting(); //Gelen isteklerin hangi controllera gitmesi gerektiğini belirler.

app.UseAuthorization(); //yetkilendirme özelliklerini aktif kılar.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//https://localhost:5100/Home/Index
//https://localhost:5100/Home
//https://localhost:5100
//https://localhost:5100 
//https://localhost:5100 
//https://localhost:5100 
//https://localhost:5100 
//https://localhost:5100 


app.Run(); //Oluşturulan web application çalıştırılıyor. 
