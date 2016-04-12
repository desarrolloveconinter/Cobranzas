﻿using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Web;

namespace Cobranzas.Codigo
{
    public class Seguridad
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
            int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public extern static bool CloseHandle(IntPtr handle);
        public delegate void Funcion();
        public static void Ejecutar(Funcion a)
        {
            SafeTokenHandle safeTokenHandle;
            try
            {
                const int LOGON32_PROVIDER_DEFAULT = 0;
                //This parameter causes LogonUser to create a primary token.
                const int LOGON32_LOGON_INTERACTIVE = 2;

                // Call LogonUser to obtain a handle to an access token.
                //                bool returnValue = LogonUser("mberroteran", "bremat", "mb123456**",
                //bool returnValue = LogonUser("Administrador", "BREMAT", "$$ABC++@dm1n", LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,  out safeTokenHandle);
                bool returnValue = LogonUser("admincobranza", "bremat", "@dm1n1$tr@d0r", LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out safeTokenHandle);
                //bool returnValue = LogonUser("administrador", "BREMAT", "&&admin%%ABC", LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out safeTokenHandle);



                using (safeTokenHandle)
                {
                    WindowsIdentity newId = new WindowsIdentity(safeTokenHandle.DangerousGetHandle());
                    using (WindowsImpersonationContext impersonatedUser = newId.Impersonate())
                    {
                        a.DynamicInvoke();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private SafeTokenHandle()
            : base(true)
        {
        }

        [DllImport("kernel32.dll")]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr handle);

        protected override bool ReleaseHandle()
        {
            return CloseHandle(handle);
        }
    }
}