using System;

public class SQLCommand
{
    private string commandText;
    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }

    public SQLCommand()
    {
        commandText = "";
    }
    public SQLCommand(string commandText)
    {
        this.commandText = commandText.ToUpper();
    }

    public void Execute()
    {
        Console.WriteLine($" SQL command: {commandText}");
    }
}