namespace Nupre_API.Utilidades
{

    // The following example demonstrates the use of the WindowsIdentity class to impersonate a user.   
    // IMPORTANT NOTE:   
    // This sample asks the user to enter a password on the console screen.   
    // The password will be visible on the screen, because the console window   
    // does not support masked input natively.  

    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Security.Principal;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Win32.SafeHandles;



    public class ImpersonationDemo
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
            int dwLogonType, int dwLogonProvider, out SafeAccessTokenHandle phToken);

        public async static Task<bool> SaveFile(IFormFile file, string filePath)
        {

            var result = false;
            string domainName = "SSRL";
            string userName = "web_user";
            string passWord = "wXhuIkub32oRvPDPv8Sg";



            const int LOGON32_PROVIDER_DEFAULT = 0;
            //This parameter causes LogonUser to create a primary token.   
            const int LOGON32_LOGON_INTERACTIVE = 2;

            // Call LogonUser to obtain a handle to an access token.   
            SafeAccessTokenHandle safeAccessTokenHandle;
            bool returnValue = LogonUser(userName, domainName, passWord,
                LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                out safeAccessTokenHandle);

            if (false == returnValue)
            {
                int ret = Marshal.GetLastWin32Error();
                throw new System.ComponentModel.Win32Exception(ret);
            }

#pragma warning disable CA1416 // Validar la compatibilidad de la plataforma
            WindowsIdentity.RunImpersonated(
                safeAccessTokenHandle,
                // User action  
                async () =>
                {
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }
                    result = true;
                }
                );
#pragma warning restore CA1416 // Validar la compatibilidad de la plataforma

            return result;
        }
        public static byte[] ReadFile(string filePath)
        {

            byte[] fi = null;

            string domainName = "SSRL";
            string userName = "web_user";
            string passWord = "wXhuIkub32oRvPDPv8Sg";



            const int LOGON32_PROVIDER_DEFAULT = 0;
            //This parameter causes LogonUser to create a primary token.   
            const int LOGON32_LOGON_INTERACTIVE = 2;

            // Call LogonUser to obtain a handle to an access token.   
            SafeAccessTokenHandle safeAccessTokenHandle;
            bool returnValue = LogonUser(userName, domainName, passWord,
                LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                out safeAccessTokenHandle);

            if (false == returnValue)
            {
                int ret = Marshal.GetLastWin32Error();
                throw new System.ComponentModel.Win32Exception(ret);
            }
            WindowsIdentity.RunImpersonated(safeAccessTokenHandle, async () =>
            {

                if (!File.Exists(filePath))
                {
                    //File.Move(fileNet, fileNet + "_duplicado_" + DateTime.Now.Ticks);


                    fi = File.ReadAllBytes(filePath);
                }
                else
                {
                    fi = File.ReadAllBytes(filePath);

                }
                return fi;

            });

            return fi;



        }
        public async static Task<bool> SaveLicenciaMaternidad(byte[] file, string filePath)
        {

            var result = false;
            string domainName = "SSRL";
            string userName = "web_user";
            string passWord = "wXhuIkub32oRvPDPv8Sg";



            const int LOGON32_PROVIDER_DEFAULT = 0;
            //This parameter causes LogonUser to create a primary token.   
            const int LOGON32_LOGON_INTERACTIVE = 2;

            // Call LogonUser to obtain a handle to an access token.   
            SafeAccessTokenHandle safeAccessTokenHandle;
            bool returnValue = LogonUser(userName, domainName, passWord,
                LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                out safeAccessTokenHandle);

            if (false == returnValue)
            {
                int ret = Marshal.GetLastWin32Error();
                throw new System.ComponentModel.Win32Exception(ret);
            }

#pragma warning disable CA1416 // Validar la compatibilidad de la plataforma
            WindowsIdentity.RunImpersonated(
                safeAccessTokenHandle,
                // User action  
                async () =>
                {
                    File.WriteAllBytes(filePath, file);

                }
                );
#pragma warning restore CA1416 // Validar la compatibilidad de la plataforma

            return result;
        }
        public async static Task<bool> SaveFileF(byte[] file, string filePath)
        {

            var result = false;
            string domainName = "SSRL";
            string userName = "web_user";
            string passWord = "wXhuIkub32oRvPDPv8Sg";



            const int LOGON32_PROVIDER_DEFAULT = 0;
            //This parameter causes LogonUser to create a primary token.   
            const int LOGON32_LOGON_INTERACTIVE = 2;

            // Call LogonUser to obtain a handle to an access token.   
            SafeAccessTokenHandle safeAccessTokenHandle;
            bool returnValue = LogonUser(userName, domainName, passWord,
                LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                out safeAccessTokenHandle);

            if (false == returnValue)
            {
                int ret = Marshal.GetLastWin32Error();
                throw new System.ComponentModel.Win32Exception(ret);
            }

#pragma warning disable CA1416 // Validar la compatibilidad de la plataforma
            WindowsIdentity.RunImpersonated(
                safeAccessTokenHandle,
                // User action  
                async () =>
                {
                    using (var stream = System.IO.File.Create(filePath))

                    {
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                            File.WriteAllBytesAsync(filePath, file);

                        }
                        await File.WriteAllBytesAsync(filePath, file);
                    }
                    result = true;
                }
                );
#pragma warning restore CA1416 // Validar la compatibilidad de la plataforma

            return result;
        }
    }
}
