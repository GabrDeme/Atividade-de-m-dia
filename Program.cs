Console.WriteLine($"Anexe as sua 1º nota aqui: ");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Anexe as sua 2º nota aqui: ");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Anexe as sua 3º nota aqui: ");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Anexe as sua 4º nota aqui: ");
int nota4 = int.Parse(Console.ReadLine());

Console.WriteLine($"Anexe as sua 5º nota aqui: ");
int nota5 = int.Parse(Console.ReadLine());



int mediaFinal = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5 );

Console.WriteLine($"Sua média final é: {mediaFinal}");

