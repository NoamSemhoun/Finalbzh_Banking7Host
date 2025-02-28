﻿using System;
using System.Text;
using Intel.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using Finalbzh_Banking7Host;


namespace Finalbzh_Banking7Host
{
    class Program
    {
        [STAThread]

       
        static void Main(string[] args)
        {
            MainWindow myWinLog = new MainWindow();
            MessageBox.Show("Installing the applet...", "Step 1");
            MessageBox.Show("Opening a session...", "Step 2");

            myWinLog.MenuStack.Visibility = Visibility.Visible;

            myWinLog.ShowDialog();


           /* 
#if AMULET
            // When compiled for Amulet the Jhi.DisableDllValidation flag is set to true 
            // in order to load the JHI.dll without DLL verification.
            // This is done because the JHI.dll is not in the regular JHI installation folder, 
            // and therefore will not be found by the JhiSharp.dll.
            // After disabling the .dll validation, the JHI.dll will be loaded using the Windows search path
            // and not by the JhiSharp.dll (see http://msdn.microsoft.com/en-us/library/7d83bc18(v=vs.100).aspx for 
            // details on the search path that is used by Windows to locate a DLL) 
            // In this case the JHI.dll will be loaded from the $(OutDir) folder (bin\Amulet by default),
            // which is the directory where the executable module for the current process is located.
            // The JHI.dll was placed in the bin\Amulet folder during project build.
            Jhi.DisableDllValidation = true;
#endif

        Jhi jhi = Jhi.Instance;
        JhiSession session;

        // This is the UUID of this Trusted Application (TA).
        //The UUID is the same value as the applet.id field in the Intel(R) DAL Trusted Application manifest.
        string appletID = "880ac3de-131a-4edf-8be3-423baa9a0edf";
        // This is the path to the Intel Intel(R) DAL Trusted Application .dalp file that was created by the Intel(R) DAL Eclipse plug-in.
        string appletPath = "C:/Users/33768/eclipse-workspace\\Finalbzh_Banking7\\bin\\Finalbzh_Banking7.dalp";

        // Install the Trusted Application
        Console.WriteLine("Installing the applet.");
        jhi.Install(appletID, appletPath);

        //Start a session with the Trusted Application
        byte[] initBuffer = new byte[] { }; // Data to send to the applet onInit function
        Console.WriteLine("Opening a session.");
        jhi.CreateSession(appletID, JHI_SESSION_FLAGS.None, initBuffer, out session);

        // Send and Receive data to/from the Trusted Application
        byte[] sendBuff = UTF32Encoding.UTF8.GetBytes("Hello"); // A message to send to the TA
        byte[] recvBuff = new byte[2000]; // A buffer to hold the output data from zthe TA
        int responseCode; // The return value that the TA provides using the IntelApplet.setResponseCode method
        int cmdId = 1; // The ID of the command to be performed by the TA
        Console.WriteLine("Performing send and receive operation.");
        jhi.SendAndRecv2(session, cmdId, sendBuff, ref recvBuff, out responseCode);
        Console.Out.WriteLine("Response buffer is " + UTF32Encoding.UTF8.GetString(recvBuff));

        // Close the session
        Console.WriteLine("Closing the session.");
        jhi.CloseSession(session);

        //Uninstall the Trusted Application
        Console.WriteLine("Uninstalling the applet.");
        jhi.Uninstall(appletID);

        Console.WriteLine("Press Enter to finish.");
         Console.Read();  */
        }
    }
}