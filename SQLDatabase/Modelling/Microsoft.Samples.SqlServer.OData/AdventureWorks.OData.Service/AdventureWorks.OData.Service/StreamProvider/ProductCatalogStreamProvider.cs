// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Services.Providers;
using System.Data.Objects;
using System.IO;
using System.Data.Services;
using System.Data.SqlClient;
using System.Data;
using System.Web.Hosting;

namespace Microsoft.Samples.SqlServer.AdventureWorksService
{
    public class ProductCatalogResourceProvider : IDataServiceStreamProvider2
    {
        #region IDataServiceStreamProvider Members
     
        //Named Resource using .NET Framework 4.5
        public Stream GetReadStream(object entity, ResourceProperty resourceProperty, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
        {
            vProductCatalog image = entity as vProductCatalog;

            if (checkETagForEquality != null)
            {
                // This stream provider implementation does not support 
                // ETag headers for media resources. This means that we do not track 
                // concurrency for a media resource and last-in wins on updates.
                throw new DataServiceException(400, "This sample service does not support the ETag header for a media resource.");
            }

            if (image == null)
            {
                throw new DataServiceException(500, "Internal Server Error.");
            }

            // Return a stream that contains the requested ThumbnailPhoto or LargePhoto
            return ProductPhoto(image.ProductID, resourceProperty.Name);
        }

        //Named Resource using .NET Framework 4.0
        public Stream GetReadStream40(object entity, ResourceProperty resourceProperty, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
        {
            vProductCatalog image = entity as vProductCatalog;

            //ThumbnailPhoto and LargePhoto
            string imageFilePath = HostingEnvironment.MapPath("~/ProductImages/" + resourceProperty.Name);

            if (checkETagForEquality != null)
            {
                // This stream provider implementation does not support 
                // ETag headers for media resources. This means that we do not track 
                // concurrency for a media resource and last-in wins on updates.
                throw new DataServiceException(400, "This sample service does not support the ETag header for a media resource.");
            }

            if (image == null)
            {
                throw new DataServiceException(500, "Internal Server Error.");
            }

            // Build the full path to the stored image file, which includes the entity key.
            string fullImageFilePath = string.Format(@"{0}\{1}.gif", imageFilePath, this.ProductPhotoID(image.ProductID));

            if (!File.Exists(fullImageFilePath))
            {
                throw new DataServiceException(500, "The image could not be found.");
            }

            // Return a stream that contains the requested file.
            return new FileStream(fullImageFilePath, FileMode.Open);
        }

        public string GetStreamContentType(object entity, ResourceProperty resourceProperty, DataServiceOperationContext operationContext)
        {
            //All images in AdventureWorks are image/gif
            return "image/gif";
        }

        public string ResolveType(string entitySetName, DataServiceOperationContext operationContext)
        {
            // Only be handle ProductCatalog types.
            if (entitySetName == "ProductCatalog")
            {
                return "AdventureWorks_ODataService.ProductCatalog";
            }
            else
            {
                // This will raise an DataServiceException.
                return null;
            }
        }

        public int StreamBufferSize
        {
            // Use a buffer size of 64K bytes.
            get { return 64000; }
        }

        //.NET Framework 4.5
        private Stream ProductPhoto(int productID, string columnName)
        {
            Stream productPhoto = null;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting.ToString()))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Setup the command
                    command.CommandText =
                        string.Format("SELECT {0} FROM Production.vProductCatalogImages WHERE ProductID=@ProductID", columnName);

                    command.CommandType = CommandType.Text;

                    // Declare the parameter
                    SqlParameter paramID = new SqlParameter("@ProductID", SqlDbType.Int);
                    paramID.Value = productID;
                    command.Parameters.Add(paramID);

                    connection.Open();

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            reader.Read();
                            if (reader.HasRows)
                                productPhoto =  reader.GetStream(0);
                        }
                    }
                    catch (SqlException ex)
                    {
                        //In Log the SqlException, such as Invalid column name, in a production application
                    }

                    return productPhoto;
                }
            }
        }

        //.NET Framework 4.0
        private int ProductPhotoID(int productID)
        {
            int productPhotoID = 0;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting.ToString()))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Setup the command
                    command.CommandText = "SELECT ProductPhotoID FROM Production.ProductProductPhoto WHERE ProductID=@ProductID";
                    command.CommandType = CommandType.Text;

                    // Declare the parameter
                    SqlParameter paramID = new SqlParameter("@ProductID", SqlDbType.Int);
                    paramID.Value = productID;
                    command.Parameters.Add(paramID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        reader.Read();
                        if (reader.HasRows)
                            productPhotoID = (int)reader[0];
                    }
                }
            }

            return productPhotoID;
        }

        #region Not implemented in this sample
        public void DeleteStream(object entity, DataServiceOperationContext operationContext) { }

        //Media Resource
        public Stream GetReadStream(object entity, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
        {
            return null;
        }

        public string GetStreamContentType(object entity, DataServiceOperationContext operationContext)
        {
            return null;
        }

        public Uri GetReadStreamUri(object entity, DataServiceOperationContext operationContext)
        {
            // Allow the runtime set the URI of the Media Resource.
            return null;
        }
       
        public Uri GetReadStreamUri(object entity, ResourceProperty resourceProperty, DataServiceOperationContext operationContext)
        {
            // Allow the runtime set the URI of the Media Resource.
            return null;
        }

        public string GetStreamETag(object entity, DataServiceOperationContext operationContext)
        {
            // This sample provider does not support the eTag header with media resources.
            // This means that we do not track concurrency for a media resource 
            // and last-in wins on updates.
            return null;
        }

        public string GetStreamETag(object entity, ResourceProperty resourceProperty, DataServiceOperationContext operationContext)
        {
            // This sample provider does not support the eTag header with media resources.
            // This means that we do not track concurrency for a media resource 
            // and last-in wins on updates.
            return null;
        }


        public Stream GetWriteStream(object entity, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
        {
            return null;
        }

        public Stream GetWriteStream(object entity, ResourceProperty resourceProperty, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
        {
            return null;
        }

        #endregion
        #endregion
    }
}
