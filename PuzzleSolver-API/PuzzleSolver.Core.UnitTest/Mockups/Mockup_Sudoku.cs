﻿using PuzzleSolver.Abstractions;
using System;
using System.Collections.Generic;

namespace PuzzleSolver.Core.UnitTest.Mockups
{
    internal class Mockup_Sudoku : PuzzleTemplate
    {
        public Mockup_Sudoku(List<PuzzleFieldTemplate> fields) : base(fields)
        {
        }

        public override string GetContentAsJson()
        {
            throw new NotImplementedException();
        }

        public override PuzzleTemplate GetFromJson(string json)
        {
            throw new NotImplementedException();
        }

        public override void LoopAndGetPotentialValues()
        {
            throw new NotImplementedException();
        }

        public override void SetIndexes()
        {
            throw new NotImplementedException();
        }
    }
}
