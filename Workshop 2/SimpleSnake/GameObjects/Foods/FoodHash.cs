﻿namespace SimpleSnake.GameObjects.Foods;

public class FoodHash : Food
{
    private const char symbol = '#';
    private const int points = 3;
    public FoodHash() : base(symbol, points)
    {
    }
}

