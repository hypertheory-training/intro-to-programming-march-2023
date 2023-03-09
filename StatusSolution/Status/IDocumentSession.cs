//// See https://aka.ms/new-console-template for more information
//using Status;

internal interface IDocumentSession
{
    object Query<T>();
    Task SaveChangesAsync();
    void Store<T>(T messageToSave);
}