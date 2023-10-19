using ConsoleLibray.BLL.Contracts;
using ConsoleLibray.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibray.UI.UI
{
    
    public static class ReadLibrayUI
    {
        private static ILibraryService _libraryService = new LibraryService();

        public static void ReadLibray() => _libraryService.Read();
    }
}
