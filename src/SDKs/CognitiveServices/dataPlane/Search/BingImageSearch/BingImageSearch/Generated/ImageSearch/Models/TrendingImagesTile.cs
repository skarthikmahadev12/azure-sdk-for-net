// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines an image tile.
    /// </summary>
    public partial class TrendingImagesTile
    {
        /// <summary>
        /// Initializes a new instance of the TrendingImagesTile class.
        /// </summary>
        public TrendingImagesTile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrendingImagesTile class.
        /// </summary>
        /// <param name="query">A query that returns a Bing search results page
        /// with more images of the subject. For example, if the category is
        /// Popular People Searches, then the thumbnail is of a popular person.
        /// The query would return a Bing search results page with more images
        /// of that person.</param>
        /// <param name="image">The image's thumbnail.</param>
        public TrendingImagesTile(Query query, ImageObject image)
        {
            Query = query;
            Image = image;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a query that returns a Bing search results page with
        /// more images of the subject. For example, if the category is Popular
        /// People Searches, then the thumbnail is of a popular person. The
        /// query would return a Bing search results page with more images of
        /// that person.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public Query Query { get; set; }

        /// <summary>
        /// Gets or sets the image's thumbnail.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public ImageObject Image { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
            if (Image == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image");
            }
            if (Query != null)
            {
                Query.Validate();
            }
        }
    }
}