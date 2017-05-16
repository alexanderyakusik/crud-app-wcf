﻿using System.Collections.Generic;

public class Discipline : BasicEntity
{
    public Discipline()
    {
        Teachers = new List<Teacher>();
    }

    public string Name { get; set; }

    public virtual List<Teacher> Teachers { get; set; }
}