// This sample demonstrates the use of the WindowsIdentity class to impersonate a user.
// IMPORTANT NOTES:
// This sample can be run only on Windows XP.  The default Windows 2000 security policy
// prevents this sample from executing properly, and changing the policy to allow
// proper execution presents a security risk.
// This sample requests the user to enter a password on the console screen.
// Because the console window does not support methods allowing the password to be masked,
// it will be visible to anyone viewing the screen.
// The sample is intended to be executed in a .NET Framework 1.1 environment.  To execute
// this code in a 1.0 environment you will need to use a duplicate token in the call to the
// WindowsIdentity constructor. See KB article Q319615 for more information.

using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using System.Windows.Forms;

[assembly:SecurityPermissionAttribute(SecurityAction.RequestMinimum, UnmanagedCode=true)]
[assembly:PermissionSetAttribute(SecurityAction.RequestMinimum, Name = "FullTrust")]
public class ImpersonationDemo
{
    [DllImport("advapi32.dll", SetLastError=true, CharSet = CharSet.Unicode)]
    public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
        int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

    [DllImport("kernel32.dll", CharSet=System.Runtime.InteropServices.CharSet.Auto)]
    private unsafe static extern int FormatMessage(int dwFlags, ref IntPtr lpSource,
        int dwMessageId, int dwLanguageId, ref String lpBuffer, int nSize, IntPtr *Arguments);

    [DllImport("kernel32.dll", CharSet=CharSet.Auto)]
    public extern static bool CloseHandle(IntPtr handle);

    [DllImport("advapi32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    public extern static bool DuplicateToken(IntPtr ExistingTokenHandle,
        int SECURITY_IMPERSONATION_LEVEL, ref IntPtr DuplicateTokenHandle);

    // Test harness.
    // If you incorporate this code into a DLL, be sure to demand FullTrust.
    [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
    public static void Main(string[] args)
    {
        IntPtr tokenHandle = new IntPtr(0);
        IntPtr dupeTokenHandle = new IntPtr(0);
        try
        {
            string userName, domainName;
            // Get the user token for the specified user, domain, and password using the
            // unmanaged LogonUser method.
            // The local machine name can be used for the domain name to impersonate a user on this machine.
            Console.Write("Enter the name of the domain on which to log on: ");
            domainName = Console.ReadLine();

            Console.Write("Enter the login of a user on {0} that you wish to impersonate: ", domainName);
            userName = Console.ReadLine();

            Console.Write("Enter the password for {0}: ", userName);

            const int LOGON32_PROVIDER_DEFAULT = 0;
            //This parameter causes LogonUser to create a primary token.
            const int LOGON32_LOGON_INTERACTIVE = 2;

            tokenHandle = IntPtr.Zero;

            // Call LogonUser to obtain a handle to an access token.
            bool returnValue = LogonUser(userName, domainName, Console.ReadLine(),
                LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                ref tokenHandle);

            Console.WriteLine("LogonUser called.");

            if (false == returnValue)
            {
                int ret = Marshal.GetLastWin32Error();
                Console.WriteLine("LogonUser failed with error code : {0}", ret);
                throw new System.ComponentModel.Win32Exception(ret);
            }

            Console.WriteLine("Did LogonUser Succeed? " + (returnValue? "Yes" : "No"));
            Console.WriteLine("Value of Windows NT token: " + tokenHandle);

            // Check the identity.
            Console.WriteLine("Before impersonation: "
                + WindowsIdentity.GetCurrent().Name);
            // Use the token handle returned by LogonUser.
            WindowsIdentity newId = new WindowsIdentity(tokenHandle);
            WindowsImpersonationContext impersonatedUser = newId.Impersonate();

            // Check the identity.
            Console.WriteLine("After impersonation: "
                + WindowsIdentity.GetCurrent().Name);

            // Stop impersonating the user.
            impersonatedUser.Undo();

            // Check the identity.
            Console.WriteLine("After Undo: " + WindowsIdentity.GetCurrent().Name);

            // Free the tokens.
            if (tokenHandle != IntPtr.Zero)
                CloseHandle(tokenHandle);

        }
        catch(Exception ex)
        {
            Console.WriteLine("Exception occurred. " + ex.Message);
        }

    }
}