
using System;
using System.Diagnostics;

const string VHDX_FILE = @"D:\VHD_Mount\应用数据.vhdx";

Process p = new();
p.StartInfo.FileName = "diskpart";
p.StartInfo.CreateNoWindow = true;
p.StartInfo.UseShellExecute = false;
p.StartInfo.RedirectStandardOutput = true;
p.StartInfo.RedirectStandardInput = true;
p.Start();

p.StandardInput.WriteLine($"select vdisk file=\"{VHDX_FILE}\"");
p.StandardInput.WriteLine("attach vdisk");
p.StandardInput.WriteLine("exit");
p.WaitForExit();
