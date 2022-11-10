# 👓🤷‍♀️🚗Best 15 Coding Practices with illlustration and XML Comments❤💕

## 1. Field OR variable naming👌

**All your field and vairables should be named according to the value it stores** 
***Example***:
```C#
string u = Console.ReadLine();
```
This code above is a bad practice because the field name those not convey the information stored in the field.
**Check This example Bellow**
```C#
string user = Console.ReadLine();
```
This particular example above convey the actual information stored in this field... 
**It always advisable to name your field and variables accordingly, this helps in code maintenance and readability.**

## 2. Class Naming 👓👓👓🕶

**Naming classes depending on what operation it perform or values it stores is a best coding practice as it gives other developers clear knowledge of what you are doing. It does promote code maintenance and readability.**

```C#
///<summary>
/// This code below gives clear illustration on how you can name classes appropriately.
///</summary>
///<returns>
///This code has a function that takes in two augments person birthday and the current date. 
///</returns>

public static class CalculateAge
///<summary>
///Here the class is named based on which operation it performs
///</summary>
{
    ///<summary>
    ///Here the function is also named based on what action it performs
    ///</summary>
    public int CalculateAge(DateTime birthDate, DateTime TodaysDate)
{
    int age = TodaysDate.Year - birthDate.Year;

    if (TodaysDate.Month < birthDate.Month 
    || 
    (TodaysDate.Month == birthDate.Month 
    && 
    TodaysDate.Day < birthDate.Day))
        age--;

    return age;
}
}
///<summary>
///All the variables in the code is named accordingly on what value it holds. This gives a clear understanding of your code.
</summary>
```
**BELOW IS THE BAD PRACTICE OF THE ABOVE COD😃😃
```c#
///<summary>
/// This cod below gives clear illustration on how you can name classes appropriately.
///</summary>
///<returns>
///This code has a function that takes in two augments person birthday and the current date. 
///</returns>

public static class ClcA
///<summary>
///Here the class is named ClcA which does not convey any meaningful information about what the classs does. This create ambiguity.
///</summary>
{
    ///<summary>
    ///Here the function is named in a way that cause confusion. User will spent time trying to understand simple logic it at all he/she would.
    ///</summary>
    public int CA(DateTime hbd, DateTime T)
{
    int a = T.Year - hbd.Year;

    if (T.Month < hbd.Month 
    || 
    (T.Month == hbd.Month 
    && 
    T.Day < hbd.Day))
        a--;

    return a;
}
}
///<summary>
///All the variables in the code is not named according to what value it holds.
///</summary>
```

## 3. Use Pascal Conversion For Defining Class
[.] **Good Practice**
```C#
public class HelloWorld
{
}
///<summary>
/// DO use PascalCasing for all public member, type, and namespace names consisting of multiple words. pascal convention makes your naming understandable as each new word that follows the naming is converted to capital letter
///</summary>
```

[] **Bad Practice**

```C#
public class helloworld
{

}
///<summary>
///DO use camelCasing for parameter names.
///</summary>
```

## 4. 👏👏While comparing string, convert string variables into Upper or Lower case.👏👏

```C#
///<summary>
///The code below checks if firstname == "yogesh"
///To do this you are surposed to convert users firstname to lower case or upper case to avoid error in comparison. This is because users may enter different cases in a word.
///<summary>
Good: if (firstName.ToLower() == "yogesh") {} 
 //OR 
Good: if (firstName.ToUpper() == “YOGESH”) {}  
///<summary>
///Aviod comparing users input with strings without first converting the string to thesame case
///</summary>
Bad: if (firstName == “rohit”) {}  
```

## 5. Use 💖💖👍String.Empty👍💖💖 instead of 👏

“”👏
```C#
Good: if (firstName == String.Empty) {}  
Bad: if (firstName == “”) {}  
///<summary>
///There are two reasons, one for readability, and two for a minor performance boost.

///Readability is easy: it's a lot quicker to spot string.Empty than "". Searching for string.Empty is also generally going to be easier and maybe more accurate than looking for the literal. It also clarifies intent: you didn't just make a typo or forget to finish something, you really did want empty string.

///The performance reason is due to interning. You see, the runtime keeps a table of previously used strings so that it can quickly do string comparisons without actually doing a character-by-character check. string.Empty is already an interned reference to "" where-as typing the literal may not give you the interned version, thus causing a slight performance hit.
///</summary>
```

## 6. 🔥🔥Use enums wherever required. 🔥🔥Don’t use numbers or strings to indicate discrete values👏

```C#
Good: public enum LoggerType {  
    Event,  
    File,  
    Database  
}  
public void LogException(string message, LoggerType loggerType) {  
    ///<summary>
    ///Here the enum where used in the cases instead of normal string;
    ///</summary>
    switch (loggerType) {  
        case LoggerType.Event:  
        Console.WriteLine(LoggerType.Event);
        break;  
        case LoggerType.File:
          Console.WriteLine(LoggerType.File);
          break;
        case LoggerType.Database:  
    Console.WriteLine(LoggerType.Database);
    break;
 
        default:  
        Console.WriteLine(message);
        break;
    }  
}  

Bad: public void LogException(string message, LoggerType loggerType) {  

    ///<summary>
    ///Here all the cases are string while instead of using the enum as the cases.
    ///<summary>
    switch (loggerType) {  
        case "Event":  
         Console.WriteLine("Event");
    break; 
        case "File":  
         Console.WriteLine("File");
    break;
        case "Database":  
           Console.WriteLine("Database");
    break;
        default:  
           Console.WriteLine(message);
           break; 
    }  
}  
```