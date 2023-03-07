
namespace Status;

// "Models"
public  record StatusMessage(Guid Id, string Message, DateTimeOffset When);

public record StatusChangeRequest(string Message);