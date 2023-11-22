//using DryIoc;
//using MapDi = Tecan.MAP.Contracts.Services.DependencyInjection;
//using MapDryIoc = Tecan.MAP.Services.DependencyInjection.DryIoC;

//namespace Tecan.IoTClient.Core.IoTClient.Bootstrapper;

//internal class DependencyInjectionStarter : IDisposable
//{
//    private DryIoc.IContainer? _originalDryIocContainer;
//    private MapDi.IContainer? _diContainer;

//    public MapDi.IContainer DiContainer
//    {
//        get
//        {
//            if( _diContainer == null )
//            {
//                throw new InvalidOperationException( "SetupDependencyInjection() must be called first." );
//            }

//            return _diContainer;
//        }
//    }

//    public DryIoc.IContainer OriginalDryIocContainer
//    {
//        get
//        {
//            if( _originalDryIocContainer == null )
//            {
//                throw new InvalidOperationException( "SetupDependencyInjection() must be called first." );
//            }

//            return _originalDryIocContainer;
//        }
//    }

//    internal /*MapDi.IModuleRegistry*/ void SetupDependencyInjection()
//    {
//        _originalDryIocContainer = new DryIoc.Container();


//        //MapDryIoc.DryIocRegistry registry = new MapDryIoc.DryIocRegistry( OriginalDryIocContainer );
//        //registry.RegisterDirectory( Path.GetDirectoryName( GetType().Assembly.Location ) );

//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Services.Logging.dll" ) ) );
//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Contracts.Services.Logging.dll" ) ) );
//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Contracts.Services.DataStore.dll" ) ) );
//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Services.DataStore.dll" ) ) );
//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Services.TimeService.dll" ) ) );
//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Contracts.Services.Cryptography.dll" ) ) );
//        //registry.RegisterAssembly( Assembly.LoadFrom( Path.Combine( Path.GetDirectoryName( GetType().Assembly.Location ), "Tecan.MAP.Services.Cryptography.dll" ) ) );
//        //registry.RegisterAssembly( GetType().Assembly );

//        //_diContainer = registry.CreateContainer();

//        //registry.RegisterInstance( _diContainer );

//        //return registry;
//    }

//    public void Dispose()
//    {
//        _diContainer?.Dispose();
//    }
//}
