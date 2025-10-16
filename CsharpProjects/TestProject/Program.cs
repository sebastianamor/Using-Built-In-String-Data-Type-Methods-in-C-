//string message = "hello there!";
//int first_h = message.IndexOf('h');
//int last_h = message.LastIndexOf('h');
//Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//int openingPosition = message.LastIndexOf('(');
//openingPosition += 1;
//int closingPosition = message.LastIndexOf(')');
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

// resulatado set of parentheses


//string message = "(What if) there are (more than) one (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;
//    openingPosition += 1;
//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
//    message = message.Substring(closingPosition + 1);
//}

//resultado What if
//more than
//set of parentheses



//string message = "Hello, world!";
//char[] charsToFind = { 'a', 'e', 'i' };

//int index = message.IndexOfAny(charsToFind);

//Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

//Found 'e' in 'Hello, world!' at index: 1.

//string message = "Help (find) the {opening symbols}";
//Console.WriteLine($"Searching THIS Message: {message}");
//char[] openSymbols = { '[', '{', '(' };
//int startPosition = 5;
//int openingPosition = message.IndexOfAny(openSymbols);
//Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

//openingPosition = message.IndexOfAny(openSymbols, startPosition);
//Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");


//resulatado =   Found WITHOUT using startPosition: (find) the {opening symbols}
//resulatado =  Found WITH using startPosition 5:  (find) the {opening symbols}

//string data = "12345John Smith          5000  3  ";
//string updatedData = data.Remove(5, 20);
//Console.WriteLine(updatedData);

//resulatado  123455000  3

//string message = "This--is--ex-amp-le--da-ta";
//message = message.Replace("--", " ");
//message = message.Replace("-", "");
//Console.WriteLine(message);

//resultado This is example data

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

//string quantity = "";
//string output = "";

// Your work here

string quantity = input.Remove(0, 35);
//string quantity = input.Remove(40, 55);
//message = message.Replace("-", "");

Console.WriteLine(  $"Quantity:  {quantity}");
//Console.WriteLine(output); tenfo que practicar mas 

//Quantity: 5000
//Output: <h2>Widgets &reg;</h2><span>5000</span>