// agradeço a atençao amigos
int idade = 0;
decimal salario = 0;

Console.WriteLine("Digite o seu nome !");
Console.ReadLine();
Console.WriteLine("Digite a sua idade !");
Console.ReadLine();
Console.WriteLine(" digite seu salario");
salario= Convert.ToDecimal(Console.ReadLine());

if (idade <= 100) 
{
    Console.WriteLine(" voce e jovem ainda !!!");
    Console.WriteLine(" seu salario e de: R$ " + salario);
        
}
else

{
    Console.WriteLine(" voce esta ficando velho !!!");
    Console.WriteLine(" seu salario e de: R$ " + salario);
    
}