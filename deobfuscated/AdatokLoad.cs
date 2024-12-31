using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class AdatokLoad
{
    public static string HardwareID(ref string Cpuid, ref string Hddid, ref string Hddpartid, ref string BoardName)
    {
        try
        {
            ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get();
            foreach (ManagementObject item in managementObjectCollection)
            {
                Cpuid = item["ProcessorId"].ToString();
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Cpuid = "Nincs_Cpu_id";
            ProjectData.ClearProjectError();
        }
        try
        {
            ManagementObjectCollection managementObjectCollection2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get();
            foreach (ManagementObject item2 in managementObjectCollection2)
            {
                string text = item2["SerialNumber"].ToString();
                string queryString = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='", item2["DeviceID"]), "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition"));
                ManagementObjectCollection managementObjectCollection3 = new ManagementObjectSearcher(queryString).Get();
                foreach (ManagementObject item3 in managementObjectCollection3)
                {
                    string queryString2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='", item3["DeviceID"]), "'} WHERE AssocClass = Win32_LogicalDiskToPartition"));
                    ManagementObjectCollection managementObjectCollection4 = new ManagementObjectSearcher(queryString2).Get();
                    foreach (ManagementObject item4 in managementObjectCollection4)
                    {
                        if (Operators.CompareString(item4["DeviceID"].ToString(), "C:", TextCompare: false) == 0)
                        {
                            Hddid = text;
                        }
                    }
                }
            }
        }
        catch (Exception ex3)
        {
            ProjectData.SetProjectError(ex3);
            Hddid = "SerialNo:09194477WOLO4DN56";
            ProjectData.ClearProjectError();
        }
        string text2 = "C";
        ManagementObject managementObject4 = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + text2 + ":\"");
        managementObject4.Get();
        Hddpartid = managementObject4["VolumeSerialNumber"].ToString();
        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Product FROM Win32_BaseBoard");
        foreach (ManagementObject item5 in managementObjectSearcher.Get())
        {
            try
            {
                BoardName = item5.GetPropertyValue("Product").ToString();
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                BoardName = "2hetmnoreadabledata";
                ProjectData.ClearProjectError();
            }
        }
        return string.Concat(string.Concat(Cpuid + Hddid, Hddpartid), BoardName);
    }

    public static string Regadatok(ref string Status, ref string Serial, ref string Vihar, ref string Barel)
    {
        string text = "SOFTWARE\\Masbate\\License";
        RegistryKey registryKey = null;
        try
        {
            registryKey = Registry.LocalMachine.OpenSubKey(text, writable: true) ?? Registry.LocalMachine.CreateSubKey(text);
            if (registryKey.GetValue("Status") != null)
            {
                Status = Conversions.ToString(registryKey.GetValue("Status"));
            }
            else
            {
                registryKey.SetValue("Status", "0", RegistryValueKind.DWord);
                Status = "0";
            }
            if (registryKey.GetValue("Serial") != null)
            {
                Serial = Conversions.ToString(registryKey.GetValue("Serial"));
            }
            else
            {
                registryKey.SetValue("Serial", "0", RegistryValueKind.String);
                Serial = "0";
            }
            if (registryKey.GetValue("Vihar") != null)
            {
                Vihar = Conversions.ToString(registryKey.GetValue("Vihar"));
            }
            else
            {
                registryKey.SetValue("Vihar", "0", RegistryValueKind.String);
                Vihar = "0";
            }
            if (registryKey.GetValue("Barel") != null)
            {
                Barel = Conversions.ToString(registryKey.GetValue("Barel"));
            }
            else
            {
                registryKey.SetValue("Barel", "0", RegistryValueKind.String);
                Barel = "0";
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Interaction.MsgBox("Hiba történt: " + ex.Message);
            ProjectData.ClearProjectError();
        }
        finally
        {
            if (registryKey != null)
            {
                registryKey?.Close();
            }
        }
        return string.Concat(string.Concat(Status + Serial, Vihar), Barel);
    }

    public static string DecryptString(byte[] data, byte[] key)
    {
        using AesManaged aesManaged = new AesManaged();
        aesManaged.KeySize = 256;
        int minSize = aesManaged.LegalKeySizes[0].MinSize;
        Array.Resize(ref key, checked((int)Math.Round((double)minSize / 8.0)));
        aesManaged.Key = key;
        aesManaged.Mode = CipherMode.ECB;
        aesManaged.Padding = PaddingMode.PKCS7;
        ICryptoTransform transform = aesManaged.CreateDecryptor();
        using MemoryStream stream = new MemoryStream(data);
        using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
        using StreamReader streamReader = new StreamReader(stream2);
        return streamReader.ReadToEnd();
    }

    public static byte[] EncryptString(string data, byte[] key)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(data);
        using AesManaged aesManaged = new AesManaged();
        aesManaged.KeySize = 256;
        int minSize = aesManaged.LegalKeySizes[0].MinSize;
        Array.Resize(ref key, checked((int)Math.Round((double)minSize / 8.0)));
        aesManaged.Key = key;
        aesManaged.Mode = CipherMode.ECB;
        aesManaged.Padding = PaddingMode.PKCS7;
        ICryptoTransform transform = aesManaged.CreateEncryptor();
        using MemoryStream memoryStream = new MemoryStream();
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
        {
            cryptoStream.Write(bytes, 0, bytes.Length);
        }
        return memoryStream.ToArray();
    }

    public static byte[] DecryptAES256(byte[] data, byte[] key)
    {
        using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1000);
        using AesManaged aesManaged = new AesManaged();
        aesManaged.Key = rfc2898DeriveBytes.GetBytes(checked((int)Math.Round((double)aesManaged.KeySize / 8.0)));
        aesManaged.Mode = CipherMode.ECB;
        aesManaged.Padding = PaddingMode.PKCS7;
        ICryptoTransform transform = aesManaged.CreateDecryptor();
        using MemoryStream stream = new MemoryStream(data);
        using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
        using MemoryStream memoryStream = new MemoryStream();
        cryptoStream.CopyTo(memoryStream);
        return memoryStream.ToArray();
    }

    public static async void StartingMain(string key)
    {
        byte[] array = MyProject.Computer.FileSystem.ReadAllBytes("c:\\Windows\\Branding\\Masbate\\boot\\2hbootx64.efi");
        byte[] bytes = Encoding.UTF8.GetBytes(key);
        byte[] bytes2 = DecryptAES256(array, bytes);
        string text = Path.Combine(path2: Guid.NewGuid().ToString() + ".exe", path1: "c:\\Windows\\Branding\\Masbate\\temp\\");
        File.WriteAllBytes(text, bytes2);
        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = text
        };
        process.StartInfo = startInfo;
        process.Start();
        await Task.Run([SpecialName] () =>
        {
            process.WaitForExit();
        });
        File.Delete(text);
        Application.Exit();
    }
}
