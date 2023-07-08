using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace APIpetshop.Models
{
	public class ApplicationDBContext: DbContext
	{

       

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){ }

        public DbSet<Producto> productos { get; set; }
        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Contacto> contactos { get; set; }

        public DbSet<ClienteCompra> clienteCompras { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto()
                {
                    idProducto = 1,
                    codeNumber = "watch001",
                    picture = "watch.png",
                    name = "Cool Watch",
                    quantity = "1",
                    price = "99"
                },
            new Producto()
            {
                idProducto = 2,
                codeNumber = "watch002",
                picture = "divingwatch.png",
                name = "Diving Watch",
                quantity = "1",
                price = "89"
            },
            new Producto()
            {
                idProducto = 3,
                codeNumber = "watch002",
                picture = "dresswatch.png",
                name = "Dress Watch",
                quantity = "1",
                price = "85"
            },
            new Producto()
            {
                idProducto = 4,
                codeNumber = "watch004",
                picture = "militarywatch.png",
                name = "Military Watch",
                quantity = "1",
                price = "99"
            },

            new Producto()
            {
                idProducto = 5,
                codeNumber = "watch004",
                picture = "wristwatch.png",
                name = "Wrist Watch",
                quantity = "1",
                price = "85"
            },

            new Producto()
            {
                idProducto = 6,
                codeNumber = "watch004",
                picture = "awatch.png",
                name = "Army Watch",
                quantity = "1",
                price = "99"
            }
            );

            //);
            //modelBuilder.Entity<Cliente>().HasData(
            //    new Cliente
            //    {
            //        idCliente=1,
            //        nombre="Carlos Guaita",
            //        cedula="1715607071",
            //        direccion="La Tola",
            //        telefono="0984667518"
            //    },
            //    new Cliente
            //    {
            //        idCliente = 2,
            //        nombre = "Luis Quishpe",
            //        cedula = "0987654321",
            //        direccion = "Ajaví",
            //        telefono = "0912345678"
            //    },
            //    new Cliente
            //    {
            //        idCliente = 3,
            //        nombre = "Edgar Guijarro",
            //        cedula = "1712349876",
            //        direccion = "Tumbaco",
            //        telefono = "0912349876"
            //    }
            //    );

            //modelBuilder.Entity<Contacto>().HasData(
            //    new Contacto
            //    {
            //        idContacto = 1,
            //        nombre = "Carlos Guaita",
            //        cedula = "1715607071",
            //        direccion = "La Tola",
            //        telefono = "0984667518",
            //        imagen= "https://cdn-icons-png.flaticon.com/512/3577/3577429.png"
            //    },
            //    new Contacto
            //    {
            //        idContacto = 2,
            //        nombre = "Luis Quishpe",
            //        cedula = "0987654321",
            //        direccion = "Ajaví",
            //        telefono = "0912345678",
            //        imagen = "https://cdn-icons-png.flaticon.com/512/1198/1198293.png"

            //    },
            //    new Contacto
            //    {
            //        idContacto = 3,
            //        nombre = "Edgar Guijarro",
            //        cedula = "1712349876",
            //        direccion = "Tumbaco",
            //        telefono = "0912349876",
            //        imagen = "https://cdn-icons-png.flaticon.com/512/1373/1373254.png"
            //    }
            //    );

        }

    }
}

