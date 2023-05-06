Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine("*** CONSULTA DE COMPUTADORES ***");

Console.ResetColor();


string consulta = "";
while (consulta != "N")

{

try

{

double renda;

Console.ForegroundColor = ConsoleColor.Gray;

Console.Write("\nA sua renda mensal: ");

renda = Convert.ToDouble(Console.ReadLine());

Console.ResetColor();


if (renda < 999)

{

Console.ForegroundColor = ConsoleColor.DarkRed;

Console.WriteLine("Você é pobre, arrume um emprego melhor!");

Console.ResetColor();

}

else if (renda < 1800)

{

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine("Você conseguirá comprar um Positivo");

Console.ResetColor();

}

else if (renda < 2500 )

{

Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("Você conseguirá comprar um Lenovo");

Console.ResetColor();

}

else if (renda < 4500)

{

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Você conseguirá comprar um Dell");

Console.ResetColor();

}

else

{

Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine("Você conseguirá comprar um MacBook");

Console.ResetColor();

}

}
catch (FormatException)
{

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("\nValor digitado incorreto, por favor digite um número.");

Console.ResetColor();

}


Console.Write("\nQuer consultar novamente [S]im [N]ão: ");

consulta = Console.ReadLine()!.ToUpper().Trim().Substring(0, 1);

}

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("\nCriado por: Vinicius e Thayna");

Console.ResetColor();


/*

ate 1000 - Positivo
ate 2500 - Lenovo
ate 4000 - Dell
ate 6000 - Macbook
*/
