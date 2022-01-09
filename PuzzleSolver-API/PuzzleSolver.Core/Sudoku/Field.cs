﻿using PuzzleSolver.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolver.Core.Sudoku
{
    internal class Field : PuzzleFieldTemplate
    {
        public Field(string? value = null) : base()
        {
            Value = value;

            if (value == null)
            {
                PotentialValues = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            }
        }

        public override int GetRowID()
        {
            // TODO: Magic numbers... moeten we wat voor verzinnen
            return Index / 9;
        }

        public override int GetColumnID()
        {
            // TODO: Magic numbers... moeten we wat voor verzinnen
            return Index - GetRowID() * 9;
        }

        public override int GetBlockID()
        {
            // TODO: Magic numbers... moeten we wat voor verzinnen
            int boxRow = GetRowID() / 3;
            int boxCol = GetColumnID() / 3;
            return boxRow * 3 + boxCol;
        }

        public Field Copy()
        {
            return new Field(Value)
            {
                Index = Index,
                PotentialValues = PotentialValues.ToList()
            };
        }

        public bool IsRelatedTo(Field field)
        {
            return field.GetBlockID() == GetBlockID() ||
                        field.GetColumnID() == GetColumnID() ||
                        field.GetRowID() == GetRowID();
        }
    }
}
