using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_WPF.configurations
{
    public class FileConfig
    {
        public string ConectionStr { get; set; }       
        private string _pathFileConfig = @"..\..\..\configurations\UniversityConfig.txt";
        public FileConfig()
        {            
            using var file = new StreamReader(_pathFileConfig);
            ConectionStr = file.ReadToEnd();
            
        }
    }
}
