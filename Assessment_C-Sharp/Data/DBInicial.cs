using Assessment_C_Sharp.Models;

namespace Assessment_C_Sharp.Data {
    public class DBInicial {

        public static void Seed(IApplicationBuilder applicationBuilder) {

            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {

                var context = serviceScope.ServiceProvider.GetService<PokemonDBContext>();


                context.Database.EnsureCreated();

                if (!context.Pokemon.Any()) {

                    context.Pokemon.AddRange(new List<Pokemon>() {

                        new Pokemon() {
                            Nome = "Bulbasauto",
                            Tipo = "Grama",      
                            Peso = "10",
                            Fraqueza= "Fogo",
                            Altura = "1.90",
                             dataCriacao = new DateTime(2010, 10, 10)

                        }

                    });
                }
                    context.SaveChanges();
                   

                }

            }
        }

    }

