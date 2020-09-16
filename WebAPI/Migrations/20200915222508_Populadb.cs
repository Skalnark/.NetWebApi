using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES('Bebidas', " +
                "'http://www.macoratti.net/Imagens/1.jpg')");
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES('Lanches', " +
                "'http://www.macoratti.net/Imagens/2.jpg')");
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES('Sobremesas', " +
                "'http://www.macoratti.net/Imagens/3.jpg')");

            mb.Sql("INSERT INTO Products(Name, Description, Price, ImageUrl, Amount, Created, CategoryId) VALUES(" +
                "'Coca-cola Diet', 'Refrigerante de Cola 350ml', 9.00, " +
                "'http://www.macoratti.net/Imagens/coca.jpg', 50, now()," +
                "(SELECT Id FROM Categories WHERE Name='Bebidas'))");
            mb.Sql("INSERT INTO Products(Name, Description, Price, ImageUrl, Amount, Created, CategoryId) VALUES(" +
                "'Lanche de Atum', 'Lanche de atum com maionese', 9.00, " +
                "'http://www.macoratti.net/Imagens/atum.jpg', 10, now()," +
                "(SELECT Id FROM Categories WHERE Name='Lanches'))");
            mb.Sql("INSERT INTO Products(Name, Description, Price, ImageUrl, Amount, Created, CategoryId) VALUES(" +
                "'Pudim 100 g', 'Pudim de leite condensado 100g', 6.00, " +
                "'http://www.macoratti.net/Imagens/pudim.jpg', 30, now()," +
                "(SELECT Id FROM Categories WHERE Name='Sobremesas'))");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM CATEGORIES");
            mb.Sql("DELETE FROM PRODUCTS");
        }
    }
}
