//-----------------------------------------------------------------------------
// <copyright file="CwdCommandHandler.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team.  See LICENSE.txt.  This file is 
//   subject to the Microsoft Public License.  All other rights reserved.
// </copyright>
// <summary>//   
//   Created: 2004 By David McClarnon (dmcclarnon@ntlworld.com)
//   Modified: June 16, 2010 by Fastalanasa.
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Ftp.FtpCommands
{
    using System.IO;
    using WheelMUD.Ftp.General;

    public class CwdCommandHandler : FtpCommandHandler
	{
		public CwdCommandHandler(FtpConnectionObject connectionObject)
			: base("CWD", connectionObject)
		{}

		protected override string OnProcess(string sMessage)
		{
			sMessage = sMessage.Replace('/', '\\');

			if (!FileNameHelpers.IsValid(sMessage))
			{
                return this.GetMessage(550, "Not a valid directory string.");
			}

            string sDirectory = this.GetPath(sMessage);

            if (!this.ConnectionObject.FileSystemObject.DirectoryExists(sDirectory))
			{
                return this.GetMessage(550, "Not a valid directory.");
			}

            this.ConnectionObject.CurrentDirectory = Path.Combine(this.ConnectionObject.CurrentDirectory, sMessage);
            return this.GetMessage(250, string.Format("CWD Successful ({0})", this.ConnectionObject.CurrentDirectory.Replace("\\", "/")));
		}
	}
}
