
//logica booleana
var cant1 = 5;
var cant2 = 5;

var cantidadIgual = cant1 == cant2; //true
var cantidadDiferente = cant1 != cant2;//false

Console.WriteLine($"Son {cant1} y {cant2} iguales? {cantidadIgual}");
Console.WriteLine($"Son {cant1} y {cant2} diferentes? {cantidadDiferente} ");

var esCantidad1MenorQue10 = cant1 < 10; //true  
var esCantidad1MayorQue10 = cant1 > 10; //false

var esCantidad1MenorIgualQue10 = cant1 <= 10;//true
var esCantidad1MayorIgualQue10 = cant1 >= 10;//false

Console.WriteLine($"Es {cant1} menor o igual que {cant2}? {esCantidad1MenorIgualQue10} ");
Console.WriteLine($"Es {cant1} mayor o igual que {cant2}? {esCantidad1MayorIgualQue10} ");
//strings
string? nom1 = null; //? de nolificable
var nom2 = "Beto";

var sonLosNombresIguales= nom1 != nom2;//true
Console.WriteLine($"Los nombre de {nom1} y {nom2} son diferentes? {sonLosNombresIguales}");

//null se usa normalmente "is"
var nombreNulo = nom1 is null; //false
var nombreNulo2 = nom2 is not null;//true
//podemos modificar como usamos el operador ==

Console.WriteLine($"Es nom1 {nom1} igual a nulo? {nombreNulo}");
Console.WriteLine($"Es nom1 {nom2} diferente de nulo? {nombreNulo2}");