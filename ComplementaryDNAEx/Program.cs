using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(MakeComplement("ATTGC"));
    }
    public static string MakeComplement(string dna)
    {
        if (string.IsNullOrWhiteSpace(dna)) return "";

        dna =  dna.ToUpper();

        var sb = new StringBuilder();

        foreach (var c in dna)
        {
            sb.Append(SwitchChar(c));
        } 

        return sb.ToString();
    }

    private static string SwitchChar(char c)
    {
        return c switch
        {
            'A' => "T",
            'T' => "A",
            'G' => "C",
            'C' => "G",
            _ => throw new NotImplementedException(),
        };
    }
}