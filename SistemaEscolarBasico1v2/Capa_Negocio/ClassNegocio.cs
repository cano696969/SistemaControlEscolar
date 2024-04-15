using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class ClassNegocio
    {

        ClassDatos objd = new ClassDatos();
        public DataTable N_login(ClassEntidad obje)
        {
            return objd.D_login(obje);
        }

        public DataTable N_listar_usuarios()
        {
            return objd.D_listarusuarios();
        }

        public DataTable N_buscarusuario(ClassEntidad obje)
        {
            return objd.D_buscarusuarios(obje);
        }

        public DataTable N_listar_tipo()
        {
            return objd.D_listatipo();
        }

        public String N_mantenimientousuario(ClassEntidad obje)
        {
            return objd.D_mantenimientousuarios(obje);
        }

        public DataTable N_listar_salon()
        {
            return objd.D_listasalon();
        }

        public DataTable N_listar_curso()
        {
            return objd.D_listacurso();
        }

        public String N_mantenimientosalon(ClassEntidad obje)
        {
            return objd.D_mantenimientosalon(obje);
        }
        public String N_mantenimientocurso(ClassEntidad obje)
        {
            return objd.D_mantenimientocurso(obje);
        }

        public String N_pass(ClassEntidad obje)
        {
            return objd.D_pass(obje);
        }

        public DataTable N_totalcurso()
        {
            return objd.D_totalcursos();
        }

        public DataTable N_totalsalones()
        {
            return objd.D_totalsalones();
        }

        public DataTable N_totalalumnos()
        {
            return objd.D_totalalumnos();
        }

        public DataTable N_listaralumnos()
        {
            return objd.D_listar_alumnos();
        }

        public DataTable N_buscaralumnos(ClassEntidad obje)
        {
            return objd.D_buscaralumnos(obje);
        }

        public String N_mantenimientoalumno(ClassEntidad obje)
        {
            return objd.D_mantenimientoalumno(obje);
        }

        public DataTable N_buscaralumnosXcurso(ClassEntidad obje)
        {
            return objd.D_buscaralumnosXcurso(obje);
        }
        public DataTable N_buscaralumnosXsalon(ClassEntidad obje)
        {
            return objd.D_buscaralumnosXsalon(obje);
        }
    }
}
