using System;

public class NegativeGoal : Goal
{
    private string _type = "Losing Bananas:";
    private bool _status;
    public NegativeGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public NegativeGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"That sukcs! You have Lost {GetPoints()} bananas.");
    }
}