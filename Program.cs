var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();
//Rest API => GET, POST, PUT, DELETE

app.MapGet("/hello",()=>
{
    return"Get Method: Hello World";
});


app.Run();
