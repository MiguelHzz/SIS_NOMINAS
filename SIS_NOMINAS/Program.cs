using TMGROUP.Filter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Move these lines here:
builder.Services.AddSession();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<Seguridad>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/", context =>
{
    context.Response.Redirect("/LoginTmg/Login"); // pagina que arraca el proyecto
    return Task.CompletedTask;
});

app.Run();
