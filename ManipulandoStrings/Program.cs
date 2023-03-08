string nome;
nome = Console.ReadLine();

Console.WriteLine("Olá "+nome);

Console.WriteLine(nome[2]);

RemoverVogais(nome);

Console.WriteLine(nome);
void RemoverVogais(string x)
{
	//for (int i = 0; i < x.Length; i++)
	//{
		x = x.Replace('a','\0');
        x = x.Replace('e', '\0');
        x = x.Replace('i', '\0');
        x = x.Replace('o', '\0');
        x = x.Replace('u', '\0');
	    Console.WriteLine(x);

        //if ((x[i] == 'a') || (x[i] == 'e') || x[i] == 'i' ||
        //	x[i] == 'o' || x[i] == 'u')
        //{
        //	x.Remove(i);
        //}
    //}
}

Console.ReadLine();