var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // ให้โหลด index.html อัตโนมัติ
app.UseStaticFiles();    // ให้อ่านไฟล์ใน wwwroot ได้

app.Run();