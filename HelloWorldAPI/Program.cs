// Program.cs  
var builder = WebApplication.CreateBuilder(args);  

// Adaugă serviciile  
builder.Services.AddCors(options =>  
{  
    options.AddPolicy("AllowOrigin", builder =>  
    {  
        builder.WithOrigins("*")  
               .AllowAnyMethod()  
               .AllowAnyHeader();  
    });  
});  
builder.Services.AddControllers();  

var app = builder.Build();  

// Configurează middleware  
app.UseCors("AllowOrigin");  
app.UseAuthorization();  

app.MapControllers();  

app.Run();