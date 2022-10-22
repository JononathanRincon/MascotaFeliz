using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;


namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddVeterinario();
           AddMascota();
           //ListarMascotas();
           //AddDueno();
           BuscarporMascota("Capuchino");
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Diaz",
                Direccion = "casa 77",
                Telefono = "555546546",
                Correo = "juan@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "angel",
                Color = "negro",
                Especie = "Gato",
                Raza = "Siames"

            };
            _repoMascota.AddMascota(mascota);
        }
          private static void ListarMascotas()
        {
            var mascotas= _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " "+ m.Raza + " "+ m.Color+ " "+ m.Especie);
            }
        }

        private static void BuscarporMascota(string Nombre)
        {
            var GetMascota = _repoMascota.GetMascotasPorFiltro(Nombre); 
             foreach (Mascota i in GetMascota)
            {
                Console.WriteLine(i.Nombre + " "+ i.Raza + " "+ i.Color+ " "+ i.Especie);
            }
        }
    }     
}
