﻿using Maxim_Cazacu_Lab2.Data;
using Maxim_Cazacu_Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Maxim_Cazacu_Lab2.Models;
namespace Maxim_Cazacu_Lab2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new
           LibraryContext(serviceProvider.GetRequiredService
            <DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return; // BD a fost creata anterior
                }
                context.Books.AddRange(
                new Book
                {
                    Title = "Baltagul",
                    Author = "Mihail Sadoveanu",Price=Decimal.Parse("22")},


                new Book
                {
                    Title = "Enigma Otiliei",
                    Author = "George Calinescu",Price=Decimal.Parse("18")},


                new Book
                {
                    Title = "Maytrei",
                    Author = "Mircea Eliade",Price=Decimal.Parse("27")}
                );

                context.Genre.AddRange(
               new Genre { Name = "Roman" },
               new Genre { Name = "Nuvela" },
               new Genre { Name = "Poezie" }
                );
                context.Customer.AddRange(
                new Customer
                {
                    Name = "Popescu Marcela",
                    Adress = "Str. Plopilor, nr. 24",
                    BirthDate = DateTime.Parse("1979-09-01")
                },
                new Customer
                {
                    Name = "Mihailescu Cornel",
                    Adress = "Str. Bucuresti, nr.45,ap. 2",BirthDate=DateTime.Parse("1969 - 07 - 08")}


                );

                context.SaveChanges();
            }
        }
    }
}