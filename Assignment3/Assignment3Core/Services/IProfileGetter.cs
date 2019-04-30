using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Assignment3Core.Models;

namespace Assignment3Core.Services
{
    public interface IProfileGetter
    {
        Profile GetProfile();
    }
}
