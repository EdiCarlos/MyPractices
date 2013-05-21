// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Data.Services.Providers;

namespace Microsoft.Samples.SqlServer.AdventureWorksService
{
    public partial class AdventureWorks : DataService<AdventureWorksEntities>, IServiceProvider
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // All entity sets are read only for this sample.
            config.SetEntitySetAccessRule("CompanySales", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("ManufacturingInstructions", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("ProductCatalog", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("TerritorySalesDrilldown", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("WorkOrderRouting", EntitySetRights.AllRead);

            // This sample does not show service operations
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);

            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;

            config.SetEntitySetPageSize("CompanySales", 500);
            config.SetEntitySetPageSize("ManufacturingInstructions", 500);
            config.SetEntitySetPageSize("ProductCatalog", 500);
            config.SetEntitySetPageSize("TerritorySalesDrilldown", 500);
            config.SetEntitySetPageSize("WorkOrderRouting", 1000);
        }

        public object GetService(Type serviceType)
        {
            if(serviceType == typeof(IDataServiceStreamProvider2))
            {
                //Return the stream provider to the data service.
                return new ProductCatalogResourceProvider();
            }

            return null;
        }
    }
}
