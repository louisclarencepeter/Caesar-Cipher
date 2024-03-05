using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.WriteLine("Write your secret message: ");
      string secretMessage = Console.ReadLine();

      char[] message = secretMessage.ToCharArray();

      char[] encryptedMessage = new char[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char character = message[i];
    int index = Array.IndexOf(alphabet, character);
    int newIndex = (index + 3) % alphabet.Length;
    encryptedMessage[i] = alphabet[newIndex];

    


}
string encryptedResult = new string(encryptedMessage);
Console.WriteLine($"Encrypted Message: {encryptedResult}");

 
    }
  }
}