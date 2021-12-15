using System.Threading.Tasks;

public interface IBeforeSendInterceptor
{
    Task BeforeSend(BeforeSendArguments args);
}