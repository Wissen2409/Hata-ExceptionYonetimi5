
Console.WriteLine("Bir değer giriniz");
try
{
    int value = Cevir(Console.ReadLine());
    int result = value / 0;
}
catch (Exception ex)
{


}


static int Cevir(string deger)
{

    int value = 0;
    try
    {
        value = int.Parse(deger);
    }
    catch (Exception ex)
    {
        //throw ex;
        throw new UnauthorizedAccessException(ex.Message);
    }

    return value;

}