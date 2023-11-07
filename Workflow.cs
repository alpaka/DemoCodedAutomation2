using System;
using System.Collections.Generic;
using System.Data;
using CodedAutomation2.ObjectRepository;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace CodedAutomation2
{
    // Code Generation:
    // add two numbers and log the result to console
    public class Workflow : CodedWorkflow
    {
        [Workflow]
        public int Execute(int n)
        {
            if (n <= 1)
                return n;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}