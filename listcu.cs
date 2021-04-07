using System;
namespace LISTA ALUMNOS{
    public class listcu{
        Static void Main(String[] args){
            String[] student = new string[2];
            student[] listastudent = new student[2];

            String[] cursos = new string[2];
            cursos[] listacursos = new cursos[2];

            int cont=0;

            while (cont<2)

            {
                Console.WriteLine("Ingrese su nombre");
                String nombre = Console.ReadLine();

                 Console.WriteLine("Ingrese su edad");
                String edad = Console.ReadLine();

                 Console.WriteLine("Ingrese el numero de su carnet");
                String carnet = Console.ReadLine();

                 Console.WriteLine("Ingrese si esta solvente");
                Boolean solvencia = Boolean.Parse(Console.ReadLine());

                student estudiante = new student(nombre, edad, carnet, solvente);

                for(int x=0; x<2; x++){
                    Console.WriteLine("Ingrese curso");
                    String nombredelcurso = Console.ReadLine();

                    Console.WriteLine("Ingrese la nota del parcial 1");
                    int nota1 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota del parcial 2");
                    int nota2 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota del examen final");
                    int notafinal = Convert.ToInt16(Console.ReadLine());

                    cursos cursitos = new cursos(nombredelcurso, nota1, nota2, final);

                    listacursos[X]= cursitos;

                    
                    

                }

                listastudent[cont]=student;
                cont++;

                

                 

                                
            }
            Console.WriteLine("");
            Console.WriteLine("Lista");

            for(int i=0; i<2; i++){
                student estudiante = listastudent[i];
                Console.WriteLine("nombre: " +estudiante.nombre + "carnet: " + estudiante.carnet + "edad: " +estudiante.edad );
                Console.WriteLine("Se encuentra solvente? "+estudiante.solvencia);

                for(int j=0; j<2; j++){
                    cursos cursitos = listacursos[j];
                    Console.WriteLine("Curso: "+cursitos.nombredelcurso);
                    Console.WriteLine("Nota del Parcial 1: "+cursitos.nota1+ "Nota del parcial 2: "+cursitos.nota2);
                    Console.WriteLine("Nota del Examen Final: "+cursitos.notafinal);
                    Console.WriteLine("");
                }
            }
        }
    }
}