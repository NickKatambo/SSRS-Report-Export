using System;
using System.Collections.Generic;
using System.Text;

namespace CoreExport
{
    public interface IFileExport
    {
        string ExportAsPdf(int id, string url, string exportPath);
    }
}
