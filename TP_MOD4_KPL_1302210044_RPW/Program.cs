internal class Program
{
    enum kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

   
    private static int kodepos(kelurahan K)
    {
        int[] L =
        {
            40266,
            40287,
            40267,
            40256,
            40287,
            40286,
            40286,
            40286,
            40272,
            40274,
            40273



        };
        return L[(int)K];

    }