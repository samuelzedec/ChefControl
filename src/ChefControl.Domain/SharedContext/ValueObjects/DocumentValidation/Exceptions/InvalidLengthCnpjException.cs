using ChefControl.Domain.SharedContext.Exceptions;

namespace ChefControl.Domain.SharedContext.ValueObjects.DocumentValidation.Exceptions;

public class InvalidLengthCnpjException(string message) 
    : DomainException(message);