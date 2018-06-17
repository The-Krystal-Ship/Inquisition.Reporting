﻿using System;

namespace Inquisition.Reporting.Models
{
    public interface IReport
    {
        Guid Guid { get; set; }
        string ErrorMessage { get; set; }
        string StackTrace { get; set; }
        string Path { get; set; }
    }
}
