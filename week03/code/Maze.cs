using System;
using System.Collections.Generic;

public class Maze {
    private readonly Dictionary<(int, int), bool[]> _mazeMap;
    
    // Initial (x, y) movement values inside the Maze 
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<(int, int), bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    public void MoveLeft() {
        if (_mazeMap[(_currX, _currY)][0]) {
            _currX--;
            Console.WriteLine($"MoveLeft: Current location (x={_currX}, y={_currY})");
        } else {
            Console.WriteLine($"MoveLeft: Can't go that way! (x={_currX}, y={_currY})");
        }
    }

    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    public void MoveRight() {
        if (_mazeMap[(_currX, _currY)][1]) {
            _currX++;
            Console.WriteLine($"MoveRight: Current location (x={_currX}, y={_currY})");
        } else {
            Console.WriteLine($"MoveRight: Can't go that way! (x={_currX}, y={_currY})");
        }
    }

    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    public void MoveUp() {
        if (_mazeMap[(_currX, _currY)][2]) {
            _currY--;
            Console.WriteLine($"MoveUp: Current location (x={_currX}, y={_currY})");
        } else {
            Console.WriteLine($"MoveUp: Can't go that way! (x={_currX}, y={_currY})");
        }
    }

    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    public void MoveDown() {
        if (_mazeMap[(_currX, _currY)][3]) {
            _currY++;
            Console.WriteLine($"MoveDown: Current location (x={_currX}, y={_currY})");
        } else {
            Console.WriteLine($"MoveDown: Can't go that way! (x={_currX}, y={_currY})");
        }
    }

    /// Show the current (x, y) values
    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}