using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Inventory_System
{
    class tools
    {
        public static string hashString(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                Encoding encoding = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(encoding.GetBytes(input));

                foreach (Byte b in result)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
            }

            return stringBuilder.ToString();
        }

        public static void consoleLog(string message)
        {
            Debug.WriteLine(message);
            Console.WriteLine(message);
        }

        public static string getNetworkDateTime()
        {
            string ntpServer = "time.windows.com";

            try
            {
                const int daysTo1900 = 1900 * 365 + 95;
                const long ticksPerSecond = 10000000L;
                const long ticksPerDay = 24 * 60 * 60 * ticksPerSecond;
                const long ticksTo1900 = daysTo1900 * ticksPerDay;

                var ntpData = new byte[48];
                ntpData[0] = 0x1B;

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;
                var ipEndPoint = new IPEndPoint(addresses[0], 123);

                var pingDuration = Stopwatch.GetTimestamp();

                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    socket.ConnectAsync(ipEndPoint);
                    socket.ReceiveTimeout = 5000;
                    socket.Send(ntpData);
                    pingDuration = Stopwatch.GetTimestamp();

                    socket.Receive(ntpData);
                    pingDuration = Stopwatch.GetTimestamp() - pingDuration;
                }

                var pingTicks = pingDuration * ticksPerSecond / Stopwatch.Frequency;

                var intPart = (long)ntpData[40] << 24 | (long)ntpData[41] << 16 | (long)ntpData[42] << 8 | ntpData[43];
                var fractPart = (long)ntpData[44] << 24 | (long)ntpData[45] << 16 | (long)ntpData[46] << 8 | ntpData[47];
                var netTicks = intPart * ticksPerSecond + (fractPart * ticksPerSecond >> 32);

                var networkDateTime = new DateTime(ticksTo1900 + netTicks + pingTicks / 2);

                tools.consoleLog("Get Server Time API Triggered");

                return networkDateTime.ToString("yyyy-MM-dd");
            }
            catch
            {
                return "";
            }
        }
    }
}
