﻿namespace ArchitectureSkeleton.Contract.Fluent.Cell;

public enum Comparisons
{
    Equal,
    NotEqual,
    GreaterThan,
    GreaterThanOrEqual,
    LessThan,
    LessThanOrEqual
}
public enum ConditionTypes
{
    And,
    Or
}
public enum JoinTypes
{
    Inner,
    Left,
    Right,
    Outer
}