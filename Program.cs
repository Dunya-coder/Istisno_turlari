internal class Program
{
    private static void Main(string[] args)
    {
      //finally-bloki,agar istisno qilingan bo'lsa yoki u istisno q-magan b-sa ham ba'zi maxsus dastur kodidi bajarishga imkon beradi
      try
      {
int x=5,y=0;
int s=x/y;
System.Console.WriteLine(s);
      }
      catch(DivideByZeroException)
      {
System.Console.WriteLine("No'lga bo'lish sodir bo'ldi");
      }
      //istisnolarni filtrlash
      //catch when(shart)
      //{
//istisno faqat when bandidagi shart rost bo'lsagina ishlaydi,Masalan y=0 u-n
// DivideByZero-0ga bo'lingandagi ch-gan istisnoni ifodalaydi
//TargatSite-istisno qilingan usulni qaytaradi
//StackTrace-istisno yuzaga kelishiga sabab b-gan chaqiruvlar stekning satrli tasvirini qaytaradi
//ArgumantOutOfRangeException-agar argument qiymati joriy qiymatlar doirasidan tashqarida b-sa ushlanadi 
      //
      //}
      catch(IndexOutOfRangeException ex)
      {
        System.Console.WriteLine(ex.Message);
      }
      catch(FormatException)
      {
        System.Console.WriteLine("Kiritilgan qiymat boshqa formatda");
      }
      //Misol 2 .B-gan double q-li son-x y=1/(x+4)^1/2 dastur x-o'zg-ni ixtiyoriy q-tida ham natija bersin
      double x,y;
      try{
        System.Console.Write("x=");
        x=Convert.ToDouble(Console.ReadLine());
        if(x+4==0)
        {
            throw new DivideByZeroException();
        }
        else if(x+4<0)
        {
            throw new InvalidCastException();
        }
        else{
            y=1/Math.Sqrt(x+4);
        }
        System.Console.WriteLine("y({0})={1}",x,y);
      }
      catch(Exception ex)
      {
        System.Console.WriteLine("Xatolik sodir bo'ldi!turi,"+ex.Message);
      }
}