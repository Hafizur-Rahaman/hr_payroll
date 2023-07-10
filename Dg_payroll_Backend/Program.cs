using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Newtonsoft.Json;
using Microsoft.ReportingServices.Interfaces;
using Dg_payroll.Services;
using ReportApi.Service;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddDbContext<dg_hrpayrollContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContetConnection")));

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IServiceReport, ServiceReport>();

//builder.Services.AddSwaggerGen(c=>
//{
//    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "WebapiAploadFile", Version = "V1" });
//});
//public void configure(IApplicationBuilder App,IWebHostEnvironment evn)
//{
//    if (Environment.IsDevelopnent())
//    {
//    App.UseDeveloperExceptionPage(); 
//    App.UseSwagger();
//        App.UseSwaggerUI(c => c.SwaggerEndpoint("/SwaggerEndpoint/v1/swagger.json", "WebApiUploadFile V1"));

//    }


//}





//builder.Services.AddScoped<IReportService, ReportService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.AddCors(p => p.AddPolicy("CorsPolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddMvc()
     .AddNewtonsoftJson(
          options => {
              options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
          });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Forhad}/{action=Index}/{id?}");

app.Run();