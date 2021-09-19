using System.Runtime.Intrinsics.Arm.Arm64;
namespace Dominio.Entidades
{
    public class Directivo : Empleado
    {
        public Directivo(string id, double SueldoBruto) : Base(id, SueldoBruto){

        
        }
        public string categoria{get;set;};
    }
}