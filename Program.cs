decimal alcool  = Convert.ToDecimal(Console.ReadLine());
decimal gasolina  = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine ("Alcool ou Gasolina");
Console.WriteLine ("Digite o valor do alcool:(R$)");
Console.WriteLine ("Digite o valor da gasolina:(R$)");

string recomendacao;
if (AbastecerComGasolina(alcool, gasolina))
{
    recomendacao = "Gasolina";
}
else
{
    recomendacao = "Alcool";
}
double razao = RazaoAlcoolGasolina(alcool, gasolina) * 100;

Console.WriteLine($"O preço do Alcool corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine($"Recomendação: Abasteça com {recomendacao.ToUpper()}.");

double RazaoAlcoolGasolina(decimal precoAlcool, decimal precoGasolina)
{
    return Convert.ToDouble(precoAlcool / precoGasolina);
}

bool AbastecerComGasolina(decimal precoAlcool, decimal precoGasolina)
{
    const double MinRazaoUsoGasolina = 0.73;
    return RazaoAlcoolGasolina(precoAlcool, precoGasolina) >= MinRazaoUsoGasolina;
}
