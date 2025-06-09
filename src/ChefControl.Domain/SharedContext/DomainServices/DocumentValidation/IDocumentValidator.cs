namespace ChefControl.Domain.SharedContext.DomainServices.DocumentValidation;

/// <summary>
/// Fornece métodos para validar, sanitizar e formatar documentos identificadores como CPF e CNPJ.
/// </summary>
public interface IDocumentValidator
{
    void IsValid(string document);
    string Sanitize(string document);
    static abstract string Format(string document);
}