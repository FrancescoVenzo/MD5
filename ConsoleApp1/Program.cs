using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

List<string> parole = new List<string>();

string obiettivo = "5d41402abc4b2a76b9719d911017c592";

string risultato = "";
char c0 = 'a';
char c1 = 'a';
char c2 = 'a';
char c3 = 'a';
char c4 = 'a';

string MD5;

funzione();

void funzione()
{
    for (int i = 0; i < 26; i++)
    {
        for (int j = 0; j < 26; j++)
        {
            for (int k = 0; k < 26; k++)
            {
                for (int o = 0; o < 26; o++)
                {
                    for (int p = 0; p < 26; p++)
                    {
                        risultato = "" + c0 + c1 + c2 + c3 + c4;
                        parole.Add(risultato);
                        MD5 = CreateMD5(risultato);
                        if (MD5 == obiettivo)
                        {
                            Console.WriteLine($"{obiettivo} corrisponde a {risultato}");
                            return;
                        }
                        c4 = (char)(c4 + 1);
                    }
                    c3 = (char)(c3 + 1);
                    c4 = 'a';
                }
                c2 = (char)(c2 + 1);
                c3 = 'a';
            }
            c1 = (char)(c1 + 1);
            c2 = 'a';
        }
        c0 = (char)(c0 + 1);
        c1 = 'a';
    }
}



string CreateMD5(string input)
{
    byte[] encodedPassword = new UTF8Encoding().GetBytes(input);

    // need MD5 to calculate the hash
    byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

    // string representation (similar to UNIX format)
    string encoded = BitConverter.ToString(hash);
    encoded = encoded.ToLower().Replace("-", string.Empty);
    return encoded;
}