/*

This file is part of the iText (R) project.
Copyright (c) 1998-2020 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/

using System;
using System.Diagnostics;
using System.Text;

namespace iText.IO.Util {
    /// <summary>
    /// This file is a helper class for internal usage only.
    /// Be aware that its API and functionality may be changed in future.
    /// </summary>
    public class SystemUtil {

        [System.ObsoleteAttribute(@"To be removed in iText version 7.2. For time-based seed, please use {@link #getTimeBasedSeed()} instead.")]
        public static long GetSystemTimeTicks() {
            return DateTime.Now.Ticks / 10000 + Environment.TickCount;
        }

        public static long GetTimeBasedSeed() {
            return DateTime.Now.Ticks + Environment.TickCount;
        }

        public static int GetTimeBasedIntSeed() {
            return unchecked((int)DateTime.Now.Ticks) + Environment.TickCount;
        }

        /// <summary>
        /// Should be used in relative constructs (for example to check how many milliseconds have passed).
        /// Shouldn't be used in the DateTime creation since the nanoseconds are expected there.
        /// </summary>
        /// <returns>relative time in milliseconds</returns>
        public static long GetRelativeTimeMillis() {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        public static long GetFreeMemory() {
            return GC.GetTotalMemory(false);
        }

        /// <summary>
        /// Gets environment variable with given name.
        /// </summary>
        /// <param name="name">the name of environment variable.</param>
        /// <returns>variable value or null if there is no such.</returns>
        public static String GetEnvironmentVariable(String name) {
            return Environment.GetEnvironmentVariable(name);
        }

        public static bool RunProcessAndWait(String execPath, String @params) {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(execPath, @params.Replace("'", "\""));
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            PrintProcessOutput(p);
            p.WaitForExit();
            return true;
        }

        private static void PrintProcessOutput(Process p) {
            StringBuilder bri = new StringBuilder();
            StringBuilder bre = new StringBuilder();
            while (!p.HasExited) {
                bri.Append(p.StandardOutput.ReadToEnd());
                bre.Append(p.StandardError.ReadToEnd());
            }
            System.Console.Out.WriteLine(bri.ToString());
            System.Console.Out.WriteLine(bre.ToString());
        }

        public static StringBuilder RunProcessAndCollectErrors(String execPath, String @params)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(execPath, @params.Replace("'", "\""));
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            StringBuilder errorsBuilder = PrintProcessErrorsOutput(p);
            p.WaitForExit();
            return errorsBuilder;
        }

        private static StringBuilder PrintProcessErrorsOutput(Process p)
        {
            StringBuilder bre = new StringBuilder();
            while (!p.HasExited)
            {
                bre.Append(p.StandardError.ReadToEnd());
            }
            System.Console.Out.WriteLine(bre.ToString());
            return bre;
        }
    }
}
