
using System.Net.Http.Headers;

Console.WriteLine("Bir değer giriniz");
try
{
    int value = Cevir(Console.ReadLine());
    int result = value / 0;
}
catch(DivideByZeroException ex){

// dıştaki try catch'i yakalar
}
catch(UnauthorizedAccessException ex){

    // içteki try catch 'i yakalar
}
catch (Exception ex)
{

    // yukarıdakilerin yakalayamadığı bir hata olursa, bu blok yakalayacaktır

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