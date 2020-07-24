using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    static Robot()
    {
        for (char firstLetter = 'A'; firstLetter <= 'Z'; firstLetter++)
        {
            for (char secondLetter = 'A'; secondLetter <= 'Z'; secondLetter++)
            {        
                for (int digit = 100; digit < 1000; digit++)
                {
                    _names.Add(firstLetter.ToString() + secondLetter.ToString() + digit.ToString());               
                }
            }
        }       
    }
    public Robot()
    {
        SetName();
    }
    public string Name
    {
        get
        {
            return _name;
        }
    }

    public void Reset()
    {
        SetName();
    }

    private string _name; 
    private static IList<string> _names = new List<string>();
    private static Random rnd = new Random();

    private void SetName()
    {
        int index = rnd.Next(0,_names.Count);
        if (_name != null)
        {
            _names.Add(_name);
        }
        _name = _names[index];
        _names.RemoveAt(index);
    }
}