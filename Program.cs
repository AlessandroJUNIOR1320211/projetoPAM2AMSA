using System;
using System.Linq;

class Program {// classe
    static void Main() {
        string text= "Abc";// Declarando o tipo da variavel (texto)
        string Reverse = new string(text.Reverse().ToArray());//criando nova variavel do array so que reverse
        Console.WriteLine(Reverse);//Mostrando na tela  
    }
}


//Criei uma váriavel para mostrar 3 letras em ordem inversa