using BlazorChatBox.Server.Hubs;
using BlazorChatBox;
using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddServerSideBlazor();

// Custom Services
builder.Services.AddSingleton<IGetLogChat, GetLogService>();
builder.Services.AddSingleton<IGetFile, GetFileService>();
var provider = new FileExtensionContentTypeProvider();
provider.Mappings["{EXTENSION}"] = "{CONTENT TYPE}";

builder.Services.Configure<StaticFileOptions>(options =>
{
    options.ContentTypeProvider = provider;
});



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapHub<ChatHub>("/chathub");
app.MapBlazorHub();
app.MapFallbackToFile("index.html");

app.Run();