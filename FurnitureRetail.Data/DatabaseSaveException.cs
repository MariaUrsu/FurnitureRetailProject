namespace FurnitureRetail.Data;

[Serializable]
public class DatabaseSaveException: Exception
{
    public DatabaseSaveException()
    {

    }

    public DatabaseSaveException(string message) : base(message)
    {

    }

    public DatabaseSaveException(string message, Exception innerException) : base(message, innerException)
    {

    }
}