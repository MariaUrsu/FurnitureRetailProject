namespace FurnitureRetail.Core;

public sealed class Result
{
    public ResultStatus Status { get; private set; } = ResultStatus.Success;
    public IReadOnlyCollection<string> Errors { get; private set; } = new List<string>();
    public static readonly Result Forbidden = new Result { Status = ResultStatus.Forbidden };
    public static readonly Result NotAuthorized = new Result { Status = ResultStatus.NotAuthorized };
    public static readonly Result NotPresent = new Result { Status = ResultStatus.NotPresent };
    public static readonly Result Success = new Result { Status = ResultStatus.Success };

    public static Result Error(string message, ResultStatus status = ResultStatus.InvalidOperation) => new Result
    {
        Status = status,
        Errors = new List<string> { message }
    };
}

public sealed class Result<TItem>
{
    private Result()
    {
    }

    public ResultStatus Status { get; private set; } = ResultStatus.Success;
    public TItem Value { get; private set; }
    public IReadOnlyCollection<string> Errors { get; private set; } = new List<string>();

    public static implicit operator Result<TItem>(Result result) => new Result<TItem>
    {
        Errors = result.Errors,
        Status = result.Status
    };

    public static implicit operator Result<TItem>(TItem value) => new Result<TItem>
    {
        Value = value,
        Status = ResultStatus.Success
    };

    public void AddErrors(IReadOnlyCollection<string> errors)
    {
        Status = ResultStatus.InvalidOperation;
        var newErrors = new List<string>(Errors);
        newErrors.AddRange(errors);
        Errors = newErrors;
    }

    public bool IsSuccess => Status == ResultStatus.Success;

    public void Join<TOther>(Result<TOther> other)
    {
        if (other.Errors.Any())
        {
            AddErrors(other.Errors);
            Status = other.Status;
        }
    }
}

public enum ResultStatus
{
    Success = 1,
    Forbidden = 2,
    NotPresent = 3,
    InvalidOperation = 4,
    NotAuthorized = 5
}