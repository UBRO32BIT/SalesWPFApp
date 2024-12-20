﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Entities;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Member> Members { get; } = new List<Member>();
}
