using Mekel.BusinessLayer.Abstract;
using Mekel.BusinessLayer.Concrate;
using Mekel.DataAccessLayer.Abstract;
using Mekel.DataAccessLayer.Concrete;
using Mekel.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IBlogDal, EfBlogDal>();
builder.Services.AddScoped<IBlogService, BlogManager>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IChefDal, EfChefDal>();
builder.Services.AddScoped<IChefService, ChefManager>();

builder.Services.AddScoped<ICommentDal, EfCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IGalleryDal, EfGalleryDal>();
builder.Services.AddScoped<IGalleryService, GalleryManager>();

builder.Services.AddScoped<IHomeDal, EfHomeDal>();
builder.Services.AddScoped<IHomeService, HomeManager>();

builder.Services.AddScoped<IMenuDal, EfMenuDal>();
builder.Services.AddScoped<IMenuService, MenuManager>();

builder.Services.AddScoped<IReservationDal, EfReservationDal>();
builder.Services.AddScoped<IReservationService, ReservationManager>();

builder.Services.AddScoped<ISendMessageDal, EfSendMessageDal>();
builder.Services.AddScoped<ISendMessageService, SendMessageManager>();

builder.Services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
builder.Services.AddScoped<IMessageCategoryService, MessageCategoryManager>();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MekelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors("MekelApiCors");
app.Run();
