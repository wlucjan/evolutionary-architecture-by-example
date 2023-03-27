namespace SuperSimpleArchitecture.Fitnet.Shared.BusinessRulesEngine;

internal interface IBusinessRule
{
    bool IsMet();
    string Error { get; }
}