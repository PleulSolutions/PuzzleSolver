﻿using PuzzleSolver.Abstractions;
using PuzzleSolver.Core.Validators;

namespace PuzzleSolver.Core.Resolvers
{
    internal class SudokuResolver : ResolverTemplate
    {
        public SudokuResolver(SudokuValidator sudokuValidator) : base(sudokuValidator) { }

        public override bool IsResolved(string puzzleJson)
        {
            // TODO: Implement after test
            throw new System.NotImplementedException();
        }

        public override string Resolve(string puzzleJson)
        {
            do
            {
                do
                {
                    // TODO: echte logica
                } while (!base.CheckMove(puzzleJson));
            }
            while (puzzleJson.Contains('0'));

            return puzzleJson;
        }
    }
}
