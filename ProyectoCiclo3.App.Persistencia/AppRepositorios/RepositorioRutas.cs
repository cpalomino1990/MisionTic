using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
        private readonly AppContext _appContext = new AppContext();
        
        public IEnumerable<Rutas> GetAll()
        {
           return _appContext.Rutas;
        }

 
        public Rutas GetRutaWithId(int Id){
        return _appContext.Rutas.Find(Id);
        }
        
        public Rutas Create(Rutas newRuta)
    {
        var addRuta = _appContext.Rutas.Add(newRuta);
        _appContext.SaveChanges();
        return addRuta.Entity;
    }

       public void Delete(int Id)
    {
        var ruta = _appContext.Rutas.Find(Id);
        if (ruta == null)
            return;
        _appContext.Rutas.Remove(ruta);
        _appContext.SaveChanges();
    }


    public Rutas Update(Rutas newRuta){
        var ruta = _appContext.Rutas.Find(newRuta.Id);
        if(ruta != null){
            ruta.Origen = newRuta.Origen;
            ruta.Destino = newRuta.Destino;
            ruta.Tiempo_Estimado = newRuta.Tiempo_Estimado;
           
            //Guardar en base de datos
            _appContext.SaveChanges();
            }
            return ruta;
        }
    }
}
         

