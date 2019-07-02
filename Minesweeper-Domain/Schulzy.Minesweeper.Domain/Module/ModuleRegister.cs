using Schulzy.Minesweeper.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Schulzy.Minesweeper.Domain.Module
{
    internal class ModuleRegister
    {
        public ModuleRegister(IUnityContainer dicontainer)
        {
            dicontainer.RegisterType<IFieldGenerator,FieldGenerator>();
            dicontainer.RegisterType<IGame,Game>();
        }
    }
}
