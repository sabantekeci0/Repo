using ExampleProject.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace ExampleProject
{
    public class SourceFile
    {
        
    }
    public class JobResponse
{
    public List<Job> Value { get; set; }
}

public class Job
{
    public string Key { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string State { get; set; }
    public string ReleaseName { get; set; }
}
}