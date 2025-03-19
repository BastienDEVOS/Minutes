(int, int) ConvertMToHM(int nbMin)
{
    return (nbMin / 60, nbMin % 60); 
}

//Programe principal
(int H, int M) = ConvertMToHM(130);
Console.WriteLine($"{H}:{M}");