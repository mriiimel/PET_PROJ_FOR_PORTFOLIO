
public interface IServiceLocator<T>
{

    TS Register<TS>(TS newService) where TS : T;
    void Unregister<TS>(TS service) where TS : T;
    TS Get<TS>()where TS : T; 

}
