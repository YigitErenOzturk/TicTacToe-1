string slot1 = " - ";  
string slot2 = " - ";
string slot3 = " - ";
string slot4 = " - ";
string slot5 = " - ";
string slot6 = " - ";
string slot7 = " - ";
string slot8 = " - ";
string slot9 = " - ";
string gamer;
string select = " X ";
string name1, name2;
int gamernumber = 0;
int selectnumber = 0;



Console.WriteLine("Welcome The TicTacToe Game");
Console.WriteLine("");
Console.WriteLine("Write Player 1's Name");
name1 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Write Player 2's Name");
name2 = Console.ReadLine();
Console.Clear();
Console.WriteLine("Player 1 (X) : " + name1 + " | Player 2 (O) : " + name2);
Console.WriteLine("");
Console.WriteLine("Game İs Starting");
Console.WriteLine("");
Console.WriteLine("Choose A Number From 1 To 9");


for (int i = 0; i < 9; i++)

{
Console.WriteLine("---------------------------");
Console.WriteLine($"|   {slot1}  |  {slot2}  |  {slot3}   |");
Console.WriteLine("|--------|-------|--------|");
Console.WriteLine($"|   {slot4}  |  {slot5}  |  {slot6}   |");
Console.WriteLine("|--------|-------|--------|");
Console.WriteLine($"|   {slot7}  |  {slot8}  |  {slot9}   |");
Console.WriteLine("---------------------------");
    


    if (i % 2 == 0) select = " X ";

    else select = " O ";

    while (selectnumber < 9)

    {
        Console.WriteLine($"{select}'s move > ");

        gamer = Console.ReadLine();

        if (!int.TryParse(gamer , out gamernumber)) continue;
        

        if (gamernumber == 1)

        {
        if (slot1 != " - ")
        {

        Console.WriteLine("İllegal Move");
            

                continue;

        }
            slot1 = select;
        }

        else if (gamernumber == 2)

        {
        if (slot2 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot2 = select;
        }

        else if (gamernumber == 3)

        {
        if (slot3 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;
        }
            slot3 = select;
        }

        else if (gamernumber == 4)

        {
        if (slot4 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot4 = select;
        }

        else if (gamernumber == 5)

        {
        if (slot5 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot5 = select;
        }

        else if (gamernumber == 6)

        {
        if (slot6 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot6 = select;
        }

        else if (gamernumber == 7)

        {
        if (slot7 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot7 = select;
        }

        else if (gamernumber == 8)

        {
        if (slot8 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot8 = select;
        }

        else if (gamernumber == 9)

        {
        if (slot9 != " - ")
        {

        Console.WriteLine("İllegal Move");

        continue;

        }
            slot9 = select;
        }

        else

        {
            Console.WriteLine("İllegal Move");
        }
        gamernumber++;

        break;
    }


        }

        Console.WriteLine("Game Over");