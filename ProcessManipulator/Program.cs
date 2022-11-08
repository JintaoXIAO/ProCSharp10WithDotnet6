using System;
using System.Diagnostics;
using System.Linq;

Console.WriteLine("Fun with Processes");
//ListAllRunningProcesses();
//EnumThreadsForPid(98932);
EnumModsForPid(98932);

static void EnumModsForPid(int pID)
{
    Process theProcess = null;
    try
    {
        theProcess = Process.GetProcessById(pID);
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    Console.WriteLine("Here are the loaded modules for: {0}", theProcess.ProcessName);
    ProcessModuleCollection theMods = theProcess.Modules;

    foreach(ProcessModule pm in theMods)
    {
        string info = $"-> Mod Name: {pm.ModuleName}";
        Console.WriteLine(info);
    }
}

static void EnumThreadsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }

    Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
    ProcessThreadCollection theThreads = theProc.Threads;

    foreach(ProcessThread pt in theThreads)    
    {
        string info = 
            $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority: {pt.PriorityLevel}";
        Console.WriteLine(info);
    }
}

static void ListAllRunningProcesses()
{
    var runningProcs = 
        from proc
        in Process.GetProcesses(".")
        orderby proc.Id
        select proc;

    foreach(var p in runningProcs)        
    {
        string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
        Console.WriteLine(info);   
    }
}