﻿using System.Collections.Generic;

public class Faculty : BasicEntity
{
    public Faculty()
    {
        Chairs = new List<Chair>();
    }

    public string Name { get; set; }

    public virtual List<Chair> Chairs { get; set; }
}