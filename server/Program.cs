var builder = WebApplication.CreateBuilder(args);

// ================================
// SERVICE REGISTRATION (DI)
// ================================

// * REST CONTROLLERS *
builder.Services.AddControllers();

// * SIGNALR (REAL-TIME GAMEPLAY) *
builder.Services.AddSignalR();

// * AUTHENTICATION *
// (JWT or Cookies will be configured here later)
builder.Services.AddAuthentication();

// * AUTHORIZATION *
// Used for trainer permissions + DM overrides
builder.Services.AddAuthorization();

// * APPLICATION SERVICES *
// ⭐ Game rules & authority live here
// builder.Services.AddScoped<IPermissionService, PermissionService>();
// builder.Services.AddScoped<IPokemonService, PokemonService>();
// builder.Services.AddScoped<IPartyService, PartyService>();
// builder.Services.AddScoped<ICampaignService, CampaignService>();

// * DATABASE *
// builder.Services.AddDbContext<ApplicationDbContext>(options =>
// {
//     options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
// });

// * EXTERNAL APIs *
// builder.Services.AddHttpClient<PokeApiClient>(client =>
// {
//     client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
// });

// * OPENAPI / SWAGGER *
builder.Services.AddOpenApi();

var app = builder.Build();

// ================================
// HTTP REQUEST PIPELINE
// ================================

if (app.Environment.IsDevelopment())
{
    // * API DOCUMENTATION *
    app.MapOpenApi();
}

// * SECURITY *
app.UseHttpsRedirection();

// * AUTH PIPELINE *
// Order matters: Authentication BEFORE Authorization
app.UseAuthentication();
app.UseAuthorization();

// ================================
// ENDPOINT MAPPING
// ================================

// * REST API ENDPOINTS *
app.MapControllers();

// * SIGNALR HUB ENDPOINT *
// All real-time campaign traffic flows through here
app.MapHub<CampaignHub>("/campaignhub");

app.Run();
