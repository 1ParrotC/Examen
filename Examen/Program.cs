using System;
using System.Collections.Generic;
using System.IO;

// Lista de libros y operaciones solicitadas en el ejercicio 2
var lista = new List<Libro>();

// a) Insertar tres libros
lista.Add(new Libro("1984", "George Orwell", 1949, true));
lista.Add(new Libro("El Quijote", "Miguel de Cervantes", 1605, false));
lista.Add(new Libro("Rebelión en la granja", "George Orwell", 1945, true));

// b) Mostrar todos los libros
Console.WriteLine("Todos los libros:");
foreach (var l in lista)
{
    Console.WriteLine(l.ToString());
}

// c) Mostrar solo los libros cuyo autor contenga "Orwell"
Console.WriteLine();
Console.WriteLine("Libros cuyo autor contiene 'Orwell':");
foreach (var l in lista)
{
    if (l.Autor.Contains("Orwell"))
    {
        Console.WriteLine(l.ToString());
    }
}

// Apartado 2.2: mostrar fecha actual en formato corto
Console.WriteLine();
Console.WriteLine($"Fecha actual: {DateTime.Now.ToShortDateString()}");

// Apartado 2.3: guardar en fichero
var ruta = Path.Combine(Directory.GetCurrentDirectory(), "libros.txt");
guardarLibros(lista, ruta);
Console.WriteLine($"Libros guardados en: {ruta}");

static void guardarLibros(List<Libro> lista, string ruta)
{
    using var sw = File.CreateText(ruta);
    foreach (var l in lista)
    {
        sw.WriteLine($"{l.Titulo};{l.Autor};{l.Anyo};{l.Disponible}");
    }
}
