using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiAbstractions.Services
{
    public interface ICountryService
    {
        Task<int> GenerateCountryDataFiles();
    }
}
