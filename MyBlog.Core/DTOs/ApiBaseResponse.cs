using System.Text.Json.Serialization;

namespace MyBlog.Core.DTOs;

public class ApiBaseResponse<T> where T : new()
{
    public T Data { get; set; }
    [JsonIgnore]
    public int StatusCode { get; set; }
    public List<string> Errors { get; set; }
    public bool HasError { get; set; }

    public static ApiBaseResponse<T> Success(int statusCode, T data)
    {
        return new ApiBaseResponse<T> { StatusCode = statusCode, Data = data, HasError = false };
    }

    public static ApiBaseResponse<T> Success(int statusCode)
    {
        return new ApiBaseResponse<T> { StatusCode = statusCode, HasError = false };
    }

    public static ApiBaseResponse<T> Fail(int statusCode, List<string> errors)
    {
        return new ApiBaseResponse<T> { StatusCode = statusCode, Errors = errors, HasError = true };
    }

    public static ApiBaseResponse<T> Fail(int statusCode, string error)
    {
        return new ApiBaseResponse<T> { StatusCode = statusCode, Errors = new List<string> { error }, HasError = true };
    }
}
