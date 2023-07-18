namespace DAL.Entities;

public class Pokemon
{
    public int id { get; set; }

    public string name { get; set; }

    public int height { get; set; }

    public int weight { get; set; }

    public int base_experience { get; set; }

    public Sprite sprites { get; set; }

    public List<MoveData> moves { get; set; }

    public List<AbilityData> abilities { get; set; }

    public List<StatData> stats { get; set; }
    
    public List<TypeData> types { get; set; }
}

public class MoveData
{
    public Move move { get; set; }
}

public class Move
{
    public string name { get; set; }
}

public class AbilityData
{
    public Ability ability { get; set; }
}

public class Ability
{
    public string name { get; set; }
}

public class StatData
{
    public int base_stat { get; set; }

    public Stat stat { get; set; }
}

public class Stat
{
    public string name { get; set; }
}

public class TypeData
{
    public Type type { get; set; }
}

public class Type
{
    public string name { get; set; }
}

public class Sprite
{
    public string front_default { get; set; }
}

public class Result
{
    public List<PokeResult> results { get; set; }
}

public class PokeResult
{
    public string name { get; set; }

    public string url { get; set; }
}