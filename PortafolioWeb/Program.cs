// Este programa solo muestra los archivos de la carpeta wwwroot.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();  // abre index.html automáticamente
app.UseStaticFiles();   // permite usar style.css, imágenes, etc.

app.Run();
