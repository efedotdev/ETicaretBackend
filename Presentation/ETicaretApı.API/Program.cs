using System.Security.Claims;
using System.Text;
using ETicaret.Apı.Persistence;
using ETicaretApı.Infrastructure.Services.Storage.Azure;
using ETicaretApı.Infrastructure.Services.Storage.Local;
using ETicaretApı.API.Configurations.ColumnWriters;
using ETicaretApı.API.Extensions;
using ETicaretApı.API.Filters;
using ETicaretApı.Application;
using ETicaretApı.Application.Validations;
using ETicaretApı.Infrastructure.Services.Storage.Azure;
using ETicaretApı.Infrasturacture;
using ETicaretApı.Infrasturacture.Filters;
using ETicaretApı.SignalR;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.PostgreSQL;
using ILogger = Microsoft.Extensions.Logging.ILogger;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructureServices();
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddSignalRServices();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials()));

Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.PostgreSQL(builder.Configuration
            .GetConnectionString("PostgreSQL"), "logs", needAutoCreateTable: true,
        columnOptions: new Dictionary<string, ColumnWriterBase>
        {
            { "message", new RenderedMessageColumnWriter() },
            { "message_template", new MessageTemplateColumnWriter() },
            { "level", new LevelColumnWriter() },
            { "time_stamp", new TimestampColumnWriter() },
            { "exception", new ExceptionColumnWriter() },
            { "log_event", new LogEventSerializedColumnWriter() },
            { "user_name", new UsernameColumnWriter() }
        })
    .WriteTo.Seq(builder.Configuration["Seq:ServerUrl"])
    .Enrich.FromLogContext()
    .MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(Logging =>
{
    Logging.LoggingFields = HttpLoggingFields.All;
    Logging.RequestHeaders.Add("sec-ch-ua");
    Logging.ResponseHeaders.Add("MyResponseHeader");
    Logging.MediaTypeOptions.AddText("application/javascript");
    Logging.RequestBodyLogLimit = 4096;
    Logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddControllers(options =>
    {
        options.Filters.Add<ValidationFilter>();
        options.Filters.Add<RolePermissionFilter>();
    })
    .AddFluentValidation(configuration =>
        configuration.RegisterValidatorsFromAssemblyContaining<CreateProductsValidator>
            ())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Admin", options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, //oluşturulacak token değerini kimlerin kullanacağını belirleyecek 
            ValidateIssuer = true, // oluşturulacak token değerinin kimin dağıtacağına karar verir
            ValidateIssuerSigningKey =
                true, //  üretilecek token değerinin uygulamamıza özel bir key verisinin doğrulanmasıdır.
            ValidateLifetime = true, // oluşturulan token değerinin süresini kontrol edecek doğrulamadır

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey =
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
            LifetimeValidator = (notBefore, expires, securityToken, validationParameters) =>
                expires != null ? expires > DateTime.UtcNow : false,

            NameClaimType = ClaimTypes.Name
        };
    });


builder.Services.AddOpenApi();
builder.Services.AddStorage<AzureStorage>();
//builder.Services.AddStorage<LocalStorage>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseStaticFiles();

app.UseSerilogRequestLogging();

app.UseHttpLogging();
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var username = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identity.Name : null;
    LogContext.PushProperty("user_name", username);
    await next();
});

app.MapControllers();
app.MapHubs();

app.Run();