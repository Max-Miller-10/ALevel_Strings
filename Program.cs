using System.Diagnostics;
using System.Text;

static List<string> MexicanWave(string input)
{
    List<string> result = [];
    char[] chars = input.ToCharArray();

    for (int i = 0; i < input.Length; i++)
    {
        if (chars[i] == ' ') { continue; }
        chars[i] = char.ToUpper(chars[i]);
        result.Add(new string(chars));
        chars[i] = input[i];
    }
    return result;
}
Debug.Assert(MexicanWave("hello")[2] == "heLlo");
Debug.Assert(MexicanWave("hello")[3] == "helLo");





List<int> CharacterCodes(string input)
{
    List<int> result = [];

    foreach (char c in input)
    {
        result.Add((int)c);
    }
    return result;
}


List<byte> CharacterCodesAsBytes(string input)
{
    List<byte> result = [];
    foreach (char c in input)
    {
        result.Add((byte)c);
    }
    return result;
}

CharacterCodesAsBytes("Hello");


string StringFromCharCodes(List<int> input)
{
    StringBuilder sb = new();


    foreach (int code in input)
    {
        sb.Append((char)code);
    }

    return sb.ToString();
}


string StringFromByteArray(List<byte> input)
{
    StringBuilder sb = new();

    foreach (byte c in input)
    {
        sb.Append((char)c);
    }
    return sb.ToString();
}


int Anagram(string word, List<string> potentialAnagrams)
{
    int anagrams = 0;
    foreach (string potentialAnagram in potentialAnagrams)
    {
        if (String.Concat(potentialAnagram.OrderBy(c => c)).Equals(String.Concat(word.OrderBy(c => c)) )){
            anagrams++;
        }
    }
    return anagrams;
}
Debug.Assert(Anagram("star", ["rats", "arts", "arc"]) == 2);

string ToVariableName(string input, string style)
{
    List<string> words= [.. input.Split(' ').Select(w => char.ToUpper(w[0]) + w[1..].ToLower())]; // Weird VisualStudio code suggestion :/ 😭
    return style.ToLower() switch //Another weird visual studio intellisense thingy... 
    {
        "camel" => char.ToLower(words[0][0]) + string.Concat(words[0][1..], words.Skip(1)),
        "pascal" => string.Concat(words),
        "snake" => string.Join("_", words.Select(w => w.ToLower())),
        _ => throw new Exception("Not a style chief :("),
    };
    ;
}

Debug.Assert(ToVariableName("hello world test case thingy", "PaScAL") == "HelloWorldTestCaseThingy");


string PigLatin(string input)
{
    return string.Join(" ", input.Split(" ").Select(w => w[1..] + w[0] + "ay" ).ToList());
}

Debug.Assert(PigLatin("this should end up as pig latin") == "histay houldsay ndeay puay saay igpay atinlay");