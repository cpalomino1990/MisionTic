using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;

 public RepositorioRutas()
    {
   rutas = new List<Rutas>()
        {
            new Rutas{Id=4,Origen= 23, Destino= 323,Tiempo_Estimado=4},
            new Rutas{Id=5,Origen= 232, Destino= 65,Tiempo_Estimado=6},
            new Rutas{Id=6,Origen= 544, Destino= 12,Tiempo_Estimado=1}
        };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int Id){
            return rutas.SingleOrDefault(b => b.Id == Id);
            
        }
        public Rutas Update(Rutas newRuta){
            var ruta = rutas.SingleOrDefault(b => b.Id == newRuta.Id);
            if(ruta != null){
                ruta.Origen = newRuta.Origen;
                ruta.Destino = newRuta.Destino;
                ruta.Tiempo_Estimado = newRuta.Tiempo_Estimado;
                
            }
        return ruta;
        }
    }
}
