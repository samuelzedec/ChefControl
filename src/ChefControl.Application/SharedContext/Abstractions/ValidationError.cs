﻿namespace ChefControl.Application.SharedContext.Abstractions;

public sealed record ValidationError(string PropertyName, string ErrorMessage);