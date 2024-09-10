using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using ServerApp.Components;
using ServerApp.Components.Account;
using ServerApp.Data;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Services;
using ServerApp.Services;


namespace ServerApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

            builder.Services.AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                // options.UseSqlite("Data source=./Data/SQLite/data.db"));
                options.UseNpgsql(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddUserManager<UserManager<ApplicationUser>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

            builder.Services.AddBlazorBootstrap();
            builder.Services.AddScoped<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
            builder.Services.AddScoped<IDataService, SqlDbDataService>();
            builder.Services.AddScoped<IAdmin, AdminService>();
            // �������� ������������ �� ����� appsettings.Development.json, ���� �� ����������
            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            // Configure MailSettings from appsettings
            builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

            builder.Services.AddSingleton<IMailService, MailService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");  // исправление маршрута обработчика исключений
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            // Add additional endpoints required by the Identity Razor components.
            app.MapAdditionalIdentityEndpoints();

            app.Run();
        }
    }
}
