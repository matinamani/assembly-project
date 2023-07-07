using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

var publicAddresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList
                .Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                .Select(x => $"http://{x}").ToList();

publicAddresses.Add("http://localhost");

Console.WriteLine($"App is running\nAvailable addresses:{string.Join(',', publicAddresses)}\nAddress example:[address]/makebeepsound\n");

app.Urls.Clear();
publicAddresses.ForEach(x => app.Urls.Add(x));

app.Run();
