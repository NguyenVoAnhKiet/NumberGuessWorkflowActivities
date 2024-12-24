using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;
using NumberGuessWorkflowActivities;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumberGuessWorkflowHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Activity _wf = new SequentialNumberGuessWorkflow();
            //AutoResetEvent syncEvent = new AutoResetEvent(false);
            //AutoResetEvent idleEvent = new AutoResetEvent(false);

            //var inputs = new Dictionary<string, object>() { { "MaxNumber", 100 } };

            //WorkflowApplication wfApp = new WorkflowApplication(_wf, inputs)
            //{

            //    Completed = delegate (WorkflowApplicationCompletedEventArgs e)
            //    {
            //        int Turns = Convert.ToInt32(e.Outputs["Turns"]);
            //        Console.WriteLine("Congratulations, you guessed the number in {0} turns.", Turns);

            //        syncEvent.Set();
            //    },

            //    Aborted = delegate (WorkflowApplicationAbortedEventArgs e)
            //    {
            //        Console.WriteLine(e.Reason);
            //        syncEvent.Set();
            //    },

            //    OnUnhandledException = delegate (WorkflowApplicationUnhandledExceptionEventArgs e)
            //    {
            //        Console.WriteLine(e.UnhandledException.ToString());
            //        return UnhandledExceptionAction.Terminate;
            //    },

            //    Idle = delegate (WorkflowApplicationIdleEventArgs e)
            //    {
            //        idleEvent.Set();
            //    }
            //};

            //wfApp.Run();

            //// Loop until the workflow completes.
            //WaitHandle[] handles = new WaitHandle[] { syncEvent, idleEvent };
            //while (WaitHandle.WaitAny(handles) != 0)
            //{
            //    // Gather the user input and resume the bookmark.
            //    bool validEntry = false;
            //    while (!validEntry)
            //    {
            //        if (!Int32.TryParse(Console.ReadLine(), out int Guess))
            //        {
            //            Console.WriteLine("Please enter an integer.");
            //        }
            //        else
            //        {
            //            validEntry = true;
            //            wfApp.ResumeBookmark("EnterGuess", Guess);
            //        }
            //    }
            //}

            Application.EnableVisualStyles();
            Application.Run(new WorkflowHostForm());
        }
    }
}
