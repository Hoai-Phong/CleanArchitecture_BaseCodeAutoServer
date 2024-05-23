using BaseCodeAutoSever.Application.Common.Services.DateTime;

namespace BaseCodeAutoSever.Infrastructure.DateTime;

public class DateTimeProvider : IDateTimeProvider
{
    public System.DateTime UtcNow => System.DateTime.UtcNow;
}
