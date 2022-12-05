using Chat_And_File_Sharing.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapHub<ChatWithFileShareHub>("/chatWithFileShareHub");
app.Run();
