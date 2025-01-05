using static System.Console;
WriteLine("Scrivi un numero : ");
string number1=ReadLine();

WriteLine(number1);

bool input = int.TryParse(number1,out int firstNumber);

WriteLine(input);
WriteLine("Scrivi un numero : ");
string number2=ReadLine();

WriteLine(number2);
// tryParse e una propietà che prova a parsificare un valore in un altro restituendo un valore booleano
// out indica un parametro  che viene definito è assegnata al interno del metodo
bool input2 = int.TryParse(number2,out int secondNumber);

WriteLine(input2);

if(input && input2){
    int result = firstNumber + secondNumber;
    WriteLine(result);
}else if (input)
{
    WriteLine($"il valore {number2} non può essere trasformato in intero");
}else if (input2)
{
    WriteLine($"il valore {number1} non può essere trasformato in intero");
}else
{
    WriteLine($"i valori {number1} {number2} non possono essere convertiti in int");
}