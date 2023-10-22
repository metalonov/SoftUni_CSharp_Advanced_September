int n = int.Parse(Console.ReadLine());

long[][] pascal = new long[n][];

pascal[0] = new long[1] {1}; //slaga 1 na nuleviq red

    for (int row = 1; row < n; row++)
    {
        pascal[row] = new long[row + 1]; //dobavq red/arr udaljen s 1

        for (int col = 0; col < pascal[row].Length; col++)
        {
            if (col < pascal[row-1].Length) //proverqva dali ima index nad tekushtata poziciq ot dqsno
            {
                pascal[row][col] += pascal[row-1][col]; //smqta indexa ot gore

            }
            if (col > 0)//proverqva dali ima index nad tekushtata poziciq ot lqvo
            {
            pascal[row][col] += pascal[row - 1][col - 1]; //smqta indexa gore v lqvo
            }
        }
    }
    for (int row = 0; row < pascal.Length; row++)
    {
        for (int col = 0; col < pascal[row].Length; col++)
        {
            Console.Write($"{pascal[row][col]} ");

        }
        Console.WriteLine();
    }
