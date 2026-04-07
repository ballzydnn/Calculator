int a = 10, b = 6;

static int penjumlahan(int a,int b)
{
    return a + b;
}
static int pengurangan(int a,int b)
{
    return (a - b);
}
static int perkalian(int a, int b)
{
    return (a * b);
}
static int pembagian(int a,int b)
{
    return (a/b);
}

Console.WriteLine("Penjumlahan: "+ a +" + "+ b+ " = "+ penjumlahan(a,b));
Console.WriteLine("Pengurangan: "+ a + " - "+ b+ " = "+ pengurangan(a,b));
Console.WriteLine("Perkalian: "+ a + " * " + b+ " = "+ perkalian (a,b));
Console.WriteLine("Pembagian: "+ a + " / "+ b+ " = "+ pembagian(a,b));