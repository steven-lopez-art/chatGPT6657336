using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatGPT6657336.Services
{
    public interface IOpenIAService
    {
        Task<string> AskQuestion(string query);
    }
}
