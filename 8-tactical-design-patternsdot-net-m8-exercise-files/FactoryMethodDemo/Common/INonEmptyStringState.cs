namespace FactoryMethodDemo.Common
{
    internal interface INonEmptyStringState
    {
        INonEmptyStringState Set(string value);
        string Get();
    }
}
