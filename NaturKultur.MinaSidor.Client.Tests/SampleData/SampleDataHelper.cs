﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NaturKultur.MinaSidor.Client.Tests.SampleData
{
    static class SampleDataHelper
    {
        /// <summary>
        /// Get text sample data.
        /// </summary>
        /// <param name="resourceName">E.g. "PersonalInformation.html".</param>
        public static async Task<string> GetStringAsync(string resourceName)
        {
            //Liber.Onlinebok.Client.Tests.SampleData.document.json
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NaturKultur.MinaSidor.Client.Tests.SampleData." + resourceName))
            using (var reader = new StreamReader(stream))
                return await reader.ReadToEndAsync();
        }
    }
}
