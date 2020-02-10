﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Grid
{
    private Base[,] _grid;

    public int Width { get; set; }
    public int Height { get; set; }
    public List<(int, int)> Corners { get; set; }

    public Grid(int width, int height)
    {
        Width = width;
        Height = height;

        Corners = new List<(int, int)>{
            (0, 0),
            (0, Height - 1),
            (Width - 1, 0),
            (Width - 1, Height - 1)
        };

        _grid = new Base[Width, Height];
    }

    public Base this[int i, int j] 
    {
        get 
        {
            return _grid[i, j];
        }

        set 
        {
            _grid[i, j] = value;
        }
    }

    public Base this[(int i, int j) position] 
    {
        get
        {
            return _grid[position.i, position.j];
        }

        set 
        {
            _grid[position.i, position.j] = value;
        }
    }
}
