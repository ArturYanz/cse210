using System;


// Hi Im Arturo :D

//This are the extra functions of my program:
// - Used int.TryParse instead of int.Parse to prevent crashes when users enter invalid input.
//   If conversion fails, tthe program shows an error instead of stopping.
//
// - Checked File.Exists before loading files to avoid FileNotFoundException.
//
//- Restored full goal state when loading (including completion status and checklist progress)
// by passing saved values into constructors.
//
// - Modified checklist logic so the bonus is awarded only once when _amountCompleted == _target.
//
// - Added validation for goal selection to prevent out-of-range errors.

// Hope you like it!

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}