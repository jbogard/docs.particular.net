namespace Core7.Sagas.FindByProperty
{
    using NServiceBus;

    public class MySagaData :
        ContainSagaData
    {
        public string SomeId { get; set; }
    }
}