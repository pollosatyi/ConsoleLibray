﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibray.BLL.Contracts
{
    public interface ILibraryService
    {
        void Create(string name, int count);
        void Read();
    }
}
