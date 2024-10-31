/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;
ValidateLength();
ValidateZeroes();
ValidateRange();

if (ValidateLength && ValidateZeroes && ValidateRange)
{
    Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}

void ValidateLength() 
{
    string [] ip = ipv4Input.Split('.');
    if (ip.Length == 4)  validLength = true;
    else  validLength = false;
    return;
  
}

void ValidateRange() 
{
    string[] ip = ipv4Input.Split('.');
    foreach (string num in ip)
    {
        int numb = int.Parse(num);
            if ((numb < 0) || (numb >= 256))
        { validRange = true;
        return; } 
    }

    validRange = true;
}
void ValidateZeroes() 
{
    string[] ip = ipv4Input.Split('.');
    foreach (string num in ip)
        if (num.StartsWith("0")) {validZeroes = false; 
    return; }

}
