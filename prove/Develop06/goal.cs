using System;
 

public abstract  class Goal
{
    public string _name;
    public string _description;
    public String _points;
    
    public bool _isComplete;
    public String getName()
    {
        return _name;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void setDescription(string description)
    {
        _description = description;
    }
    public string GetPoints()
    {
        return _points;
    }
    public void setPoints(string points)
    {
        _points = points;
    }
       public Goal()
    {
        
    }
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"[ ] {_name}: {_description}";
    }
    public abstract string GetStringRepresentation();
    

}