﻿using PuzzleSolver.Abstractions;
using PuzzleSolver.Models.DTO;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolver.Core.UnitTest.Mockups
{
    internal class Mockup_SudokuResolver : IResolver
    {
        public InvocationService InvocationService = new InvocationService();

        public IEnumerable<string> GetHint(IEnumerable<PuzzleFieldDTO> puzzleFields)
        {
            throw new System.NotImplementedException();
        }

        public PuzzleTemplate Resolve(IEnumerable<PuzzleFieldDTO> fields)
        {
            InvocationService.AddOrUpdateInvocation("Resolve");

            foreach (var item in fields)
            {
                if (string.IsNullOrEmpty(item.Value))
                    item.Value = "1";
            }

            var abstractFields = fields.Select(x => (PuzzleFieldTemplate)new Mockup_SudokuField(x.Value)).ToList();

            return new Mockup_Sudoku(abstractFields);
        }
    }
}
