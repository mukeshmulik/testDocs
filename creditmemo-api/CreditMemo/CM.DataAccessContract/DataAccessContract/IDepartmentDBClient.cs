﻿using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface IDepartmentDBClient
    {
        string GetAllDepartments();
    }
}
