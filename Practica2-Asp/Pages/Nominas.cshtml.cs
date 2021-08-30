using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica2
{
    public class NominasModel : PageModel
    {
        public List<NominasModel> ListaNomina = new List<NominasModel>();

        NominasModel emp1;
        NominasModel emp2;
        NominasModel emp3;
        NominasModel emp4;
        NominasModel emp5;



        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double Salario_Mensual { get; set; }
        public double ARS { get; set; }
        public double AFP { get; set; }



        public void OnGet()
        {
            emp1 = new NominasModel();
            emp1.Nombre = "Pablo";
            emp1.Apellido = "Lopez";
            emp1.Cargo = "Desarrollador Web";
            emp1.Salario_Mensual = 624329;
            ListaNomina.Add(emp1);


            emp2 = new NominasModel();
            emp2.Nombre = "Rafa";
            emp2.Apellido = "Marquez";
            emp2.Cargo = "Economista";
            emp2.Salario_Mensual = 150000;
            ListaNomina.Add(emp2);

            emp3 = new NominasModel();
            emp3.Nombre = "Maria";
            emp3.Apellido = "Montero";
            emp3.Cargo = "Desarrollador Front-End";
            emp3.Salario_Mensual = 40600;
            ListaNomina.Add(emp3);

            emp4 = new NominasModel();
            emp4.Nombre = "Pedro";
            emp4.Apellido = "Monegro";
            emp4.Cargo = "Encargado de Seguridad";
            emp4.Salario_Mensual = 30000;
            ListaNomina.Add(emp4);

            emp5 = new NominasModel();
            emp5.Nombre = "Luisa";
            emp5.Apellido = "Paulino";
            emp5.Cargo = "Economista";
            emp5.Salario_Mensual = 70000;
            ListaNomina.Add(emp5);
        }

        public double Calcular_ARS(double Salario)
        {
            double a;
            a = Salario * 0.0304;

            if (a> 4098.53)
            {
                a = 4098.53;
            }
           
            return a;
        }

        public double Calcular_AFP(double Salario)
        {
            double a;
            a = Salario * 0.0287;

            if (a > 7738.67)
            {
                a = 7738.67;
            }
          
            return a;
        }

       
        public double Calcular_IRS(double Salario)
        {
            
            if (Salario < 416220)
            {
                Salario = 0;
            }
            else if (Salario < 624329)
            {
                Salario = 416220 * 0.15;
            }

            else if (Salario < 867123)
            {
                Salario = (624329 * 0.2) + 31216;

            }
            else
            {
                Salario = (867123 * 0.25) + 79776;
            }

            return Salario;
        }

        public double TotalDescuentos(double a, double b,double c)
        {
            double total;
            total = a + b + c;

            return total;
        }
        public double CalcularSalarioNeto(double a, double b)
        {
            double total;
            total = a - b;

            return total;
        }

    }
}