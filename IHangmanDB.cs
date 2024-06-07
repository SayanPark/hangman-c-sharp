using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    interface IHangmanDB
    {
        DataTable SelectRow(string iname);
        DataTable SelectAll();
        bool Insert(string iname);
        bool Delete(string iname);
        int CountOfData();
    }

}