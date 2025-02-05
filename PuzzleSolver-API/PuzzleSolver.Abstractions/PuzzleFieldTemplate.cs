﻿using PuzzleSolver.Models.DTO;
using System.Collections.Generic;

namespace PuzzleSolver.Abstractions
{
    public abstract class PuzzleFieldTemplate
    {
        public string? Value { get; set; }
        public int Index { get; set; }
        public List<string> PotentialValues { get; set; }
        public bool HasValue { get => !string.IsNullOrEmpty(Value); }

        protected PuzzleFieldTemplate()
        {
            PotentialValues = new List<string>();
        }

        public abstract int GetRowID();
        public abstract int GetColumnID();
        public abstract int GetBlockID();
        public PuzzleFieldDTO ToDTO()
        {
            return new PuzzleFieldDTO() { Value = Value };
        }
    }
}
