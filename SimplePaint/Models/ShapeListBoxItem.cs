﻿using ReactiveUI;
using System.Reactive;

namespace SimplePaint.Models
{
    public class ShapeListBoxItem
    {
        public ShapeListBoxItem(string name, Mapper map)
        {
            Name = name;
            Remove = ReactiveCommand.Create<Unit, Unit>(_ => { map.Remove(this); return new Unit(); });
        }

        public string Name { get; }

        public ReactiveCommand<Unit, Unit> Remove { get; }
    }
}
