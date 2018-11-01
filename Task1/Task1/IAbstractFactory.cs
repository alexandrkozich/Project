﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface IAbstractFactory
    {
        IAbstractWomensA CreateWomensShoesA();

        IAbstractMensShoesB CreateMensShoesB();

        IAbstractProductC CreateChildrensShoesC();

       // public string Name { get; set; }

    }
}