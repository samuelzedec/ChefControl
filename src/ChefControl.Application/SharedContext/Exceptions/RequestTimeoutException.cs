﻿using System.Net;

namespace ChefControl.Application.SharedContext.Exceptions;

public class RequestTimeoutException(string requestName, TimeSpan elapsedTime)
    : ApplicationException($"Request '{requestName}' timed out after {elapsedTime.TotalSeconds:F1} seconds", (int)HttpStatusCode.RequestTimeout)
{
    public string RequestName { get; } = requestName;
    public TimeSpan ElapsedTime { get; } = elapsedTime;
}