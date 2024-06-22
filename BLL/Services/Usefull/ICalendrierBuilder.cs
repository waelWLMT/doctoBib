using BLL.UseCases.Commands.CalendrierCmd;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Usefull
{
    public interface ICalendrierBuilder
    {
        Calendrier BuildFromCalendrierCmd(CreateCalendrierCommand cmd);
         
    }
}
