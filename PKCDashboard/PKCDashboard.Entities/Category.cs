// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="EPAM Systems">
//   Copyright 2015
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PKCDashboard.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using global::PKCDashboard.Common.Annotations;
    using global::PKCDashboard.Repository.Ef6;

    /// <summary>
    /// The category.
    /// </summary>
    [Service(ServiceName = "ProductService")]
    public class Category : Entity
    {
        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>

        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>


        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        /// <value>
        /// The name of the category.
        /// </value>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>

        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>

        public byte? Picture { get; set; }
    }
}
