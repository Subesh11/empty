var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=User}/{action=Index}"
    );


//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/Home",async(context)=> {
//        await context.Response.WriteAsync("This is Home page");
//    });

//});
//app.MapGet("/", () => "Hello World!");

app.Run();
