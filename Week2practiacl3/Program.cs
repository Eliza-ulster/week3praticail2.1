Main();

static void Main()
{
    Console.WriteLine("Enter a string:");
    string str = Console.ReadLine();

    Console.WriteLine("Enter no of rotation:");
    int noOfrotation = Convert.ToInt32(Console.ReadLine());
    

    string encrypt = (Encrypt(str, noOfrotation));
    Console.WriteLine($"The sentence you inputted is :, {str}");
    Console.WriteLine($"the encrypted sentence is now :, {encrypt}");

   
    
}
static string Encrypt(string ToEncrpy, int Rotation)
{
    string encodedText = " ";
    foreach(char c in ToEncrpy)
    {
        int encodedChar = c + Rotation;
        
        encodedText += (char)encodedChar;

    }

    return encodedText;

}