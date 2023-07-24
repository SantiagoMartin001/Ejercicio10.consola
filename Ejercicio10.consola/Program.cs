// See https://aka.ms/new-console-template for more information

////Convierte Grados Celsius a Reaumur y Fahrenheits.

///VARIABLES
int GradosCelsius;
int GradosReaumur;
int GradosFahrenheits;

///PROCESO.


Console.WriteLine("Ingrese la temperatura en grados Celsius");
GradosCelsius= int.Parse(Console.ReadLine());

///// PROSESO 
GradosReaumur = (int)(0.8 * GradosCelsius);
GradosFahrenheits = (int)(1.8 * GradosCelsius + 32);



Console.WriteLine($"La conversión a grados Reaumur es  {GradosReaumur} ");
Console.WriteLine($"La conversión a grados Fahrenheits es {GradosFahrenheits}");