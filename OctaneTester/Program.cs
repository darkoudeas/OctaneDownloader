﻿using OctaneDownloadEngine;

namespace OctaneDownloadEngine
{
    internal static class Program
    {
        private static void Main()
        {
            const string url = "https://az764295.vo.msecnd.net/stable/d5e9aa0227e057a60c82568bf31c04730dc15dcd/VSCodeUserSetup-x64-1.47.0.exe";

            OctaneEngine.DownloadFile(url, 4).GetAwaiter().GetResult();
        }
    }
}