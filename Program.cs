using CIRCLE_OBJECTS;
Circle myCircle = new Circle(1);
Console.WriteLine("Welcome to the Circle Tester");

//Gets the users radius 
while (true)
{
    Console.Write("\nEnter radius: ");
    try
    {
        myCircle.Radius = double.Parse(Console.ReadLine().Trim());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n"+ex);
        Console.WriteLine("\nPlesetry agan");
    }
}
Console.WriteLine();

//Displays the circles information 
bool run = true;
while (run)
{
    Console.WriteLine("{0,10}| {1,10}| {2,15}| {3,15}|", "Radius", "Diameter", "Circumference", "Area");
    Console.WriteLine("{0,10:n}| {1,10:n}| {2,15:n}| {3,15:n}|",
        myCircle.GetRadius(), myCircle.CalculateDiameter(), myCircle.CalculateCircumference(), myCircle.CalculateArea());


    //Gatekeeper 
    //Asks the user if he or she wishes to end the program or it will double the size the
    //radius then print the radius, diameter, circumference, and area.
    while (true)
    {
        Console.Write("\nShould the circle grow? (y/n): ");
        string entry = Console.ReadLine();
        if (entry == "y" || entry == "n")
        {
            if (entry == "y")
            {
                myCircle.Grow();
                break;
            }
            else
            {
                run = false;
                break;
            }
        }
        else
        {
            Console.WriteLine("Invalid response ");
        }
    }
}
Console.Clear();
Console.WriteLine("{0,10}| ", "Radius");
Console.WriteLine("{0,10:n}| ", myCircle.GetRadius());
Console.WriteLine("\n\n\nHave a nice day!!\n\n\n");
