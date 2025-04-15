public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(int target, int bonus, string name, string description, int point)
        : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"✔ Goal \"{_shortName}\" progress updated. Earned {_points} points.");

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"🎉 Goal \"{_shortName}\" completed! Bonus: {_bonus} points!");
        }
    }

    public override bool IsCompleted() => _amountCompleted >= _target;

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        string status = IsCompleted() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }

    public int GetAmountCompleted() => _amountCompleted;
    public void SetAmountCompleted(int number) => _amountCompleted += number;
}
